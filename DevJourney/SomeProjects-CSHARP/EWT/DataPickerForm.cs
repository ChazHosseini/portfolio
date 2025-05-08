using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EWT
{
    public partial class DataPickerForm : BaseForm
    {
        public DataPickerForm()
        {
            InitializeComponent();
        }

        private bool _enableCheckBox = false;
        public bool EnableCheckBox
        {
            get
            {
                return _enableCheckBox;
            }
            set
            {
                _enableCheckBox = value;
                MyDataGridView.Columns["chkColumn"].Visible = _enableCheckBox;
                if (_enableCheckBox)
                {
                    MyDataGridView.ReadOnly = false;
                    MyDataGridView.Columns["chkColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
        }
        public bool FormIsLoaded { get; set; }

        private Dictionary<string, string> _selectedListItems = null;
        public Dictionary<string, string> SelectedListItems
        {
            get
            {
                if (_selectedListItems == null)
                {
                    _selectedListItems = new Dictionary<string, string>();
                }

                return _selectedListItems;
            }
            set
            {
                _selectedListItems = value;
            }
        }

        public DataPickerForm(bool isStringDataPicker, string textSearch, bool enableCheckBox, Dictionary<string, string> selectedListItems)
            : this()
        {
            this.IsStringDataPicker = isStringDataPicker;
            searchBox1.TextSearch = textSearch;
            EnableCheckBox = enableCheckBox;
            SelectedListItems = selectedListItems;
        }

        public System.Collections.Generic.List<DataGridViewColumn> DataGridColumns { get; set; }

        public bool IsStringDataPicker { get; set; } = false;

        public object _dataSource = null;
        public object DataSource
        {
            get
            {
                return _dataSource;
            }
            set
            {
                _dataSource = value;
                if (_dataSource != null)
                {
                    LoadDataGridColumns();
                }
            }
        }

        public int? SelectedId { get; set; } = null;
        public string SelectedStringId { get; set; } = null;
        public string SelectedTitle { get; set; } = null;

        private void LoadDataGridColumns()
        {
            MyDataGridView.AutoGenerateColumns = false;
            if (MyDataGridView.Columns.Count == 1)
            {
                foreach (var column in DataGridColumns)
                {
                    column.ReadOnly = true;
                    MyDataGridView.Columns.Add(column);
                }
            }

            MyDataGridView.DataSource = DataSource;          
        }

        private void MyDataGridView_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataPickerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EnableCheckBox == false)
            {
                if (MyDataGridView.CurrentRow != null && MyDataGridView.CurrentRow.Cells[2].Value != null)
                {
                    if (IsStringDataPicker)
                    {
                        this.SelectedStringId = MyDataGridView.CurrentRow.Cells[1].Value.ToString();
                    }
                    else
                    {
                        this.SelectedId = System.Convert.ToInt32(MyDataGridView.CurrentRow.Cells[1].Value);
                    }

                    this.SelectedTitle = MyDataGridView.CurrentRow.Cells[2].Value.ToString();
                }
            }
            else
            {
                this.SelectedTitle = "چندین آیتم انتخاب شده است";
            }
        }

        private void MyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MyDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void MyDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (FormIsLoaded == false)
            {
                return;
            }

            if (MyDataGridView.DataSource != null)
            {
                if (MyDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "True")
                {
                    SelectedListItems.Add
                        (
                        MyDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        MyDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString()
                        );
                }
                else
                {
                    if (SelectedListItems.FirstOrDefault(p => p.Key == MyDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()).Key != null)
                    {
                        SelectedListItems.Remove(MyDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                    }
                }
            }
        }

        private void DataPickerForm_Load(object sender, EventArgs e)
        {
            if (SelectedListItems.Count > 0)
            {
                foreach (DataGridViewRow row in MyDataGridView.Rows)
                {
                    if (SelectedListItems.Any(p => p.Key == row.Cells[1].Value.ToString()))
                    {
                        row.Cells[0].Value = true;
                    }
                }
            }

            FormIsLoaded = true;
        }
    }
}
