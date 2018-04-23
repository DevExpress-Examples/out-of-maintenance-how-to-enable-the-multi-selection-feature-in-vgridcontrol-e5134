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
    [ProvideProperty("MultiSelect",typeof(VGridControlBase))]
    public class SelectionProvider: Component, IExtenderProvider
    {
        Hashtable controls;

        public SelectionProvider()
        {
            this.controls = new Hashtable();
        }

        public bool GetMultiSelect(VGridControlBase vgrid)
        {
            return controls.Contains(vgrid);
        }

        public void SetMultiSelect(VGridControlBase vgrid, bool val)
        {
            if (val)
            {
                controls[vgrid] = new SelectionHelper(vgrid);
                EnableMultiSelect(vgrid);
            }
            else
            {
                SelectionHelper selectionHelper = GetSelectionHelper(vgrid);
                if (selectionHelper != null)
                {
                    selectionHelper.Clear();
                    DisableMultiSelect(vgrid);
                    controls[vgrid] = null;
                    controls.Remove(vgrid);
                }
            }
        }

        private void EnableMultiSelect(VGridControlBase vgrid)
        {
            vgrid.CustomDrawRowHeaderCell += OnCustomDrawRowHeaderCell;
            vgrid.RecordCellStyle += OnRecordCellStyle;
            vgrid.KeyUp += OnKeyUp;
            vgrid.MouseDown += OnMouseDown;
            vgrid.MouseUp += OnMouseUp;
            vgrid.ShowingEditor += OnShowingEditor;
            vgrid.ShownEditor += OnShownEditor;
            vgrid.Leave += OnFocusChanged;
            vgrid.Enter += OnFocusChanged;
        }

        private void DisableMultiSelect(VGridControlBase vgrid)
        {
            vgrid.CustomDrawRowHeaderCell -= OnCustomDrawRowHeaderCell;
            vgrid.RecordCellStyle -= OnRecordCellStyle;
            vgrid.KeyUp -= OnKeyUp;
            vgrid.MouseDown -= OnMouseDown;
            vgrid.MouseUp -= OnMouseUp;
            vgrid.ShowingEditor -= OnShowingEditor;
            vgrid.ShownEditor -= OnShownEditor;
            vgrid.Leave -= OnFocusChanged;
            vgrid.Enter -= OnFocusChanged;
        }

        private SelectionHelper GetSelectionHelper(VGridControlBase vgrid)
        {
            return controls[vgrid] as SelectionHelper;
        }

        bool canShowEditor = true;

        void OnMouseDown(object sender, MouseEventArgs e)
        {
            VGridControlBase vgrid = sender as VGridControlBase;
            VGridHitInfo hitInfo = vgrid.CalcHitInfo(e.Location);
            canShowEditor = hitInfo.Row != null && hitInfo.Row.Equals(vgrid.FocusedRow) && hitInfo.RecordIndex.Equals(vgrid.FocusedRecord) && hitInfo.CellIndex.Equals(vgrid.FocusedRecordCellIndex);
        }

        void OnMouseUp(object sender, MouseEventArgs e)
        {
            VGridControlBase vgrid = sender as VGridControlBase;
            SelectionHelper selectionHelper = GetSelectionHelper(vgrid);
            if (e.Button == MouseButtons.Left)
            {
                GridCell cell = new GridCell(vgrid.FocusedRow, vgrid.FocusedRecordCellIndex, vgrid.FocusedRecord);
                if ((Control.ModifierKeys & Keys.Control) == Keys.Control || selectionHelper.IsEmpty)
                    selectionHelper.SelectCell(cell);
                else if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                    selectionHelper.SelectCellRange(cell);
                else
                    selectionHelper.ClearAndSelectCell(cell); 
            }
        }

        void OnShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = !CanShowEditor();
            canShowEditor = true;
        }

        bool CanShowEditor()
        {
            return canShowEditor && !IsSelectionMode();
        }

        bool IsSelectionMode()
        {
            return (Control.ModifierKeys & Keys.Control) == Keys.Control || (Control.ModifierKeys & Keys.Shift) == Keys.Shift;
        }

        void OnShownEditor(object sender, EventArgs e)
        {
            VGridControlBase vgrid = sender as VGridControlBase;
            SelectionHelper selectionHelper = GetSelectionHelper(vgrid);
            selectionHelper.Clear();
        }

        void OnKeyUp(object sender, KeyEventArgs e)
        {
            VGridControlBase vgrid = sender as VGridControlBase;
            SelectionHelper selectionHelper = GetSelectionHelper(vgrid);
            if (e.Shift)
            {
                if ((e.KeyData & Keys.Right) == Keys.Right || 
                    (e.KeyData & Keys.Left) == Keys.Left || 
                    (e.KeyData & Keys.Up) == Keys.Up || 
                    (e.KeyData & Keys.Down) == Keys.Down ||
                    (e.KeyData & Keys.PageDown) == Keys.PageDown||
                    (e.KeyData & Keys.PageUp) == Keys.PageUp)
                {
                    GridCell endCell = new GridCell(vgrid.FocusedRow, vgrid.FocusedRecordCellIndex, vgrid.FocusedRecord);
                    selectionHelper.SelectCellRange(endCell);
                }
            }
            if (e.Control && (e.KeyData & Keys.A) == Keys.A)
                selectionHelper.SelectAll();
        }

        void OnRecordCellStyle(object sender, DevExpress.XtraVerticalGrid.Events.GetCustomRowCellStyleEventArgs e)
        {
            VGridControlBase vgrid = sender as VGridControlBase;
            SelectionHelper selectionHelper = GetSelectionHelper(vgrid);
            GridCell cell = new GridCell(e.Row, e.CellIndex, e.RecordIndex);
            if (selectionHelper.Contains(cell))
            {
                e.Appearance.BackColor = GetBackColor(vgrid);
                e.Appearance.ForeColor = GetForeColor(vgrid);
            }
        }

        private Color GetBackColor(VGridControlBase vgrid)
        {
            return vgrid.ContainsFocus ? vgrid.ViewInfo.PaintAppearance.FocusedRow.BackColor : vgrid.ViewInfo.PaintAppearance.HideSelectionRow.BackColor;
        }

        private Color GetForeColor(VGridControlBase vgrid)
        {
            return vgrid.ContainsFocus ? vgrid.ViewInfo.PaintAppearance.FocusedRow.ForeColor : vgrid.ViewInfo.PaintAppearance.HideSelectionRow.ForeColor;
        }

        void OnCustomDrawRowHeaderCell(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventArgs e)
        {
            if (e.Row is CategoryRow)
            {
                VGridControlBase vgrid = sender as VGridControlBase;
                SelectionHelper selectionHelper = GetSelectionHelper(vgrid);
                GridCell cell = new GridCell(e.Row, e.CellIndex, vgrid.FocusedRecord);
                if (selectionHelper.Contains(cell))
                {
                    e.Appearance.BackColor = GetBackColor(vgrid);
                    e.Appearance.ForeColor = GetForeColor(vgrid);
                }
            }
        }

        void OnFocusChanged(object sender, EventArgs e)
        {
            VGridControlBase vgrid = sender as VGridControlBase;
            SelectionHelper selectionHelper = GetSelectionHelper(vgrid);
            selectionHelper.RefreshSelection();
        }

        bool IExtenderProvider.CanExtend(object extendee)
        {
            return extendee is VGridControlBase;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                foreach (VGridControlBase vgrid in controls)
                    SetMultiSelect(vgrid, false);
            base.Dispose(disposing);
        }
    }
}
