Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid
Imports System.Diagnostics
Imports System.Collections
Imports DevExpress.XtraVerticalGrid.Rows
Imports System.Linq
Imports DevExpress.LookAndFeel

Namespace DXSample
	Public Class SelectionHelper
		Private _SelectionOperation As SelectOperaion
		Private _Selection As Selection
		Private vgrid As VGridControlBase

		Public Sub New(ByVal vgrid As VGridControlBase)
			Me.vgrid = vgrid
			Selection = New Selection(vgrid)
		End Sub

		Public Property Selection() As Selection
			Get
				Return _Selection
			End Get
			Set(ByVal value As Selection)
				If _Selection IsNot value Then
					_Selection = value
				End If
			End Set
		End Property

		Private ReadOnly Property SelectionOperation() As SelectOperaion
			Get
				If _SelectionOperation Is Nothing Then
					_SelectionOperation = New SelectOperaion(Selection)
				End If
				Return _SelectionOperation
			End Get
		End Property

		Public Sub SelectCell(ByVal cell As GridCell)
			Selection.StartRangeCell = Nothing
			If Selection.Contains(cell) Then
				Selection.Remove(cell)
			Else
				Selection.Add(cell)
			End If
		End Sub


		Public ReadOnly Property IsEmpty() As Boolean
			Get
				Return Selection.Count = 0
			End Get
		End Property

		Public Sub SelectCellRange(ByVal endCell As GridCell)
			Dim startCell As GridCell = Selection(Selection.Count - 1)
			If Selection.StartRangeCell IsNot Nothing Then
				Dim index As Integer = Selection.IndexOf(Selection.StartRangeCell)
				Do While Selection.Count > index + 1
					Selection.RemoveAt(Selection.Count - 1)
				Loop
				startCell = Selection.StartRangeCell
			Else
				Selection.StartRangeCell = startCell
			End If

			Dim startRow As Integer = Math.Min(startCell.Row.VisibleIndex, endCell.Row.VisibleIndex)
			Dim endRow As Integer = Math.Max(startCell.Row.VisibleIndex, endCell.Row.VisibleIndex)
			Dim startRecord As Integer = Math.Min(startCell.Record, endCell.Record)
			Dim endRecord As Integer = Math.Max(startCell.Record, endCell.Record)
			SelectionOperation.StartCell = New Point(startRow, startRecord)
			SelectionOperation.EndCell = New Point(endRow, endRecord)
			vgrid.RowsIterator.DoOperation(SelectionOperation)
		End Sub

		Public Sub ClearAndSelectCell(ByVal cell As GridCell)
			Selection.StartRangeCell = Nothing
			Selection.Clear()
			Selection.Add(cell)
		End Sub

		Public Sub Clear()
			Selection.Clear()
		End Sub

		Public Function Contains(ByVal cell As GridCell) As Boolean
			Return Selection.Contains(cell)
		End Function

		Public Sub SelectAll()
			SelectionOperation.StartCell = New Point(0, 0)
			SelectionOperation.EndCell = New Point(vgrid.Rows.VisibleRowsCount, vgrid.RecordCount)
			vgrid.RowsIterator.DoOperation(SelectionOperation)
		End Sub

		Public Sub RefreshSelection()
			For Each cell As GridCell In Selection
				vgrid.InvalidateRow(cell.Row)
			Next cell
		End Sub
	End Class
End Namespace