namespace Menu
{
    partial class FinishedFormTrack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinishedFormTrack));
            this.panelTrack = new DevComponents.DotNetBar.PanelEx();
            this.lblClose = new DevComponents.DotNetBar.LabelX();
            this.txtResult = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelTrack.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTrack
            // 
            this.panelTrack.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelTrack.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelTrack.Controls.Add(this.txtResult);
            this.panelTrack.Controls.Add(this.lblClose);
            this.panelTrack.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrack.Location = new System.Drawing.Point(0, 0);
            this.panelTrack.Name = "panelTrack";
            this.panelTrack.Size = new System.Drawing.Size(694, 548);
            this.panelTrack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelTrack.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelTrack.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelTrack.Style.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTrack.Style.BackgroundImage")));
            this.panelTrack.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelTrack.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelTrack.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelTrack.Style.GradientAngle = 90;
            this.panelTrack.TabIndex = 10;
            // 
            // lblClose
            // 
            // 
            // 
            // 
            this.lblClose.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.Location = new System.Drawing.Point(663, 12);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(19, 23);
            this.lblClose.TabIndex = 13;
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
            this.txtResult.Font = new System.Drawing.Font("B Titr", 14F, System.Drawing.FontStyle.Bold);
            this.txtResult.Location = new System.Drawing.Point(32, 25);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.PreventEnterBeep = true;
            this.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtResult.Size = new System.Drawing.Size(636, 74);
            this.txtResult.TabIndex = 15;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FinishedFormTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 548);
            this.Controls.Add(this.panelTrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinishedFormTrack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinishedForm";
            this.Load += new System.EventHandler(this.FinishedForm_Load);
            this.panelTrack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.PanelEx panelTrack;
        private DevComponents.DotNetBar.LabelX lblClose;
        private DevComponents.DotNetBar.Controls.TextBoxX txtResult;
    }
}