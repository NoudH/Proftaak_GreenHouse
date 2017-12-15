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
            this.TxtLogging = new System.Windows.Forms.TextBox();
            this.LbPlanten = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPlantnaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NudWater = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAddPlant = new System.Windows.Forms.Button();
            this.BtnRemovePlant = new System.Windows.Forms.Button();
            this.BtnSendPlant = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabLogin.SuspendLayout();
            this.tabLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudWater)).BeginInit();
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
            this.TabLogin.Controls.Add(this.BtnSendPlant);
            this.TabLogin.Controls.Add(this.BtnRemovePlant);
            this.TabLogin.Controls.Add(this.BtnAddPlant);
            this.TabLogin.Controls.Add(this.label3);
            this.TabLogin.Controls.Add(this.NudWater);
            this.TabLogin.Controls.Add(this.label2);
            this.TabLogin.Controls.Add(this.TxtPlantnaam);
            this.TabLogin.Controls.Add(this.label1);
            this.TabLogin.Controls.Add(this.LbPlanten);
            this.TabLogin.Location = new System.Drawing.Point(4, 22);
            this.TabLogin.Name = "TabLogin";
            this.TabLogin.Size = new System.Drawing.Size(805, 465);
            this.TabLogin.TabIndex = 2;
            this.TabLogin.Text = "Planten";
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
            this.tabLogs.Controls.Add(this.TxtLogging);
            this.tabLogs.Location = new System.Drawing.Point(4, 22);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Size = new System.Drawing.Size(805, 465);
            this.tabLogs.TabIndex = 3;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // TxtLogging
            // 
            this.TxtLogging.Location = new System.Drawing.Point(0, 0);
            this.TxtLogging.Multiline = true;
            this.TxtLogging.Name = "TxtLogging";
            this.TxtLogging.Size = new System.Drawing.Size(805, 465);
            this.TxtLogging.TabIndex = 0;
            // 
            // LbPlanten
            // 
            this.LbPlanten.FormattingEnabled = true;
            this.LbPlanten.Location = new System.Drawing.Point(523, 35);
            this.LbPlanten.Name = "LbPlanten";
            this.LbPlanten.Size = new System.Drawing.Size(264, 394);
            this.LbPlanten.TabIndex = 0;
            this.LbPlanten.SelectedIndexChanged += new System.EventHandler(this.LbPlanten_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Planten";
            // 
            // TxtPlantnaam
            // 
            this.TxtPlantnaam.Location = new System.Drawing.Point(9, 41);
            this.TxtPlantnaam.Name = "TxtPlantnaam";
            this.TxtPlantnaam.Size = new System.Drawing.Size(139, 20);
            this.TxtPlantnaam.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naam:";
            // 
            // NudWater
            // 
            this.NudWater.Location = new System.Drawing.Point(9, 80);
            this.NudWater.Name = "NudWater";
            this.NudWater.Size = new System.Drawing.Size(139, 20);
            this.NudWater.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Water:";
            // 
            // BtnAddPlant
            // 
            this.BtnAddPlant.Location = new System.Drawing.Point(9, 116);
            this.BtnAddPlant.Name = "BtnAddPlant";
            this.BtnAddPlant.Size = new System.Drawing.Size(139, 23);
            this.BtnAddPlant.TabIndex = 6;
            this.BtnAddPlant.Text = "Voeg plant toe.";
            this.BtnAddPlant.UseVisualStyleBackColor = true;
            this.BtnAddPlant.Click += new System.EventHandler(this.BtnAddPlant_Click);
            // 
            // BtnRemovePlant
            // 
            this.BtnRemovePlant.Location = new System.Drawing.Point(523, 435);
            this.BtnRemovePlant.Name = "BtnRemovePlant";
            this.BtnRemovePlant.Size = new System.Drawing.Size(264, 23);
            this.BtnRemovePlant.TabIndex = 7;
            this.BtnRemovePlant.Text = "Verwijder plant";
            this.BtnRemovePlant.UseVisualStyleBackColor = true;
            this.BtnRemovePlant.Click += new System.EventHandler(this.BtnRemovePlant_Click);
            // 
            // BtnSendPlant
            // 
            this.BtnSendPlant.Location = new System.Drawing.Point(9, 145);
            this.BtnSendPlant.Name = "BtnSendPlant";
            this.BtnSendPlant.Size = new System.Drawing.Size(139, 23);
            this.BtnSendPlant.TabIndex = 8;
            this.BtnSendPlant.Text = "Stuur plant naar arduino";
            this.BtnSendPlant.UseVisualStyleBackColor = true;
            this.BtnSendPlant.Click += new System.EventHandler(this.BtnSendPlant_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 493);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Project Greenhouse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.TabLogin.ResumeLayout(false);
            this.TabLogin.PerformLayout();
            this.tabLogs.ResumeLayout(false);
            this.tabLogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudWater)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabGraphs;
        private System.Windows.Forms.TabPage TabLiveFeed;
        private System.Windows.Forms.TabPage TabLogin;
        private System.Windows.Forms.TabPage tabLogs;

        private System.Windows.Forms.TextBox TxtLogging;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LbPlanten;
        private System.Windows.Forms.TextBox TxtPlantnaam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NudWater;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddPlant;
        private System.Windows.Forms.Button BtnRemovePlant;
        private System.Windows.Forms.Button BtnSendPlant;
    }
}

