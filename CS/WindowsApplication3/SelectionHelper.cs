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
    public class SelectionHelper
    {
        private SelectOperaion _SelectionOperation;
        private Selection _Selection;
        VGridControlBase vgrid;

        public SelectionHelper(VGridControlBase vgrid)
        {
            this.vgrid = vgrid;
            Selection = new Selection(vgrid);
        }

        public Selection Selection
        {
            get { return _Selection; }
            set
            {
                if (_Selection != value)
                {
                    _Selection = value;
                }
            }
        }

        private SelectOperaion SelectionOperation
        {
            get {
                if (_SelectionOperation == null)
                    _SelectionOperation = new SelectOperaion(Selection);
                return _SelectionOperation;
            }
        }

        public void SelectCell(GridCell cell)
        {
            Selection.StartRangeCell = null;
            if (Selection.Contains(cell))
                Selection.Remove(cell);
            else
                Selection.Add(cell);
        }


        public bool IsEmpty
        {
            get { return Selection.Count == 0; }
        }

        public void SelectCellRange(GridCell endCell)
        {
            GridCell startCell = Selection[Selection.Count - 1];
            if (Selection.StartRangeCell != null)
            {
                int index = Selection.IndexOf(Selection.StartRangeCell);
                while (Selection.Count > index + 1)
                    Selection.RemoveAt(Selection.Count - 1);
                startCell = Selection.StartRangeCell;
            }
            else
                Selection.StartRangeCell = startCell;

            int startRow = Math.Min(startCell.Row.VisibleIndex, endCell.Row.VisibleIndex);
            int endRow = Math.Max(startCell.Row.VisibleIndex, endCell.Row.VisibleIndex);
            int startRecord = Math.Min(startCell.Record, endCell.Record);
            int endRecord = Math.Max(startCell.Record, endCell.Record);
            SelectionOperation.StartCell = new Point(startRow, startRecord);
            SelectionOperation.EndCell = new Point(endRow, endRecord);
            vgrid.RowsIterator.DoOperation(SelectionOperation);
        }

        public void ClearAndSelectCell(GridCell cell)
        {
            Selection.StartRangeCell = null;
            Selection.Clear();
            Selection.Add(cell);
        }

        public void Clear()
        {
            Selection.Clear();
        }

        public bool Contains(GridCell cell)
        {
            return Selection.Contains(cell);
        }

        public void SelectAll()
        {
            SelectionOperation.StartCell = new Point(0, 0);
            SelectionOperation.EndCell = new Point(vgrid.Rows.VisibleRowsCount, vgrid.RecordCount);
            vgrid.RowsIterator.DoOperation(SelectionOperation);
        }

        public void RefreshSelection()
        {
            foreach (GridCell cell in Selection)
                vgrid.InvalidateRow(cell.Row);
        }
    }
}