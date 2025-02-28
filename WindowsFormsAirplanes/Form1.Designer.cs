﻿
namespace WindowsFormsAirplanes
{
    partial class FormRunwayController
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabControl tabControlAirplanes;
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.buttonGenerateSchedule = new System.Windows.Forms.Button();
            this.buttonManualShedule = new System.Windows.Forms.Button();
            this.buttonTypesWithDurations = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxModulationMode = new System.Windows.Forms.ComboBox();
            this.labelModulationStepMode = new System.Windows.Forms.Label();
            this.comboBoxRunwayMaintenanceTime = new System.Windows.Forms.ComboBox();
            this.labelRunwayMaintenanceTime = new System.Windows.Forms.Label();
            this.comboBoxModulationStartTimeMinutes = new System.Windows.Forms.ComboBox();
            this.comboBoxModulationStep = new System.Windows.Forms.ComboBox();
            this.labelModulationStep = new System.Windows.Forms.Label();
            this.comboBoxModulationStartTimeHours = new System.Windows.Forms.ComboBox();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.comboBoxAmountOfRunways = new System.Windows.Forms.ComboBox();
            this.labelAmountOfRunways = new System.Windows.Forms.Label();
            this.tabPageRunways = new System.Windows.Forms.TabPage();
            this.labelRunwayStatus = new System.Windows.Forms.Label();
            this.labelRunwayNumber = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPageDepartureQueue = new System.Windows.Forms.TabPage();
            this.tabPageArrivalQueue = new System.Windows.Forms.TabPage();
            this.tabPageDepartureSchedule = new System.Windows.Forms.TabPage();
            this.dataGridViewDepartureSchedule = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Airline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Airplane_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageArrivalSchedule = new System.Windows.Forms.TabPage();
            this.dataGridViewArrivalSchedule = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageStatistics = new System.Windows.Forms.TabPage();
            this.openFileDialogAirplanesWithTheirTypes = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogTypesWithDurations = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogSchedule = new System.Windows.Forms.OpenFileDialog();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.buttonNextStep = new System.Windows.Forms.Button();
            this.labelNowTime = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.buttonHelp = new System.Windows.Forms.Button();
            tabControlAirplanes = new System.Windows.Forms.TabControl();
            tabControlAirplanes.SuspendLayout();
            this.tabPageData.SuspendLayout();
            this.tabPageRunways.SuspendLayout();
            this.tabPageDepartureSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartureSchedule)).BeginInit();
            this.tabPageArrivalSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrivalSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAirplanes
            // 
            tabControlAirplanes.Controls.Add(this.tabPageData);
            tabControlAirplanes.Controls.Add(this.tabPageRunways);
            tabControlAirplanes.Controls.Add(this.tabPageDepartureQueue);
            tabControlAirplanes.Controls.Add(this.tabPageArrivalQueue);
            tabControlAirplanes.Controls.Add(this.tabPageDepartureSchedule);
            tabControlAirplanes.Controls.Add(this.tabPageArrivalSchedule);
            tabControlAirplanes.Controls.Add(this.tabPageStatistics);
            tabControlAirplanes.Dock = System.Windows.Forms.DockStyle.Left;
            tabControlAirplanes.Location = new System.Drawing.Point(0, 0);
            tabControlAirplanes.Name = "tabControlAirplanes";
            tabControlAirplanes.SelectedIndex = 0;
            tabControlAirplanes.Size = new System.Drawing.Size(829, 550);
            tabControlAirplanes.TabIndex = 0;
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.statusStrip1);
            this.tabPageData.Controls.Add(this.buttonGenerateSchedule);
            this.tabPageData.Controls.Add(this.buttonManualShedule);
            this.tabPageData.Controls.Add(this.buttonTypesWithDurations);
            this.tabPageData.Controls.Add(this.buttonStart);
            this.tabPageData.Controls.Add(this.comboBoxModulationMode);
            this.tabPageData.Controls.Add(this.labelModulationStepMode);
            this.tabPageData.Controls.Add(this.comboBoxRunwayMaintenanceTime);
            this.tabPageData.Controls.Add(this.labelRunwayMaintenanceTime);
            this.tabPageData.Controls.Add(this.comboBoxModulationStartTimeMinutes);
            this.tabPageData.Controls.Add(this.comboBoxModulationStep);
            this.tabPageData.Controls.Add(this.labelModulationStep);
            this.tabPageData.Controls.Add(this.comboBoxModulationStartTimeHours);
            this.tabPageData.Controls.Add(this.labelStartTime);
            this.tabPageData.Controls.Add(this.comboBoxAmountOfRunways);
            this.tabPageData.Controls.Add(this.labelAmountOfRunways);
            this.tabPageData.Location = new System.Drawing.Point(4, 29);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageData.Size = new System.Drawing.Size(821, 517);
            this.tabPageData.TabIndex = 6;
            this.tabPageData.Text = "Data";
            this.tabPageData.UseVisualStyleBackColor = true;
            this.tabPageData.Click += new System.EventHandler(this.tabPageData_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(3, 492);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(815, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // buttonGenerateSchedule
            // 
            this.buttonGenerateSchedule.Location = new System.Drawing.Point(423, 268);
            this.buttonGenerateSchedule.Name = "buttonGenerateSchedule";
            this.buttonGenerateSchedule.Size = new System.Drawing.Size(341, 39);
            this.buttonGenerateSchedule.TabIndex = 20;
            this.buttonGenerateSchedule.Text = "generate schedule";
            this.buttonGenerateSchedule.UseVisualStyleBackColor = true;
            this.buttonGenerateSchedule.Click += new System.EventHandler(this.buttonGenerateSchedule_Click);
            // 
            // buttonManualShedule
            // 
            this.buttonManualShedule.Location = new System.Drawing.Point(18, 268);
            this.buttonManualShedule.Name = "buttonManualShedule";
            this.buttonManualShedule.Size = new System.Drawing.Size(368, 39);
            this.buttonManualShedule.TabIndex = 19;
            this.buttonManualShedule.Text = "choose file with schedule";
            this.buttonManualShedule.UseVisualStyleBackColor = true;
            this.buttonManualShedule.Click += new System.EventHandler(this.buttonManualShedule_Click);
            // 
            // buttonTypesWithDurations
            // 
            this.buttonTypesWithDurations.Location = new System.Drawing.Point(18, 165);
            this.buttonTypesWithDurations.Name = "buttonTypesWithDurations";
            this.buttonTypesWithDurations.Size = new System.Drawing.Size(368, 58);
            this.buttonTypesWithDurations.TabIndex = 18;
            this.buttonTypesWithDurations.Text = "choose file where written types with durations of departure and arrival";
            this.buttonTypesWithDurations.UseVisualStyleBackColor = true;
            this.buttonTypesWithDurations.Click += new System.EventHandler(this.buttonTypesWithDurations_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(348, 341);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(111, 51);
            this.buttonStart.TabIndex = 16;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxModulationMode
            // 
            this.comboBoxModulationMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModulationMode.FormattingEnabled = true;
            this.comboBoxModulationMode.Items.AddRange(new object[] {
            "automatic",
            "manual"});
            this.comboBoxModulationMode.Location = new System.Drawing.Point(599, 184);
            this.comboBoxModulationMode.Name = "comboBoxModulationMode";
            this.comboBoxModulationMode.Size = new System.Drawing.Size(165, 28);
            this.comboBoxModulationMode.TabIndex = 10;
            this.comboBoxModulationMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxModulationMode_SelectedIndexChanged);
            // 
            // labelModulationStepMode
            // 
            this.labelModulationStepMode.AutoSize = true;
            this.labelModulationStepMode.Location = new System.Drawing.Point(419, 184);
            this.labelModulationStepMode.Name = "labelModulationStepMode";
            this.labelModulationStepMode.Size = new System.Drawing.Size(174, 20);
            this.labelModulationStepMode.TabIndex = 9;
            this.labelModulationStepMode.Text = "modulation step mode: ";
            // 
            // comboBoxRunwayMaintenanceTime
            // 
            this.comboBoxRunwayMaintenanceTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRunwayMaintenanceTime.FormattingEnabled = true;
            this.comboBoxRunwayMaintenanceTime.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.comboBoxRunwayMaintenanceTime.Location = new System.Drawing.Point(292, 80);
            this.comboBoxRunwayMaintenanceTime.Name = "comboBoxRunwayMaintenanceTime";
            this.comboBoxRunwayMaintenanceTime.Size = new System.Drawing.Size(94, 28);
            this.comboBoxRunwayMaintenanceTime.TabIndex = 8;
            this.comboBoxRunwayMaintenanceTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxRunwayMaintenanceTime_SelectedIndexChanged);
            // 
            // labelRunwayMaintenanceTime
            // 
            this.labelRunwayMaintenanceTime.AutoSize = true;
            this.labelRunwayMaintenanceTime.Location = new System.Drawing.Point(24, 83);
            this.labelRunwayMaintenanceTime.Name = "labelRunwayMaintenanceTime";
            this.labelRunwayMaintenanceTime.Size = new System.Drawing.Size(197, 20);
            this.labelRunwayMaintenanceTime.TabIndex = 7;
            this.labelRunwayMaintenanceTime.Text = "runway maintenance time: ";
            this.labelRunwayMaintenanceTime.Click += new System.EventHandler(this.labelRunwayMaintenanceTime_Click);
            // 
            // comboBoxModulationStartTimeMinutes
            // 
            this.comboBoxModulationStartTimeMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModulationStartTimeMinutes.FormattingEnabled = true;
            this.comboBoxModulationStartTimeMinutes.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.comboBoxModulationStartTimeMinutes.Location = new System.Drawing.Point(691, 11);
            this.comboBoxModulationStartTimeMinutes.Name = "comboBoxModulationStartTimeMinutes";
            this.comboBoxModulationStartTimeMinutes.Size = new System.Drawing.Size(73, 28);
            this.comboBoxModulationStartTimeMinutes.TabIndex = 6;
            this.comboBoxModulationStartTimeMinutes.SelectedIndexChanged += new System.EventHandler(this.comboBoxModulationStartTimeMinutes_SelectedIndexChanged);
            // 
            // comboBoxModulationStep
            // 
            this.comboBoxModulationStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModulationStep.FormattingEnabled = true;
            this.comboBoxModulationStep.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.comboBoxModulationStep.Location = new System.Drawing.Point(618, 99);
            this.comboBoxModulationStep.Name = "comboBoxModulationStep";
            this.comboBoxModulationStep.Size = new System.Drawing.Size(146, 28);
            this.comboBoxModulationStep.TabIndex = 5;
            this.comboBoxModulationStep.SelectedIndexChanged += new System.EventHandler(this.comboBoxModulationStep_SelectedIndexChanged);
            // 
            // labelModulationStep
            // 
            this.labelModulationStep.AutoSize = true;
            this.labelModulationStep.Location = new System.Drawing.Point(428, 102);
            this.labelModulationStep.Name = "labelModulationStep";
            this.labelModulationStep.Size = new System.Drawing.Size(130, 20);
            this.labelModulationStep.TabIndex = 4;
            this.labelModulationStep.Text = "modulation step: ";
            // 
            // comboBoxModulationStartTimeHours
            // 
            this.comboBoxModulationStartTimeHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModulationStartTimeHours.FormattingEnabled = true;
            this.comboBoxModulationStartTimeHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBoxModulationStartTimeHours.Location = new System.Drawing.Point(607, 11);
            this.comboBoxModulationStartTimeHours.Name = "comboBoxModulationStartTimeHours";
            this.comboBoxModulationStartTimeHours.Size = new System.Drawing.Size(78, 28);
            this.comboBoxModulationStartTimeHours.TabIndex = 3;
            this.comboBoxModulationStartTimeHours.SelectedIndexChanged += new System.EventHandler(this.comboBoxModulationStartTimeHours_SelectedIndexChanged);
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(428, 14);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(165, 20);
            this.labelStartTime.TabIndex = 2;
            this.labelStartTime.Text = "modulation start time: ";
            this.labelStartTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxAmountOfRunways
            // 
            this.comboBoxAmountOfRunways.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAmountOfRunways.FormattingEnabled = true;
            this.comboBoxAmountOfRunways.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxAmountOfRunways.Location = new System.Drawing.Point(265, 20);
            this.comboBoxAmountOfRunways.Name = "comboBoxAmountOfRunways";
            this.comboBoxAmountOfRunways.Size = new System.Drawing.Size(121, 28);
            this.comboBoxAmountOfRunways.TabIndex = 1;
            this.comboBoxAmountOfRunways.SelectedIndexChanged += new System.EventHandler(this.comboBoxAmountOfRunways_SelectedIndexChanged);
            // 
            // labelAmountOfRunways
            // 
            this.labelAmountOfRunways.AutoSize = true;
            this.labelAmountOfRunways.Location = new System.Drawing.Point(24, 23);
            this.labelAmountOfRunways.Name = "labelAmountOfRunways";
            this.labelAmountOfRunways.Size = new System.Drawing.Size(151, 20);
            this.labelAmountOfRunways.TabIndex = 0;
            this.labelAmountOfRunways.Text = "amount of runways: ";
            // 
            // tabPageRunways
            // 
            this.tabPageRunways.Controls.Add(this.labelRunwayStatus);
            this.tabPageRunways.Controls.Add(this.labelRunwayNumber);
            this.tabPageRunways.Controls.Add(this.tableLayoutPanel1);
            this.tabPageRunways.Location = new System.Drawing.Point(4, 29);
            this.tabPageRunways.Name = "tabPageRunways";
            this.tabPageRunways.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRunways.Size = new System.Drawing.Size(821, 517);
            this.tabPageRunways.TabIndex = 0;
            this.tabPageRunways.Text = "Runways";
            this.tabPageRunways.UseVisualStyleBackColor = true;
            // 
            // labelRunwayStatus
            // 
            this.labelRunwayStatus.AutoSize = true;
            this.labelRunwayStatus.Location = new System.Drawing.Point(350, 28);
            this.labelRunwayStatus.Name = "labelRunwayStatus";
            this.labelRunwayStatus.Size = new System.Drawing.Size(56, 20);
            this.labelRunwayStatus.TabIndex = 2;
            this.labelRunwayStatus.Text = "Status";
            // 
            // labelRunwayNumber
            // 
            this.labelRunwayNumber.AutoSize = true;
            this.labelRunwayNumber.Location = new System.Drawing.Point(57, 28);
            this.labelRunwayNumber.Name = "labelRunwayNumber";
            this.labelRunwayNumber.Size = new System.Drawing.Size(124, 20);
            this.labelRunwayNumber.TabIndex = 1;
            this.labelRunwayNumber.Text = "Runway number";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.32609F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.67391F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(551, 436);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabPageDepartureQueue
            // 
            this.tabPageDepartureQueue.Location = new System.Drawing.Point(4, 29);
            this.tabPageDepartureQueue.Name = "tabPageDepartureQueue";
            this.tabPageDepartureQueue.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepartureQueue.Size = new System.Drawing.Size(821, 517);
            this.tabPageDepartureQueue.TabIndex = 1;
            this.tabPageDepartureQueue.Text = "Departure queue";
            this.tabPageDepartureQueue.UseVisualStyleBackColor = true;
            // 
            // tabPageArrivalQueue
            // 
            this.tabPageArrivalQueue.Location = new System.Drawing.Point(4, 29);
            this.tabPageArrivalQueue.Name = "tabPageArrivalQueue";
            this.tabPageArrivalQueue.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArrivalQueue.Size = new System.Drawing.Size(821, 517);
            this.tabPageArrivalQueue.TabIndex = 2;
            this.tabPageArrivalQueue.Text = "Arrival queue";
            this.tabPageArrivalQueue.UseVisualStyleBackColor = true;
            // 
            // tabPageDepartureSchedule
            // 
            this.tabPageDepartureSchedule.Controls.Add(this.dataGridViewDepartureSchedule);
            this.tabPageDepartureSchedule.Location = new System.Drawing.Point(4, 29);
            this.tabPageDepartureSchedule.Name = "tabPageDepartureSchedule";
            this.tabPageDepartureSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepartureSchedule.Size = new System.Drawing.Size(821, 517);
            this.tabPageDepartureSchedule.TabIndex = 3;
            this.tabPageDepartureSchedule.Text = "Departure schedule";
            this.tabPageDepartureSchedule.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDepartureSchedule
            // 
            this.dataGridViewDepartureSchedule.AllowUserToAddRows = false;
            this.dataGridViewDepartureSchedule.AllowUserToDeleteRows = false;
            this.dataGridViewDepartureSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewDepartureSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartureSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Flight,
            this.Airline,
            this.Airplane_type,
            this.Status});
            this.dataGridViewDepartureSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDepartureSchedule.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDepartureSchedule.Name = "dataGridViewDepartureSchedule";
            this.dataGridViewDepartureSchedule.ReadOnly = true;
            this.dataGridViewDepartureSchedule.RowHeadersWidth = 62;
            this.dataGridViewDepartureSchedule.RowTemplate.Height = 28;
            this.dataGridViewDepartureSchedule.Size = new System.Drawing.Size(815, 511);
            this.dataGridViewDepartureSchedule.TabIndex = 1;
            this.dataGridViewDepartureSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Time
            // 
            this.Time.Frozen = true;
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 8;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 79;
            // 
            // Flight
            // 
            this.Flight.Frozen = true;
            this.Flight.HeaderText = "Flight";
            this.Flight.MinimumWidth = 8;
            this.Flight.Name = "Flight";
            this.Flight.ReadOnly = true;
            this.Flight.Width = 84;
            // 
            // Airline
            // 
            this.Airline.Frozen = true;
            this.Airline.HeaderText = "Airline";
            this.Airline.MinimumWidth = 8;
            this.Airline.Name = "Airline";
            this.Airline.ReadOnly = true;
            this.Airline.Width = 88;
            // 
            // Airplane_type
            // 
            this.Airplane_type.Frozen = true;
            this.Airplane_type.HeaderText = "Airplane type";
            this.Airplane_type.MinimumWidth = 8;
            this.Airplane_type.Name = "Airplane_type";
            this.Airplane_type.ReadOnly = true;
            this.Airplane_type.Width = 137;
            // 
            // Status
            // 
            this.Status.Frozen = true;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 92;
            // 
            // tabPageArrivalSchedule
            // 
            this.tabPageArrivalSchedule.Controls.Add(this.dataGridViewArrivalSchedule);
            this.tabPageArrivalSchedule.Location = new System.Drawing.Point(4, 29);
            this.tabPageArrivalSchedule.Name = "tabPageArrivalSchedule";
            this.tabPageArrivalSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArrivalSchedule.Size = new System.Drawing.Size(821, 517);
            this.tabPageArrivalSchedule.TabIndex = 4;
            this.tabPageArrivalSchedule.Text = "Arrival schedule";
            this.tabPageArrivalSchedule.UseVisualStyleBackColor = true;
            // 
            // dataGridViewArrivalSchedule
            // 
            this.dataGridViewArrivalSchedule.AllowUserToAddRows = false;
            this.dataGridViewArrivalSchedule.AllowUserToDeleteRows = false;
            this.dataGridViewArrivalSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewArrivalSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArrivalSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridViewArrivalSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewArrivalSchedule.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewArrivalSchedule.Name = "dataGridViewArrivalSchedule";
            this.dataGridViewArrivalSchedule.ReadOnly = true;
            this.dataGridViewArrivalSchedule.RowHeadersWidth = 62;
            this.dataGridViewArrivalSchedule.RowTemplate.Height = 28;
            this.dataGridViewArrivalSchedule.Size = new System.Drawing.Size(815, 511);
            this.dataGridViewArrivalSchedule.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Time";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 79;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Flight";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 84;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Airline";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 88;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Airplane type";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 137;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Status";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 92;
            // 
            // tabPageStatistics
            // 
            this.tabPageStatistics.Location = new System.Drawing.Point(4, 29);
            this.tabPageStatistics.Name = "tabPageStatistics";
            this.tabPageStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatistics.Size = new System.Drawing.Size(821, 517);
            this.tabPageStatistics.TabIndex = 5;
            this.tabPageStatistics.Text = "Statistics";
            this.tabPageStatistics.UseVisualStyleBackColor = true;
            // 
            // openFileDialogAirplanesWithTheirTypes
            // 
            this.openFileDialogAirplanesWithTheirTypes.FileName = "openFileDialogAirplanesWithTypes";
            this.openFileDialogAirplanesWithTheirTypes.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogAirplanesWithTheirTypes_FileOk);
            // 
            // openFileDialogTypesWithDurations
            // 
            this.openFileDialogTypesWithDurations.FileName = "openFileDialogTypesWithDurations";
            // 
            // openFileDialogSchedule
            // 
            this.openFileDialogSchedule.FileName = "openFileDialogSchedule";
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Location = new System.Drawing.Point(844, 42);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(101, 20);
            this.labelCurrentTime.TabIndex = 1;
            this.labelCurrentTime.Text = "current time: ";
            this.labelCurrentTime.Click += new System.EventHandler(this.labelCurrentTime_Click);
            // 
            // buttonNextStep
            // 
            this.buttonNextStep.Location = new System.Drawing.Point(848, 89);
            this.buttonNextStep.Name = "buttonNextStep";
            this.buttonNextStep.Size = new System.Drawing.Size(152, 33);
            this.buttonNextStep.TabIndex = 5;
            this.buttonNextStep.Text = "next step";
            this.buttonNextStep.UseVisualStyleBackColor = true;
            this.buttonNextStep.Click += new System.EventHandler(this.buttonNextStep_Click);
            // 
            // labelNowTime
            // 
            this.labelNowTime.AutoSize = true;
            this.labelNowTime.Location = new System.Drawing.Point(951, 42);
            this.labelNowTime.Name = "labelNowTime";
            this.labelNowTime.Size = new System.Drawing.Size(49, 20);
            this.labelNowTime.TabIndex = 6;
            this.labelNowTime.Text = "00:00";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(881, 507);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(104, 36);
            this.buttonHelp.TabIndex = 7;
            this.buttonHelp.Text = "help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // FormRunwayController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 550);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.labelNowTime);
            this.Controls.Add(this.buttonNextStep);
            this.Controls.Add(this.labelCurrentTime);
            this.Controls.Add(tabControlAirplanes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormRunwayController";
            this.Text = "RunwayController";
            this.Load += new System.EventHandler(this.FormRunwayController_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormRunwayController_HelpRequested);
            tabControlAirplanes.ResumeLayout(false);
            this.tabPageData.ResumeLayout(false);
            this.tabPageData.PerformLayout();
            this.tabPageRunways.ResumeLayout(false);
            this.tabPageRunways.PerformLayout();
            this.tabPageDepartureSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartureSchedule)).EndInit();
            this.tabPageArrivalSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrivalSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageRunways;
        private System.Windows.Forms.TabPage tabPageDepartureQueue;
        private System.Windows.Forms.TabPage tabPageArrivalQueue;
        private System.Windows.Forms.TabPage tabPageDepartureSchedule;
        private System.Windows.Forms.TabPage tabPageArrivalSchedule;
        private System.Windows.Forms.TabPage tabPageStatistics;
        private System.Windows.Forms.TabPage tabPageData;
        private System.Windows.Forms.Label labelAmountOfRunways;
        private System.Windows.Forms.ComboBox comboBoxAmountOfRunways;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.ComboBox comboBoxModulationStartTimeMinutes;
        private System.Windows.Forms.ComboBox comboBoxModulationStep;
        private System.Windows.Forms.Label labelModulationStep;
        private System.Windows.Forms.ComboBox comboBoxModulationStartTimeHours;
        private System.Windows.Forms.ComboBox comboBoxModulationMode;
        private System.Windows.Forms.Label labelModulationStepMode;
        private System.Windows.Forms.ComboBox comboBoxRunwayMaintenanceTime;
        private System.Windows.Forms.Label labelRunwayMaintenanceTime;
        private System.Windows.Forms.Button buttonGenerateSchedule;
        private System.Windows.Forms.Button buttonManualShedule;
        private System.Windows.Forms.Button buttonTypesWithDurations;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.OpenFileDialog openFileDialogAirplanesWithTheirTypes;
        private System.Windows.Forms.OpenFileDialog openFileDialogTypesWithDurations;
        private System.Windows.Forms.OpenFileDialog openFileDialogSchedule;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Button buttonNextStep;
        private System.Windows.Forms.Label labelNowTime;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelRunwayStatus;
        private System.Windows.Forms.Label labelRunwayNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewDepartureSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Airline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Airplane_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridView dataGridViewArrivalSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

