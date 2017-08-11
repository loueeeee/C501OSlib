namespace DesignTry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.AddProcess = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtBurst = new System.Windows.Forms.TextBox();
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataInitial = new System.Windows.Forms.DataGridView();
            this.lblFinished = new System.Windows.Forms.GroupBox();
            this.dataFinished = new System.Windows.Forms.DataGridView();
            this.FinishedPId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnaroundTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaitingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataReady = new System.Windows.Forms.DataGridView();
            this.ReadyPId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingBurst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ttaLbl = new System.Windows.Forms.Label();
            this.wtaveLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ganttChartPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.currentLbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SimulateBtn = new System.Windows.Forms.Button();
            this.remTimeCounterLbl = new System.Windows.Forms.Label();
            this.remLbl = new System.Windows.Forms.Label();
            this.FormTextAnimator = new System.ComponentModel.BackgroundWorker();
            this.AlgorithmBox = new System.Windows.Forms.ComboBox();
            this.AutoSimulateTimer = new System.Windows.Forms.Timer(this.components);
            this.AutoSimulateWorker = new System.ComponentModel.BackgroundWorker();
            this.speedBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbProcLimit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArriveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BurstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInitial)).BeginInit();
            this.lblFinished.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFinished)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataReady)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resetBtn);
            this.groupBox1.Controls.Add(this.AddProcess);
            this.groupBox1.Controls.Add(this.btnEnter);
            this.groupBox1.Controls.Add(this.txtBurst);
            this.groupBox1.Controls.Add(this.txtArrival);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter a process:";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(6, 103);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(62, 23);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // AddProcess
            // 
            this.AddProcess.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProcess.ForeColor = System.Drawing.Color.White;
            this.AddProcess.Location = new System.Drawing.Point(152, 103);
            this.AddProcess.Name = "AddProcess";
            this.AddProcess.Size = new System.Drawing.Size(60, 23);
            this.AddProcess.TabIndex = 2;
            this.AddProcess.Text = "Insert";
            this.AddProcess.UseVisualStyleBackColor = false;
            this.AddProcess.Click += new System.EventHandler(this.AddProcess_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(79, 103);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(62, 23);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Auto Fill";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.autoFillbtn_click);
            // 
            // txtBurst
            // 
            this.txtBurst.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBurst.ForeColor = System.Drawing.Color.Black;
            this.txtBurst.Location = new System.Drawing.Point(114, 68);
            this.txtBurst.Name = "txtBurst";
            this.txtBurst.Size = new System.Drawing.Size(69, 21);
            this.txtBurst.TabIndex = 1;
            this.txtBurst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBurst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numOnly_KeyPress);
            // 
            // txtArrival
            // 
            this.txtArrival.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArrival.ForeColor = System.Drawing.Color.Black;
            this.txtArrival.Location = new System.Drawing.Point(114, 28);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(69, 21);
            this.txtArrival.TabIndex = 0;
            this.txtArrival.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArrival.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numOnly_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Burst Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arrival Time:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dataInitial);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(267, 147);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 311);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INITIAL QUEUE";
            // 
            // dataInitial
            // 
            this.dataInitial.AllowUserToAddRows = false;
            this.dataInitial.AllowUserToDeleteRows = false;
            this.dataInitial.AllowUserToResizeColumns = false;
            this.dataInitial.AllowUserToResizeRows = false;
            this.dataInitial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataInitial.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataInitial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataInitial.ColumnHeadersHeight = 34;
            this.dataInitial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataInitial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PId,
            this.ArriveTime,
            this.BurstTime,
            this.Prio});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataInitial.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataInitial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataInitial.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataInitial.Location = new System.Drawing.Point(6, 19);
            this.dataInitial.MultiSelect = false;
            this.dataInitial.Name = "dataInitial";
            this.dataInitial.RowHeadersVisible = false;
            this.dataInitial.Size = new System.Drawing.Size(234, 286);
            this.dataInitial.TabIndex = 0;
            this.dataInitial.TabStop = false;
            // 
            // lblFinished
            // 
            this.lblFinished.Controls.Add(this.dataFinished);
            this.lblFinished.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinished.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFinished.Location = new System.Drawing.Point(753, 147);
            this.lblFinished.Name = "lblFinished";
            this.lblFinished.Size = new System.Drawing.Size(410, 311);
            this.lblFinished.TabIndex = 2;
            this.lblFinished.TabStop = false;
            this.lblFinished.Text = "FINISHED PROCESS";
            // 
            // dataFinished
            // 
            this.dataFinished.AllowUserToAddRows = false;
            this.dataFinished.AllowUserToDeleteRows = false;
            this.dataFinished.AllowUserToResizeColumns = false;
            this.dataFinished.AllowUserToResizeRows = false;
            this.dataFinished.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFinished.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataFinished.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataFinished.ColumnHeadersHeight = 34;
            this.dataFinished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataFinished.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FinishedPId,
            this.StartTime,
            this.TimeFin,
            this.TurnaroundTime,
            this.WaitingTime});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataFinished.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataFinished.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataFinished.Location = new System.Drawing.Point(6, 19);
            this.dataFinished.MultiSelect = false;
            this.dataFinished.Name = "dataFinished";
            this.dataFinished.RowHeadersVisible = false;
            this.dataFinished.Size = new System.Drawing.Size(398, 283);
            this.dataFinished.TabIndex = 1;
            this.dataFinished.TabStop = false;
            // 
            // FinishedPId
            // 
            this.FinishedPId.HeaderText = "Process ID";
            this.FinishedPId.Name = "FinishedPId";
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.Name = "StartTime";
            // 
            // TimeFin
            // 
            this.TimeFin.HeaderText = "Time Finished";
            this.TimeFin.Name = "TimeFin";
            // 
            // TurnaroundTime
            // 
            this.TurnaroundTime.HeaderText = "Turnaround Time";
            this.TurnaroundTime.Name = "TurnaroundTime";
            // 
            // WaitingTime
            // 
            this.WaitingTime.HeaderText = "Waiting Time";
            this.WaitingTime.Name = "WaitingTime";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataReady);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(519, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(228, 311);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "READY QUEUE";
            // 
            // dataReady
            // 
            this.dataReady.AllowUserToAddRows = false;
            this.dataReady.AllowUserToDeleteRows = false;
            this.dataReady.AllowUserToResizeColumns = false;
            this.dataReady.AllowUserToResizeRows = false;
            this.dataReady.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataReady.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataReady.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataReady.ColumnHeadersHeight = 34;
            this.dataReady.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataReady.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReadyPId,
            this.ArrivalTime,
            this.RemainingBurst});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataReady.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataReady.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataReady.Location = new System.Drawing.Point(6, 19);
            this.dataReady.MultiSelect = false;
            this.dataReady.Name = "dataReady";
            this.dataReady.RowHeadersVisible = false;
            this.dataReady.Size = new System.Drawing.Size(216, 286);
            this.dataReady.TabIndex = 0;
            this.dataReady.TabStop = false;
            // 
            // ReadyPId
            // 
            this.ReadyPId.HeaderText = "Process ID";
            this.ReadyPId.Name = "ReadyPId";
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.HeaderText = "Arrival Time";
            this.ArrivalTime.Name = "ArrivalTime";
            // 
            // RemainingBurst
            // 
            this.RemainingBurst.HeaderText = "Remaining Burst";
            this.RemainingBurst.Name = "RemainingBurst";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPU Scheduler Simulator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time: ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(102, 210);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(32, 33);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Average Turnaround Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Average Waiting Time:";
            // 
            // ttaLbl
            // 
            this.ttaLbl.AutoSize = true;
            this.ttaLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttaLbl.Location = new System.Drawing.Point(187, 351);
            this.ttaLbl.Name = "ttaLbl";
            this.ttaLbl.Size = new System.Drawing.Size(15, 16);
            this.ttaLbl.TabIndex = 8;
            this.ttaLbl.Text = "0";
            // 
            // wtaveLbl
            // 
            this.wtaveLbl.AutoSize = true;
            this.wtaveLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wtaveLbl.Location = new System.Drawing.Point(161, 320);
            this.wtaveLbl.Name = "wtaveLbl";
            this.wtaveLbl.Size = new System.Drawing.Size(15, 16);
            this.wtaveLbl.TabIndex = 9;
            this.wtaveLbl.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(268, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Gantt Chart";
            // 
            // ganttChartPanel
            // 
            this.ganttChartPanel.AutoScroll = true;
            this.ganttChartPanel.Location = new System.Drawing.Point(273, 58);
            this.ganttChartPanel.Name = "ganttChartPanel";
            this.ganttChartPanel.Size = new System.Drawing.Size(891, 83);
            this.ganttChartPanel.TabIndex = 11;
            this.ganttChartPanel.WrapContents = false;
            // 
            // currentLbl
            // 
            this.currentLbl.AutoSize = true;
            this.currentLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLbl.Location = new System.Drawing.Point(123, 258);
            this.currentLbl.Name = "currentLbl";
            this.currentLbl.Size = new System.Drawing.Size(18, 16);
            this.currentLbl.TabIndex = 13;
            this.currentLbl.Text = "--";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Current Process:";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(20, 410);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 28);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_click);
            // 
            // SimulateBtn
            // 
            this.SimulateBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SimulateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SimulateBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimulateBtn.ForeColor = System.Drawing.Color.White;
            this.SimulateBtn.Location = new System.Drawing.Point(126, 410);
            this.SimulateBtn.Name = "SimulateBtn";
            this.SimulateBtn.Size = new System.Drawing.Size(88, 28);
            this.SimulateBtn.TabIndex = 6;
            this.SimulateBtn.Text = "Auto Simulate";
            this.SimulateBtn.UseVisualStyleBackColor = false;
            this.SimulateBtn.Click += new System.EventHandler(this.simulateBtn_Click);
            // 
            // remTimeCounterLbl
            // 
            this.remTimeCounterLbl.AutoSize = true;
            this.remTimeCounterLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remTimeCounterLbl.Location = new System.Drawing.Point(123, 289);
            this.remTimeCounterLbl.Name = "remTimeCounterLbl";
            this.remTimeCounterLbl.Size = new System.Drawing.Size(15, 16);
            this.remTimeCounterLbl.TabIndex = 17;
            this.remTimeCounterLbl.Text = "0";
            // 
            // remLbl
            // 
            this.remLbl.AutoSize = true;
            this.remLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remLbl.Location = new System.Drawing.Point(17, 289);
            this.remLbl.Name = "remLbl";
            this.remLbl.Size = new System.Drawing.Size(106, 16);
            this.remLbl.TabIndex = 16;
            this.remLbl.Text = "Remaining Burst:";
            // 
            // FormTextAnimator
            // 
            this.FormTextAnimator.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FormTextAnimator_DoWork);
            // 
            // AlgorithmBox
            // 
            this.AlgorithmBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AlgorithmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlgorithmBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlgorithmBox.ForeColor = System.Drawing.Color.White;
            this.AlgorithmBox.FormattingEnabled = true;
            this.AlgorithmBox.Location = new System.Drawing.Point(12, 38);
            this.AlgorithmBox.Name = "AlgorithmBox";
            this.AlgorithmBox.Size = new System.Drawing.Size(119, 21);
            this.AlgorithmBox.TabIndex = 18;
            this.AlgorithmBox.TabStop = false;
            this.AlgorithmBox.SelectedIndexChanged += new System.EventHandler(this.AlgorithmBox_SelectedIndexChanged);
            // 
            // AutoSimulateTimer
            // 
            this.AutoSimulateTimer.Tick += new System.EventHandler(this.AutoSimulateTimer_Tick);
            // 
            // AutoSimulateWorker
            // 
            this.AutoSimulateWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AutoSimulateWorker_DoWork);
            // 
            // speedBox
            // 
            this.speedBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.speedBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speedBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speedBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedBox.ForeColor = System.Drawing.Color.White;
            this.speedBox.FormattingEnabled = true;
            this.speedBox.Items.AddRange(new object[] {
            "1000",
            "500",
            "250",
            "125"});
            this.speedBox.Location = new System.Drawing.Point(164, 380);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(76, 24);
            this.speedBox.TabIndex = 19;
            this.speedBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Simulate Speed (in ms)";
            // 
            // tbProcLimit
            // 
            this.tbProcLimit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProcLimit.Location = new System.Drawing.Point(194, 39);
            this.tbProcLimit.Name = "tbProcLimit";
            this.tbProcLimit.Size = new System.Drawing.Size(35, 21);
            this.tbProcLimit.TabIndex = 21;
            this.tbProcLimit.Text = "10";
            this.tbProcLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbProcLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numOnly_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Max Limit:";
            // 
            // PId
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.PId.DefaultCellStyle = dataGridViewCellStyle18;
            this.PId.HeaderText = "Process ID";
            this.PId.Name = "PId";
            // 
            // ArriveTime
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ArriveTime.DefaultCellStyle = dataGridViewCellStyle19;
            this.ArriveTime.HeaderText = "Arrival Time";
            this.ArriveTime.Name = "ArriveTime";
            // 
            // BurstTime
            // 
            this.BurstTime.HeaderText = "Burst Time";
            this.BurstTime.Name = "BurstTime";
            // 
            // Prio
            // 
            this.Prio.HeaderText = "Priority Level";
            this.Prio.Name = "Prio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1176, 468);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbProcLimit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.AlgorithmBox);
            this.Controls.Add(this.remTimeCounterLbl);
            this.Controls.Add(this.remLbl);
            this.Controls.Add(this.SimulateBtn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.currentLbl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ganttChartPanel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.wtaveLbl);
            this.Controls.Add(this.ttaLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFinished);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C501 - JAPANESE CORN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataInitial)).EndInit();
            this.lblFinished.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFinished)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataReady)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtBurst;
        private System.Windows.Forms.TextBox txtArrival;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox lblFinished;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ttaLbl;
        private System.Windows.Forms.Label wtaveLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel ganttChartPanel;
        private System.Windows.Forms.Label currentLbl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button SimulateBtn;
        private System.Windows.Forms.DataGridView dataInitial;
        private System.Windows.Forms.DataGridView dataReady;
        private System.Windows.Forms.DataGridView dataFinished;
        private System.Windows.Forms.Button AddProcess;
        private System.Windows.Forms.Label remTimeCounterLbl;
        private System.Windows.Forms.Label remLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReadyPId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingBurst;
        private System.ComponentModel.BackgroundWorker FormTextAnimator;
        private System.Windows.Forms.ComboBox AlgorithmBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishedPId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnaroundTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaitingTime;
        private System.Windows.Forms.Timer AutoSimulateTimer;
        private System.ComponentModel.BackgroundWorker AutoSimulateWorker;
        private System.Windows.Forms.ComboBox speedBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbProcLimit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn PId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArriveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BurstTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prio;
        private System.Windows.Forms.Button resetBtn;
    }
}

