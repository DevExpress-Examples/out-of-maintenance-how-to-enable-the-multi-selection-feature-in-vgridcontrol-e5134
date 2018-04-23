Imports Microsoft.VisualBasic
Imports System
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
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.vGridControl2 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.selectionProvider1 = New DXSample.SelectionProvider()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.vGridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.checkEdit2)
			Me.panelControl1.Controls.Add(Me.checkEdit1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(1201, 43)
			Me.panelControl1.TabIndex = 0
			' 
			' checkEdit2
			' 
			Me.checkEdit2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkEdit2.EditValue = True
			Me.checkEdit2.Location = New System.Drawing.Point(848, 6)
			Me.checkEdit2.Name = "checkEdit2"
			Me.checkEdit2.Properties.Caption = "MultiSelect"
			Me.checkEdit2.Size = New System.Drawing.Size(341, 19)
			Me.checkEdit2.TabIndex = 1
'			Me.checkEdit2.CheckedChanged += New System.EventHandler(Me.OnCheckedChanged);
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkEdit1.EditValue = True
			Me.checkEdit1.Location = New System.Drawing.Point(244, 6)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "MultiSelect"
			Me.checkEdit1.Size = New System.Drawing.Size(341, 19)
			Me.checkEdit1.TabIndex = 0
'			Me.checkEdit1.CheckedChanged += New System.EventHandler(Me.OnCheckedChanged);
			' 
			' vGridControl1
			' 
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.vGridControl1.Location = New System.Drawing.Point(0, 43)
			Me.selectionProvider1.SetMultiSelect(Me.vGridControl1, True)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.Size = New System.Drawing.Size(596, 448)
			Me.vGridControl1.TabIndex = 2
			' 
			' vGridControl2
			' 
			Me.vGridControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl2.Location = New System.Drawing.Point(596, 43)
			Me.selectionProvider1.SetMultiSelect(Me.vGridControl2, True)
			Me.vGridControl2.Name = "vGridControl2"
			Me.vGridControl2.Size = New System.Drawing.Size(605, 448)
			Me.vGridControl2.TabIndex = 3
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1201, 491)
			Me.Controls.Add(Me.vGridControl2)
			Me.Controls.Add(Me.vGridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Name = "Main"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.OnFormLoad);
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.vGridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents checkEdit2 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
		Private vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private vGridControl2 As DevExpress.XtraVerticalGrid.VGridControl
		Private selectionProvider1 As SelectionProvider
	End Class
End Namespace

