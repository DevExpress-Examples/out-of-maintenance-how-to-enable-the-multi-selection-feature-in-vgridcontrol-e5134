using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid;
using System.Diagnostics;
using System.Collections;
using DevExpress.XtraVerticalGrid.Rows;
using System.Linq;
using DevExpress.LookAndFeel;


namespace DXSample
{
    public partial class Main : XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        public DataSet GetDataSet()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Application.StartupPath + "\\nwind.xml");
            return ds;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            DataSet ds = GetDataSet();
            vGridControl1.DataSource = ds.Tables["Customers"];
            vGridControl2.DataSource = ds.Tables["Products"];
        }

        private void OnCheckedChanged(object sender, EventArgs e)
        {
            CheckEdit edit = sender as CheckEdit;
            if (edit.Name.Equals("checkEdit1"))
                selectionProvider1.SetMultiSelect(vGridControl1, !selectionProvider1.GetMultiSelect(vGridControl1));
            else
                selectionProvider1.SetMultiSelect(vGridControl2, !selectionProvider1.GetMultiSelect(vGridControl2));
        }
    }
}