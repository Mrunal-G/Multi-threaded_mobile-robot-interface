﻿namespace trObject1
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
            this.btn_Begin = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTrackingObject = new System.Windows.Forms.Button();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            this.sp = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.btnDriveForward = new System.Windows.Forms.Button();
            this.btnStopRobot = new System.Windows.Forms.Button();
            this.btnDriftRight = new System.Windows.Forms.Button();
            this.btnRotateLeft20Deg = new System.Windows.Forms.Button();
            this.btnRotateRight20Deg = new System.Windows.Forms.Button();
            this.btnDriveRight = new System.Windows.Forms.Button();
            this.btnDriftLeft = new System.Windows.Forms.Button();
            this.btnDriveLeft = new System.Windows.Forms.Button();
            this.btnBackRight = new System.Windows.Forms.Button();
            this.btnbackLeft = new System.Windows.Forms.Button();
            this.btnDriveBack = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.BatteryStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Begin
            // 
            this.btn_Begin.Location = new System.Drawing.Point(101, 64);
            this.btn_Begin.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Begin.Name = "btn_Begin";
            this.btn_Begin.Size = new System.Drawing.Size(150, 44);
            this.btn_Begin.TabIndex = 0;
            this.btn_Begin.Text = "Begin";
            this.btn_Begin.UseVisualStyleBackColor = true;
            this.btn_Begin.Click += new System.EventHandler(this.btn_Begin_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(299, 71);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 33);
            this.comboBox1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(150, 285);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1516, 735);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(746, 723);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(764, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(746, 723);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnTrackingObject
            // 
            this.btnTrackingObject.Location = new System.Drawing.Point(608, 64);
            this.btnTrackingObject.Margin = new System.Windows.Forms.Padding(6);
            this.btnTrackingObject.Name = "btnTrackingObject";
            this.btnTrackingObject.Size = new System.Drawing.Size(150, 44);
            this.btnTrackingObject.TabIndex = 5;
            this.btnTrackingObject.Text = "TrObject";
            this.btnTrackingObject.UseVisualStyleBackColor = true;
            this.btnTrackingObject.Click += new System.EventHandler(this.btnTrackingObject_Click);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(903, 30);
            this.trackBarRed.Margin = new System.Windows.Forms.Padding(6);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(556, 90);
            this.trackBarRed.TabIndex = 6;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(903, 105);
            this.trackBarGreen.Margin = new System.Windows.Forms.Padding(6);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(550, 90);
            this.trackBarGreen.TabIndex = 7;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(903, 165);
            this.trackBarBlue.Margin = new System.Windows.Forms.Padding(6);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(550, 90);
            this.trackBarBlue.TabIndex = 8;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(815, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(814, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(815, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Blue";
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Location = new System.Drawing.Point(1537, 52);
            this.numericUpDownRed.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(234, 31);
            this.numericUpDownRed.TabIndex = 12;
            this.numericUpDownRed.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Location = new System.Drawing.Point(1531, 118);
            this.numericUpDownGreen.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(240, 31);
            this.numericUpDownGreen.TabIndex = 13;
            this.numericUpDownGreen.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Location = new System.Drawing.Point(1537, 179);
            this.numericUpDownBlue.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(240, 31);
            this.numericUpDownBlue.TabIndex = 14;
            this.numericUpDownBlue.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // sp
            // 
            this.sp.BaudRate = 115200;
            this.sp.PortName = "COM8";
            this.sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sp_DataReceived);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(1713, 285);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(506, 297);
            this.textBox.TabIndex = 15;
            this.textBox.Text = "Manual Control";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(2274, 285);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbData.Size = new System.Drawing.Size(510, 416);
            this.tbData.TabIndex = 16;
            this.tbData.Text = "Autonomous path";
            this.tbData.TextChanged += new System.EventHandler(this.tbData_TextChanged);
            // 
            // btnDriveForward
            // 
            this.btnDriveForward.Location = new System.Drawing.Point(1713, 608);
            this.btnDriveForward.Margin = new System.Windows.Forms.Padding(4);
            this.btnDriveForward.Name = "btnDriveForward";
            this.btnDriveForward.Size = new System.Drawing.Size(144, 75);
            this.btnDriveForward.TabIndex = 17;
            this.btnDriveForward.Text = "Drive Forward";
            this.btnDriveForward.UseVisualStyleBackColor = true;
            this.btnDriveForward.Click += new System.EventHandler(this.btnDriveForward_Click);
            // 
            // btnStopRobot
            // 
            this.btnStopRobot.Location = new System.Drawing.Point(1881, 608);
            this.btnStopRobot.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopRobot.Name = "btnStopRobot";
            this.btnStopRobot.Size = new System.Drawing.Size(144, 75);
            this.btnStopRobot.TabIndex = 18;
            this.btnStopRobot.Text = "Stop Robot";
            this.btnStopRobot.UseVisualStyleBackColor = true;
            this.btnStopRobot.Click += new System.EventHandler(this.btnStopRobot_Click);
            // 
            // btnDriftRight
            // 
            this.btnDriftRight.Location = new System.Drawing.Point(2056, 608);
            this.btnDriftRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnDriftRight.Name = "btnDriftRight";
            this.btnDriftRight.Size = new System.Drawing.Size(144, 75);
            this.btnDriftRight.TabIndex = 19;
            this.btnDriftRight.Text = "Drift Right";
            this.btnDriftRight.UseVisualStyleBackColor = true;
            this.btnDriftRight.Click += new System.EventHandler(this.btnDriftRight_Click);
            // 
            // btnRotateLeft20Deg
            // 
            this.btnRotateLeft20Deg.Location = new System.Drawing.Point(1713, 708);
            this.btnRotateLeft20Deg.Margin = new System.Windows.Forms.Padding(4);
            this.btnRotateLeft20Deg.Name = "btnRotateLeft20Deg";
            this.btnRotateLeft20Deg.Size = new System.Drawing.Size(144, 75);
            this.btnRotateLeft20Deg.TabIndex = 22;
            this.btnRotateLeft20Deg.Text = "Rotate Left 20 Deg";
            this.btnRotateLeft20Deg.UseVisualStyleBackColor = true;
            this.btnRotateLeft20Deg.Click += new System.EventHandler(this.btnRotateLeft20Deg_Click);
            // 
            // btnRotateRight20Deg
            // 
            this.btnRotateRight20Deg.Location = new System.Drawing.Point(1881, 708);
            this.btnRotateRight20Deg.Margin = new System.Windows.Forms.Padding(4);
            this.btnRotateRight20Deg.Name = "btnRotateRight20Deg";
            this.btnRotateRight20Deg.Size = new System.Drawing.Size(144, 75);
            this.btnRotateRight20Deg.TabIndex = 23;
            this.btnRotateRight20Deg.Text = "Rotate Right 20 Deg";
            this.btnRotateRight20Deg.UseVisualStyleBackColor = true;
            this.btnRotateRight20Deg.Click += new System.EventHandler(this.btnRotateRight20Deg_Click);
            // 
            // btnDriveRight
            // 
            this.btnDriveRight.Location = new System.Drawing.Point(2056, 708);
            this.btnDriveRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnDriveRight.Name = "btnDriveRight";
            this.btnDriveRight.Size = new System.Drawing.Size(144, 75);
            this.btnDriveRight.TabIndex = 24;
            this.btnDriveRight.Text = "Drive Right";
            this.btnDriveRight.UseVisualStyleBackColor = true;
            this.btnDriveRight.Click += new System.EventHandler(this.btnDriveRight_Click);
            // 
            // btnDriftLeft
            // 
            this.btnDriftLeft.Location = new System.Drawing.Point(1713, 815);
            this.btnDriftLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnDriftLeft.Name = "btnDriftLeft";
            this.btnDriftLeft.Size = new System.Drawing.Size(144, 75);
            this.btnDriftLeft.TabIndex = 25;
            this.btnDriftLeft.Text = "Drift Left";
            this.btnDriftLeft.UseVisualStyleBackColor = true;
            this.btnDriftLeft.Click += new System.EventHandler(this.btnDriftLeft_Click);
            // 
            // btnDriveLeft
            // 
            this.btnDriveLeft.Location = new System.Drawing.Point(1881, 815);
            this.btnDriveLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnDriveLeft.Name = "btnDriveLeft";
            this.btnDriveLeft.Size = new System.Drawing.Size(144, 75);
            this.btnDriveLeft.TabIndex = 26;
            this.btnDriveLeft.Text = "Drive Left";
            this.btnDriveLeft.UseVisualStyleBackColor = true;
            this.btnDriveLeft.Click += new System.EventHandler(this.btnDriveLeft_Click);
            // 
            // btnBackRight
            // 
            this.btnBackRight.Location = new System.Drawing.Point(2056, 815);
            this.btnBackRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackRight.Name = "btnBackRight";
            this.btnBackRight.Size = new System.Drawing.Size(144, 75);
            this.btnBackRight.TabIndex = 27;
            this.btnBackRight.Text = "Back Right";
            this.btnBackRight.UseVisualStyleBackColor = true;
            this.btnBackRight.Click += new System.EventHandler(this.btnBackRight_Click);
            // 
            // btnbackLeft
            // 
            this.btnbackLeft.Location = new System.Drawing.Point(1713, 907);
            this.btnbackLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnbackLeft.Name = "btnbackLeft";
            this.btnbackLeft.Size = new System.Drawing.Size(144, 75);
            this.btnbackLeft.TabIndex = 28;
            this.btnbackLeft.Text = "Back Left";
            this.btnbackLeft.UseVisualStyleBackColor = true;
            this.btnbackLeft.Click += new System.EventHandler(this.btnbackLeft_Click);
            // 
            // btnDriveBack
            // 
            this.btnDriveBack.Location = new System.Drawing.Point(1881, 907);
            this.btnDriveBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnDriveBack.Name = "btnDriveBack";
            this.btnDriveBack.Size = new System.Drawing.Size(144, 75);
            this.btnDriveBack.TabIndex = 29;
            this.btnDriveBack.Text = "Drive Back";
            this.btnDriveBack.UseVisualStyleBackColor = true;
            this.btnDriveBack.Click += new System.EventHandler(this.btnDriveBack_Click);
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(2051, 907);
            this.btnM.Margin = new System.Windows.Forms.Padding(4);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(168, 75);
            this.btnM.TabIndex = 30;
            this.btnM.Text = "M : Direct Motor Control";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(2274, 126);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(489, 77);
            this.progressBar1.TabIndex = 31;
            this.progressBar1.Value = 100;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Chartreuse;
            this.btnStart.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(2284, 769);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(232, 137);
            this.btnStart.TabIndex = 38;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.BackColor = System.Drawing.Color.Crimson;
            this.btnAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbort.Location = new System.Drawing.Point(2554, 769);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(230, 137);
            this.btnAbort.TabIndex = 39;
            this.btnAbort.Text = "ABORT !";
            this.btnAbort.UseVisualStyleBackColor = false;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // BatteryStatus
            // 
            this.BatteryStatus.AutoSize = true;
            this.BatteryStatus.Location = new System.Drawing.Point(2165, 148);
            this.BatteryStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.BatteryStatus.Name = "BatteryStatus";
            this.BatteryStatus.Size = new System.Drawing.Size(70, 25);
            this.BatteryStatus.TabIndex = 40;
            this.BatteryStatus.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(2974, 2103);
            this.Controls.Add(this.BatteryStatus);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnDriveBack);
            this.Controls.Add(this.btnbackLeft);
            this.Controls.Add(this.btnBackRight);
            this.Controls.Add(this.btnDriveLeft);
            this.Controls.Add(this.btnDriftLeft);
            this.Controls.Add(this.btnDriveRight);
            this.Controls.Add(this.btnRotateRight20Deg);
            this.Controls.Add(this.btnRotateLeft20Deg);
            this.Controls.Add(this.btnDriftRight);
            this.Controls.Add(this.btnStopRobot);
            this.Controls.Add(this.btnDriveForward);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.numericUpDownBlue);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.btnTrackingObject);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Begin);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "CONTROL  FOR  UCLAN  MOBILE  ROBOT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Form1_Scroll);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Begin;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnTrackingObject;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.NumericUpDown numericUpDownGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownBlue;
        private System.IO.Ports.SerialPort sp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button btnDriveForward;
        private System.Windows.Forms.Button btnStopRobot;
        private System.Windows.Forms.Button btnDriftRight;
        private System.Windows.Forms.Button btnRotateLeft20Deg;
        private System.Windows.Forms.Button btnRotateRight20Deg;
        private System.Windows.Forms.Button btnDriveRight;
        private System.Windows.Forms.Button btnDriftLeft;
        private System.Windows.Forms.Button btnDriveLeft;
        private System.Windows.Forms.Button btnBackRight;
        private System.Windows.Forms.Button btnbackLeft;
        private System.Windows.Forms.Button btnDriveBack;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Label BatteryStatus;
    }
}

