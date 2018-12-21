Namespace DXSample
    Partial Public Class Main
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.checkEdit3 = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.vGridControl2 = New DevExpress.XtraVerticalGrid.VGridControl()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.vGridControl3 = New DevExpress.XtraVerticalGrid.VGridControl()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.splitterItem2 = New DevExpress.XtraLayout.SplitterItem()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vGridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vGridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitterItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.vGridControl3)
            Me.layoutControl1.Controls.Add(Me.vGridControl2)
            Me.layoutControl1.Controls.Add(Me.vGridControl1)
            Me.layoutControl1.Controls.Add(Me.checkEdit3)
            Me.layoutControl1.Controls.Add(Me.checkEdit2)
            Me.layoutControl1.Controls.Add(Me.checkEdit1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(3190, 243, 650, 400)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(1201, 491)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.splitterItem1, Me.splitterItem2})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(1201, 491)
            Me.Root.TextVisible = False
            ' 
            ' checkEdit1
            ' 
            Me.checkEdit1.EditValue = True
            Me.checkEdit1.Location = New System.Drawing.Point(12, 12)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "MultiSelect (Default)"
            Me.checkEdit1.Size = New System.Drawing.Size(389, 19)
            Me.checkEdit1.StyleController = Me.layoutControl1
            Me.checkEdit1.TabIndex = 4
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.checkEdit1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(393, 23)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' checkEdit2
            ' 
            Me.checkEdit2.EditValue = True
            Me.checkEdit2.Location = New System.Drawing.Point(411, 12)
            Me.checkEdit2.Name = "checkEdit2"
            Me.checkEdit2.Properties.Caption = "MultiSelect (MultiSelectMode = RowSelect)"
            Me.checkEdit2.Size = New System.Drawing.Size(386, 19)
            Me.checkEdit2.StyleController = Me.layoutControl1
            Me.checkEdit2.TabIndex = 5
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.checkEdit2
            Me.layoutControlItem2.Location = New System.Drawing.Point(399, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(390, 23)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' checkEdit3
            ' 
            Me.checkEdit3.EditValue = True
            Me.checkEdit3.Location = New System.Drawing.Point(807, 12)
            Me.checkEdit3.Name = "checkEdit3"
            Me.checkEdit3.Properties.Caption = "MultiSelect (MultiSelectMode = CellSelect)"
            Me.checkEdit3.Size = New System.Drawing.Size(382, 19)
            Me.checkEdit3.StyleController = Me.layoutControl1
            Me.checkEdit3.TabIndex = 6
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.checkEdit3
            Me.layoutControlItem3.Location = New System.Drawing.Point(795, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(386, 23)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' vGridControl1
            ' 
            Me.vGridControl1.Location = New System.Drawing.Point(12, 35)
            Me.vGridControl1.Name = "vGridControl1"
            Me.vGridControl1.Size = New System.Drawing.Size(389, 444)
            Me.vGridControl1.TabIndex = 7
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.vGridControl1
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 23)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(393, 448)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' vGridControl2
            ' 
            Me.vGridControl2.Location = New System.Drawing.Point(411, 35)
            Me.vGridControl2.Name = "vGridControl2"
            Me.vGridControl2.Size = New System.Drawing.Size(386, 444)
            Me.vGridControl2.TabIndex = 8
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.vGridControl2
            Me.layoutControlItem5.Location = New System.Drawing.Point(399, 23)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(390, 448)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' vGridControl3
            ' 
            Me.vGridControl3.Location = New System.Drawing.Point(807, 35)
            Me.vGridControl3.Name = "vGridControl3"
            Me.vGridControl3.Size = New System.Drawing.Size(382, 444)
            Me.vGridControl3.TabIndex = 9
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.vGridControl3
            Me.layoutControlItem6.Location = New System.Drawing.Point(795, 23)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(386, 448)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' splitterItem1
            ' 
            Me.splitterItem1.AllowHotTrack = True
            Me.splitterItem1.Location = New System.Drawing.Point(393, 0)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(6, 471)
            ' 
            ' splitterItem2
            ' 
            Me.splitterItem2.AllowHotTrack = True
            Me.splitterItem2.Location = New System.Drawing.Point(789, 0)
            Me.splitterItem2.Name = "splitterItem2"
            Me.splitterItem2.Size = New System.Drawing.Size(6, 471)
            ' 
            ' Main
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1201, 491)
            Me.Controls.Add(Me.layoutControl1)
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "Main"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "How to enable the Multi Selection feature in VGridControl"
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.vGridControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.vGridControl3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitterItem2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private Root As DevExpress.XtraLayout.LayoutControlGroup
        Private vGridControl3 As DevExpress.XtraVerticalGrid.VGridControl
        Private vGridControl2 As DevExpress.XtraVerticalGrid.VGridControl
        Private vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
        Private WithEvents checkEdit3 As DevExpress.XtraEditors.CheckEdit
        Private WithEvents checkEdit2 As DevExpress.XtraEditors.CheckEdit
        Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
        Private splitterItem2 As DevExpress.XtraLayout.SplitterItem
    End Class
End Namespace

