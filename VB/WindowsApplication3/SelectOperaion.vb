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
	Public Class SelectOperaion
		Inherits RowOperation
		Private _EndCell As Point
		Private _StartCell As Point
		Private selection As Selection

		Public Sub New(ByVal selection As Selection)
			Me.selection = selection
		End Sub

		Public Property StartCell() As Point
			Get
				Return _StartCell
			End Get
			Set(ByVal value As Point)
				_StartCell = value
			End Set
		End Property

		Public Property EndCell() As Point
			Get
				Return _EndCell
			End Get
			Set(ByVal value As Point)
				_EndCell = value
			End Set
		End Property

		Public Overrides Sub Execute(ByVal row As BaseRow)
			If row.VisibleIndex >= StartCell.X AndAlso row.VisibleIndex <= EndCell.X Then
				For i As Integer = StartCell.Y To EndCell.Y
					Dim multiRow As MultiEditorRow = TryCast(row, MultiEditorRow)
					Dim endCellIndex As Integer = 0
					If multiRow IsNot Nothing Then
						endCellIndex = multiRow.RowPropertiesCount - 1
					End If
					For k As Integer = 0 To endCellIndex
						Dim newCell As New GridCell(row, k, i)
						If (Not selection.Contains(newCell)) Then
							selection.Add(newCell)
						End If
					Next k
				Next i
			End If
		End Sub
	End Class
End Namespace
