namespace Word_Processor
{
    partial class Welcome_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_Page));
            this.btnNew_Page = new System.Windows.Forms.Button();
            this.btnOpen_Page = new System.Windows.Forms.Button();
            this.btnExit_Application = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNew_Page
            // 
            this.btnNew_Page.BackColor = System.Drawing.Color.Silver;
            this.btnNew_Page.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew_Page.Location = new System.Drawing.Point(280, 113);
            this.btnNew_Page.Name = "btnNew_Page";
            this.btnNew_Page.Size = new System.Drawing.Size(225, 80);
            this.btnNew_Page.TabIndex = 0;
            this.btnNew_Page.Text = "Blank Document";
            this.btnNew_Page.UseVisualStyleBackColor = false;
            this.btnNew_Page.Click += new System.EventHandler(this.btnNew_Page_Click);
            this.btnNew_Page.MouseEnter += new System.EventHandler(this.btnNew_Page_MouseEnter);
            this.btnNew_Page.MouseLeave += new System.EventHandler(this.btnNew_Page_MouseLeave);
            // 
            // btnOpen_Page
            // 
            this.btnOpen_Page.BackColor = System.Drawing.Color.Silver;
            this.btnOpen_Page.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen_Page.Location = new System.Drawing.Point(280, 248);
            this.btnOpen_Page.Name = "btnOpen_Page";
            this.btnOpen_Page.Size = new System.Drawing.Size(225, 80);
            this.btnOpen_Page.TabIndex = 1;
            this.btnOpen_Page.Text = "Browse Document";
            this.btnOpen_Page.UseVisualStyleBackColor = false;
            this.btnOpen_Page.Click += new System.EventHandler(this.btnOpen_Page_Click);
            this.btnOpen_Page.MouseEnter += new System.EventHandler(this.btnOpen_Page_MouseEnter);
            this.btnOpen_Page.MouseLeave += new System.EventHandler(this.btnOpen_Page_MouseLeave);
            // 
            // btnExit_Application
            // 
            this.btnExit_Application.BackColor = System.Drawing.Color.Silver;
            this.btnExit_Application.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit_Application.Location = new System.Drawing.Point(280, 385);
            this.btnExit_Application.Name = "btnExit_Application";
            this.btnExit_Application.Size = new System.Drawing.Size(225, 80);
            this.btnExit_Application.TabIndex = 2;
            this.btnExit_Application.Text = "Close Application";
            this.btnExit_Application.UseVisualStyleBackColor = false;
            this.btnExit_Application.Click += new System.EventHandler(this.btnExit_Application_Click);
            this.btnExit_Application.MouseEnter += new System.EventHandler(this.btnExit_Application_MouseEnter);
            this.btnExit_Application.MouseLeave += new System.EventHandler(this.btnExit_Application_MouseLeave);
            // 
            // Welcome
            // 
            this.Welcome.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(109, 9);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(593, 50);
            this.Welcome.TabIndex = 3;
            this.Welcome.Text = "Welcomr To Your Word Processor";
            // 
            // Welcome_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.btnExit_Application);
            this.Controls.Add(this.btnOpen_Page);
            this.Controls.Add(this.btnNew_Page);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Welcome_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome_Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Welcome_Page_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew_Page;
        private System.Windows.Forms.Button btnOpen_Page;
        private System.Windows.Forms.Button btnExit_Application;
        private System.Windows.Forms.Label Welcome;
    }
}