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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabLogin = new System.Windows.Forms.TabPage();
            this.BtnDataArduino = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnAddPlantsoort = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPlantsoortNaam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbPlantNummer = new System.Windows.Forms.ComboBox();
            this.BtnConnect = new System.Windows.Forms.Button();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.TxtLogging = new System.Windows.Forms.RichTextBox();
            this.tabGenereerMeetingen = new System.Windows.Forms.TabPage();
            this.gbGenereer = new System.Windows.Forms.GroupBox();
            this.tbGenereerTotaalAantalMeetingen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGenereerMeetingen = new System.Windows.Forms.Button();
            this.gbGenereerOpties = new System.Windows.Forms.GroupBox();
            this.cbVervangDB = new System.Windows.Forms.CheckBox();
            this.gbGenereerAantalDecimalen = new System.Windows.Forms.GroupBox();
            this.nudADGrondvochtigheid = new System.Windows.Forms.NumericUpDown();
            this.nudADTemperatuur = new System.Windows.Forms.NumericUpDown();
            this.nudADLichtintensiteit = new System.Windows.Forms.NumericUpDown();
            this.gbGenereerMax = new System.Windows.Forms.GroupBox();
            this.nudMaxGrondvochtigheid = new System.Windows.Forms.NumericUpDown();
            this.nudMaxTemperatuur = new System.Windows.Forms.NumericUpDown();
            this.nudMaxLichtintensiteit = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbGenereerMin = new System.Windows.Forms.GroupBox();
            this.nudMinGrondvochtigheid = new System.Windows.Forms.NumericUpDown();
            this.nudMinTemperatuur = new System.Windows.Forms.NumericUpDown();
            this.nudMinLichtintensiteit = new System.Windows.Forms.NumericUpDown();
            this.gbInterval = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.tbMeetingenPerDag = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbTijdsEenheid = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gbGenereerDatums = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbGeneerDatums = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpGenereerVan = new System.Windows.Forms.DateTimePicker();
            this.dtpGenereerTot = new System.Windows.Forms.DateTimePicker();
            this.TabGraphs = new System.Windows.Forms.TabPage();
            this.gbGraphPeriode = new System.Windows.Forms.GroupBox();
            this.dtpGraphVan = new System.Windows.Forms.DateTimePicker();
            this.dtpGraphTot = new System.Windows.Forms.DateTimePicker();
            this.gbGraphData = new System.Windows.Forms.GroupBox();
            this.cbLichtintensiteit = new System.Windows.Forms.CheckBox();
            this.cbGrondvochtigheid2 = new System.Windows.Forms.CheckBox();
            this.cbTemperatuur = new System.Windows.Forms.CheckBox();
            this.cbGrondvochtigheid1 = new System.Windows.Forms.CheckBox();
            this.chartMetingen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OfdDatafile = new System.Windows.Forms.OpenFileDialog();
            this.readMessageTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.TabLogin.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudWater)).BeginInit();
            this.tabLogs.SuspendLayout();
            this.tabGenereerMeetingen.SuspendLayout();
            this.gbGenereer.SuspendLayout();
            this.gbGenereerOpties.SuspendLayout();
            this.gbGenereerAantalDecimalen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudADGrondvochtigheid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudADTemperatuur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudADLichtintensiteit)).BeginInit();
            this.gbGenereerMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxGrondvochtigheid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTemperatuur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLichtintensiteit)).BeginInit();
            this.gbGenereerMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinGrondvochtigheid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinTemperatuur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLichtintensiteit)).BeginInit();
            this.gbInterval.SuspendLayout();
            this.gbGenereerDatums.SuspendLayout();
            this.TabGraphs.SuspendLayout();
            this.gbGraphPeriode.SuspendLayout();
            this.gbGraphData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMetingen)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabLogin);
            this.tabControl1.Controls.Add(this.TabGraphs);
            this.tabControl1.Controls.Add(this.tabGenereerMeetingen);
            this.tabControl1.Controls.Add(this.tabLogs);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 491);
            this.tabControl1.TabIndex = 0;
            // 
            // TabLogin
            // 
            this.TabLogin.Controls.Add(this.BtnDataArduino);
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
            // BtnDataArduino
            // 
            this.BtnDataArduino.Enabled = false;
            this.BtnDataArduino.Location = new System.Drawing.Point(9, 435);
            this.BtnDataArduino.Name = "BtnDataArduino";
            this.BtnDataArduino.Size = new System.Drawing.Size(139, 23);
            this.BtnDataArduino.TabIndex = 17;
            this.BtnDataArduino.Text = "Lees data van arduino";
            this.BtnDataArduino.UseVisualStyleBackColor = true;
            this.BtnDataArduino.Click += new System.EventHandler(this.BtnDataArduino_Click);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Plant nummer:";
            // 
            // CbPlantNummer
            // 
            this.CbPlantNummer.FormattingEnabled = true;
            this.CbPlantNummer.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CbPlantNummer.Location = new System.Drawing.Point(9, 350);
            this.CbPlantNummer.Name = "CbPlantNummer";
            this.CbPlantNummer.Size = new System.Drawing.Size(138, 21);
            this.CbPlantNummer.TabIndex = 13;
            this.CbPlantNummer.Text = "1";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(9, 377);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(139, 23);
            this.BtnConnect.TabIndex = 12;
            this.BtnConnect.Text = "Connect to Arduino";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
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
            this.BtnSendPlant.Location = new System.Drawing.Point(9, 406);
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
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 183);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Planten";
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
            // tabGenereerMeetingen
            // 
            this.tabGenereerMeetingen.Controls.Add(this.gbGenereer);
            this.tabGenereerMeetingen.Controls.Add(this.gbInterval);
            this.tabGenereerMeetingen.Controls.Add(this.gbGenereerDatums);
            this.tabGenereerMeetingen.Location = new System.Drawing.Point(4, 22);
            this.tabGenereerMeetingen.Name = "tabGenereerMeetingen";
            this.tabGenereerMeetingen.Size = new System.Drawing.Size(805, 465);
            this.tabGenereerMeetingen.TabIndex = 5;
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
            this.tbGenereerTotaalAantalMeetingen.Location = new System.Drawing.Point(255, 200);
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
            this.label8.Size = new System.Drawing.Size(243, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Totaal aantal (geschatte) meetingen te genereren:";
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
            this.gbGenereerOpties.Controls.Add(this.label10);
            this.gbGenereerOpties.Controls.Add(this.label9);
            this.gbGenereerOpties.Controls.Add(this.gbGenereerMin);
            this.gbGenereerOpties.Location = new System.Drawing.Point(9, 28);
            this.gbGenereerOpties.Name = "gbGenereerOpties";
            this.gbGenereerOpties.Size = new System.Drawing.Size(777, 132);
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
            this.gbGenereerAantalDecimalen.Controls.Add(this.nudADTemperatuur);
            this.gbGenereerAantalDecimalen.Controls.Add(this.nudADLichtintensiteit);
            this.gbGenereerAantalDecimalen.Location = new System.Drawing.Point(314, 17);
            this.gbGenereerAantalDecimalen.Name = "gbGenereerAantalDecimalen";
            this.gbGenereerAantalDecimalen.Size = new System.Drawing.Size(107, 99);
            this.gbGenereerAantalDecimalen.TabIndex = 6;
            this.gbGenereerAantalDecimalen.TabStop = false;
            this.gbGenereerAantalDecimalen.Text = "Aantal Decimalen";
            // 
            // nudADGrondvochtigheid
            // 
            this.nudADGrondvochtigheid.Location = new System.Drawing.Point(6, 68);
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
            this.gbGenereerMax.Controls.Add(this.nudMaxTemperatuur);
            this.gbGenereerMax.Controls.Add(this.nudMaxLichtintensiteit);
            this.gbGenereerMax.Location = new System.Drawing.Point(210, 17);
            this.gbGenereerMax.Name = "gbGenereerMax";
            this.gbGenereerMax.Size = new System.Drawing.Size(98, 99);
            this.gbGenereerMax.TabIndex = 4;
            this.gbGenereerMax.TabStop = false;
            this.gbGenereerMax.Text = "Max Waarde";
            // 
            // nudMaxGrondvochtigheid
            // 
            this.nudMaxGrondvochtigheid.Location = new System.Drawing.Point(6, 68);
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
            this.label11.Location = new System.Drawing.Point(6, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Grondvochtigheid:";
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
            this.gbGenereerMin.Controls.Add(this.nudMinTemperatuur);
            this.gbGenereerMin.Controls.Add(this.nudMinLichtintensiteit);
            this.gbGenereerMin.Location = new System.Drawing.Point(106, 17);
            this.gbGenereerMin.Name = "gbGenereerMin";
            this.gbGenereerMin.Size = new System.Drawing.Size(98, 99);
            this.gbGenereerMin.TabIndex = 2;
            this.gbGenereerMin.TabStop = false;
            this.gbGenereerMin.Text = "Min Waarde";
            // 
            // nudMinGrondvochtigheid
            // 
            this.nudMinGrondvochtigheid.Location = new System.Drawing.Point(6, 68);
            this.nudMinGrondvochtigheid.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMinGrondvochtigheid.Name = "nudMinGrondvochtigheid";
            this.nudMinGrondvochtigheid.Size = new System.Drawing.Size(86, 20);
            this.nudMinGrondvochtigheid.TabIndex = 3;
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
            this.gbInterval.Controls.Add(this.label7);
            this.gbInterval.Controls.Add(this.tbInterval);
            this.gbInterval.Controls.Add(this.tbMeetingenPerDag);
            this.gbInterval.Controls.Add(this.label13);
            this.gbInterval.Controls.Add(this.cbTijdsEenheid);
            this.gbInterval.Controls.Add(this.label14);
            this.gbInterval.Location = new System.Drawing.Point(8, 125);
            this.gbInterval.Name = "gbInterval";
            this.gbInterval.Size = new System.Drawing.Size(792, 52);
            this.gbInterval.TabIndex = 8;
            this.gbInterval.TabStop = false;
            this.gbInterval.Text = "Interval";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(642, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "meetingen/dag";
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(513, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Dit is/zijn";
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
            this.cbTijdsEenheid.SelectedIndexChanged += new System.EventHandler(this.cbTijdsEenheid_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(115, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Meetingen elk(e):";
            // 
            // gbGenereerDatums
            // 
            this.gbGenereerDatums.Controls.Add(this.label15);
            this.gbGenereerDatums.Controls.Add(this.tbGeneerDatums);
            this.gbGenereerDatums.Controls.Add(this.label16);
            this.gbGenereerDatums.Controls.Add(this.label17);
            this.gbGenereerDatums.Controls.Add(this.label18);
            this.gbGenereerDatums.Controls.Add(this.dtpGenereerVan);
            this.gbGenereerDatums.Controls.Add(this.dtpGenereerTot);
            this.gbGenereerDatums.Location = new System.Drawing.Point(8, 13);
            this.gbGenereerDatums.Name = "gbGenereerDatums";
            this.gbGenereerDatums.Size = new System.Drawing.Size(792, 79);
            this.gbGenereerDatums.TabIndex = 7;
            this.gbGenereerDatums.TabStop = false;
            this.gbGenereerDatums.Text = "Datums";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(642, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "dag(en)";
            // 
            // tbGeneerDatums
            // 
            this.tbGeneerDatums.Location = new System.Drawing.Point(569, 41);
            this.tbGeneerDatums.MaxLength = 6;
            this.tbGeneerDatums.Name = "tbGeneerDatums";
            this.tbGeneerDatums.Size = new System.Drawing.Size(67, 20);
            this.tbGeneerDatums.TabIndex = 8;
            this.tbGeneerDatums.Text = "1";
            this.tbGeneerDatums.TextChanged += new System.EventHandler(this.tbGeneerDatums_TextChanged);
            this.tbGeneerDatums.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbGeneerDatums_KeyUp);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(513, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Dit is/zijn";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Van:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(240, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Tot:";
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
            // TabGraphs
            // 
            this.TabGraphs.Controls.Add(this.gbGraphPeriode);
            this.TabGraphs.Controls.Add(this.gbGraphData);
            this.TabGraphs.Controls.Add(this.chartMetingen);
            this.TabGraphs.Location = new System.Drawing.Point(4, 22);
            this.TabGraphs.Name = "TabGraphs";
            this.TabGraphs.Padding = new System.Windows.Forms.Padding(3);
            this.TabGraphs.Size = new System.Drawing.Size(805, 465);
            this.TabGraphs.TabIndex = 6;
            this.TabGraphs.Text = "Graphs";
            this.TabGraphs.UseVisualStyleBackColor = true;
            // 
            // gbGraphPeriode
            // 
            this.gbGraphPeriode.Controls.Add(this.dtpGraphVan);
            this.gbGraphPeriode.Controls.Add(this.dtpGraphTot);
            this.gbGraphPeriode.Location = new System.Drawing.Point(8, 7);
            this.gbGraphPeriode.Name = "gbGraphPeriode";
            this.gbGraphPeriode.Size = new System.Drawing.Size(423, 54);
            this.gbGraphPeriode.TabIndex = 7;
            this.gbGraphPeriode.TabStop = false;
            this.gbGraphPeriode.Text = "Periode";
            // 
            // dtpGraphVan
            // 
            this.dtpGraphVan.Location = new System.Drawing.Point(6, 19);
            this.dtpGraphVan.Name = "dtpGraphVan";
            this.dtpGraphVan.Size = new System.Drawing.Size(200, 20);
            this.dtpGraphVan.TabIndex = 1;
            this.dtpGraphVan.ValueChanged += new System.EventHandler(this.dtpGraphVan_ValueChanged);
            // 
            // dtpGraphTot
            // 
            this.dtpGraphTot.Location = new System.Drawing.Point(212, 19);
            this.dtpGraphTot.Name = "dtpGraphTot";
            this.dtpGraphTot.Size = new System.Drawing.Size(200, 20);
            this.dtpGraphTot.TabIndex = 2;
            this.dtpGraphTot.ValueChanged += new System.EventHandler(this.dtpGraphVan_ValueChanged);
            // 
            // gbGraphData
            // 
            this.gbGraphData.Controls.Add(this.cbLichtintensiteit);
            this.gbGraphData.Controls.Add(this.cbGrondvochtigheid2);
            this.gbGraphData.Controls.Add(this.cbTemperatuur);
            this.gbGraphData.Controls.Add(this.cbGrondvochtigheid1);
            this.gbGraphData.Location = new System.Drawing.Point(8, 67);
            this.gbGraphData.Name = "gbGraphData";
            this.gbGraphData.Size = new System.Drawing.Size(141, 106);
            this.gbGraphData.TabIndex = 6;
            this.gbGraphData.TabStop = false;
            this.gbGraphData.Text = "Data";
            // 
            // cbLichtintensiteit
            // 
            this.cbLichtintensiteit.AutoSize = true;
            this.cbLichtintensiteit.Location = new System.Drawing.Point(5, 18);
            this.cbLichtintensiteit.Margin = new System.Windows.Forms.Padding(2);
            this.cbLichtintensiteit.Name = "cbLichtintensiteit";
            this.cbLichtintensiteit.Size = new System.Drawing.Size(93, 17);
            this.cbLichtintensiteit.TabIndex = 0;
            this.cbLichtintensiteit.Text = "Lichtintensiteit";
            this.cbLichtintensiteit.UseVisualStyleBackColor = true;
            this.cbLichtintensiteit.CheckedChanged += new System.EventHandler(this.cbLichtintensiteit_CheckedChanged);
            // 
            // cbGrondvochtigheid2
            // 
            this.cbGrondvochtigheid2.AutoSize = true;
            this.cbGrondvochtigheid2.Location = new System.Drawing.Point(5, 83);
            this.cbGrondvochtigheid2.Margin = new System.Windows.Forms.Padding(2);
            this.cbGrondvochtigheid2.Name = "cbGrondvochtigheid2";
            this.cbGrondvochtigheid2.Size = new System.Drawing.Size(119, 17);
            this.cbGrondvochtigheid2.TabIndex = 4;
            this.cbGrondvochtigheid2.Text = "Grondvochtigheid 2";
            this.cbGrondvochtigheid2.UseVisualStyleBackColor = true;
            this.cbGrondvochtigheid2.CheckedChanged += new System.EventHandler(this.cbLichtintensiteit_CheckedChanged);
            // 
            // cbTemperatuur
            // 
            this.cbTemperatuur.AutoSize = true;
            this.cbTemperatuur.Location = new System.Drawing.Point(5, 40);
            this.cbTemperatuur.Margin = new System.Windows.Forms.Padding(2);
            this.cbTemperatuur.Name = "cbTemperatuur";
            this.cbTemperatuur.Size = new System.Drawing.Size(86, 17);
            this.cbTemperatuur.TabIndex = 1;
            this.cbTemperatuur.Text = "Temperatuur";
            this.cbTemperatuur.UseVisualStyleBackColor = true;
            this.cbTemperatuur.CheckedChanged += new System.EventHandler(this.cbLichtintensiteit_CheckedChanged);
            // 
            // cbGrondvochtigheid1
            // 
            this.cbGrondvochtigheid1.AutoSize = true;
            this.cbGrondvochtigheid1.Location = new System.Drawing.Point(5, 61);
            this.cbGrondvochtigheid1.Margin = new System.Windows.Forms.Padding(2);
            this.cbGrondvochtigheid1.Name = "cbGrondvochtigheid1";
            this.cbGrondvochtigheid1.Size = new System.Drawing.Size(119, 17);
            this.cbGrondvochtigheid1.TabIndex = 3;
            this.cbGrondvochtigheid1.Text = "Grondvochtigheid 1";
            this.cbGrondvochtigheid1.UseVisualStyleBackColor = true;
            this.cbGrondvochtigheid1.CheckedChanged += new System.EventHandler(this.cbLichtintensiteit_CheckedChanged);
            // 
            // chartMetingen
            // 
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 95F;
            chartArea2.Position.Width = 84F;
            chartArea2.Position.X = 16F;
            chartArea2.Position.Y = 3F;
            this.chartMetingen.ChartAreas.Add(chartArea2);
            legend2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Left;
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 16.8798F;
            legend2.Position.Width = 22.13622F;
            legend2.Position.Y = 31F;
            this.chartMetingen.Legends.Add(legend2);
            this.chartMetingen.Location = new System.Drawing.Point(8, 67);
            this.chartMetingen.Margin = new System.Windows.Forms.Padding(2);
            this.chartMetingen.Name = "chartMetingen";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Lichtintensiteit";
            series5.ToolTip = "\"L: #VAL{P1}\"";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Temperatuur";
            series6.ToolTip = "\"T: #VAL{P1}\"";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Grondvochtigheid1";
            series7.ToolTip = "\"G1: #VAL{P1}\"";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "Grondvochtigheid2";
            series8.ToolTip = "\"G2: #VAL{P1}\"";
            series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chartMetingen.Series.Add(series5);
            this.chartMetingen.Series.Add(series6);
            this.chartMetingen.Series.Add(series7);
            this.chartMetingen.Series.Add(series8);
            this.chartMetingen.Size = new System.Drawing.Size(793, 392);
            this.chartMetingen.TabIndex = 4;
            this.chartMetingen.Text = "Metingen";
            // 
            // readMessageTimer
            // 
            this.readMessageTimer.Enabled = true;
            this.readMessageTimer.Interval = 10;
            this.readMessageTimer.Tick += new System.EventHandler(this.readMessageTimer_Tick);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabLogin.ResumeLayout(false);
            this.TabLogin.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudWater)).EndInit();
            this.tabLogs.ResumeLayout(false);
            this.tabGenereerMeetingen.ResumeLayout(false);
            this.gbGenereer.ResumeLayout(false);
            this.gbGenereer.PerformLayout();
            this.gbGenereerOpties.ResumeLayout(false);
            this.gbGenereerOpties.PerformLayout();
            this.gbGenereerAantalDecimalen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudADGrondvochtigheid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudADTemperatuur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudADLichtintensiteit)).EndInit();
            this.gbGenereerMax.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxGrondvochtigheid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTemperatuur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLichtintensiteit)).EndInit();
            this.gbGenereerMin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinGrondvochtigheid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinTemperatuur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLichtintensiteit)).EndInit();
            this.gbInterval.ResumeLayout(false);
            this.gbInterval.PerformLayout();
            this.gbGenereerDatums.ResumeLayout(false);
            this.gbGenereerDatums.PerformLayout();
            this.TabGraphs.ResumeLayout(false);
            this.gbGraphPeriode.ResumeLayout(false);
            this.gbGraphData.ResumeLayout(false);
            this.gbGraphData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMetingen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
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
        private System.Windows.Forms.OpenFileDialog OfdDatafile;
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
        private System.Windows.Forms.Button BtnDataArduino;
        private System.Windows.Forms.TabPage tabGenereerMeetingen;
        private System.Windows.Forms.GroupBox gbGenereer;
        private System.Windows.Forms.TextBox tbGenereerTotaalAantalMeetingen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGenereerMeetingen;
        private System.Windows.Forms.GroupBox gbGenereerOpties;
        private System.Windows.Forms.CheckBox cbVervangDB;
        private System.Windows.Forms.GroupBox gbGenereerAantalDecimalen;
        private System.Windows.Forms.NumericUpDown nudADGrondvochtigheid;
        private System.Windows.Forms.NumericUpDown nudADTemperatuur;
        private System.Windows.Forms.NumericUpDown nudADLichtintensiteit;
        private System.Windows.Forms.GroupBox gbGenereerMax;
        private System.Windows.Forms.NumericUpDown nudMaxGrondvochtigheid;
        private System.Windows.Forms.NumericUpDown nudMaxTemperatuur;
        private System.Windows.Forms.NumericUpDown nudMaxLichtintensiteit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbGenereerMin;
        private System.Windows.Forms.NumericUpDown nudMinGrondvochtigheid;
        private System.Windows.Forms.NumericUpDown nudMinTemperatuur;
        private System.Windows.Forms.NumericUpDown nudMinLichtintensiteit;
        private System.Windows.Forms.GroupBox gbInterval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.TextBox tbMeetingenPerDag;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbTijdsEenheid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbGenereerDatums;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbGeneerDatums;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpGenereerVan;
        private System.Windows.Forms.DateTimePicker dtpGenereerTot;
        private System.Windows.Forms.TabPage TabGraphs;
        private System.Windows.Forms.CheckBox cbGrondvochtigheid2;
        private System.Windows.Forms.CheckBox cbGrondvochtigheid1;
        private System.Windows.Forms.CheckBox cbTemperatuur;
        private System.Windows.Forms.CheckBox cbLichtintensiteit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMetingen;
        private System.Windows.Forms.DateTimePicker dtpGraphTot;
        private System.Windows.Forms.DateTimePicker dtpGraphVan;
        private System.Windows.Forms.GroupBox gbGraphPeriode;
        private System.Windows.Forms.GroupBox gbGraphData;
    }
}

