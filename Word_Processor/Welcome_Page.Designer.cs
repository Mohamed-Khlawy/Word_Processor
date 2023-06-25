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
            this.btnNew_Page = new System.Windows.Forms.Button();
            this.btnOpen_Page = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNew_Page
            // 
            this.btnNew_Page.Location = new System.Drawing.Point(304, 128);
            this.btnNew_Page.Name = "btnNew_Page";
            this.btnNew_Page.Size = new System.Drawing.Size(135, 60);
            this.btnNew_Page.TabIndex = 0;
            this.btnNew_Page.Text = "New";
            this.btnNew_Page.UseVisualStyleBackColor = true;
            this.btnNew_Page.Click += new System.EventHandler(this.btnNew_Page_Click);
            // 
            // btnOpen_Page
            // 
            this.btnOpen_Page.Location = new System.Drawing.Point(304, 215);
            this.btnOpen_Page.Name = "btnOpen_Page";
            this.btnOpen_Page.Size = new System.Drawing.Size(135, 60);
            this.btnOpen_Page.TabIndex = 1;
            this.btnOpen_Page.Text = "Open";
            this.btnOpen_Page.UseVisualStyleBackColor = true;
            // 
            // Welcome_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.btnOpen_Page);
            this.Controls.Add(this.btnNew_Page);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Welcome_Page";
            this.Text = "Welcome_Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew_Page;
        private System.Windows.Forms.Button btnOpen_Page;
    }
}