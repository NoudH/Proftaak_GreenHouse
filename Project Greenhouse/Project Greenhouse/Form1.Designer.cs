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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabLogin = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.CbPlantsoort = new System.Windows.Forms.ComboBox();
            this.TvPlanten = new System.Windows.Forms.TreeView();
            this.BtnSendPlant = new System.Windows.Forms.Button();
            this.BtnRemovePlant = new System.Windows.Forms.Button();
            this.BtnAddPlant = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NudWater = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPlantnaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabGraphs = new System.Windows.Forms.TabPage();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.DtpGraphs = new System.Windows.Forms.DateTimePicker();
            this.ChartHumidity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChartMoisture = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TabLiveFeed = new System.Windows.Forms.TabPage();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.TxtLogging = new System.Windows.Forms.RichTextBox();
            this.OfdDatafile = new System.Windows.Forms.OpenFileDialog();
            this.readMessageTimer = new System.Windows.Forms.Timer(this.components);
            this.BtnConnect = new System.Windows.Forms.Button();
            this.CbPlantNummer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPlantsoortNaam = new System.Windows.Forms.TextBox();
            this.BtnAddPlantsoort = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudWater)).BeginInit();
            this.TabGraphs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTemp)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMoisture)).BeginInit();
            this.tabLogs.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.TabLogin.Controls.Add(this.groupBox3);
            this.TabLogin.Controls.Add(this.label5);
            this.TabLogin.Controls.Add(this.CbPlantNummer);
            this.TabLogin.Controls.Add(this.BtnConnect);
            this.TabLogin.Controls.Add(this.label4);
            this.TabLogin.Controls.Add(this.CbPlantsoort);
            this.TabLogin.Controls.Add(this.TvPlanten);
            this.TabLogin.Controls.Add(this.BtnSendPlant);
            this.TabLogin.Controls.Add(this.BtnRemovePlant);
            this.TabLogin.Controls.Add(this.BtnAddPlant);
            this.TabLogin.Controls.Add(this.label3);
            this.TabLogin.Controls.Add(this.NudWater);
            this.TabLogin.Controls.Add(this.label2);
            this.TabLogin.Controls.Add(this.TxtPlantnaam);
            this.TabLogin.Controls.Add(this.label1);
            this.TabLogin.Controls.Add(this.groupBox2);
            this.TabLogin.Location = new System.Drawing.Point(4, 22);
            this.TabLogin.Name = "TabLogin";
            this.TabLogin.Size = new System.Drawing.Size(805, 465);
            this.TabLogin.TabIndex = 2;
            this.TabLogin.Text = "Planten";
            this.TabLogin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Plantsoort";
            // 
            // CbPlantsoort
            // 
            this.CbPlantsoort.FormattingEnabled = true;
            this.CbPlantsoort.Items.AddRange(new object[] {
            "Undefined"});
            this.CbPlantsoort.Location = new System.Drawing.Point(8, 119);
            this.CbPlantsoort.Name = "CbPlantsoort";
            this.CbPlantsoort.Size = new System.Drawing.Size(139, 21);
            this.CbPlantsoort.TabIndex = 10;
            this.CbPlantsoort.Text = "Undefined";
            // 
            // TvPlanten
            // 
            this.TvPlanten.Location = new System.Drawing.Point(523, 35);
            this.TvPlanten.Name = "TvPlanten";
            this.TvPlanten.Size = new System.Drawing.Size(264, 394);
            this.TvPlanten.TabIndex = 9;
            this.TvPlanten.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvPlanten_AfterSelect);
            // 
            // BtnSendPlant
            // 
            this.BtnSendPlant.Enabled = false;
            this.BtnSendPlant.Location = new System.Drawing.Point(8, 435);
            this.BtnSendPlant.Name = "BtnSendPlant";
            this.BtnSendPlant.Size = new System.Drawing.Size(139, 23);
            this.BtnSendPlant.TabIndex = 8;
            this.BtnSendPlant.Text = "Stuur plant naar arduino";
            this.BtnSendPlant.UseVisualStyleBackColor = true;
            this.BtnSendPlant.Click += new System.EventHandler(this.BtnSendPlant_Click);
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
            // BtnAddPlant
            // 
            this.BtnAddPlant.Location = new System.Drawing.Point(8, 146);
            this.BtnAddPlant.Name = "BtnAddPlant";
            this.BtnAddPlant.Size = new System.Drawing.Size(139, 23);
            this.BtnAddPlant.TabIndex = 6;
            this.BtnAddPlant.Text = "Voeg plant toe.";
            this.BtnAddPlant.UseVisualStyleBackColor = true;
            this.BtnAddPlant.Click += new System.EventHandler(this.BtnAddPlant_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grondvochtigheid:";
            // 
            // NudWater
            // 
            this.NudWater.Location = new System.Drawing.Point(9, 80);
            this.NudWater.Name = "NudWater";
            this.NudWater.Size = new System.Drawing.Size(139, 20);
            this.NudWater.TabIndex = 4;
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
            // TxtPlantnaam
            // 
            this.TxtPlantnaam.Location = new System.Drawing.Point(9, 41);
            this.TxtPlantnaam.Name = "TxtPlantnaam";
            this.TxtPlantnaam.Size = new System.Drawing.Size(139, 20);
            this.TxtPlantnaam.TabIndex = 2;
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
            // TabGraphs
            // 
            this.TabGraphs.Controls.Add(this.BtnOpenFile);
            this.TabGraphs.Controls.Add(this.DtpGraphs);
            this.TabGraphs.Controls.Add(this.ChartHumidity);
            this.TabGraphs.Controls.Add(this.ChartTemp);
            this.TabGraphs.Controls.Add(this.groupBox1);
            this.TabGraphs.Location = new System.Drawing.Point(4, 22);
            this.TabGraphs.Name = "TabGraphs";
            this.TabGraphs.Padding = new System.Windows.Forms.Padding(3);
            this.TabGraphs.Size = new System.Drawing.Size(805, 465);
            this.TabGraphs.TabIndex = 0;
            this.TabGraphs.Text = "Graphs";
            this.TabGraphs.UseVisualStyleBackColor = true;
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Location = new System.Drawing.Point(54, 9);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(75, 20);
            this.BtnOpenFile.TabIndex = 6;
            this.BtnOpenFile.Text = "Open File";
            this.BtnOpenFile.UseVisualStyleBackColor = true;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // DtpGraphs
            // 
            this.DtpGraphs.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpGraphs.Location = new System.Drawing.Point(135, 9);
            this.DtpGraphs.Name = "DtpGraphs";
            this.DtpGraphs.Size = new System.Drawing.Size(105, 20);
            this.DtpGraphs.TabIndex = 4;
            this.DtpGraphs.ValueChanged += new System.EventHandler(this.DtpGraphs_ValueChanged);
            // 
            // ChartHumidity
            // 
            chartArea13.Name = "ChartArea1";
            chartArea13.Position.Auto = false;
            chartArea13.Position.Height = 90F;
            chartArea13.Position.Width = 94F;
            chartArea13.Position.X = 3F;
            chartArea13.Position.Y = 10F;
            this.ChartHumidity.ChartAreas.Add(chartArea13);
            legend13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend13.IsTextAutoFit = false;
            legend13.Name = "Legend1";
            legend13.Position.Auto = false;
            legend13.Position.Height = 9F;
            legend13.Position.Width = 39.48368F;
            legend13.Position.X = 60F;
            legend13.Position.Y = 4F;
            this.ChartHumidity.Legends.Add(legend13);
            this.ChartHumidity.Location = new System.Drawing.Point(406, 32);
            this.ChartHumidity.Name = "ChartHumidity";
            series17.BorderWidth = 3;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series17.Legend = "Legend1";
            series17.Name = "Licht intensiteit";
            this.ChartHumidity.Series.Add(series17);
            this.ChartHumidity.Size = new System.Drawing.Size(393, 201);
            this.ChartHumidity.TabIndex = 3;
            this.ChartHumidity.Text = "chart2";
            // 
            // ChartTemp
            // 
            chartArea14.Name = "ChartArea1";
            chartArea14.Position.Auto = false;
            chartArea14.Position.Height = 90F;
            chartArea14.Position.Width = 94F;
            chartArea14.Position.X = 3F;
            chartArea14.Position.Y = 10F;
            this.ChartTemp.ChartAreas.Add(chartArea14);
            legend14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend14.IsTextAutoFit = false;
            legend14.Name = "Legend1";
            legend14.Position.Auto = false;
            legend14.Position.Height = 9F;
            legend14.Position.Width = 45.07463F;
            legend14.Position.X = 54.92537F;
            legend14.Position.Y = 4F;
            this.ChartTemp.Legends.Add(legend14);
            this.ChartTemp.Location = new System.Drawing.Point(8, 32);
            this.ChartTemp.Name = "ChartTemp";
            this.ChartTemp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series18.BorderWidth = 3;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series18.Legend = "Legend1";
            series18.Name = "Temperatuur in °C";
            this.ChartTemp.Series.Add(series18);
            this.ChartTemp.Size = new System.Drawing.Size(403, 201);
            this.ChartTemp.TabIndex = 2;
            this.ChartTemp.Text = "chart3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChartMoisture);
            this.groupBox1.Location = new System.Drawing.Point(3, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 222);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grondvochtigheid:";
            // 
            // ChartMoisture
            // 
            chartArea15.Name = "ChartArea1";
            chartArea15.Position.Auto = false;
            chartArea15.Position.Height = 94F;
            chartArea15.Position.Width = 81.21519F;
            chartArea15.Position.Y = 3F;
            this.ChartMoisture.ChartAreas.Add(chartArea15);
            legend15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend15.IsTextAutoFit = false;
            legend15.Name = "Legend1";
            this.ChartMoisture.Legends.Add(legend15);
            this.ChartMoisture.Location = new System.Drawing.Point(6, 15);
            this.ChartMoisture.Name = "ChartMoisture";
            this.ChartMoisture.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series19.BorderWidth = 3;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series19.Legend = "Legend1";
            series19.Name = "Plant 1";
            series20.BorderWidth = 3;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series20.Legend = "Legend1";
            series20.Name = "Plant 2";
            this.ChartMoisture.Series.Add(series19);
            this.ChartMoisture.Series.Add(series20);
            this.ChartMoisture.Size = new System.Drawing.Size(784, 197);
            this.ChartMoisture.TabIndex = 0;
            this.ChartMoisture.Text = "chart1";
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
            this.TxtLogging.Name = "TxtLogging";
            this.TxtLogging.Size = new System.Drawing.Size(805, 465);
            this.TxtLogging.TabIndex = 1;
            this.TxtLogging.Text = "";
            // 
            // readMessageTimer
            // 
            this.readMessageTimer.Enabled = true;
            this.readMessageTimer.Interval = 10;
            this.readMessageTimer.Tick += new System.EventHandler(this.readMessageTimer_Tick);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(8, 406);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(139, 23);
            this.BtnConnect.TabIndex = 12;
            this.BtnConnect.Text = "Connect to Arduino";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // CbPlantNummer
            // 
            this.CbPlantNummer.FormattingEnabled = true;
            this.CbPlantNummer.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CbPlantNummer.Location = new System.Drawing.Point(8, 379);
            this.CbPlantNummer.Name = "CbPlantNummer";
            this.CbPlantNummer.Size = new System.Drawing.Size(138, 21);
            this.CbPlantNummer.TabIndex = 13;
            this.CbPlantNummer.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Plant nummer:";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 183);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Planten";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnAddPlantsoort);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtPlantsoortNaam);
            this.groupBox3.Location = new System.Drawing.Point(161, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 182);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plantsoort";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Naam:";
            // 
            // TxtPlantsoortNaam
            // 
            this.TxtPlantsoortNaam.Location = new System.Drawing.Point(6, 37);
            this.TxtPlantsoortNaam.Name = "TxtPlantsoortNaam";
            this.TxtPlantsoortNaam.Size = new System.Drawing.Size(139, 20);
            this.TxtPlantsoortNaam.TabIndex = 17;
            // 
            // BtnAddPlantsoort
            // 
            this.BtnAddPlantsoort.Location = new System.Drawing.Point(6, 142);
            this.BtnAddPlantsoort.Name = "BtnAddPlantsoort";
            this.BtnAddPlantsoort.Size = new System.Drawing.Size(139, 23);
            this.BtnAddPlantsoort.TabIndex = 17;
            this.BtnAddPlantsoort.Text = "Voeg plantsoort toe.";
            this.BtnAddPlantsoort.UseVisualStyleBackColor = true;
            this.BtnAddPlantsoort.Click += new System.EventHandler(this.BtnAddPlantsoort_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.NudWater)).EndInit();
            this.TabGraphs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTemp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartMoisture)).EndInit();
            this.tabLogs.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabGraphs;
        private System.Windows.Forms.TabPage TabLiveFeed;
        private System.Windows.Forms.TabPage TabLogin;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPlantnaam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NudWater;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddPlant;
        private System.Windows.Forms.Button BtnRemovePlant;
        private System.Windows.Forms.Button BtnSendPlant;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartHumidity;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartMoisture;
        private System.Windows.Forms.DateTimePicker DtpGraphs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog OfdDatafile;
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.TreeView TvPlanten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbPlantsoort;
        private System.Windows.Forms.RichTextBox TxtLogging;
        private System.Windows.Forms.Timer readMessageTimer;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbPlantNummer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnAddPlantsoort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPlantsoortNaam;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

