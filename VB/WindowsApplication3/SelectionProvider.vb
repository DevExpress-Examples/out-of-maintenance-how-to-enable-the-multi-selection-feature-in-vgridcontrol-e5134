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
	<ProvideProperty("MultiSelect",GetType(VGridControlBase))> _
	Public Class SelectionProvider
		Inherits Component
		Implements IExtenderProvider
		Private controls As Hashtable

		Public Sub New()
			Me.controls = New Hashtable()
		End Sub

		Public Function GetMultiSelect(ByVal vgrid As VGridControlBase) As Boolean
			Return controls.Contains(vgrid)
		End Function

		Public Sub SetMultiSelect(ByVal vgrid As VGridControlBase, ByVal val As Boolean)
			If val Then
				controls(vgrid) = New SelectionHelper(vgrid)
				EnableMultiSelect(vgrid)
			Else
				Dim selectionHelper As SelectionHelper = GetSelectionHelper(vgrid)
				If selectionHelper IsNot Nothing Then
					selectionHelper.Clear()
					DisableMultiSelect(vgrid)
					controls(vgrid) = Nothing
					controls.Remove(vgrid)
				End If
			End If
		End Sub

		Private Sub EnableMultiSelect(ByVal vgrid As VGridControlBase)
			AddHandler vgrid.CustomDrawRowHeaderCell, AddressOf OnCustomDrawRowHeaderCell
			AddHandler vgrid.RecordCellStyle, AddressOf OnRecordCellStyle
			AddHandler vgrid.KeyUp, AddressOf OnKeyUp
			AddHandler vgrid.MouseDown, AddressOf OnMouseDown
			AddHandler vgrid.MouseUp, AddressOf OnMouseUp
			AddHandler vgrid.ShowingEditor, AddressOf OnShowingEditor
			AddHandler vgrid.ShownEditor, AddressOf OnShownEditor
			AddHandler vgrid.Leave, AddressOf OnFocusChanged
			AddHandler vgrid.Enter, AddressOf OnFocusChanged
		End Sub

		Private Sub DisableMultiSelect(ByVal vgrid As VGridControlBase)
			RemoveHandler vgrid.CustomDrawRowHeaderCell, AddressOf OnCustomDrawRowHeaderCell
			RemoveHandler vgrid.RecordCellStyle, AddressOf OnRecordCellStyle
			RemoveHandler vgrid.KeyUp, AddressOf OnKeyUp
			RemoveHandler vgrid.MouseDown, AddressOf OnMouseDown
			RemoveHandler vgrid.MouseUp, AddressOf OnMouseUp
			RemoveHandler vgrid.ShowingEditor, AddressOf OnShowingEditor
			RemoveHandler vgrid.ShownEditor, AddressOf OnShownEditor
			RemoveHandler vgrid.Leave, AddressOf OnFocusChanged
			RemoveHandler vgrid.Enter, AddressOf OnFocusChanged
		End Sub

		Private Function GetSelectionHelper(ByVal vgrid As VGridControlBase) As SelectionHelper
			Return TryCast(controls(vgrid), SelectionHelper)
		End Function

		Private canShowEditor_Renamed As Boolean = True

		Private Sub OnMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim vgrid As VGridControlBase = TryCast(sender, VGridControlBase)
			Dim hitInfo As VGridHitInfo = vgrid.CalcHitInfo(e.Location)
			canShowEditor_Renamed = hitInfo.Row IsNot Nothing AndAlso hitInfo.Row.Equals(vgrid.FocusedRow) AndAlso hitInfo.RecordIndex.Equals(vgrid.FocusedRecord) AndAlso hitInfo.CellIndex.Equals(vgrid.FocusedRecordCellIndex)
		End Sub

		Private Sub OnMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim vgrid As VGridControlBase = TryCast(sender, VGridControlBase)
			Dim selectionHelper As SelectionHelper = GetSelectionHelper(vgrid)
			If e.Button = MouseButtons.Left Then
				Dim cell As New GridCell(vgrid.FocusedRow, vgrid.FocusedRecordCellIndex, vgrid.FocusedRecord)
				If (Control.ModifierKeys And Keys.Control) = Keys.Control OrElse selectionHelper.IsEmpty Then
					selectionHelper.SelectCell(cell)
				ElseIf (Control.ModifierKeys And Keys.Shift) = Keys.Shift Then
					selectionHelper.SelectCellRange(cell)
				Else
					selectionHelper.ClearAndSelectCell(cell)
				End If
			End If
		End Sub

		Private Sub OnShowingEditor(ByVal sender As Object, ByVal e As CancelEventArgs)
			e.Cancel = Not CanShowEditor()
			canShowEditor_Renamed = True
		End Sub

		Private Function CanShowEditor() As Boolean
			Return canShowEditor_Renamed AndAlso Not IsSelectionMode()
		End Function

		Private Function IsSelectionMode() As Boolean
			Return (Control.ModifierKeys And Keys.Control) = Keys.Control OrElse (Control.ModifierKeys And Keys.Shift) = Keys.Shift
		End Function

		Private Sub OnShownEditor(ByVal sender As Object, ByVal e As EventArgs)
			Dim vgrid As VGridControlBase = TryCast(sender, VGridControlBase)
			Dim selectionHelper As SelectionHelper = GetSelectionHelper(vgrid)
			selectionHelper.Clear()
		End Sub

		Private Sub OnKeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
			Dim vgrid As VGridControlBase = TryCast(sender, VGridControlBase)
			Dim selectionHelper As SelectionHelper = GetSelectionHelper(vgrid)
			If e.Shift Then
				If (e.KeyData And Keys.Right) = Keys.Right OrElse (e.KeyData And Keys.Left) = Keys.Left OrElse (e.KeyData And Keys.Up) = Keys.Up OrElse (e.KeyData And Keys.Down) = Keys.Down OrElse (e.KeyData And Keys.PageDown) = Keys.PageDown OrElse (e.KeyData And Keys.PageUp) = Keys.PageUp Then
					Dim endCell As New GridCell(vgrid.FocusedRow, vgrid.FocusedRecordCellIndex, vgrid.FocusedRecord)
					selectionHelper.SelectCellRange(endCell)
				End If
			End If
			If e.Control AndAlso (e.KeyData And Keys.A) = Keys.A Then
				selectionHelper.SelectAll()
			End If
		End Sub

		Private Sub OnRecordCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.GetCustomRowCellStyleEventArgs)
			Dim vgrid As VGridControlBase = TryCast(sender, VGridControlBase)
			Dim selectionHelper As SelectionHelper = GetSelectionHelper(vgrid)
			Dim cell As New GridCell(e.Row, e.CellIndex, e.RecordIndex)
			If selectionHelper.Contains(cell) Then
				e.Appearance.BackColor = GetBackColor(vgrid)
				e.Appearance.ForeColor = GetForeColor(vgrid)
			End If
		End Sub

		Private Function GetBackColor(ByVal vgrid As VGridControlBase) As Color
			Return If(vgrid.ContainsFocus, vgrid.ViewInfo.PaintAppearance.FocusedRow.BackColor, vgrid.ViewInfo.PaintAppearance.HideSelectionRow.BackColor)
		End Function

		Private Function GetForeColor(ByVal vgrid As VGridControlBase) As Color
			Return If(vgrid.ContainsFocus, vgrid.ViewInfo.PaintAppearance.FocusedRow.ForeColor, vgrid.ViewInfo.PaintAppearance.HideSelectionRow.ForeColor)
		End Function

		Private Sub OnCustomDrawRowHeaderCell(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventArgs)
			If TypeOf e.Row Is CategoryRow Then
				Dim vgrid As VGridControlBase = TryCast(sender, VGridControlBase)
				Dim selectionHelper As SelectionHelper = GetSelectionHelper(vgrid)
				Dim cell As New GridCell(e.Row, e.CellIndex, vgrid.FocusedRecord)
				If selectionHelper.Contains(cell) Then
					e.Appearance.BackColor = GetBackColor(vgrid)
					e.Appearance.ForeColor = GetForeColor(vgrid)
				End If
			End If
		End Sub

		Private Sub OnFocusChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim vgrid As VGridControlBase = TryCast(sender, VGridControlBase)
			Dim selectionHelper As SelectionHelper = GetSelectionHelper(vgrid)
			selectionHelper.RefreshSelection()
		End Sub

		Private Function CanExtend(ByVal extendee As Object) As Boolean Implements IExtenderProvider.CanExtend
			Return TypeOf extendee Is VGridControlBase
		End Function

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				For Each vgrid As VGridControlBase In controls
					SetMultiSelect(vgrid, False)
				Next vgrid
			End If
			MyBase.Dispose(disposing)
		End Sub
	End Class
End Namespace
