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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabLogin = new System.Windows.Forms.TabPage();
            this.TabGraphs = new System.Windows.Forms.TabPage();
            this.pnlGrafiek = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.cbGrondvochtigheid2 = new System.Windows.Forms.CheckBox();
            this.cbGrondvochtigheid1 = new System.Windows.Forms.CheckBox();
            this.cbLuchtvochtigheid = new System.Windows.Forms.CheckBox();
            this.cbTemperatuur = new System.Windows.Forms.CheckBox();
            this.cbLichtintensiteit = new System.Windows.Forms.CheckBox();
            this.chartMeetingen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnScanFiles = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TabLiveFeed = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.TxtLogging = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.TabGraphs.SuspendLayout();
            this.pnlGrafiek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMeetingen)).BeginInit();
            this.TabLiveFeed.SuspendLayout();
            this.tabLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabLogin);
            this.tabControl1.Controls.Add(this.TabGraphs);
            this.tabControl1.Controls.Add(this.TabLiveFeed);
            this.tabControl1.Controls.Add(this.tabLogs);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 604);
            this.tabControl1.TabIndex = 0;
            // 
            // TabLogin
            // 
            this.TabLogin.Location = new System.Drawing.Point(4, 25);
            this.TabLogin.Margin = new System.Windows.Forms.Padding(4);
            this.TabLogin.Name = "TabLogin";
            this.TabLogin.Size = new System.Drawing.Size(1076, 575);
            this.TabLogin.TabIndex = 2;
            this.TabLogin.Text = "Login";
            this.TabLogin.UseVisualStyleBackColor = true;
            // 
            // TabGraphs
            // 
            this.TabGraphs.Controls.Add(this.pnlGrafiek);
            this.TabGraphs.Controls.Add(this.chartMeetingen);
            this.TabGraphs.Controls.Add(this.btnScanFiles);
            this.TabGraphs.Controls.Add(this.dateTimePicker2);
            this.TabGraphs.Controls.Add(this.dateTimePicker1);
            this.TabGraphs.Location = new System.Drawing.Point(4, 25);
            this.TabGraphs.Margin = new System.Windows.Forms.Padding(4);
            this.TabGraphs.Name = "TabGraphs";
            this.TabGraphs.Padding = new System.Windows.Forms.Padding(4);
            this.TabGraphs.Size = new System.Drawing.Size(1076, 575);
            this.TabGraphs.TabIndex = 0;
            this.TabGraphs.Text = "Graphs";
            this.TabGraphs.UseVisualStyleBackColor = true;
            // 
            // pnlGrafiek
            // 
            this.pnlGrafiek.Controls.Add(this.lblData);
            this.pnlGrafiek.Controls.Add(this.cbGrondvochtigheid2);
            this.pnlGrafiek.Controls.Add(this.cbGrondvochtigheid1);
            this.pnlGrafiek.Controls.Add(this.cbLuchtvochtigheid);
            this.pnlGrafiek.Controls.Add(this.cbTemperatuur);
            this.pnlGrafiek.Controls.Add(this.cbLichtintensiteit);
            this.pnlGrafiek.Location = new System.Drawing.Point(11, 83);
            this.pnlGrafiek.Name = "pnlGrafiek";
            this.pnlGrafiek.Size = new System.Drawing.Size(205, 179);
            this.pnlGrafiek.TabIndex = 5;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(3, 9);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(42, 17);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data:";
            // 
            // cbGrondvochtigheid2
            // 
            this.cbGrondvochtigheid2.AutoSize = true;
            this.cbGrondvochtigheid2.Location = new System.Drawing.Point(3, 144);
            this.cbGrondvochtigheid2.Name = "cbGrondvochtigheid2";
            this.cbGrondvochtigheid2.Size = new System.Drawing.Size(154, 21);
            this.cbGrondvochtigheid2.TabIndex = 4;
            this.cbGrondvochtigheid2.Text = "Grondvochtigheid 2";
            this.cbGrondvochtigheid2.UseVisualStyleBackColor = true;
            // 
            // cbGrondvochtigheid1
            // 
            this.cbGrondvochtigheid1.AutoSize = true;
            this.cbGrondvochtigheid1.Location = new System.Drawing.Point(3, 117);
            this.cbGrondvochtigheid1.Name = "cbGrondvochtigheid1";
            this.cbGrondvochtigheid1.Size = new System.Drawing.Size(154, 21);
            this.cbGrondvochtigheid1.TabIndex = 3;
            this.cbGrondvochtigheid1.Text = "Grondvochtigheid 1";
            this.cbGrondvochtigheid1.UseVisualStyleBackColor = true;
            // 
            // cbLuchtvochtigheid
            // 
            this.cbLuchtvochtigheid.AutoSize = true;
            this.cbLuchtvochtigheid.Location = new System.Drawing.Point(3, 92);
            this.cbLuchtvochtigheid.Name = "cbLuchtvochtigheid";
            this.cbLuchtvochtigheid.Size = new System.Drawing.Size(137, 21);
            this.cbLuchtvochtigheid.TabIndex = 2;
            this.cbLuchtvochtigheid.Text = "Luchtvochtigheid";
            this.cbLuchtvochtigheid.UseVisualStyleBackColor = true;
            // 
            // cbTemperatuur
            // 
            this.cbTemperatuur.AutoSize = true;
            this.cbTemperatuur.Location = new System.Drawing.Point(3, 65);
            this.cbTemperatuur.Name = "cbTemperatuur";
            this.cbTemperatuur.Size = new System.Drawing.Size(112, 21);
            this.cbTemperatuur.TabIndex = 1;
            this.cbTemperatuur.Text = "Temperatuur";
            this.cbTemperatuur.UseVisualStyleBackColor = true;
            // 
            // cbLichtintensiteit
            // 
            this.cbLichtintensiteit.AutoSize = true;
            this.cbLichtintensiteit.Location = new System.Drawing.Point(3, 38);
            this.cbLichtintensiteit.Name = "cbLichtintensiteit";
            this.cbLichtintensiteit.Size = new System.Drawing.Size(120, 21);
            this.cbLichtintensiteit.TabIndex = 0;
            this.cbLichtintensiteit.Text = "Lichtintensiteit";
            this.cbLichtintensiteit.UseVisualStyleBackColor = true;
            this.cbLichtintensiteit.CheckedChanged += new System.EventHandler(this.cbLichtintensiteit_CheckedChanged);
            // 
            // chartMeetingen
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMeetingen.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMeetingen.Legends.Add(legend1);
            this.chartMeetingen.Location = new System.Drawing.Point(222, 71);
            this.chartMeetingen.Name = "chartMeetingen";
            this.chartMeetingen.Size = new System.Drawing.Size(847, 497);
            this.chartMeetingen.TabIndex = 4;
            this.chartMeetingen.Text = "chart1";
            // 
            // btnScanFiles
            // 
            this.btnScanFiles.Location = new System.Drawing.Point(11, 7);
            this.btnScanFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnScanFiles.Name = "btnScanFiles";
            this.btnScanFiles.Size = new System.Drawing.Size(100, 28);
            this.btnScanFiles.TabIndex = 3;
            this.btnScanFiles.Text = "Scan";
            this.btnScanFiles.UseVisualStyleBackColor = true;
            this.btnScanFiles.Click += new System.EventHandler(this.btnScanFiles_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(285, 42);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 42);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // TabLiveFeed
            // 
            this.TabLiveFeed.Controls.Add(this.listBox1);
            this.TabLiveFeed.Location = new System.Drawing.Point(4, 25);
            this.TabLiveFeed.Margin = new System.Windows.Forms.Padding(4);
            this.TabLiveFeed.Name = "TabLiveFeed";
            this.TabLiveFeed.Padding = new System.Windows.Forms.Padding(4);
            this.TabLiveFeed.Size = new System.Drawing.Size(1076, 575);
            this.TabLiveFeed.TabIndex = 1;
            this.TabLiveFeed.Text = "Live Feed";
            this.TabLiveFeed.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(9, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1052, 548);
            this.listBox1.TabIndex = 0;
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.TxtLogging);
            this.tabLogs.Location = new System.Drawing.Point(4, 25);
            this.tabLogs.Margin = new System.Windows.Forms.Padding(4);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Size = new System.Drawing.Size(1076, 575);
            this.tabLogs.TabIndex = 3;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // TxtLogging
            // 
            this.TxtLogging.Location = new System.Drawing.Point(0, 0);
            this.TxtLogging.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLogging.Multiline = true;
            this.TxtLogging.Name = "TxtLogging";
            this.TxtLogging.Size = new System.Drawing.Size(1072, 571);
            this.TxtLogging.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 607);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabGraphs.ResumeLayout(false);
            this.pnlGrafiek.ResumeLayout(false);
            this.pnlGrafiek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMeetingen)).EndInit();
            this.TabLiveFeed.ResumeLayout(false);
            this.tabLogs.ResumeLayout(false);
            this.tabLogs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabGraphs;
        private System.Windows.Forms.TabPage TabLiveFeed;
        private System.Windows.Forms.TabPage TabLogin;
        private System.Windows.Forms.TabPage tabLogs;

        private System.Windows.Forms.TextBox TxtLogging;
        private System.Windows.Forms.Button btnScanFiles;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel pnlGrafiek;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.CheckBox cbGrondvochtigheid2;
        private System.Windows.Forms.CheckBox cbGrondvochtigheid1;
        private System.Windows.Forms.CheckBox cbLuchtvochtigheid;
        private System.Windows.Forms.CheckBox cbTemperatuur;
        private System.Windows.Forms.CheckBox cbLichtintensiteit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMeetingen;
        private System.Windows.Forms.ListBox listBox1;
    }
}