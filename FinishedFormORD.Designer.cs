namespace Menu
{
    partial class FinishedFormORD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinishedFormORD));
            this.panelOrd = new DevComponents.DotNetBar.PanelEx();
            this.lblClose = new DevComponents.DotNetBar.LabelX();
            this.txtResult = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelOrd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOrd
            // 
            this.panelOrd.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelOrd.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelOrd.Controls.Add(this.txtResult);
            this.panelOrd.Controls.Add(this.lblClose);
            this.panelOrd.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelOrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrd.Location = new System.Drawing.Point(0, 0);
            this.panelOrd.Name = "panelOrd";
            this.panelOrd.Size = new System.Drawing.Size(733, 509);
            this.panelOrd.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelOrd.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelOrd.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelOrd.Style.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelOrd.Style.BackgroundImage")));
            this.panelOrd.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelOrd.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelOrd.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelOrd.Style.GradientAngle = 90;
            this.panelOrd.TabIndex = 4;
            // 
            // lblClose
            // 
            // 
            // 
            // 
            this.lblClose.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.Location = new System.Drawing.Point(702, 12);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(19, 23);
            this.lblClose.TabIndex = 12;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // txtResult
            // 
            // 
            // 
            // 
            this.txtResult.Border.Class = "TextBoxBorder";
            this.txtResult.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("B Titr", 17F, System.Drawing.FontStyle.Bold);
            this.txtResult.Location = new System.Drawing.Point(376, 36);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.PreventEnterBeep = true;
            this.txtResult.Size = new System.Drawing.Size(318, 228);
            this.txtResult.TabIndex = 16;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FinishedFormORD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 509);
            this.Controls.Add(this.panelOrd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinishedFormORD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinishedFormORD";
            this.Load += new System.EventHandler(this.FinishedFormORD_Load);
            this.panelOrd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.PanelEx panelOrd;
        private DevComponents.DotNetBar.LabelX lblClose;
        private DevComponents.DotNetBar.Controls.TextBoxX txtResult;
    }
}