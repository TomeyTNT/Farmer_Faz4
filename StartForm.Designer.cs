namespace Menu
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lblClose = new DevComponents.DotNetBar.LabelX();
            this.btnNewFarmer = new DevComponents.DotNetBar.ButtonX();
            this.btnInitialFarmer = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.lblClose);
            this.panelEx1.Controls.Add(this.btnNewFarmer);
            this.panelEx1.Controls.Add(this.btnInitialFarmer);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(381, 221);
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
            this.lblClose.Location = new System.Drawing.Point(359, 3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(19, 23);
            this.lblClose.TabIndex = 3;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnNewFarmer
            // 
            this.btnNewFarmer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNewFarmer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNewFarmer.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNewFarmer.Location = new System.Drawing.Point(45, 89);
            this.btnNewFarmer.Name = "btnNewFarmer";
            this.btnNewFarmer.Size = new System.Drawing.Size(118, 42);
            this.btnNewFarmer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNewFarmer.TabIndex = 1;
            this.btnNewFarmer.Text = "خودت کشاورز باش";
            this.btnNewFarmer.Click += new System.EventHandler(this.btnNewFarmer_Click);
            // 
            // btnInitialFarmer
            // 
            this.btnInitialFarmer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInitialFarmer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInitialFarmer.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnInitialFarmer.Location = new System.Drawing.Point(221, 89);
            this.btnInitialFarmer.Name = "btnInitialFarmer";
            this.btnInitialFarmer.Size = new System.Drawing.Size(118, 42);
            this.btnInitialFarmer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInitialFarmer.TabIndex = 1;
            this.btnInitialFarmer.Text = "کشاورز پیش فرض";
            this.btnInitialFarmer.Click += new System.EventHandler(this.btnInitialFarmer_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 221);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnNewFarmer;
        private DevComponents.DotNetBar.ButtonX btnInitialFarmer;
        private DevComponents.DotNetBar.LabelX lblClose;
    }
}