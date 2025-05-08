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
    public partial class EWTDailyInputPickDateForm : BaseForm
    {
        public string SelectedDate { get; set; }
        public int ewt_Id { get; set; }

        public EWTDailyInputPickDateForm()
        {
            InitializeComponent();
            dailydateGridView.AutoGenerateColumns = false;
            
        }

        public async Task LoadData()
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                string queryString = null;
                switch (Utilities.Tools.UserInfo.UserBusinessRole)
                {
                    case Enums.BusinessRoleEnum.CheckMan:
                        queryString = "select ewt.Id,EWT.Title,EWTDailyInput.RegisterDate from EWTDailyInput inner join EWT on ewt.Id = EWTDailyInput.EWT_Id inner join EWTCheckMans on ewt.Id=EWTCheckMans.EWT_Id where EWTCheckMans.PERS_NO=@PERS_NO";

                        break;

                    case Enums.BusinessRoleEnum.Masool:
                        queryString = "select ewt.Id,EWT.Title,EWTDailyInput.RegisterDate from EWTDailyInput inner join EWT on ewt.Id = EWTDailyInput.EWT_Id inner join EWTMasools on ewt.Id=EWTMasools.EWT_Id where EWTMasools.PERS_NO=@PERS_NO";
                        break;

                    case Enums.BusinessRoleEnum.Auditor:
                        queryString = "select ewt.Id,EWT.Title,EWTDailyInput.RegisterDate from EWTDailyInput inner join EWT on ewt.Id = EWTDailyInput.EWT_Id inner join EWTAuditors on ewt.Id=EWTAuditors.EWT_Id where EWTAuditors.PERS_NO=@PERS_NO";
                        break;

                    default:
                        break;

                }


                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@PERS_NO", dbType: DbType.String, value: Utilities.Tools.UserInfo.PersNo);
                var reader = await connection.ExecuteReaderAsync(sql: queryString, param: parameter);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dailydateGridView.DataSource = dataTable;
            }


        }

      

        private void tsbtnShow_Click(object sender, EventArgs e)
        {
            ewt_Id = System.Convert.ToInt32(dailydateGridView.CurrentRow.Cells["Id"].Value);
            SelectedDate = dailydateGridView.CurrentRow.Cells["RegisterDate"].Value.ToString();

            EWTDailyInputShowForm ewtdailyinputshowform = new EWTDailyInputShowForm(SelectedDate, ewt_Id, Enums.FormDataModeEnum.Display);
            ewtdailyinputshowform.ShowDialog();

            ewtdailyinputshowform.Dispose();
            ewtdailyinputshowform = null;
        }

        private async void EWTDailyInputPickDateForm_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
    }
}
