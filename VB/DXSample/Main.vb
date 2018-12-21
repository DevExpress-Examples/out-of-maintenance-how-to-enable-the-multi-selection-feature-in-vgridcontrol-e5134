Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid
Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace DXSample
    Partial Public Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            vGridControl1.OptionsSelectionAndFocus.MultiSelect = True
            vGridControl2.OptionsSelectionAndFocus.MultiSelect = True
            vGridControl3.OptionsSelectionAndFocus.MultiSelect = True


            vGridControl2.OptionsSelectionAndFocus.MultiSelectMode = MultiSelectMode.RowSelect
            vGridControl3.OptionsSelectionAndFocus.MultiSelectMode = MultiSelectMode.CellSelect
        End Sub

        Private Sub OnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged, checkEdit2.CheckedChanged, checkEdit3.CheckedChanged
            Dim editor As CheckEdit = TryCast(sender, CheckEdit)

            If editor.Name.Contains("1") Then
                vGridControl1.OptionsSelectionAndFocus.MultiSelect = editor.Checked
            ElseIf editor.Name.Contains("2") Then
                vGridControl2.OptionsSelectionAndFocus.MultiSelect = editor.Checked
            ElseIf editor.Name.Contains("3") Then
                vGridControl3.OptionsSelectionAndFocus.MultiSelect = editor.Checked
            End If
        End Sub

        Public Function GetDataSet() As DataSet
            Dim ds As New DataSet()
            ds.ReadXml(Application.StartupPath & "\nwind.xml")
            Return ds
        End Function

        Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            Dim ds As DataSet = GetDataSet()
            vGridControl1.DataSource = ds.Tables("Customers")
            vGridControl2.DataSource = ds.Tables("Products")
            vGridControl3.DataSource = ds.Tables("Orders")
        End Sub
    End Class
End Namespace