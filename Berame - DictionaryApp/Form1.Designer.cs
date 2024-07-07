namespace Berame___DictionaryApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.actionbarPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.headerLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.searchWordBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.searchDictionaryTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.meaningsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usageBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.definitionBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.antonymBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.synonymBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelHeader2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.actionbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchWordBtn)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // actionbarPanel
            // 
            this.actionbarPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("actionbarPanel.BackgroundImage")));
            this.actionbarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actionbarPanel.Controls.Add(this.bunifuImageButton1);
            this.actionbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionbarPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.actionbarPanel.GradientBottomRight = System.Drawing.Color.White;
            this.actionbarPanel.GradientTopLeft = System.Drawing.Color.White;
            this.actionbarPanel.GradientTopRight = System.Drawing.Color.White;
            this.actionbarPanel.Location = new System.Drawing.Point(0, 0);
            this.actionbarPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.actionbarPanel.Name = "actionbarPanel";
            this.actionbarPanel.Quality = 10;
            this.actionbarPanel.Size = new System.Drawing.Size(1226, 30);
            this.actionbarPanel.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1202, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(15, 16);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 10;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.actionbarPanel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Leelawadee UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(536, 56);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(606, 62);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "WHAT\'S ON YOUR MIND?";
            // 
            // searchWordBtn
            // 
            this.searchWordBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchWordBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchWordBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchWordBtn.Image")));
            this.searchWordBtn.ImageActive = null;
            this.searchWordBtn.Location = new System.Drawing.Point(906, 123);
            this.searchWordBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchWordBtn.Name = "searchWordBtn";
            this.searchWordBtn.Size = new System.Drawing.Size(34, 20);
            this.searchWordBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchWordBtn.TabIndex = 7;
            this.searchWordBtn.TabStop = false;
            this.searchWordBtn.Zoom = 10;
            this.searchWordBtn.Click += new System.EventHandler(this.searchWordBtn_Click);
            // 
            // searchDictionaryTextBox
            // 
            this.searchDictionaryTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchDictionaryTextBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.searchDictionaryTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(68)))));
            this.searchDictionaryTextBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(226)))));
            this.searchDictionaryTextBox.BorderThickness = 3;
            this.searchDictionaryTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchDictionaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.75F);
            this.searchDictionaryTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.searchDictionaryTextBox.isPassword = false;
            this.searchDictionaryTextBox.Location = new System.Drawing.Point(591, 110);
            this.searchDictionaryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchDictionaryTextBox.Name = "searchDictionaryTextBox";
            this.searchDictionaryTextBox.Size = new System.Drawing.Size(356, 43);
            this.searchDictionaryTextBox.TabIndex = 9;
            this.searchDictionaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchDictionaryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchDictionaryTextBox_KeyDown);
            // 
            // meaningsFlowLayoutPanel
            // 
            this.meaningsFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.meaningsFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(226)))));
            this.meaningsFlowLayoutPanel.Location = new System.Drawing.Point(328, 177);
            this.meaningsFlowLayoutPanel.Name = "meaningsFlowLayoutPanel";
            this.meaningsFlowLayoutPanel.Size = new System.Drawing.Size(856, 501);
            this.meaningsFlowLayoutPanel.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.usageBtn);
            this.panel1.Controls.Add(this.definitionBtn);
            this.panel1.Controls.Add(this.antonymBtn);
            this.panel1.Controls.Add(this.synonymBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 690);
            this.panel1.TabIndex = 11;
            // 
            // usageBtn
            // 
            this.usageBtn.ActiveBorderThickness = 1;
            this.usageBtn.ActiveCornerRadius = 20;
            this.usageBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(131)))), ((int)(((byte)(105)))));
            this.usageBtn.ActiveForecolor = System.Drawing.Color.White;
            this.usageBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(131)))), ((int)(((byte)(105)))));
            this.usageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.usageBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usageBtn.BackgroundImage")));
            this.usageBtn.ButtonText = "Usage Examples";
            this.usageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usageBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.usageBtn.IdleBorderThickness = 1;
            this.usageBtn.IdleCornerRadius = 20;
            this.usageBtn.IdleFillColor = System.Drawing.Color.White;
            this.usageBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.usageBtn.IdleLineColor = System.Drawing.Color.White;
            this.usageBtn.Location = new System.Drawing.Point(16, 209);
            this.usageBtn.Margin = new System.Windows.Forms.Padding(5);
            this.usageBtn.Name = "usageBtn";
            this.usageBtn.Size = new System.Drawing.Size(248, 62);
            this.usageBtn.TabIndex = 16;
            this.usageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usageBtn.Click += new System.EventHandler(this.usageBtn_Click);
            // 
            // definitionBtn
            // 
            this.definitionBtn.ActiveBorderThickness = 1;
            this.definitionBtn.ActiveCornerRadius = 20;
            this.definitionBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(131)))), ((int)(((byte)(105)))));
            this.definitionBtn.ActiveForecolor = System.Drawing.Color.White;
            this.definitionBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(131)))), ((int)(((byte)(105)))));
            this.definitionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.definitionBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("definitionBtn.BackgroundImage")));
            this.definitionBtn.ButtonText = "Definitions";
            this.definitionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.definitionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.definitionBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.definitionBtn.IdleBorderThickness = 1;
            this.definitionBtn.IdleCornerRadius = 20;
            this.definitionBtn.IdleFillColor = System.Drawing.Color.White;
            this.definitionBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.definitionBtn.IdleLineColor = System.Drawing.Color.White;
            this.definitionBtn.Location = new System.Drawing.Point(16, 136);
            this.definitionBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.definitionBtn.Name = "definitionBtn";
            this.definitionBtn.Size = new System.Drawing.Size(248, 62);
            this.definitionBtn.TabIndex = 17;
            this.definitionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.definitionBtn.Click += new System.EventHandler(this.definitionBtn_Click);
            // 
            // antonymBtn
            // 
            this.antonymBtn.ActiveBorderThickness = 1;
            this.antonymBtn.ActiveCornerRadius = 20;
            this.antonymBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(131)))), ((int)(((byte)(105)))));
            this.antonymBtn.ActiveForecolor = System.Drawing.Color.White;
            this.antonymBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(131)))), ((int)(((byte)(105)))));
            this.antonymBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.antonymBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("antonymBtn.BackgroundImage")));
            this.antonymBtn.ButtonText = "Antonyms";
            this.antonymBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.antonymBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antonymBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.antonymBtn.IdleBorderThickness = 1;
            this.antonymBtn.IdleCornerRadius = 20;
            this.antonymBtn.IdleFillColor = System.Drawing.Color.White;
            this.antonymBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.antonymBtn.IdleLineColor = System.Drawing.Color.White;
            this.antonymBtn.Location = new System.Drawing.Point(16, 354);
            this.antonymBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.antonymBtn.Name = "antonymBtn";
            this.antonymBtn.Size = new System.Drawing.Size(248, 62);
            this.antonymBtn.TabIndex = 16;
            this.antonymBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // synonymBtn
            // 
            this.synonymBtn.ActiveBorderThickness = 1;
            this.synonymBtn.ActiveCornerRadius = 20;
            this.synonymBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(131)))), ((int)(((byte)(105)))));
            this.synonymBtn.ActiveForecolor = System.Drawing.Color.White;
            this.synonymBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(131)))), ((int)(((byte)(105)))));
            this.synonymBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.synonymBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("synonymBtn.BackgroundImage")));
            this.synonymBtn.ButtonText = "Synonyms";
            this.synonymBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.synonymBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.synonymBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.synonymBtn.IdleBorderThickness = 1;
            this.synonymBtn.IdleCornerRadius = 20;
            this.synonymBtn.IdleFillColor = System.Drawing.Color.White;
            this.synonymBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.synonymBtn.IdleLineColor = System.Drawing.Color.White;
            this.synonymBtn.Location = new System.Drawing.Point(16, 281);
            this.synonymBtn.Margin = new System.Windows.Forms.Padding(5);
            this.synonymBtn.Name = "synonymBtn";
            this.synonymBtn.Size = new System.Drawing.Size(248, 62);
            this.synonymBtn.TabIndex = 15;
            this.synonymBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelHeader);
            this.panel2.Controls.Add(this.panelHeader2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 127);
            this.panel2.TabIndex = 14;
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelHeader.AutoSize = true;
            this.panelHeader.Font = new System.Drawing.Font("Leelawadee UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHeader.ForeColor = System.Drawing.Color.White;
            this.panelHeader.Location = new System.Drawing.Point(43, 11);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(255, 62);
            this.panelHeader.TabIndex = 12;
            this.panelHeader.Text = "Dictionary";
            // 
            // panelHeader2
            // 
            this.panelHeader2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelHeader2.AutoSize = true;
            this.panelHeader2.Font = new System.Drawing.Font("Leelawadee UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHeader2.ForeColor = System.Drawing.Color.White;
            this.panelHeader2.Location = new System.Drawing.Point(102, 61);
            this.panelHeader2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelHeader2.Name = "panelHeader2";
            this.panelHeader2.Size = new System.Drawing.Size(104, 62);
            this.panelHeader2.TabIndex = 13;
            this.panelHeader2.Text = "API";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(131)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1226, 720);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.meaningsFlowLayoutPanel);
            this.Controls.Add(this.searchWordBtn);
            this.Controls.Add(this.searchDictionaryTextBox);
            this.Controls.Add(this.actionbarPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.actionbarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchWordBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel actionbarPanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuCustomLabel headerLabel;
        private Bunifu.Framework.UI.BunifuImageButton searchWordBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchDictionaryTextBox;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.FlowLayoutPanel meaningsFlowLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel panelHeader;
        private Bunifu.Framework.UI.BunifuThinButton2 synonymBtn;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel panelHeader2;
        private Bunifu.Framework.UI.BunifuThinButton2 definitionBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 antonymBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 usageBtn;
    }
}

