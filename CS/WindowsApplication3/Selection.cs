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
    public class Selection : CollectionBase
    {
        private GridCell _StartRangeCell;
        VGridControlBase vgrid;
        public Selection(VGridControlBase vgrid)
        {
            this.vgrid = vgrid;
        }

        protected override void OnInsertComplete(int index, object value)
        {
            base.OnInsertComplete(index, value);
            InvalidateRow(value);
        }

        private void InvalidateRow(object value)
        {
            GridCell cell = value as GridCell;
            vgrid.InvalidateRow(cell.Row);
        }

        protected override void OnRemoveComplete(int index, object value)
        {
            base.OnRemoveComplete(index, value);
            InvalidateRow(value);
        }

        protected override void OnClear()
        {
            while (List.Count > 0)
                List.RemoveAt(List.Count - 1);
        }

        public bool Contains(GridCell cell)
        {
            if (cell.Row is CategoryRow)
                return List.OfType<GridCell>().Any(c => c.Row.Equals(cell.Row)); 
           return List.Contains(cell);
        }

        public void Add(GridCell cell)
        {
            List.Add(cell);
        }

        public void Remove(GridCell cell)
        {
            if (cell.Row is CategoryRow)
                List.Remove(List.OfType<GridCell>().First(c => c.Row.Equals(cell.Row)));
            else
                List.Remove(cell);
        }

        public GridCell this[int index]
        {
            get
            {
                return List[index] as GridCell;
            }
            set
            {
                List[index] = value;
            }
        }

        public int IndexOf(GridCell cell)
        {
            return List.IndexOf(cell);
        }


        public GridCell StartRangeCell
        {
            get { return _StartRangeCell; }
            set { _StartRangeCell = value; }
        }

    }
}
