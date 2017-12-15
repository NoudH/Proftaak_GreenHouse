namespace Project_Greenhouse
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabLogin = new System.Windows.Forms.TabPage();
            this.TabGraphs = new System.Windows.Forms.TabPage();
            this.TabLiveFeed = new System.Windows.Forms.TabPage();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabLogin);
            this.tabControl1.Controls.Add(this.TabGraphs);
            this.tabControl1.Controls.Add(this.TabLiveFeed);
            this.tabControl1.Controls.Add(this.tabLogs);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 491);
            this.tabControl1.TabIndex = 0;
            // 
            // TabLogin
            // 
            this.TabLogin.Controls.Add(this.button1);
            this.TabLogin.Location = new System.Drawing.Point(4, 22);
            this.TabLogin.Name = "TabLogin";
            this.TabLogin.Size = new System.Drawing.Size(805, 465);
            this.TabLogin.TabIndex = 2;
            this.TabLogin.Text = "Login";
            this.TabLogin.UseVisualStyleBackColor = true;
            // 
            // TabGraphs
            // 
            this.TabGraphs.Location = new System.Drawing.Point(4, 22);
            this.TabGraphs.Name = "TabGraphs";
            this.TabGraphs.Padding = new System.Windows.Forms.Padding(3);
            this.TabGraphs.Size = new System.Drawing.Size(805, 465);
            this.TabGraphs.TabIndex = 0;
            this.TabGraphs.Text = "Graphs";
            this.TabGraphs.UseVisualStyleBackColor = true;
            // 
            // TabLiveFeed
            // 
            this.TabLiveFeed.Location = new System.Drawing.Point(4, 22);
            this.TabLiveFeed.Name = "TabLiveFeed";
            this.TabLiveFeed.Padding = new System.Windows.Forms.Padding(3);
            this.TabLiveFeed.Size = new System.Drawing.Size(805, 465);
            this.TabLiveFeed.TabIndex = 1;
            this.TabLiveFeed.Text = "Live Feed";
            this.TabLiveFeed.UseVisualStyleBackColor = true;
            // 
            // tabLogs
            // 
            this.tabLogs.Location = new System.Drawing.Point(4, 22);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Size = new System.Drawing.Size(805, 465);
            this.tabLogs.TabIndex = 3;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 493);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.TabLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabGraphs;
        private System.Windows.Forms.TabPage TabLiveFeed;
        private System.Windows.Forms.TabPage TabLogin;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.Button button1;
    }
}

