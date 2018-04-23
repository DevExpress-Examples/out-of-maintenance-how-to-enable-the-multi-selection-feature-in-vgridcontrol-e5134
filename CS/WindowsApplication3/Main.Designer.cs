namespace DXSample {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.vGridControl2 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.selectionProvider1 = new DXSample.SelectionProvider();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.checkEdit2);
            this.panelControl1.Controls.Add(this.checkEdit1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1201, 43);
            this.panelControl1.TabIndex = 0;
            // 
            // checkEdit2
            // 
            this.checkEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEdit2.EditValue = true;
            this.checkEdit2.Location = new System.Drawing.Point(848, 6);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "MultiSelect";
            this.checkEdit2.Size = new System.Drawing.Size(341, 19);
            this.checkEdit2.TabIndex = 1;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(244, 6);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "MultiSelect";
            this.checkEdit1.Size = new System.Drawing.Size(341, 19);
            this.checkEdit1.TabIndex = 0;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // vGridControl1
            // 
            this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.vGridControl1.Location = new System.Drawing.Point(0, 43);
            this.selectionProvider1.SetMultiSelect(this.vGridControl1, true);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.Size = new System.Drawing.Size(596, 448);
            this.vGridControl1.TabIndex = 2;
            // 
            // vGridControl2
            // 
            this.vGridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl2.Location = new System.Drawing.Point(596, 43);
            this.selectionProvider1.SetMultiSelect(this.vGridControl2, true);
            this.vGridControl2.Name = "vGridControl2";
            this.vGridControl2.Size = new System.Drawing.Size(605, 448);
            this.vGridControl2.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 491);
            this.Controls.Add(this.vGridControl2);
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl2;
        private SelectionProvider selectionProvider1;
    }
}

