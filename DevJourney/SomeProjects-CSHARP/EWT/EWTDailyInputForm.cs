using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;

namespace EWT
{
    public partial class EWTDailyInputForm : BaseForm
    {
        public enum FormSizeModeEnum
        {
            ModeA = 130,
            ModeB = 320,
            ModeC = 645
        }

        public Enums.FormDataModeEnum SelectedFormMode { get; set; }
        public Models.EWTDailyInput _EWTDailyInput { get; set; }

        public string SelectedDate { get; set; }
        public int? SelectedEwtId { get; set; }

        public bool FormIsLoaded { get; set; } = false;

        //my1
        // public bool UserControlIsLoaded { get; set; } = false;
        //my1

        #region FormConstructors
        public EWTDailyInputForm()
        {
            InitializeComponent();

            ewtDataPicker.SelectedItem += EwtDataPicker_SelectedItem;
            SetFormSize(FormSizeModeEnum.ModeA);
        }

        public EWTDailyInputForm(string selectedDate, int selectedEwtId, Enums.FormDataModeEnum selectedFormMode)
            : this()
        {
            SelectedDate = selectedDate;
            SelectedEwtId = selectedEwtId;
            SelectedFormMode = selectedFormMode;
            label4.Text = selectedDate;

        }

        public EWTDailyInputForm(Enums.FormDataModeEnum selectedFormMode)
           : this()
        {
            SelectedFormMode = selectedFormMode;
        }
        #endregion

        private async Task<Models.EWTDailyInput> GetSingleEWTDailyInput()
        {
            Models.EWTDailyInput eWTDailyInput = null;
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@EWT_Id", dbType: DbType.Int32, value: SelectedEwtId);
                parameters.Add("@RegisterDate", dbType: DbType.String, value: SelectedDate);
                eWTDailyInput = await connection.QueryFirstOrDefaultAsync<Models.EWTDailyInput>("Select * From EWTDailyInput Where EWT_Id=@EWT_Id And RegisterDate=@RegisterDate", parameters);

                return eWTDailyInput;
            }
        }

        private async Task<bool> SaveData()
        {
            if (this.FormDataMode != Enums.FormDataModeEnum.Delete && FormDataIsValid() == false)
            {
                return false;
            }

            switch (FormDataMode)
            {
                case Enums.FormDataModeEnum.Edit:

                    switch (Utilities.Tools.UserInfo.UserBusinessRole)
                    {
                        case Enums.BusinessRoleEnum.Masool:
                            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                            {
                                int ewtdailyinput_Id = _EWTDailyInput.Id;
                                DynamicParameters parameters = new DynamicParameters();
                                parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtdailyinput_Id);
                                parameters.Add(name: "@TotalProduction", dbType: DbType.Int32, value: txtPR.Value);
                                parameters.Add(name: "@FiveS", dbType: DbType.Int32, value: txt5S.Value);
                                parameters.Add(name: "@Top5", dbType: DbType.String, value: txtTop5.Text);
                                parameters.Add(name: "@Masool_User_Id", dbType: DbType.Int32, value: Utilities.Tools.UserInfo.UserId);

                                await connection.ExecuteAsync("EWTDailyInput_Upd_ForMasool", param: parameters, commandType: CommandType.StoredProcedure);

                            }
                            break;

                        case Enums.BusinessRoleEnum.CheckMan:
                            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                            {
                                int ewtdailyinput_Id = _EWTDailyInput.Id;
                                DynamicParameters parameters = new DynamicParameters();
                                parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtdailyinput_Id);
                                parameters.Add(name: "@NQcSampleQuantity", dbType: DbType.Int32, value: txtSampleQuantity.Value);
                                parameters.Add(name: "@CheckMan_User_Id", dbType: DbType.Int32, value: Utilities.Tools.UserInfo.UserId);


                                await connection.ExecuteAsync("EWTDailyInput_Upd_ForCheckMan", param: parameters, commandType: CommandType.StoredProcedure);

                            }
                            break;

                        case Enums.BusinessRoleEnum.Auditor:
                            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                            {
                                int ewtdailyinput_Id = _EWTDailyInput.Id;
                                DynamicParameters parameters = new DynamicParameters();
                                parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtdailyinput_Id);
                                parameters.Add(name: "@NQaSampleQuantity", dbType: DbType.Int32, value: txtSampleQuantity.Value);
                                parameters.Add(name: "@Auditor_User_Id", dbType: DbType.Int32, value: Utilities.Tools.UserInfo.UserId);


                                await connection.ExecuteAsync("EWTDailyInput_Upd_ForAuditor", param: parameters, commandType: CommandType.StoredProcedure);

                            }
                            break;
                    }

                    break;
            }

            return true;
        }

        private async void EWTDailyInputForm_Load(object sender, EventArgs e)
        {

            #region Initialize ewtDataPicker
            ewtDataPicker.DataGridColumns = new List<DataGridViewColumn>();

            ewtDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "EWT_Id",
                HeaderText = "EWT_Id",
                DataPropertyName = "EWT_Id",
                Visible = false
            });

            ewtDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Title",
                HeaderText = "عنوان EWT",
                DataPropertyName = "Title"
            });

            string ewtQuery = null;
            switch (Utilities.Tools.UserInfo.UserBusinessRole)
            {
                case Enums.BusinessRoleEnum.CheckMan:
                    ewtQuery = "Select EWT_Id,E.Title From EWTCheckMans EWTCM Inner Join EWT E On E.Id=EWTCM.EWT_Id Where EWTCM.PERS_NO=@Pers_No and EWTCM.IsActive=1";
                    break;

                case Enums.BusinessRoleEnum.Masool:
                    ewtQuery = "Select EWT_Id,E.Title From EWTMasools EWTM Inner Join EWT E On E.Id=EWTM.EWT_Id Where EWTM.PERS_NO=@Pers_No and EWTM.IsActive=1";
                    break;

                case Enums.BusinessRoleEnum.Auditor:
                    ewtQuery = "Select EWT_Id,E.Title From EWTAuditors EWTA Inner Join EWT E On E.Id=EWTA.EWT_Id Where EWTA.PERS_NO=@Pers_No and EWTA.IsActive=1";
                    break;
            }

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Pers_No", Utilities.Tools.UserInfo.PersNo);

                var reader = await connection.ExecuteReaderAsync(sql: ewtQuery, param: parameters);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                ewtDataPicker.DataSource = dataTable;
            }

            #endregion

            if (Utilities.Tools.UserInfo.UserBusinessRole == Enums.BusinessRoleEnum.Masool)
            {
                using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Pers_No", Utilities.Tools.UserInfo.PersNo);
                    int ewt_id = await connection.ExecuteScalarAsync<int>(sql: "Select EWT_Id from EWTMasools em where em.PERS_NO=@PERS_NO and em.IsActive=1", param: parameters, commandType: CommandType.Text);
                    ewtDataPicker.SelectedId = ewt_id;
                }


            }
            else
            {
                txtPR.Enabled = false;
                txt5S.Enabled = false;
                txtTop5.Enabled = false;
                txtPR.Visible = false;
                txt5S.Visible = false;
                txtTop5.Visible = false;

            }



            if (SelectedFormMode == Enums.FormDataModeEnum.Edit)
            {


                _EWTDailyInput = await GetSingleEWTDailyInput();
                LoadDataInControls();



                using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                {
                    Models.EWTDailyInputInitialDate insertValidDates =
                    await connection.QueryFirstOrDefaultAsync<Models.EWTDailyInputInitialDate>(sql: "GetDailyInputValidDate", commandType: CommandType.StoredProcedure);

                    if ((label4.Text == insertValidDates.CurrentDate) || (label4.Text == insertValidDates.PrevDate))
                    {
                        this.FormDataMode = Enums.FormDataModeEnum.Edit;
                        tsbtnSave.Enabled = true;

                    }

                }


            }
            else
            {
                this.FormDataMode = Enums.FormDataModeEnum.Add;
                using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@DayCount", value: -1);
                    Models.EWTDailyInputInitialDate insertValidDates =
                    await connection.QueryFirstOrDefaultAsync<Models.EWTDailyInputInitialDate>(sql: "GetDailyInputValidDate", param: parameters, commandType: CommandType.StoredProcedure);

                    rdToday.Text = insertValidDates.CurrentDate;
                    rdYesterday.Text = insertValidDates.PrevDate;
                }
            }

            switch (Utilities.Tools.UserInfo.UserBusinessRole)
            {

                case Enums.BusinessRoleEnum.CheckMan:
                    MyTabControl.TabPages.Remove(MyTabControl.TabPages["tabpageNQA"]);
                    MyTabControl.TabPages.Remove(MyTabControl.TabPages["tabpageNR"]);
                    MyTabControl.TabPages.Remove(MyTabControl.TabPages["tabpageNP"]);
                    MyTabControl.TabPages.Remove(MyTabControl.TabPages["tabpageSTP"]);
                    MyTabControl.TabPages.Remove(MyTabControl.TabPages["tabpageACD"]);
                    MyTabControl.TabPages.Remove(MyTabControl.TabPages["tabpageWAS"]);
                    MyTabControl.TabPages.Remove(MyTabControl.TabPages["tabpageREW"]);
                    MyTabControl.TabPages.Remove(MyTabControl.TabPages["tabpageSUG"]);

                    break;

                case Enums.BusinessRoleEnum.Masool:
                    gbxCheckManAuditorPanel.Visible = false;
                    MyTabControl.TabPages.Remove(MyTabControl.TabPages["tabpageNQA"]);
                    MyTabControl.TabPages.Remove(MyTabControl.TabPages["tabpageNQC"]);
                    break;

                case Enums.BusinessRoleEnum.Auditor:
                    MyTabControl.TabPages.Remove(MyTabControl.TabPages["tabpageNQC"]);
                    MyTabControl.TabPages.Remove(MyTabControl.TabPages["tabpageNR"]);
                    MyTabControl.TabPages.Remove(MyTabControl.TabPages["tabpageNP"]);
                    MyTabControl.TabPages.Remove(MyTabControl.TabPages["tabpageSTP"]);
                    MyTabControl.TabPages.Remove(MyTabControl.TabPages["tabpageACD"]);
                    MyTabControl.TabPages.Remove(MyTabControl.TabPages["tabpageWAS"]);
                    MyTabControl.TabPages.Remove(MyTabControl.TabPages["tabpageSUG"]);
                    MyTabControl.TabPages.Remove(MyTabControl.TabPages["tabpageREW"]);



                    break;
            }

            FormIsLoaded = true;
        }

        private bool FormDataIsValid()
        {
            bool isValidData = true;

            switch (Utilities.Tools.UserInfo.UserBusinessRole)
            {
                case Enums.BusinessRoleEnum.CheckMan:
                    if (string.IsNullOrWhiteSpace(txtSampleQuantity.Value.ToString()))
                    {
                        MyErrorProvider.SetError(txtSampleQuantity, "فیلد اجباری");
                        isValidData = false;
                    }
                    break;
                case Enums.BusinessRoleEnum.Masool:
                    if (string.IsNullOrWhiteSpace(txt5S.Value.ToString()))
                    {
                        MyErrorProvider.SetError(txt5S, "فیلد اجباری");
                        isValidData = false;
                    }

                    if (string.IsNullOrWhiteSpace(txtPR.Value.ToString()) || txtPR.Value <= 0)
                    {
                        MyErrorProvider.SetError(txtPR, "فیلد اجباری");
                        isValidData = false;
                    }


                    if (string.IsNullOrWhiteSpace(txtTop5.Text))
                    {
                        MyErrorProvider.SetError(txtTop5, "فیلد اجباری");
                        isValidData = false;
                    }
                    break;
                case Enums.BusinessRoleEnum.Auditor:
                    if (string.IsNullOrWhiteSpace(txtSampleQuantity.Value.ToString()))
                    {
                        MyErrorProvider.SetError(txtSampleQuantity, "فیلد اجباری");
                        isValidData = false;
                    }
                    break;
                default:
                    break;
            }

            return isValidData;
        }

        private void LoadDataInControls()
        {
            txt5S.Text = System.Convert.ToString(_EWTDailyInput.FiveS);
            txtPR.Text = System.Convert.ToString(_EWTDailyInput.TotalProduction);
            txtTop5.Text = _EWTDailyInput.Top5;

            switch (Utilities.Tools.UserInfo.UserBusinessRole)
            {
                case Enums.BusinessRoleEnum.CheckMan:
                    txtSampleQuantity.Text = System.Convert.ToString(_EWTDailyInput.NQcSampleQuantity);
                    break;

                case Enums.BusinessRoleEnum.Auditor:
                    txtSampleQuantity.Text = System.Convert.ToString(_EWTDailyInput.NQaSampleQuantity);
                    break;
            }


            txtSampleQuantity.Text = System.Convert.ToString(_EWTDailyInput.NQaSampleQuantity);


            if (SelectedEwtId != null && ewtDataPicker.SelectedId != SelectedEwtId)
            {
                ewtDataPicker.SelectedId = SelectedEwtId;
            }
        }

        private void MyTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormIsLoaded == false)
            {
                return;
            }

            switch (MyTabControl.SelectedTab.Name)
            {
                case "tabpageNR":
                    UserControls.DailyInputForm.NRUserControl nRUserControl =
                        new UserControls.DailyInputForm.NRUserControl();
                    nRUserControl.Dock = DockStyle.Fill;

                    MyTabControl.SelectedTab.Controls.Add(nRUserControl);
                    break;

                case "tabpageNP":
                    UserControls.DailyInputForm.NPUserControl npUserControl = new UserControls.DailyInputForm.NPUserControl();
                    npUserControl.Dock = DockStyle.Fill;

                    MyTabControl.SelectedTab.Controls.Add(npUserControl);
                    break;

                case "tabpageSTP":
                    UserControls.DailyInputForm.STPUserControl stpUserControl = new UserControls.DailyInputForm.STPUserControl();
                    stpUserControl.Dock = DockStyle.Fill;

                    MyTabControl.SelectedTab.Controls.Add(stpUserControl);
                    break;

                case "tabpageREW":
                    UserControls.DailyInputForm.REWUserControl rewUserControl = new UserControls.DailyInputForm.REWUserControl();
                    rewUserControl.Dock = DockStyle.Fill;

                    MyTabControl.SelectedTab.Controls.Add(rewUserControl);
                    break;

                case "tabpageWAS":
                    UserControls.DailyInputForm.WASUserControl wasUserControl = new UserControls.DailyInputForm.WASUserControl();
                    wasUserControl.Dock = DockStyle.Fill;

                    MyTabControl.SelectedTab.Controls.Add(wasUserControl);
                    break;

                case "tabpageACD":
                    UserControls.DailyInputForm.ACDUserControl acdUserControl = new UserControls.DailyInputForm.ACDUserControl();
                    acdUserControl.Dock = DockStyle.Fill;

                    MyTabControl.SelectedTab.Controls.Add(acdUserControl);
                    break;

                case "tabpageSUG":
                    UserControls.DailyInputForm.SUGUserControl sugUserControl = new UserControls.DailyInputForm.SUGUserControl();
                    sugUserControl.Dock = DockStyle.Fill;

                    MyTabControl.SelectedTab.Controls.Add(sugUserControl);
                    break;

                case "tabpageNQA":
                    UserControls.DailyInputForm.NQAUserControl nqaUserControl = new UserControls.DailyInputForm.NQAUserControl();
                    nqaUserControl.Dock = DockStyle.Fill;

                    MyTabControl.SelectedTab.Controls.Add(nqaUserControl);
                    break;

                case "tabpageNQC":
                    UserControls.DailyInputForm.NQCUserControl nqcUserControl = new UserControls.DailyInputForm.NQCUserControl();
                    nqcUserControl.Dock = DockStyle.Fill;

                    MyTabControl.SelectedTab.Controls.Add(nqcUserControl);
                    break;
            }
        }

        private void rdToday_Click(object sender, EventArgs e)
        {
            MyTabControl.Enabled = true;
        }

        private async void rbtnSelectedDate_CheckedChanged(object sender, EventArgs e)
        {

            //if (UserControlIsLoaded == true)
            {


                groupBox1.Enabled = true;

                if (ewtDataPicker.SelectedId == null)
                {
                    MyErrorProvider.SetError(ewtDataPicker, "فیلد اجبار");
                    return;
                }

                if (rdToday.Checked == false && rdYesterday.Checked == false)
                {
                    return;
                }

                SelectedDate = rdYesterday.Checked == true ? rdYesterday.Text : rdToday.Text;
                SelectedEwtId = ewtDataPicker.SelectedId;

                using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@EWT_Id", SelectedEwtId);
                    parameters.Add("@RegisterDate", SelectedDate);
                    Models.EWTDailyInput currentEWTDailyInput =
                         await connection.QueryFirstOrDefaultAsync<Models.EWTDailyInput>("Select * From EWTDailyInput Where EWT_Id=@EWT_Id And RegisterDate=@RegisterDate", param: parameters, commandType: CommandType.Text);

                    if (currentEWTDailyInput != null)
                    {
                        SelectedFormMode = Enums.FormDataModeEnum.Edit;
                        this.FormDataMode = Enums.FormDataModeEnum.Edit;
                    }
                    else
                    {
                        SelectedFormMode = Enums.FormDataModeEnum.Add;
                        this.FormDataMode = Enums.FormDataModeEnum.Add;
                    }
                }


                if (SelectedFormMode == Enums.FormDataModeEnum.Add)
                {
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add("@EWT_Id", SelectedEwtId);
                        parameters.Add("@RegisterDate", SelectedDate);

                        await connection.ExecuteAsync("EWTDailyInput_Ins", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                }

                using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@EWT_Id", SelectedEwtId);
                    parameters.Add("@RegisterDate", SelectedDate);
                    Models.EWTDailyInput currentEWTDailyInput =
                         await connection.QueryFirstOrDefaultAsync<Models.EWTDailyInput>("Select * From EWTDailyInput Where EWT_Id=@EWT_Id And RegisterDate=@RegisterDate", param: parameters, commandType: CommandType.Text);

                    if (currentEWTDailyInput != null)
                    {
                        this.FormDataMode = Enums.FormDataModeEnum.Edit;  //should we type both of them??
                        SelectedFormMode = Enums.FormDataModeEnum.Edit;   //should we type both of them??
                        _EWTDailyInput = await GetSingleEWTDailyInput();

                        switch (Utilities.Tools.UserInfo.UserBusinessRole)
                        {
                            case Enums.BusinessRoleEnum.CheckMan:
                                UserControls.DailyInputForm.NQCUserControl nqcUserControl = new UserControls.DailyInputForm.NQCUserControl();
                                nqcUserControl.Dock = DockStyle.Fill;
                                MyTabControl.SelectedTab.Controls.Add(nqcUserControl);
                                break;
                            case Enums.BusinessRoleEnum.Masool:
                                UserControls.DailyInputForm.NRUserControl nRUserControl = new UserControls.DailyInputForm.NRUserControl();
                                nRUserControl.Dock = DockStyle.Fill;
                                MyTabControl.SelectedTab.Controls.Add(nRUserControl);
                                break;
                            case Enums.BusinessRoleEnum.Auditor:
                                UserControls.DailyInputForm.NQAUserControl nqaUserControl = new UserControls.DailyInputForm.NQAUserControl();
                                nqaUserControl.Dock = DockStyle.Fill;

                                MyTabControl.SelectedTab.Controls.Add(nqaUserControl);
                                break;
                            default:
                                break;
                        }

                        LoadDataInControls();

                    }

                }

                SetFormSize(FormSizeModeEnum.ModeB);
            }
        }

        private void EwtDataPicker_SelectedItem(object sender, int? selectedId, string selectedTitle, object selectedTag)
        {
            if (ewtDataPicker.SelectedId == null)
            {
                gbxSelectDate.Enabled = false;
            }
            else
            {
                foreach (TabPage item in MyTabControl.TabPages)
                {
                    item.Controls.Clear();
                }
                gbxSelectDate.Enabled = true;
                rdToday.Checked = false;
                rdYesterday.Checked = false;
                SetFormSize(FormSizeModeEnum.ModeA);
                //selectedFormMode == Enums.FormDataModeEnum.Add;

                //if (UserControlIsLoaded)
                //{
                //    EWTDailyInputForm frmEWTDailyInput = new EWTDailyInputForm();
                //    frmEWTDailyInput.Show();
                //    this.Close();
                //}

            }
        }

        private async void tsbtnSave_Click(object sender, EventArgs e)
        {
            switch (Utilities.Tools.UserInfo.UserBusinessRole)
            {
                case Enums.BusinessRoleEnum.CheckMan:
                    if (txtSampleQuantity.Value == 0)
                    {
                        System.Windows.Forms.MessageBox.Show(text: "تعداد نمونه نمیتوان صفر باشد", caption: "خطا", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                        return;
                    }
                    break;

                case Enums.BusinessRoleEnum.Auditor:
                    if (txtSampleQuantity.Value == 0)
                    {
                        System.Windows.Forms.MessageBox.Show(text: "تعداد نمونه نمیتوان صفر باشد", caption: "خطا", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                        return;
                    }

                    break;
                default:
                    break;
            }

            FormDataMode = Enums.FormDataModeEnum.Edit;
            bool isValid = await SaveData();

            if (isValid)
            {
                SetFormSize(FormSizeModeEnum.ModeC);
            }
        }

        public void SetFormSize(FormSizeModeEnum formSizeModeEnum)
        {
            switch (formSizeModeEnum)
            {
                case FormSizeModeEnum.ModeA:
                    this.Height = (int)FormSizeModeEnum.ModeA;
                    tsbtnSave.Visible = false;
                    break;

                case FormSizeModeEnum.ModeB:
                    this.Height = (int)FormSizeModeEnum.ModeB;
                    tsbtnSave.Visible = true;
                    break;

                case FormSizeModeEnum.ModeC:
                    this.Height = (int)FormSizeModeEnum.ModeC;
                    break;
            }
        }
    }
}