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
	Public Class Selection
		Inherits CollectionBase
		Private _StartRangeCell As GridCell
		Private vgrid As VGridControlBase
		Public Sub New(ByVal vgrid As VGridControlBase)
			Me.vgrid = vgrid
		End Sub

		Protected Overrides Sub OnInsertComplete(ByVal index As Integer, ByVal value As Object)
			MyBase.OnInsertComplete(index, value)
			InvalidateRow(value)
		End Sub

		Private Sub InvalidateRow(ByVal value As Object)
			Dim cell As GridCell = TryCast(value, GridCell)
			vgrid.InvalidateRow(cell.Row)
		End Sub

		Protected Overrides Sub OnRemoveComplete(ByVal index As Integer, ByVal value As Object)
			MyBase.OnRemoveComplete(index, value)
			InvalidateRow(value)
		End Sub

		Protected Overrides Sub OnClear()
			Do While List.Count > 0
				List.RemoveAt(List.Count - 1)
			Loop
		End Sub

		Public Function Contains(ByVal cell As GridCell) As Boolean
			If TypeOf cell.Row Is CategoryRow Then
				Return List.OfType(Of GridCell)().Any(Function(c) c.Row.Equals(cell.Row))
			End If
		   Return List.Contains(cell)
		End Function

		Public Sub Add(ByVal cell As GridCell)
			List.Add(cell)
		End Sub

		Public Sub Remove(ByVal cell As GridCell)
			If TypeOf cell.Row Is CategoryRow Then
				List.Remove(List.OfType(Of GridCell)().First(Function(c) c.Row.Equals(cell.Row)))
			Else
				List.Remove(cell)
			End If
		End Sub

		Default Public Property Item(ByVal index As Integer) As GridCell
			Get
				Return TryCast(List(index), GridCell)
			End Get
			Set(ByVal value As GridCell)
				List(index) = value
			End Set
		End Property

		Public Function IndexOf(ByVal cell As GridCell) As Integer
			Return List.IndexOf(cell)
		End Function


		Public Property StartRangeCell() As GridCell
			Get
				Return _StartRangeCell
			End Get
			Set(ByVal value As GridCell)
				_StartRangeCell = value
			End Set
		End Property

	End Class
End Namespace
