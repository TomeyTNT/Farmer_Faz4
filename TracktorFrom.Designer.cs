namespace Menu
{
    partial class TracktorFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TracktorFrom));
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtPower = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblClose = new DevComponents.DotNetBar.LabelX();
            this.txtWeight = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(40, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 85);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 7;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPower
            // 
            // 
            // 
            // 
            this.txtPower.Border.Class = "TextBoxBorder";
            this.txtPower.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPower.Font = new System.Drawing.Font("B Titr", 10F, System.Drawing.FontStyle.Bold);
            this.txtPower.Location = new System.Drawing.Point(119, 48);
            this.txtPower.Name = "txtPower";
            this.txtPower.PreventEnterBeep = true;
            this.txtPower.Size = new System.Drawing.Size(151, 31);
            this.txtPower.TabIndex = 5;
            this.txtPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPower.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtPower.WatermarkText = "قدرت";
            // 
            // lblClose
            // 
            // 
            // 
            // 
            this.lblClose.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.Location = new System.Drawing.Point(287, 12);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(19, 23);
            this.lblClose.TabIndex = 8;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // txtWeight
            // 
            // 
            // 
            // 
            this.txtWeight.Border.Class = "TextBoxBorder";
            this.txtWeight.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtWeight.Font = new System.Drawing.Font("B Titr", 10F, System.Drawing.FontStyle.Bold);
            this.txtWeight.Location = new System.Drawing.Point(119, 96);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PreventEnterBeep = true;
            this.txtWeight.Size = new System.Drawing.Size(151, 31);
            this.txtWeight.TabIndex = 5;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWeight.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtWeight.WatermarkText = "وزن";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.btnSave);
            this.panelEx1.Controls.Add(this.txtPower);
            this.panelEx1.Controls.Add(this.lblClose);
            this.panelEx1.Controls.Add(this.txtWeight);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(314, 160);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEx1.Style.BackgroundImage")));
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(89, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(157, 23);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "مشخصات تراکتور  را وارد کنید";
            // 
            // TracktorFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 160);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TracktorFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TracktorFrom";
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPower;
        private DevComponents.DotNetBar.LabelX lblClose;
        private DevComponents.DotNetBar.Controls.TextBoxX txtWeight;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}