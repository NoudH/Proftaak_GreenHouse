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
            this.dtpGraphTot = new System.Windows.Forms.DateTimePicker();
            this.dtpGraphVan = new System.Windows.Forms.DateTimePicker();
            this.TabLiveFeed = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.TxtLogging = new System.Windows.Forms.TextBox();
            this.tabGenereerMeetingen = new System.Windows.Forms.TabPage();
            this.gbGenereer = new System.Windows.Forms.GroupBox();
            this.tbGenereerTotaalAantalMeetingen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGenereerMeetingen = new System.Windows.Forms.Button();
            this.gbGenereerOpties = new System.Windows.Forms.GroupBox();
            this.cbVervangDB = new System.Windows.Forms.CheckBox();
            this.gbGenereerAantalDecimalen = new System.Windows.Forms.GroupBox();
            this.nudADGrondvochtigheid = new System.Windows.Forms.NumericUpDown();
            this.nudADLuchtvochtigheid = new System.Windows.Forms.NumericUpDown();
            this.nudADTemperatuur = new System.Windows.Forms.NumericUpDown();
            this.nudADLichtintensiteit = new System.Windows.Forms.NumericUpDown();
            this.gbGenereerMax = new System.Windows.Forms.GroupBox();
            this.nudMaxGrondvochtigheid = new System.Windows.Forms.NumericUpDown();
            this.nudMaxLuchtvochtigheid = new System.Windows.Forms.NumericUpDown();
            this.nudMaxTemperatuur = new System.Windows.Forms.NumericUpDown();
            this.nudMaxLichtintensiteit = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbGenereerMin = new System.Windows.Forms.GroupBox();
            this.nudMinGrondvochtigheid = new System.Windows.Forms.NumericUpDown();
            this.nudMinLuchtvochtigheid = new System.Windows.Forms.NumericUpDown();
            this.nudMinTemperatuur = new System.Windows.Forms.NumericUpDown();
            this.nudMinLichtintensiteit = new System.Windows.Forms.NumericUpDown();
            this.gbInterval = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.tbMeetingenPerDag = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTijdsEenheid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGenereerDatums = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGeneerDatums = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpGenereerVan = new System.Windows.Forms.DateTimePicker();
            this.dtpGenereerTot = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.TabGraphs.SuspendLayout();
            this.pnlGrafiek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMeetingen)).BeginInit();
            this.TabLiveFeed.SuspendLayout();
            this.tabLogs.SuspendLayout();
            this.tabGenereerMeetingen.SuspendLayout();
            this.gbGenereer.SuspendLayout();
            this.gbGenereerOpties.SuspendLayout();
            this.gbGenereerAantalDecimalen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudADGrondvochtigheid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudADLuchtvochtigheid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudADTemperatuur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudADLichtintensiteit)).BeginInit();
            this.gbGenereerMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxGrondvochtigheid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLuchtvochtigheid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTemperatuur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLichtintensiteit)).BeginInit();
            this.gbGenereerMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinGrondvochtigheid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLuchtvochtigheid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinTemperatuur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLichtintensiteit)).BeginInit();
            this.gbInterval.SuspendLayout();
            this.gbGenereerDatums.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabLogin);
            this.tabControl1.Controls.Add(this.TabGraphs);
            this.tabControl1.Controls.Add(this.TabLiveFeed);
            this.tabControl1.Controls.Add(this.tabLogs);
            this.tabControl1.Controls.Add(this.tabGenereerMeetingen);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 491);
            this.tabControl1.TabIndex = 0;
            // 
            // TabLogin
            // 
            this.TabLogin.Location = new System.Drawing.Point(4, 22);
            this.TabLogin.Name = "TabLogin";
            this.TabLogin.Size = new System.Drawing.Size(805, 465);
            this.TabLogin.TabIndex = 2;
            this.TabLogin.Text = "Login";
            this.TabLogin.UseVisualStyleBackColor = true;
            // 
            // TabGraphs
            // 
            this.TabGraphs.Controls.Add(this.pnlGrafiek);
            this.TabGraphs.Controls.Add(this.chartMeetingen);
            this.TabGraphs.Controls.Add(this.dtpGraphTot);
            this.TabGraphs.Controls.Add(this.dtpGraphVan);
            this.TabGraphs.Location = new System.Drawing.Point(4, 22);
            this.TabGraphs.Name = "TabGraphs";
            this.TabGraphs.Padding = new System.Windows.Forms.Padding(3);
            this.TabGraphs.Size = new System.Drawing.Size(805, 465);
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
            this.pnlGrafiek.Location = new System.Drawing.Point(8, 67);
            this.pnlGrafiek.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGrafiek.Name = "pnlGrafiek";
            this.pnlGrafiek.Size = new System.Drawing.Size(154, 145);
            this.pnlGrafiek.TabIndex = 5;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(2, 7);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data:";
            // 
            // cbGrondvochtigheid2
            // 
            this.cbGrondvochtigheid2.AutoSize = true;
            this.cbGrondvochtigheid2.Location = new System.Drawing.Point(2, 117);
            this.cbGrondvochtigheid2.Margin = new System.Windows.Forms.Padding(2);
            this.cbGrondvochtigheid2.Name = "cbGrondvochtigheid2";
            this.cbGrondvochtigheid2.Size = new System.Drawing.Size(119, 17);
            this.cbGrondvochtigheid2.TabIndex = 4;
            this.cbGrondvochtigheid2.Text = "Grondvochtigheid 2";
            this.cbGrondvochtigheid2.UseVisualStyleBackColor = true;
            // 
            // cbGrondvochtigheid1
            // 
            this.cbGrondvochtigheid1.AutoSize = true;
            this.cbGrondvochtigheid1.Location = new System.Drawing.Point(2, 95);
            this.cbGrondvochtigheid1.Margin = new System.Windows.Forms.Padding(2);
            this.cbGrondvochtigheid1.Name = "cbGrondvochtigheid1";
            this.cbGrondvochtigheid1.Size = new System.Drawing.Size(119, 17);
            this.cbGrondvochtigheid1.TabIndex = 3;
            this.cbGrondvochtigheid1.Text = "Grondvochtigheid 1";
            this.cbGrondvochtigheid1.UseVisualStyleBackColor = true;
            // 
            // cbLuchtvochtigheid
            // 
            this.cbLuchtvochtigheid.AutoSize = true;
            this.cbLuchtvochtigheid.Location = new System.Drawing.Point(2, 75);
            this.cbLuchtvochtigheid.Margin = new System.Windows.Forms.Padding(2);
            this.cbLuchtvochtigheid.Name = "cbLuchtvochtigheid";
            this.cbLuchtvochtigheid.Size = new System.Drawing.Size(108, 17);
            this.cbLuchtvochtigheid.TabIndex = 2;
            this.cbLuchtvochtigheid.Text = "Luchtvochtigheid";
            this.cbLuchtvochtigheid.UseVisualStyleBackColor = true;
            // 
            // cbTemperatuur
            // 
            this.cbTemperatuur.AutoSize = true;
            this.cbTemperatuur.Location = new System.Drawing.Point(2, 53);
            this.cbTemperatuur.Margin = new System.Windows.Forms.Padding(2);
            this.cbTemperatuur.Name = "cbTemperatuur";
            this.cbTemperatuur.Size = new System.Drawing.Size(86, 17);
            this.cbTemperatuur.TabIndex = 1;
            this.cbTemperatuur.Text = "Temperatuur";
            this.cbTemperatuur.UseVisualStyleBackColor = true;
            // 
            // cbLichtintensiteit
            // 
            this.cbLichtintensiteit.AutoSize = true;
            this.cbLichtintensiteit.Location = new System.Drawing.Point(2, 31);
            this.cbLichtintensiteit.Margin = new System.Windows.Forms.Padding(2);
            this.cbLichtintensiteit.Name = "cbLichtintensiteit";
            this.cbLichtintensiteit.Size = new System.Drawing.Size(93, 17);
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
            this.chartMeetingen.Location = new System.Drawing.Point(166, 58);
            this.chartMeetingen.Margin = new System.Windows.Forms.Padding(2);
            this.chartMeetingen.Name = "chartMeetingen";
            this.chartMeetingen.Size = new System.Drawing.Size(635, 404);
            this.chartMeetingen.TabIndex = 4;
            this.chartMeetingen.Text = "chart1";
            // 
            // dateTimePicker2
            // 
            this.dtpGraphTot.Location = new System.Drawing.Point(214, 34);
            this.dtpGraphTot.Name = "dateTimePicker2";
            this.dtpGraphTot.Size = new System.Drawing.Size(200, 20);
            this.dtpGraphTot.TabIndex = 2;
            this.dtpGraphTot.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dtpGraphVan.Location = new System.Drawing.Point(8, 34);
            this.dtpGraphVan.Name = "dateTimePicker1";
            this.dtpGraphVan.Size = new System.Drawing.Size(200, 20);
            this.dtpGraphVan.TabIndex = 1;
            this.dtpGraphVan.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // TabLiveFeed
            // 
            this.TabLiveFeed.Controls.Add(this.listBox1);
            this.TabLiveFeed.Location = new System.Drawing.Point(4, 22);
            this.TabLiveFeed.Name = "TabLiveFeed";
            this.TabLiveFeed.Padding = new System.Windows.Forms.Padding(3);
            this.TabLiveFeed.Size = new System.Drawing.Size(805, 465);
            this.TabLiveFeed.TabIndex = 1;
            this.TabLiveFeed.Text = "Live Feed";
            this.TabLiveFeed.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 6);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(790, 446);
            this.listBox1.TabIndex = 0;
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
            // tabGenereerMeetingen
            // 
            this.tabGenereerMeetingen.Controls.Add(this.gbGenereer);
            this.tabGenereerMeetingen.Controls.Add(this.gbInterval);
            this.tabGenereerMeetingen.Controls.Add(this.gbGenereerDatums);
            this.tabGenereerMeetingen.Location = new System.Drawing.Point(4, 22);
            this.tabGenereerMeetingen.Name = "tabGenereerMeetingen";
            this.tabGenereerMeetingen.Size = new System.Drawing.Size(805, 465);
            this.tabGenereerMeetingen.TabIndex = 4;
            this.tabGenereerMeetingen.Text = "Genereer Meetingen";
            this.tabGenereerMeetingen.UseVisualStyleBackColor = true;
            // 
            // gbGenereer
            // 
            this.gbGenereer.Controls.Add(this.tbGenereerTotaalAantalMeetingen);
            this.gbGenereer.Controls.Add(this.label8);
            this.gbGenereer.Controls.Add(this.btnGenereerMeetingen);
            this.gbGenereer.Controls.Add(this.gbGenereerOpties);
            this.gbGenereer.Location = new System.Drawing.Point(8, 219);
            this.gbGenereer.Name = "gbGenereer";
            this.gbGenereer.Size = new System.Drawing.Size(792, 243);
            this.gbGenereer.TabIndex = 9;
            this.gbGenereer.TabStop = false;
            this.gbGenereer.Text = "Genereer";
            // 
            // tbGenereerTotaalAantalMeetingen
            // 
            this.tbGenereerTotaalAantalMeetingen.Location = new System.Drawing.Point(198, 200);
            this.tbGenereerTotaalAantalMeetingen.Name = "tbGenereerTotaalAantalMeetingen";
            this.tbGenereerTotaalAantalMeetingen.ReadOnly = true;
            this.tbGenereerTotaalAantalMeetingen.Size = new System.Drawing.Size(232, 20);
            this.tbGenereerTotaalAantalMeetingen.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Totaal aantal meetingen te genereren:";
            // 
            // btnGenereerMeetingen
            // 
            this.btnGenereerMeetingen.Location = new System.Drawing.Point(619, 182);
            this.btnGenereerMeetingen.Name = "btnGenereerMeetingen";
            this.btnGenereerMeetingen.Size = new System.Drawing.Size(167, 55);
            this.btnGenereerMeetingen.TabIndex = 1;
            this.btnGenereerMeetingen.Text = "Genereer";
            this.btnGenereerMeetingen.UseVisualStyleBackColor = true;
            this.btnGenereerMeetingen.Click += new System.EventHandler(this.btnGenereerMeetingen_Click);
            // 
            // gbGenereerOpties
            // 
            this.gbGenereerOpties.Controls.Add(this.cbVervangDB);
            this.gbGenereerOpties.Controls.Add(this.gbGenereerAantalDecimalen);
            this.gbGenereerOpties.Controls.Add(this.gbGenereerMax);
            this.gbGenereerOpties.Controls.Add(this.label11);
            this.gbGenereerOpties.Controls.Add(this.label12);
            this.gbGenereerOpties.Controls.Add(this.label10);
            this.gbGenereerOpties.Controls.Add(this.label9);
            this.gbGenereerOpties.Controls.Add(this.gbGenereerMin);
            this.gbGenereerOpties.Location = new System.Drawing.Point(9, 28);
            this.gbGenereerOpties.Name = "gbGenereerOpties";
            this.gbGenereerOpties.Size = new System.Drawing.Size(777, 148);
            this.gbGenereerOpties.TabIndex = 0;
            this.gbGenereerOpties.TabStop = false;
            this.gbGenereerOpties.Text = "Opties";
            // 
            // cbVervangDB
            // 
            this.cbVervangDB.AutoSize = true;
            this.cbVervangDB.Checked = true;
            this.cbVervangDB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVervangDB.Location = new System.Drawing.Point(507, 19);
            this.cbVervangDB.Name = "cbVervangDB";
            this.cbVervangDB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbVervangDB.Size = new System.Drawing.Size(97, 17);
            this.cbVervangDB.TabIndex = 7;
            this.cbVervangDB.Text = "Leeg database";
            this.cbVervangDB.UseVisualStyleBackColor = true;
            // 
            // gbGenereerAantalDecimalen
            // 
            this.gbGenereerAantalDecimalen.Controls.Add(this.nudADGrondvochtigheid);
            this.gbGenereerAantalDecimalen.Controls.Add(this.nudADLuchtvochtigheid);
            this.gbGenereerAantalDecimalen.Controls.Add(this.nudADTemperatuur);
            this.gbGenereerAantalDecimalen.Controls.Add(this.nudADLichtintensiteit);
            this.gbGenereerAantalDecimalen.Location = new System.Drawing.Point(314, 17);
            this.gbGenereerAantalDecimalen.Name = "gbGenereerAantalDecimalen";
            this.gbGenereerAantalDecimalen.Size = new System.Drawing.Size(107, 123);
            this.gbGenereerAantalDecimalen.TabIndex = 6;
            this.gbGenereerAantalDecimalen.TabStop = false;
            this.gbGenereerAantalDecimalen.Text = "Aantal Decimalen";
            // 
            // nudADGrondvochtigheid
            // 
            this.nudADGrondvochtigheid.Location = new System.Drawing.Point(6, 94);
            this.nudADGrondvochtigheid.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudADGrondvochtigheid.Name = "nudADGrondvochtigheid";
            this.nudADGrondvochtigheid.Size = new System.Drawing.Size(86, 20);
            this.nudADGrondvochtigheid.TabIndex = 3;
            this.nudADGrondvochtigheid.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudADLuchtvochtigheid
            // 
            this.nudADLuchtvochtigheid.Location = new System.Drawing.Point(6, 68);
            this.nudADLuchtvochtigheid.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudADLuchtvochtigheid.Name = "nudADLuchtvochtigheid";
            this.nudADLuchtvochtigheid.Size = new System.Drawing.Size(86, 20);
            this.nudADLuchtvochtigheid.TabIndex = 2;
            this.nudADLuchtvochtigheid.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudADTemperatuur
            // 
            this.nudADTemperatuur.Location = new System.Drawing.Point(6, 42);
            this.nudADTemperatuur.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudADTemperatuur.Name = "nudADTemperatuur";
            this.nudADTemperatuur.Size = new System.Drawing.Size(86, 20);
            this.nudADTemperatuur.TabIndex = 1;
            this.nudADTemperatuur.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudADLichtintensiteit
            // 
            this.nudADLichtintensiteit.Location = new System.Drawing.Point(6, 16);
            this.nudADLichtintensiteit.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudADLichtintensiteit.Name = "nudADLichtintensiteit";
            this.nudADLichtintensiteit.Size = new System.Drawing.Size(86, 20);
            this.nudADLichtintensiteit.TabIndex = 0;
            this.nudADLichtintensiteit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // gbGenereerMax
            // 
            this.gbGenereerMax.Controls.Add(this.nudMaxGrondvochtigheid);
            this.gbGenereerMax.Controls.Add(this.nudMaxLuchtvochtigheid);
            this.gbGenereerMax.Controls.Add(this.nudMaxTemperatuur);
            this.gbGenereerMax.Controls.Add(this.nudMaxLichtintensiteit);
            this.gbGenereerMax.Location = new System.Drawing.Point(210, 17);
            this.gbGenereerMax.Name = "gbGenereerMax";
            this.gbGenereerMax.Size = new System.Drawing.Size(98, 123);
            this.gbGenereerMax.TabIndex = 4;
            this.gbGenereerMax.TabStop = false;
            this.gbGenereerMax.Text = "Max Waarde";
            // 
            // nudMaxGrondvochtigheid
            // 
            this.nudMaxGrondvochtigheid.Location = new System.Drawing.Point(6, 94);
            this.nudMaxGrondvochtigheid.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxGrondvochtigheid.Name = "nudMaxGrondvochtigheid";
            this.nudMaxGrondvochtigheid.Size = new System.Drawing.Size(86, 20);
            this.nudMaxGrondvochtigheid.TabIndex = 3;
            this.nudMaxGrondvochtigheid.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudMaxLuchtvochtigheid
            // 
            this.nudMaxLuchtvochtigheid.Location = new System.Drawing.Point(6, 68);
            this.nudMaxLuchtvochtigheid.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxLuchtvochtigheid.Name = "nudMaxLuchtvochtigheid";
            this.nudMaxLuchtvochtigheid.Size = new System.Drawing.Size(86, 20);
            this.nudMaxLuchtvochtigheid.TabIndex = 2;
            this.nudMaxLuchtvochtigheid.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudMaxTemperatuur
            // 
            this.nudMaxTemperatuur.Location = new System.Drawing.Point(6, 42);
            this.nudMaxTemperatuur.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxTemperatuur.Name = "nudMaxTemperatuur";
            this.nudMaxTemperatuur.Size = new System.Drawing.Size(86, 20);
            this.nudMaxTemperatuur.TabIndex = 1;
            this.nudMaxTemperatuur.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudMaxLichtintensiteit
            // 
            this.nudMaxLichtintensiteit.Location = new System.Drawing.Point(6, 16);
            this.nudMaxLichtintensiteit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxLichtintensiteit.Name = "nudMaxLichtintensiteit";
            this.nudMaxLichtintensiteit.Size = new System.Drawing.Size(86, 20);
            this.nudMaxLichtintensiteit.TabIndex = 0;
            this.nudMaxLichtintensiteit.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Grondvochtigheid:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Luchtvochtigheid:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Temperatuur:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Lichtintensiteit:";
            // 
            // gbGenereerMin
            // 
            this.gbGenereerMin.Controls.Add(this.nudMinGrondvochtigheid);
            this.gbGenereerMin.Controls.Add(this.nudMinLuchtvochtigheid);
            this.gbGenereerMin.Controls.Add(this.nudMinTemperatuur);
            this.gbGenereerMin.Controls.Add(this.nudMinLichtintensiteit);
            this.gbGenereerMin.Location = new System.Drawing.Point(106, 17);
            this.gbGenereerMin.Name = "gbGenereerMin";
            this.gbGenereerMin.Size = new System.Drawing.Size(98, 123);
            this.gbGenereerMin.TabIndex = 2;
            this.gbGenereerMin.TabStop = false;
            this.gbGenereerMin.Text = "Min Waarde";
            // 
            // nudMinGrondvochtigheid
            // 
            this.nudMinGrondvochtigheid.Location = new System.Drawing.Point(6, 94);
            this.nudMinGrondvochtigheid.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMinGrondvochtigheid.Name = "nudMinGrondvochtigheid";
            this.nudMinGrondvochtigheid.Size = new System.Drawing.Size(86, 20);
            this.nudMinGrondvochtigheid.TabIndex = 3;
            // 
            // nudMinLuchtvochtigheid
            // 
            this.nudMinLuchtvochtigheid.Location = new System.Drawing.Point(6, 68);
            this.nudMinLuchtvochtigheid.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMinLuchtvochtigheid.Name = "nudMinLuchtvochtigheid";
            this.nudMinLuchtvochtigheid.Size = new System.Drawing.Size(86, 20);
            this.nudMinLuchtvochtigheid.TabIndex = 2;
            // 
            // nudMinTemperatuur
            // 
            this.nudMinTemperatuur.Location = new System.Drawing.Point(6, 42);
            this.nudMinTemperatuur.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMinTemperatuur.Name = "nudMinTemperatuur";
            this.nudMinTemperatuur.Size = new System.Drawing.Size(86, 20);
            this.nudMinTemperatuur.TabIndex = 1;
            // 
            // nudMinLichtintensiteit
            // 
            this.nudMinLichtintensiteit.Location = new System.Drawing.Point(6, 16);
            this.nudMinLichtintensiteit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMinLichtintensiteit.Name = "nudMinLichtintensiteit";
            this.nudMinLichtintensiteit.Size = new System.Drawing.Size(86, 20);
            this.nudMinLichtintensiteit.TabIndex = 0;
            // 
            // gbInterval
            // 
            this.gbInterval.Controls.Add(this.label6);
            this.gbInterval.Controls.Add(this.tbInterval);
            this.gbInterval.Controls.Add(this.tbMeetingenPerDag);
            this.gbInterval.Controls.Add(this.label7);
            this.gbInterval.Controls.Add(this.cbTijdsEenheid);
            this.gbInterval.Controls.Add(this.label1);
            this.gbInterval.Location = new System.Drawing.Point(8, 125);
            this.gbInterval.Name = "gbInterval";
            this.gbInterval.Size = new System.Drawing.Size(792, 52);
            this.gbInterval.TabIndex = 8;
            this.gbInterval.TabStop = false;
            this.gbInterval.Text = "Interval";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(642, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "meetingen/dag";
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(9, 19);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(100, 20);
            this.tbInterval.TabIndex = 0;
            this.tbInterval.Text = "1";
            this.tbInterval.TextChanged += new System.EventHandler(this.tbInterval_TextChanged);
            // 
            // tbMeetingenPerDag
            // 
            this.tbMeetingenPerDag.Location = new System.Drawing.Point(569, 18);
            this.tbMeetingenPerDag.MaxLength = 6;
            this.tbMeetingenPerDag.Name = "tbMeetingenPerDag";
            this.tbMeetingenPerDag.ReadOnly = true;
            this.tbMeetingenPerDag.Size = new System.Drawing.Size(67, 20);
            this.tbMeetingenPerDag.TabIndex = 11;
            this.tbMeetingenPerDag.Text = "1";
            this.tbMeetingenPerDag.TextChanged += new System.EventHandler(this.tbMeetingenPerDag_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dit is/zijn";
            // 
            // cbTijdsEenheid
            // 
            this.cbTijdsEenheid.FormattingEnabled = true;
            this.cbTijdsEenheid.Items.AddRange(new object[] {
            "Seconde",
            "Minuut",
            "Uur",
            "Dag",
            "Week",
            "Maand",
            "Jaar"});
            this.cbTijdsEenheid.Location = new System.Drawing.Point(204, 18);
            this.cbTijdsEenheid.Name = "cbTijdsEenheid";
            this.cbTijdsEenheid.Size = new System.Drawing.Size(94, 21);
            this.cbTijdsEenheid.TabIndex = 1;
            this.cbTijdsEenheid.Text = "Dag";
            this.cbTijdsEenheid.SelectedIndexChanged += new System.EventHandler(this.cbTijdsEenheid_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Meetingen elk(e):";
            // 
            // gbGenereerDatums
            // 
            this.gbGenereerDatums.Controls.Add(this.label5);
            this.gbGenereerDatums.Controls.Add(this.tbGeneerDatums);
            this.gbGenereerDatums.Controls.Add(this.label4);
            this.gbGenereerDatums.Controls.Add(this.label2);
            this.gbGenereerDatums.Controls.Add(this.label3);
            this.gbGenereerDatums.Controls.Add(this.dtpGenereerVan);
            this.gbGenereerDatums.Controls.Add(this.dtpGenereerTot);
            this.gbGenereerDatums.Location = new System.Drawing.Point(8, 13);
            this.gbGenereerDatums.Name = "gbGenereerDatums";
            this.gbGenereerDatums.Size = new System.Drawing.Size(792, 79);
            this.gbGenereerDatums.TabIndex = 7;
            this.gbGenereerDatums.TabStop = false;
            this.gbGenereerDatums.Text = "Datums";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(642, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "dag(en)";
            // 
            // tbGeneerDatums
            // 
            this.tbGeneerDatums.Location = new System.Drawing.Point(569, 41);
            this.tbGeneerDatums.MaxLength = 6;
            this.tbGeneerDatums.Name = "tbGeneerDatums";
            this.tbGeneerDatums.Size = new System.Drawing.Size(67, 20);
            this.tbGeneerDatums.TabIndex = 8;
            this.tbGeneerDatums.Text = "1";
            this.tbGeneerDatums.TextChanged += new System.EventHandler(this.tbMeetingenPerDag_TextChanged);
            this.tbGeneerDatums.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbGeneerDatums_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dit is/zijn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Van:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tot:";
            // 
            // dtpGenereerVan
            // 
            this.dtpGenereerVan.Location = new System.Drawing.Point(9, 41);
            this.dtpGenereerVan.Name = "dtpGenereerVan";
            this.dtpGenereerVan.Size = new System.Drawing.Size(200, 20);
            this.dtpGenereerVan.TabIndex = 3;
            this.dtpGenereerVan.ValueChanged += new System.EventHandler(this.dtpGenereerVan_ValueChanged);
            // 
            // dtpGenereerTot
            // 
            this.dtpGenereerTot.Location = new System.Drawing.Point(243, 41);
            this.dtpGenereerTot.Name = "dtpGenereerTot";
            this.dtpGenereerTot.Size = new System.Drawing.Size(200, 20);
            this.dtpGenereerTot.TabIndex = 4;
            this.dtpGenereerTot.ValueChanged += new System.EventHandler(this.dtpGenereerVan_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 493);
            this.Controls.Add(this.tabControl1);
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
            this.tabGenereerMeetingen.ResumeLayout(false);
            this.gbGenereer.ResumeLayout(false);
            this.gbGenereer.PerformLayout();
            this.gbGenereerOpties.ResumeLayout(false);
            this.gbGenereerOpties.PerformLayout();
            this.gbGenereerAantalDecimalen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudADGrondvochtigheid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudADLuchtvochtigheid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudADTemperatuur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudADLichtintensiteit)).EndInit();
            this.gbGenereerMax.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxGrondvochtigheid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLuchtvochtigheid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTemperatuur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLichtintensiteit)).EndInit();
            this.gbGenereerMin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinGrondvochtigheid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLuchtvochtigheid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinTemperatuur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLichtintensiteit)).EndInit();
            this.gbInterval.ResumeLayout(false);
            this.gbInterval.PerformLayout();
            this.gbGenereerDatums.ResumeLayout(false);
            this.gbGenereerDatums.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabGraphs;
        private System.Windows.Forms.TabPage TabLiveFeed;
        private System.Windows.Forms.TabPage TabLogin;
        private System.Windows.Forms.TabPage tabLogs;

        private System.Windows.Forms.TextBox TxtLogging;
        private System.Windows.Forms.DateTimePicker dtpGraphTot;
        private System.Windows.Forms.DateTimePicker dtpGraphVan;
        private System.Windows.Forms.Panel pnlGrafiek;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.CheckBox cbGrondvochtigheid2;
        private System.Windows.Forms.CheckBox cbGrondvochtigheid1;
        private System.Windows.Forms.CheckBox cbLuchtvochtigheid;
        private System.Windows.Forms.CheckBox cbTemperatuur;
        private System.Windows.Forms.CheckBox cbLichtintensiteit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMeetingen;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabGenereerMeetingen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTijdsEenheid;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.GroupBox gbGenereerDatums;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbGeneerDatums;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpGenereerVan;
        private System.Windows.Forms.DateTimePicker dtpGenereerTot;
        private System.Windows.Forms.GroupBox gbInterval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMeetingenPerDag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbGenereer;
        private System.Windows.Forms.GroupBox gbGenereerOpties;
        private System.Windows.Forms.GroupBox gbGenereerMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudMinTemperatuur;
        private System.Windows.Forms.NumericUpDown nudMinLichtintensiteit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudMinGrondvochtigheid;
        private System.Windows.Forms.NumericUpDown nudMinLuchtvochtigheid;
        private System.Windows.Forms.TextBox tbGenereerTotaalAantalMeetingen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGenereerMeetingen;
        private System.Windows.Forms.CheckBox cbVervangDB;
        private System.Windows.Forms.GroupBox gbGenereerAantalDecimalen;
        private System.Windows.Forms.NumericUpDown nudADGrondvochtigheid;
        private System.Windows.Forms.NumericUpDown nudADLuchtvochtigheid;
        private System.Windows.Forms.NumericUpDown nudADTemperatuur;
        private System.Windows.Forms.NumericUpDown nudADLichtintensiteit;
        private System.Windows.Forms.GroupBox gbGenereerMax;
        private System.Windows.Forms.NumericUpDown nudMaxGrondvochtigheid;
        private System.Windows.Forms.NumericUpDown nudMaxLuchtvochtigheid;
        private System.Windows.Forms.NumericUpDown nudMaxTemperatuur;
        private System.Windows.Forms.NumericUpDown nudMaxLichtintensiteit;
    }
}