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
    public class SelectOperaion : RowOperation
    {
        private Point _EndCell;
        private Point _StartCell;
        Selection selection;

        public SelectOperaion(Selection selection)
        {
            this.selection = selection;
        }

        public Point StartCell
        {
            get { return _StartCell; }
            set
            {
                _StartCell = value;
            }
        }

        public Point EndCell
        {
            get { return _EndCell; }
            set
            {
                _EndCell = value;
            }
        }

        public override void Execute(BaseRow row)
        {
            if (row.VisibleIndex >= StartCell.X && row.VisibleIndex <= EndCell.X)
            {
                for (int i = StartCell.Y; i <= EndCell.Y; i++)
                {
                    MultiEditorRow multiRow = row as MultiEditorRow;
                    int endCellIndex = 0;
                    if (multiRow != null)
                        endCellIndex = multiRow.RowPropertiesCount - 1;
                    for (int k = 0; k <= endCellIndex; k++)
                    {
                        GridCell newCell = new GridCell(row, k, i);  
                        if (!selection.Contains(newCell))
                            selection.Add(newCell);
                    }
                }
            }
        }
    }
}
