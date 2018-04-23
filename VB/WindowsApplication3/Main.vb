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
	Partial Public Class Main
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Function GetDataSet() As DataSet
			Dim ds As New DataSet()
			ds.ReadXml(Application.StartupPath & "\nwind.xml")
			Return ds
		End Function

		Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim ds As DataSet = GetDataSet()
			vGridControl1.DataSource = ds.Tables("Customers")
			vGridControl2.DataSource = ds.Tables("Products")
		End Sub

		Private Sub OnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit2.CheckedChanged, checkEdit1.CheckedChanged
			Dim edit As CheckEdit = TryCast(sender, CheckEdit)
			If edit.Name.Equals("checkEdit1") Then
				selectionProvider1.SetMultiSelect(vGridControl1, (Not selectionProvider1.GetMultiSelect(vGridControl1)))
			Else
				selectionProvider1.SetMultiSelect(vGridControl2, (Not selectionProvider1.GetMultiSelect(vGridControl2)))
			End If
		End Sub
	End Class
End Namespace