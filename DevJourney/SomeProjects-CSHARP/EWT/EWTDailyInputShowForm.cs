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
    public partial class EWTDailyInputShowForm : BaseForm
    {
        public Enums.FormDataModeEnum SelectedFormMode { get; set; }
        public Models.EWTDailyInput _EWTDailyInput { get; set; }

        public bool SaveAllowed { get; set; }

        public string SelectedDate { get; set; }
        public int? SelectedEwtId { get; set; }

        public bool FormIsLoaded { get; set; } = false;

        #region FormConstructors
        public EWTDailyInputShowForm()
        {
            InitializeComponent();

            ewtDataPicker.SelectedItem += EwtDataPicker_SelectedItem;
        }

        public EWTDailyInputShowForm(string selectedDate, int selectedEwtId, Enums.FormDataModeEnum selectedFormMode)
            : this()
        {
            SelectedDate = selectedDate;
            SelectedEwtId = selectedEwtId;
            SelectedFormMode = selectedFormMode;
            label4.Text = selectedDate;

        }

        public EWTDailyInputShowForm(Enums.FormDataModeEnum selectedFormMode)
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
                    ewtQuery = "Select EWT_Id,E.Title From EWTCheckMans EWTCM Inner Join EWT E On E.Id=EWTCM.EWT_Id Where EWTCM.PERS_NO=@Pers_No";
                    break;

                case Enums.BusinessRoleEnum.Masool:
                    ewtQuery = "Select EWT_Id,E.Title From EWTMasools EWTCM Inner Join EWT E On E.Id=EWTCM.EWT_Id Where EWTCM.PERS_NO=@Pers_No";
                    break;

                case Enums.BusinessRoleEnum.Auditor:
                    ewtQuery = "Select EWT_Id,E.Title From EWTAuditors EWTCM Inner Join EWT E On E.Id=EWTCM.EWT_Id Where EWTCM.PERS_NO=@Pers_No";
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

            //await LoadData();

            /////end of Load EWT DataPicker For Current Masool

            if (SelectedFormMode == Enums.FormDataModeEnum.Display)
            {

                ewtDataPicker.Enabled = false;
                _EWTDailyInput = await GetSingleEWTDailyInput();
                LoadDataInControls();
                label4.Visible = true;

                using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                {
                    Models.EWTDailyInputInitialDate insertValidDates =
                    await connection.QueryFirstOrDefaultAsync<Models.EWTDailyInputInitialDate>(sql: "GetDailyInputValidDate", commandType: CommandType.StoredProcedure);

                    if ((label4.Text == insertValidDates.CurrentDate) || (label4.Text == insertValidDates.PrevDate))
                    {
                        this.FormDataMode = Enums.FormDataModeEnum.Edit;
                        tsbtnSave.Enabled = true;
                        SaveAllowed = true;
                    }
                    else
                    {
                        this.FormDataMode = Enums.FormDataModeEnum.Display;
                        tsbtnSave.Enabled = false;
                        SaveAllowed = false;
                    }
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
                    MyTabControl.TabPages.Remove(MyTabControl.TabPages["tabpageGeneral"]);
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

                    UserControls.DailyInputForm.NQAUserControl nqaUserControl = new UserControls.DailyInputForm.NQAUserControl();
                    nqaUserControl.Dock = DockStyle.Fill;

                    MyTabControl.SelectedTab.Controls.Add(nqaUserControl);

                    break;
            }

            FormIsLoaded = true;
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


            if (SelectedEwtId != null)
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

                   /* case "tabpageNQC":
                        UserControls.DailyInputForm.SUGUserControl sugUserControl = new UserControls.DailyInputForm.SUGUserControl();
                        sugUserControl.Dock = DockStyle.Fill;

                        MyTabControl.SelectedTab.Controls.Add(sugUserControl);
                        break;
                    */
                    
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
                gbxSelectDate.Enabled = true;
            }
        }

      
    }
}