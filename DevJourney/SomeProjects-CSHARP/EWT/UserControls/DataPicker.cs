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
    public partial class DataPicker : UserControl
    {
        public DataPicker()
        {
            InitializeComponent();
        }

        public bool IsStringDataPicker { get; set; } = false;
        public bool EnableCheckBox { get; set; }
        public Dictionary<string, string> SelectedListItems = null;
        public string TextSearch { get; set; }

        public string ColumnTagName { get; set; }

        public delegate void SelectedItemEventHandler(object sender, int? selectedId, string selectedTitle, object selectedTag);
        public event SelectedItemEventHandler SelectedItem;

        public delegate void SelectedStringItemEventHandler(object sender, string selectedStringId, string selectedTitle, object selectedTag);
        public event SelectedStringItemEventHandler SelectedStringItem;

        public string TextColumnName { get; set; } = null;

        public System.Collections.Generic.List<DataGridViewColumn> DataGridColumns { get; set; }


        private int? _selectedId = null;

        [Browsable(false)]
        public int? SelectedId
        {
            get
            {
                return _selectedId;
            }
            set
            {
                _selectedId = value;

                if (value != null && DataSource != null)
                {
                    var findedRow = ((DataTable)DataSource).AsEnumerable().FirstOrDefault(p => Convert.ToInt64(p[0]) == _selectedId);
                    if (findedRow != null)
                    {
                        if (TextColumnName == null)
                        {
                            txtSelectedTitle.Text = findedRow.Field<string>(1);
                        }
                        else
                        {
                            txtSelectedTitle.Text = findedRow.Field<string>(TextColumnName);
                        }

                        if (string.IsNullOrEmpty(ColumnTagName) == false)
                        {
                            SelectedTagValue = findedRow.Field<object>(ColumnTagName);
                        }
                    }
                }

                OnSelectedItem();
            }
        }


        private string _selectedStringId = null;
        public string SelectedStringId
        {
            get
            {
                return _selectedStringId;
            }
            set
            {
                _selectedStringId = value;

                if (value != null && DataSource != null)
                {
                    var findedRow = ((DataTable)DataSource).AsEnumerable().FirstOrDefault(p => p[0].ToString() == _selectedStringId);
                    if (findedRow != null)
                    {
                        if (TextColumnName == null)
                        {
                            txtSelectedTitle.Text = findedRow.Field<string>(1);
                        }
                        else
                        {
                            txtSelectedTitle.Text = findedRow.Field<string>(TextColumnName);
                        }

                        if (string.IsNullOrEmpty(ColumnTagName) == false)
                        {
                            SelectedTagValue = findedRow.Field<object>(ColumnTagName);
                        }
                    }
                }

                OnSelectedItem();
            }
        }


        [Browsable(false)]
        public string SelectedTitle { get; set; } = null;

        public object SelectedTagValue { get; set; }

        [Browsable(false)]
        public object DataSource { get; set; }

        public DataPickerForm DataPickerForm { get; set; }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataPickerForm = new DataPickerForm(this.IsStringDataPicker, TextSearch, EnableCheckBox, SelectedListItems);
            
            DataPickerForm.DataGridColumns = this.DataGridColumns.ToList();
            DataPickerForm.DataSource = this.DataSource;
            DataPickerForm.ShowDialog(this);
            this.SelectedListItems = DataPickerForm.SelectedListItems;

            TextSearch = DataPickerForm.searchBox1.TextSearch;
            if (IsStringDataPicker)
            {
                this.SelectedStringId = DataPickerForm.SelectedStringId;
            }
            else
            {
                this.SelectedId = DataPickerForm.SelectedId;
            }

            this.SelectedTitle = DataPickerForm.SelectedTitle;
            txtSelectedTitle.Text = this.SelectedTitle;

            DataPickerForm.Dispose();
            DataPickerForm = null;

            //(this.DataSource as DataTable).DefaultView.RowStateFilter = DataViewRowState.OriginalRows;
        }

        public void Clear()
        {
            txtSelectedTitle.Clear();
        }

        private void DataPicker_ControlAdded(object sender, ControlEventArgs e)
        {
            if (DataGridColumns == null)
            {
                DataGridColumns = new List<DataGridViewColumn>();
            }
        }

        protected virtual void OnSelectedItem()
        {
            if (IsStringDataPicker == false)
            {
                if (SelectedItem != null)
                    SelectedItem(this, (int?)SelectedId, SelectedTitle, SelectedTagValue);
            }
            else
            {
                if (SelectedStringItem != null)
                    SelectedStringItem(this, SelectedStringId, SelectedTitle, SelectedTagValue);
            }

        }
    }
}
