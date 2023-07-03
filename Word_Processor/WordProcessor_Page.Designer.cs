namespace Word_Processor
{
    partial class WordProcessor_Page
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
            this.menuItems = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanThisPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfEachWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfEachSeperatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewText = new System.Windows.Forms.TextBox();
            this.resultText = new System.Windows.Forms.TextBox();
            this.btnSummary = new System.Windows.Forms.Button();
            this.TextInformation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuItems
            // 
            this.menuItems.BackColor = System.Drawing.Color.DimGray;
            this.menuItems.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.designToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.themeToolStripMenuItem});
            this.menuItems.Location = new System.Drawing.Point(0, 0);
            this.menuItems.Name = "menuItems";
            this.menuItems.Size = new System.Drawing.Size(1900, 28);
            this.menuItems.TabIndex = 0;
            this.menuItems.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPageToolStripMenuItem,
            this.cleanThisPageToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newPageToolStripMenuItem
            // 
            this.newPageToolStripMenuItem.Name = "newPageToolStripMenuItem";
            this.newPageToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.newPageToolStripMenuItem.Text = "New Page";
            this.newPageToolStripMenuItem.Click += new System.EventHandler(this.newPageToolStripMenuItem_Click);
            // 
            // cleanThisPageToolStripMenuItem
            // 
            this.cleanThisPageToolStripMenuItem.Name = "cleanThisPageToolStripMenuItem";
            this.cleanThisPageToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.cleanThisPageToolStripMenuItem.Text = "Clean This Page";
            this.cleanThisPageToolStripMenuItem.Click += new System.EventHandler(this.cleanThisPageToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // designToolStripMenuItem
            // 
            this.designToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textAlignToolStripMenuItem,
            this.pageColorToolStripMenuItem,
            this.foToolStripMenuItem,
            this.fontsToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.designToolStripMenuItem.Name = "designToolStripMenuItem";
            this.designToolStripMenuItem.Size = new System.Drawing.Size(69, 26);
            this.designToolStripMenuItem.Text = "Design";
            // 
            // textAlignToolStripMenuItem
            // 
            this.textAlignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftAlignToolStripMenuItem,
            this.centerToolStripMenuItem,
            this.rightAlignToolStripMenuItem});
            this.textAlignToolStripMenuItem.Name = "textAlignToolStripMenuItem";
            this.textAlignToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.textAlignToolStripMenuItem.Text = "Text Align";
            // 
            // leftAlignToolStripMenuItem
            // 
            this.leftAlignToolStripMenuItem.Name = "leftAlignToolStripMenuItem";
            this.leftAlignToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.leftAlignToolStripMenuItem.Text = "Left Align";
            this.leftAlignToolStripMenuItem.Click += new System.EventHandler(this.leftAlignToolStripMenuItem_Click);
            // 
            // centerToolStripMenuItem
            // 
            this.centerToolStripMenuItem.Name = "centerToolStripMenuItem";
            this.centerToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.centerToolStripMenuItem.Text = "Center";
            this.centerToolStripMenuItem.Click += new System.EventHandler(this.centerToolStripMenuItem_Click);
            // 
            // rightAlignToolStripMenuItem
            // 
            this.rightAlignToolStripMenuItem.Name = "rightAlignToolStripMenuItem";
            this.rightAlignToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.rightAlignToolStripMenuItem.Text = "Right Align";
            this.rightAlignToolStripMenuItem.Click += new System.EventHandler(this.rightAlignToolStripMenuItem_Click);
            // 
            // pageColorToolStripMenuItem
            // 
            this.pageColorToolStripMenuItem.Name = "pageColorToolStripMenuItem";
            this.pageColorToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.pageColorToolStripMenuItem.Text = "Page Color";
            this.pageColorToolStripMenuItem.Click += new System.EventHandler(this.pageColorToolStripMenuItem_Click);
            // 
            // foToolStripMenuItem
            // 
            this.foToolStripMenuItem.Name = "foToolStripMenuItem";
            this.foToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.foToolStripMenuItem.Text = "Font Color";
            this.foToolStripMenuItem.Click += new System.EventHandler(this.foToolStripMenuItem_Click);
            // 
            // fontsToolStripMenuItem
            // 
            this.fontsToolStripMenuItem.Name = "fontsToolStripMenuItem";
            this.fontsToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.fontsToolStripMenuItem.Text = "Fonts";
            this.fontsToolStripMenuItem.Click += new System.EventHandler(this.fontsToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoom1ToolStripMenuItem,
            this.zoom2ToolStripMenuItem,
            this.zoom3ToolStripMenuItem,
            this.zoom4ToolStripMenuItem,
            this.zoom5ToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoom1ToolStripMenuItem
            // 
            this.zoom1ToolStripMenuItem.Name = "zoom1ToolStripMenuItem";
            this.zoom1ToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.zoom1ToolStripMenuItem.Text = "25%";
            this.zoom1ToolStripMenuItem.Click += new System.EventHandler(this.zoom1ToolStripMenuItem_Click_1);
            // 
            // zoom2ToolStripMenuItem
            // 
            this.zoom2ToolStripMenuItem.Name = "zoom2ToolStripMenuItem";
            this.zoom2ToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.zoom2ToolStripMenuItem.Text = "50%";
            this.zoom2ToolStripMenuItem.Click += new System.EventHandler(this.zoom2ToolStripMenuItem_Click);
            // 
            // zoom3ToolStripMenuItem
            // 
            this.zoom3ToolStripMenuItem.Name = "zoom3ToolStripMenuItem";
            this.zoom3ToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.zoom3ToolStripMenuItem.Text = "75%";
            this.zoom3ToolStripMenuItem.Click += new System.EventHandler(this.zoom3ToolStripMenuItem_Click);
            // 
            // zoom4ToolStripMenuItem
            // 
            this.zoom4ToolStripMenuItem.Name = "zoom4ToolStripMenuItem";
            this.zoom4ToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.zoom4ToolStripMenuItem.Text = "100%";
            this.zoom4ToolStripMenuItem.Click += new System.EventHandler(this.zoom4ToolStripMenuItem_Click);
            // 
            // zoom5ToolStripMenuItem
            // 
            this.zoom5ToolStripMenuItem.Name = "zoom5ToolStripMenuItem";
            this.zoom5ToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.zoom5ToolStripMenuItem.Text = "200%";
            this.zoom5ToolStripMenuItem.Click += new System.EventHandler(this.zoom5ToolStripMenuItem_Click);
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberOfEachWordToolStripMenuItem,
            this.numberOfEachSeperatorToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.analysisToolStripMenuItem.Text = "Analysis";
            // 
            // numberOfEachWordToolStripMenuItem
            // 
            this.numberOfEachWordToolStripMenuItem.Name = "numberOfEachWordToolStripMenuItem";
            this.numberOfEachWordToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.numberOfEachWordToolStripMenuItem.Text = "Number of Each Word";
            this.numberOfEachWordToolStripMenuItem.Click += new System.EventHandler(this.numberOfEachWordToolStripMenuItem_Click);
            // 
            // numberOfEachSeperatorToolStripMenuItem
            // 
            this.numberOfEachSeperatorToolStripMenuItem.Name = "numberOfEachSeperatorToolStripMenuItem";
            this.numberOfEachSeperatorToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.numberOfEachSeperatorToolStripMenuItem.Text = "Number of Each Seperator";
            this.numberOfEachSeperatorToolStripMenuItem.Click += new System.EventHandler(this.numberOfEachSeperatorToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.whiteModeToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.darkToolStripMenuItem.Text = "DarkGray Mode";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // whiteModeToolStripMenuItem
            // 
            this.whiteModeToolStripMenuItem.Name = "whiteModeToolStripMenuItem";
            this.whiteModeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.whiteModeToolStripMenuItem.Text = "White Mode";
            this.whiteModeToolStripMenuItem.Click += new System.EventHandler(this.whiteModeToolStripMenuItem_Click);
            // 
            // viewText
            // 
            this.viewText.BackColor = System.Drawing.Color.LightGray;
            this.viewText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewText.ForeColor = System.Drawing.Color.Black;
            this.viewText.Location = new System.Drawing.Point(400, 140);
            this.viewText.Multiline = true;
            this.viewText.Name = "viewText";
            this.viewText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.viewText.Size = new System.Drawing.Size(975, 766);
            this.viewText.TabIndex = 1;
            this.viewText.TextChanged += new System.EventHandler(this.viewText_TextChanged);
            // 
            // resultText
            // 
            this.resultText.BackColor = System.Drawing.Color.LightGray;
            this.resultText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultText.ForeColor = System.Drawing.Color.Black;
            this.resultText.Location = new System.Drawing.Point(12, 140);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultText.Size = new System.Drawing.Size(256, 715);
            this.resultText.TabIndex = 2;
            // 
            // btnSummary
            // 
            this.btnSummary.BackColor = System.Drawing.Color.LightGray;
            this.btnSummary.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.Location = new System.Drawing.Point(12, 873);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(153, 45);
            this.btnSummary.TabIndex = 3;
            this.btnSummary.Text = "Text Summary";
            this.btnSummary.UseVisualStyleBackColor = false;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // TextInformation
            // 
            this.TextInformation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextInformation.ForeColor = System.Drawing.Color.Black;
            this.TextInformation.Location = new System.Drawing.Point(1518, 329);
            this.TextInformation.Name = "TextInformation";
            this.TextInformation.Size = new System.Drawing.Size(290, 550);
            this.TextInformation.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1497, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Information About Your Text";
            // 
            // WordProcessor_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1900, 981);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextInformation);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.viewText);
            this.Controls.Add(this.menuItems);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuItems;
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "WordProcessor_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordProcessor_Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WordProcessor_Page_FormClosing);
            this.Load += new System.EventHandler(this.WordProcessor_Page_Load);
            this.menuItems.ResumeLayout(false);
            this.menuItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuItems;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanThisPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoom3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoom4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoom5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfEachWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfEachSeperatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textAlignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftAlignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightAlignToolStripMenuItem;
        private System.Windows.Forms.TextBox viewText;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.ToolStripMenuItem zoom1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoom2ToolStripMenuItem;
        private System.Windows.Forms.Label TextInformation;
        private System.Windows.Forms.Label label1;
    }
}

