using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EWT.UserControls
{
    public partial class SearchBox : UserControl
    {
        public SearchBox()
        {
            InitializeComponent();
        }

        public string TextSearch
        {
            get
            {
                return txtSearchBox.Text;
            }
            set
            {
                txtSearchBox.Text = value;
            }
        }

        private DataGridView dataGridView = null;
        public DataGridView DataGridView
        {
            get
            {
                return dataGridView;
            }
            set
            {
                dataGridView = value;
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (DataGridView.DataSource == null)
            {
                return;
            }
            string searchOperator = "LIKE '%{1}%'";
            switch (cbxSearchType.SelectedValue)
            {
                case "1":
                    searchOperator = "LIKE '{1}%'";
                    break;

                case "2":
                    searchOperator = "LIKE '%{1}%'";
                    break;

                case "3":
                    searchOperator = "='{1}'";
                    break;

                case "4":
                    searchOperator = "<>'{1}'";
                    break;
            }

            try
            {
                string rowFilter = string.Format("{0} " + searchOperator, cbxDataGridVewColumns.SelectedValue, txtSearchBox.Text);
                (DataGridView.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
            catch (Exception)
            {

            }
        }

        private void SearchBox_Load(object sender, EventArgs e)
        {
            #region Initialize cbxSearchType
            Dictionary<string, string> searchTypes = new Dictionary<string, string>();
            searchTypes.Add("2", "شامل");
            searchTypes.Add("1", "شروع با");
            searchTypes.Add("3", "مساوی");
            searchTypes.Add("4", "مخالف");

            cbxSearchType.DataSource = new BindingSource(searchTypes, null);
            cbxSearchType.DisplayMember = "Value";
            cbxSearchType.ValueMember = "Key";

            //cbxSearchType.Items.Add("شروع با");
            //cbxSearchType.Items.Add("شامل");
            //cbxSearchType.Items.Add("مساوی");
            #endregion

            if (DataGridView != null)
            {
                var dataGridViewVisibleColumns =
                    DataGridView.Columns.Cast<DataGridViewColumn>().Where(p => p.Visible == true).Select(p => new
                    {
                        HeaderText = p.HeaderText,
                        Name = p.Name
                    })
                 .ToList();

                cbxDataGridVewColumns.DataSource = dataGridViewVisibleColumns;
                cbxDataGridVewColumns.DisplayMember = "HeaderText";
                cbxDataGridVewColumns.ValueMember = "Name";
            }

            (this.ParentForm).Shown += SearchBox_Shown;
        }

        private void SearchBox_Shown(object sender, EventArgs e)
        {
            txtSearchBox.Focus();
            txtSearchBox.SelectAll();
        }

        private void cbxDataGridVewColumns_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextSearch))
            {
                txtSearchBox.Clear();
            }
        }
    }
}
