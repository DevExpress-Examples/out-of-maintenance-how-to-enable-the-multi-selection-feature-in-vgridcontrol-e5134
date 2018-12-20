using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid;
using System;
using System.Data;
using System.Windows.Forms;

namespace DXSample {
    public partial class Main : XtraForm {
        public Main() {
            InitializeComponent();
            vGridControl1.OptionsSelectionAndFocus.MultiSelect = true;
            vGridControl2.OptionsSelectionAndFocus.MultiSelect = true;
            vGridControl3.OptionsSelectionAndFocus.MultiSelect = true;


            vGridControl2.OptionsSelectionAndFocus.MultiSelectMode = MultiSelectMode.RowSelect;
            vGridControl3.OptionsSelectionAndFocus.MultiSelectMode = MultiSelectMode.CellSelect;
        }

        private void OnCheckedChanged(object sender, EventArgs e) {
            CheckEdit editor = sender as CheckEdit;

            if (editor.Name.Contains("1"))
                vGridControl1.OptionsSelectionAndFocus.MultiSelect = editor.Checked;
            else if (editor.Name.Contains("2"))
                vGridControl2.OptionsSelectionAndFocus.MultiSelect = editor.Checked;
            else if (editor.Name.Contains("3"))
                vGridControl3.OptionsSelectionAndFocus.MultiSelect = editor.Checked;
        }

        public DataSet GetDataSet() {
            DataSet ds = new DataSet();
            ds.ReadXml(Application.StartupPath + "\\nwind.xml");
            return ds;
        }

        private void OnFormLoad(object sender, EventArgs e) {
            DataSet ds = GetDataSet();
            vGridControl1.DataSource = ds.Tables["Customers"];
            vGridControl2.DataSource = ds.Tables["Products"];
            vGridControl3.DataSource = ds.Tables["Orders"];
        }
    }
}