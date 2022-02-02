namespace Menu
{
    partial class NewFarmerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFarmerForm));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lblClose = new DevComponents.DotNetBar.LabelX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtAge = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtLName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.lblClose);
            this.panelEx1.Controls.Add(this.btnSave);
            this.panelEx1.Controls.Add(this.txtAge);
            this.panelEx1.Controls.Add(this.txtLName);
            this.panelEx1.Controls.Add(this.txtFName);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(340, 208);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEx1.Style.BackgroundImage")));
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // lblClose
            // 
            // 
            // 
            // 
            this.lblClose.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.Location = new System.Drawing.Point(309, 12);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(19, 23);
            this.lblClose.TabIndex = 4;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(44, 48);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 105);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 2;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAge
            // 
            // 
            // 
            // 
            this.txtAge.Border.Class = "TextBoxBorder";
            this.txtAge.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAge.Font = new System.Drawing.Font("B Titr", 10F, System.Drawing.FontStyle.Bold);
            this.txtAge.Location = new System.Drawing.Point(130, 122);
            this.txtAge.Name = "txtAge";
            this.txtAge.PreventEnterBeep = true;
            this.txtAge.Size = new System.Drawing.Size(145, 31);
            this.txtAge.TabIndex = 0;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAge.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtAge.WatermarkText = "سن";
            // 
            // txtLName
            // 
            // 
            // 
            // 
            this.txtLName.Border.Class = "TextBoxBorder";
            this.txtLName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLName.Font = new System.Drawing.Font("B Titr", 10F, System.Drawing.FontStyle.Bold);
            this.txtLName.Location = new System.Drawing.Point(130, 85);
            this.txtLName.Name = "txtLName";
            this.txtLName.PreventEnterBeep = true;
            this.txtLName.Size = new System.Drawing.Size(145, 31);
            this.txtLName.TabIndex = 0;
            this.txtLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLName.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtLName.WatermarkText = "نام خانوادگی";
            // 
            // txtFName
            // 
            // 
            // 
            // 
            this.txtFName.Border.Class = "TextBoxBorder";
            this.txtFName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFName.Font = new System.Drawing.Font("B Titr", 10F, System.Drawing.FontStyle.Bold);
            this.txtFName.Location = new System.Drawing.Point(130, 48);
            this.txtFName.Name = "txtFName";
            this.txtFName.PreventEnterBeep = true;
            this.txtFName.Size = new System.Drawing.Size(145, 31);
            this.txtFName.TabIndex = 0;
            this.txtFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFName.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtFName.WatermarkText = "نام";
            // 
            // NewFarmerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 208);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewFarmerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewFarmerForm";
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAge;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFName;
        private DevComponents.DotNetBar.LabelX lblClose;
    }
}