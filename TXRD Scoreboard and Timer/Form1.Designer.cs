namespace TXRD_Scoreboard_and_Timer
{
    partial class boxotools
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.jamTime = new System.Windows.Forms.NumericUpDown();
            this.jamStart = new System.Windows.Forms.Button();
            this.quarterTime = new System.Windows.Forms.NumericUpDown();
            this.jamStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeOutTimer = new System.Windows.Forms.Timer(this.components);
            this.timeOutStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.quarterBreakTimerStart = new System.Windows.Forms.Button();
            this.halftimeTimerStart = new System.Windows.Forms.Button();
            this.hourTimerStart = new System.Windows.Forms.Button();
            this.quarterSecondUpDown = new System.Windows.Forms.NumericUpDown();
            this.quarterMinuteUpDown = new System.Windows.Forms.NumericUpDown();
            this.jamSecondUpDown = new System.Windows.Forms.NumericUpDown();
            this.state = new System.Windows.Forms.Label();
            this.jamMinuteUpDown = new System.Windows.Forms.NumericUpDown();
            this.spaceToStart = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.team2 = new System.Windows.Forms.Button();
            this.team1 = new System.Windows.Forms.Button();
            this.points2UpDown = new System.Windows.Forms.NumericUpDown();
            this.points1UpDown = new System.Windows.Forms.NumericUpDown();
            this.score2UpDown = new System.Windows.Forms.NumericUpDown();
            this.score1UpDown = new System.Windows.Forms.NumericUpDown();
            this.debugton = new System.Windows.Forms.Button();
            this.points2 = new System.Windows.Forms.Label();
            this.points1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addPoints = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.jammer2PicPreview = new System.Windows.Forms.PictureBox();
            this.team2Jammers = new System.Windows.Forms.ListBox();
            this.jammer1PicPreview = new System.Windows.Forms.PictureBox();
            this.team1Jammers = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bannerTimeSet = new System.Windows.Forms.TextBox();
            this.adTimerButton = new System.Windows.Forms.Button();
            this.bannerClock = new System.Windows.Forms.NumericUpDown();
            this.bannerCheckList = new System.Windows.Forms.CheckedListBox();
            this.adTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.roster2 = new System.Windows.Forms.CheckedListBox();
            this.roster1 = new System.Windows.Forms.CheckedListBox();
            this.introActive = new System.Windows.Forms.CheckBox();
            this.introPicClear = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.clearPenaltyPic = new System.Windows.Forms.Button();
            this.penaltyPicList = new System.Windows.Forms.ListBox();
            this.setRootFolder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.team1add1point = new System.Windows.Forms.Button();
            this.team1add4point = new System.Windows.Forms.Button();
            this.team1add5point = new System.Windows.Forms.Button();
            this.team2add5point = new System.Windows.Forms.Button();
            this.team2add4point = new System.Windows.Forms.Button();
            this.team2add1point = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jamTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarterTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quarterSecondUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarterMinuteUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jamSecondUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jamMinuteUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.points2UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.points1UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.score2UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.score1UpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jammer2PicPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jammer1PicPreview)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bannerClock)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.jamTimer_Tick);
            // 
            // jamTime
            // 
            this.jamTime.Location = new System.Drawing.Point(171, 33);
            this.jamTime.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.jamTime.Name = "jamTime";
            this.jamTime.Size = new System.Drawing.Size(40, 20);
            this.jamTime.TabIndex = 10;
            this.jamTime.ValueChanged += new System.EventHandler(this.JamTimeOutput_ValueChanged);
            this.jamTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jamTime_KeyDown);
            // 
            // jamStart
            // 
            this.jamStart.Location = new System.Drawing.Point(25, 82);
            this.jamStart.Name = "jamStart";
            this.jamStart.Size = new System.Drawing.Size(75, 23);
            this.jamStart.TabIndex = 0;
            this.jamStart.Text = "Start Jam";
            this.jamStart.UseVisualStyleBackColor = true;
            this.jamStart.Click += new System.EventHandler(this.jamStart_Click);
            // 
            // quarterTime
            // 
            this.quarterTime.Location = new System.Drawing.Point(171, 56);
            this.quarterTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.quarterTime.Name = "quarterTime";
            this.quarterTime.Size = new System.Drawing.Size(40, 20);
            this.quarterTime.TabIndex = 11;
            this.quarterTime.ValueChanged += new System.EventHandler(this.quarterTimeOutput_ValueChanged);
            // 
            // jamStop
            // 
            this.jamStop.Location = new System.Drawing.Point(106, 82);
            this.jamStop.Name = "jamStop";
            this.jamStop.Size = new System.Drawing.Size(75, 23);
            this.jamStop.TabIndex = 1;
            this.jamStop.Text = "Stop Jam";
            this.jamStop.UseVisualStyleBackColor = true;
            this.jamStop.Click += new System.EventHandler(this.jamStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Jam/TO Clock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quarter Clock";
            // 
            // timeOutTimer
            // 
            this.timeOutTimer.Interval = 1000;
            this.timeOutTimer.Tick += new System.EventHandler(this.timeOutTimer_Tick);
            // 
            // timeOutStart
            // 
            this.timeOutStart.Location = new System.Drawing.Point(9, 124);
            this.timeOutStart.Name = "timeOutStart";
            this.timeOutStart.Size = new System.Drawing.Size(94, 23);
            this.timeOutStart.TabIndex = 2;
            this.timeOutStart.Text = "Start Time Out";
            this.timeOutStart.UseVisualStyleBackColor = true;
            this.timeOutStart.Click += new System.EventHandler(this.timeOutStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.quarterBreakTimerStart);
            this.groupBox1.Controls.Add(this.halftimeTimerStart);
            this.groupBox1.Controls.Add(this.hourTimerStart);
            this.groupBox1.Controls.Add(this.quarterSecondUpDown);
            this.groupBox1.Controls.Add(this.quarterMinuteUpDown);
            this.groupBox1.Controls.Add(this.jamSecondUpDown);
            this.groupBox1.Controls.Add(this.state);
            this.groupBox1.Controls.Add(this.jamMinuteUpDown);
            this.groupBox1.Controls.Add(this.jamTime);
            this.groupBox1.Controls.Add(this.timeOutStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.jamStart);
            this.groupBox1.Controls.Add(this.jamStop);
            this.groupBox1.Controls.Add(this.quarterTime);
            this.groupBox1.Controls.Add(this.spaceToStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer Stuff";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "To Doors";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // quarterBreakTimerStart
            // 
            this.quarterBreakTimerStart.Location = new System.Drawing.Point(109, 182);
            this.quarterBreakTimerStart.Name = "quarterBreakTimerStart";
            this.quarterBreakTimerStart.Size = new System.Drawing.Size(102, 23);
            this.quarterBreakTimerStart.TabIndex = 17;
            this.quarterBreakTimerStart.Text = "5 Minute Timer";
            this.quarterBreakTimerStart.UseVisualStyleBackColor = true;
            this.quarterBreakTimerStart.Click += new System.EventHandler(this.quarterBreakTimerStart_Click);
            // 
            // halftimeTimerStart
            // 
            this.halftimeTimerStart.Location = new System.Drawing.Point(109, 153);
            this.halftimeTimerStart.Name = "halftimeTimerStart";
            this.halftimeTimerStart.Size = new System.Drawing.Size(102, 23);
            this.halftimeTimerStart.TabIndex = 16;
            this.halftimeTimerStart.Text = "30 Minute Timer";
            this.halftimeTimerStart.UseVisualStyleBackColor = true;
            this.halftimeTimerStart.Click += new System.EventHandler(this.halftimeTimerStart_Click);
            // 
            // hourTimerStart
            // 
            this.hourTimerStart.Location = new System.Drawing.Point(9, 153);
            this.hourTimerStart.Name = "hourTimerStart";
            this.hourTimerStart.Size = new System.Drawing.Size(94, 23);
            this.hourTimerStart.TabIndex = 6;
            this.hourTimerStart.Text = "1 Hour Timer";
            this.hourTimerStart.UseVisualStyleBackColor = true;
            this.hourTimerStart.Click += new System.EventHandler(this.hourTimerStart_Click);
            // 
            // quarterSecondUpDown
            // 
            this.quarterSecondUpDown.Location = new System.Drawing.Point(125, 56);
            this.quarterSecondUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.quarterSecondUpDown.Name = "quarterSecondUpDown";
            this.quarterSecondUpDown.Size = new System.Drawing.Size(37, 20);
            this.quarterSecondUpDown.TabIndex = 15;
            this.quarterSecondUpDown.ValueChanged += new System.EventHandler(this.quarterSecondUpDown_ValueChanged);
            // 
            // quarterMinuteUpDown
            // 
            this.quarterMinuteUpDown.Location = new System.Drawing.Point(88, 56);
            this.quarterMinuteUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quarterMinuteUpDown.Name = "quarterMinuteUpDown";
            this.quarterMinuteUpDown.Size = new System.Drawing.Size(41, 20);
            this.quarterMinuteUpDown.TabIndex = 14;
            this.quarterMinuteUpDown.ValueChanged += new System.EventHandler(this.quarterMinuteUpDown_ValueChanged);
            // 
            // jamSecondUpDown
            // 
            this.jamSecondUpDown.Location = new System.Drawing.Point(125, 33);
            this.jamSecondUpDown.Maximum = new decimal(new int[] {
            61,
            0,
            0,
            0});
            this.jamSecondUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.jamSecondUpDown.Name = "jamSecondUpDown";
            this.jamSecondUpDown.Size = new System.Drawing.Size(37, 20);
            this.jamSecondUpDown.TabIndex = 13;
            this.jamSecondUpDown.ValueChanged += new System.EventHandler(this.jamSecondUpDown_ValueChanged);
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.ForeColor = System.Drawing.Color.Gray;
            this.state.Location = new System.Drawing.Point(65, 10);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(78, 17);
            this.state.TabIndex = 5;
            this.state.Text = "HOLDING";
            // 
            // jamMinuteUpDown
            // 
            this.jamMinuteUpDown.Location = new System.Drawing.Point(88, 33);
            this.jamMinuteUpDown.Name = "jamMinuteUpDown";
            this.jamMinuteUpDown.Size = new System.Drawing.Size(41, 20);
            this.jamMinuteUpDown.TabIndex = 12;
            this.jamMinuteUpDown.ValueChanged += new System.EventHandler(this.jamMinuteUpDown_ValueChanged);
            // 
            // spaceToStart
            // 
            this.spaceToStart.AutoSize = true;
            this.spaceToStart.Location = new System.Drawing.Point(9, 111);
            this.spaceToStart.Name = "spaceToStart";
            this.spaceToStart.Size = new System.Drawing.Size(146, 17);
            this.spaceToStart.TabIndex = 3;
            this.spaceToStart.Text = "Spacebar Start/Stop Jam";
            this.spaceToStart.UseVisualStyleBackColor = true;
            this.spaceToStart.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.team2add5point);
            this.groupBox2.Controls.Add(this.team2add4point);
            this.groupBox2.Controls.Add(this.team2add1point);
            this.groupBox2.Controls.Add(this.team1add5point);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.team1add4point);
            this.groupBox2.Controls.Add(this.team2);
            this.groupBox2.Controls.Add(this.team1add1point);
            this.groupBox2.Controls.Add(this.team1);
            this.groupBox2.Controls.Add(this.points2UpDown);
            this.groupBox2.Controls.Add(this.points1UpDown);
            this.groupBox2.Controls.Add(this.score2UpDown);
            this.groupBox2.Controls.Add(this.score1UpDown);
            this.groupBox2.Controls.Add(this.debugton);
            this.groupBox2.Controls.Add(this.points2);
            this.groupBox2.Controls.Add(this.points1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.addPoints);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(235, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 136);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Score Stuff";
            // 
            // team2
            // 
            this.team2.Location = new System.Drawing.Point(8, 67);
            this.team2.Name = "team2";
            this.team2.Size = new System.Drawing.Size(100, 23);
            this.team2.TabIndex = 16;
            this.team2.Text = "Set Team 2";
            this.team2.UseVisualStyleBackColor = true;
            this.team2.Click += new System.EventHandler(this.team2_Click);
            // 
            // team1
            // 
            this.team1.Location = new System.Drawing.Point(8, 40);
            this.team1.Name = "team1";
            this.team1.Size = new System.Drawing.Size(100, 23);
            this.team1.TabIndex = 15;
            this.team1.Text = "Set Team 1";
            this.team1.UseVisualStyleBackColor = true;
            this.team1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // points2UpDown
            // 
            this.points2UpDown.Location = new System.Drawing.Point(236, 67);
            this.points2UpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.points2UpDown.Name = "points2UpDown";
            this.points2UpDown.Size = new System.Drawing.Size(50, 20);
            this.points2UpDown.TabIndex = 1;
            this.points2UpDown.Enter += new System.EventHandler(this.points2UpDown_Enter);
            this.points2UpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.points2UpDown_KeyDown);
            // 
            // points1UpDown
            // 
            this.points1UpDown.Location = new System.Drawing.Point(236, 40);
            this.points1UpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.points1UpDown.Name = "points1UpDown";
            this.points1UpDown.Size = new System.Drawing.Size(50, 20);
            this.points1UpDown.TabIndex = 0;
            this.points1UpDown.Enter += new System.EventHandler(this.points1UpDown_Enter);
            this.points1UpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.points1UpDown_KeyDown);
            // 
            // score2UpDown
            // 
            this.score2UpDown.Location = new System.Drawing.Point(113, 67);
            this.score2UpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.score2UpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.score2UpDown.Name = "score2UpDown";
            this.score2UpDown.Size = new System.Drawing.Size(46, 20);
            this.score2UpDown.TabIndex = 13;
            this.score2UpDown.ValueChanged += new System.EventHandler(this.score2UpDown_ValueChanged);
            // 
            // score1UpDown
            // 
            this.score1UpDown.Location = new System.Drawing.Point(113, 40);
            this.score1UpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.score1UpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.score1UpDown.Name = "score1UpDown";
            this.score1UpDown.Size = new System.Drawing.Size(46, 20);
            this.score1UpDown.TabIndex = 12;
            this.score1UpDown.ValueChanged += new System.EventHandler(this.score1UpDown_ValueChanged);
            // 
            // debugton
            // 
            this.debugton.Location = new System.Drawing.Point(153, 102);
            this.debugton.Name = "debugton";
            this.debugton.Size = new System.Drawing.Size(62, 21);
            this.debugton.TabIndex = 14;
            this.debugton.Text = "debugton";
            this.debugton.UseVisualStyleBackColor = true;
            this.debugton.Visible = false;
            this.debugton.Click += new System.EventHandler(this.debugton_Click);
            // 
            // points2
            // 
            this.points2.AutoSize = true;
            this.points2.Location = new System.Drawing.Point(175, 71);
            this.points2.Name = "points2";
            this.points2.Size = new System.Drawing.Size(13, 13);
            this.points2.TabIndex = 4;
            this.points2.Text = "0";
            // 
            // points1
            // 
            this.points1.AutoSize = true;
            this.points1.Location = new System.Drawing.Point(175, 44);
            this.points1.Name = "points1";
            this.points1.Size = new System.Drawing.Size(13, 13);
            this.points1.TabIndex = 3;
            this.points1.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Gained";
            // 
            // addPoints
            // 
            this.addPoints.Location = new System.Drawing.Point(221, 100);
            this.addPoints.Name = "addPoints";
            this.addPoints.Size = new System.Drawing.Size(75, 23);
            this.addPoints.TabIndex = 2;
            this.addPoints.Text = "Add Points";
            this.addPoints.UseVisualStyleBackColor = true;
            this.addPoints.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Points";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Teams";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.jammer2PicPreview);
            this.groupBox3.Controls.Add(this.team2Jammers);
            this.groupBox3.Controls.Add(this.jammer1PicPreview);
            this.groupBox3.Controls.Add(this.team1Jammers);
            this.groupBox3.Location = new System.Drawing.Point(9, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 133);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jammer Stuff";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Team #2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Team #1";
            // 
            // jammer2PicPreview
            // 
            this.jammer2PicPreview.Location = new System.Drawing.Point(394, 29);
            this.jammer2PicPreview.Name = "jammer2PicPreview";
            this.jammer2PicPreview.Size = new System.Drawing.Size(124, 95);
            this.jammer2PicPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jammer2PicPreview.TabIndex = 3;
            this.jammer2PicPreview.TabStop = false;
            // 
            // team2Jammers
            // 
            this.team2Jammers.FormattingEnabled = true;
            this.team2Jammers.Location = new System.Drawing.Point(268, 29);
            this.team2Jammers.Name = "team2Jammers";
            this.team2Jammers.Size = new System.Drawing.Size(120, 95);
            this.team2Jammers.TabIndex = 1;
            this.team2Jammers.SelectedIndexChanged += new System.EventHandler(this.team2Jammers_SelectedIndexChanged);
            // 
            // jammer1PicPreview
            // 
            this.jammer1PicPreview.Location = new System.Drawing.Point(134, 29);
            this.jammer1PicPreview.Name = "jammer1PicPreview";
            this.jammer1PicPreview.Size = new System.Drawing.Size(124, 98);
            this.jammer1PicPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jammer1PicPreview.TabIndex = 1;
            this.jammer1PicPreview.TabStop = false;
            // 
            // team1Jammers
            // 
            this.team1Jammers.FormattingEnabled = true;
            this.team1Jammers.Location = new System.Drawing.Point(8, 31);
            this.team1Jammers.Name = "team1Jammers";
            this.team1Jammers.Size = new System.Drawing.Size(120, 95);
            this.team1Jammers.TabIndex = 0;
            this.team1Jammers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bannerTimeSet);
            this.groupBox4.Controls.Add(this.adTimerButton);
            this.groupBox4.Controls.Add(this.bannerClock);
            this.groupBox4.Controls.Add(this.bannerCheckList);
            this.groupBox4.Location = new System.Drawing.Point(550, 236);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(197, 130);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ad Banner";
            // 
            // bannerTimeSet
            // 
            this.bannerTimeSet.Location = new System.Drawing.Point(7, 90);
            this.bannerTimeSet.Name = "bannerTimeSet";
            this.bannerTimeSet.Size = new System.Drawing.Size(33, 20);
            this.bannerTimeSet.TabIndex = 1;
            this.bannerTimeSet.Text = "60";
            // 
            // adTimerButton
            // 
            this.adTimerButton.Location = new System.Drawing.Point(110, 90);
            this.adTimerButton.Name = "adTimerButton";
            this.adTimerButton.Size = new System.Drawing.Size(77, 23);
            this.adTimerButton.TabIndex = 3;
            this.adTimerButton.Text = "Start Banner";
            this.adTimerButton.UseVisualStyleBackColor = true;
            this.adTimerButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // bannerClock
            // 
            this.bannerClock.Location = new System.Drawing.Point(46, 90);
            this.bannerClock.Name = "bannerClock";
            this.bannerClock.Size = new System.Drawing.Size(58, 20);
            this.bannerClock.TabIndex = 2;
            // 
            // bannerCheckList
            // 
            this.bannerCheckList.FormattingEnabled = true;
            this.bannerCheckList.Location = new System.Drawing.Point(7, 20);
            this.bannerCheckList.Name = "bannerCheckList";
            this.bannerCheckList.Size = new System.Drawing.Size(184, 64);
            this.bannerCheckList.TabIndex = 0;
            this.bannerCheckList.SelectedIndexChanged += new System.EventHandler(this.bannerCheckList_SelectedIndexChanged);
            // 
            // adTimer
            // 
            this.adTimer.Interval = 1000;
            this.adTimer.Tick += new System.EventHandler(this.adTimer_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.roster2);
            this.groupBox5.Controls.Add(this.roster1);
            this.groupBox5.Controls.Add(this.introActive);
            this.groupBox5.Controls.Add(this.introPicClear);
            this.groupBox5.Location = new System.Drawing.Point(550, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(194, 214);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rosters / Intro Pics";
            // 
            // roster2
            // 
            this.roster2.FormattingEnabled = true;
            this.roster2.Location = new System.Drawing.Point(4, 127);
            this.roster2.Name = "roster2";
            this.roster2.Size = new System.Drawing.Size(178, 79);
            this.roster2.TabIndex = 6;
            this.roster2.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.roster2_ItemCheck);
            this.roster2.SelectedIndexChanged += new System.EventHandler(this.roster2_SelectedIndexChanged);
            // 
            // roster1
            // 
            this.roster1.FormattingEnabled = true;
            this.roster1.Location = new System.Drawing.Point(4, 42);
            this.roster1.Name = "roster1";
            this.roster1.Size = new System.Drawing.Size(178, 79);
            this.roster1.TabIndex = 5;
            this.roster1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.roster1_ItemCheck);
            this.roster1.SelectedIndexChanged += new System.EventHandler(this.roster1_SelectedIndexChanged_1);
            // 
            // introActive
            // 
            this.introActive.AutoSize = true;
            this.introActive.Location = new System.Drawing.Point(6, 20);
            this.introActive.Name = "introActive";
            this.introActive.Size = new System.Drawing.Size(70, 17);
            this.introActive.TabIndex = 4;
            this.introActive.Text = "Intro Pics";
            this.introActive.UseVisualStyleBackColor = true;
            this.introActive.CheckedChanged += new System.EventHandler(this.introActive_CheckedChanged);
            // 
            // introPicClear
            // 
            this.introPicClear.Location = new System.Drawing.Point(120, 13);
            this.introPicClear.Name = "introPicClear";
            this.introPicClear.Size = new System.Drawing.Size(62, 23);
            this.introPicClear.TabIndex = 2;
            this.introPicClear.Text = "Clear Pic";
            this.introPicClear.UseVisualStyleBackColor = true;
            this.introPicClear.Visible = false;
            this.introPicClear.Click += new System.EventHandler(this.introPicClear_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.clearPenaltyPic);
            this.groupBox6.Controls.Add(this.penaltyPicList);
            this.groupBox6.Location = new System.Drawing.Point(235, 155);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(215, 72);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Penalty Pics";
            // 
            // clearPenaltyPic
            // 
            this.clearPenaltyPic.Location = new System.Drawing.Point(133, 31);
            this.clearPenaltyPic.Name = "clearPenaltyPic";
            this.clearPenaltyPic.Size = new System.Drawing.Size(69, 23);
            this.clearPenaltyPic.TabIndex = 1;
            this.clearPenaltyPic.Text = "Clear Pic";
            this.clearPenaltyPic.UseVisualStyleBackColor = true;
            this.clearPenaltyPic.Click += new System.EventHandler(this.clearPenaltyPic_Click);
            // 
            // penaltyPicList
            // 
            this.penaltyPicList.FormattingEnabled = true;
            this.penaltyPicList.Location = new System.Drawing.Point(6, 20);
            this.penaltyPicList.Name = "penaltyPicList";
            this.penaltyPicList.Size = new System.Drawing.Size(121, 43);
            this.penaltyPicList.TabIndex = 0;
            this.penaltyPicList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // setRootFolder
            // 
            this.setRootFolder.Location = new System.Drawing.Point(465, 160);
            this.setRootFolder.Name = "setRootFolder";
            this.setRootFolder.Size = new System.Drawing.Size(75, 34);
            this.setRootFolder.TabIndex = 6;
            this.setRootFolder.Text = "Set Root Folder";
            this.setRootFolder.UseVisualStyleBackColor = true;
            this.setRootFolder.Click += new System.EventHandler(this.setRootFolder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 29);
            this.button2.TabIndex = 17;
            this.button2.Text = "Switch Points Entry";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // team1add1point
            // 
            this.team1add1point.Location = new System.Drawing.Point(212, 40);
            this.team1add1point.Name = "team1add1point";
            this.team1add1point.Size = new System.Drawing.Size(27, 23);
            this.team1add1point.TabIndex = 7;
            this.team1add1point.Text = "+1";
            this.team1add1point.UseVisualStyleBackColor = true;
            this.team1add1point.Visible = false;
            this.team1add1point.Click += new System.EventHandler(this.team1add1point_Click);
            // 
            // team1add4point
            // 
            this.team1add4point.Location = new System.Drawing.Point(245, 40);
            this.team1add4point.Name = "team1add4point";
            this.team1add4point.Size = new System.Drawing.Size(27, 23);
            this.team1add4point.TabIndex = 8;
            this.team1add4point.Text = "+4";
            this.team1add4point.UseVisualStyleBackColor = true;
            this.team1add4point.Visible = false;
            this.team1add4point.Click += new System.EventHandler(this.team1add4point_Click);
            // 
            // team1add5point
            // 
            this.team1add5point.Location = new System.Drawing.Point(278, 40);
            this.team1add5point.Name = "team1add5point";
            this.team1add5point.Size = new System.Drawing.Size(27, 23);
            this.team1add5point.TabIndex = 9;
            this.team1add5point.Text = "+5";
            this.team1add5point.UseVisualStyleBackColor = true;
            this.team1add5point.Visible = false;
            this.team1add5point.Click += new System.EventHandler(this.team1add5point_Click);
            // 
            // team2add5point
            // 
            this.team2add5point.Location = new System.Drawing.Point(278, 66);
            this.team2add5point.Name = "team2add5point";
            this.team2add5point.Size = new System.Drawing.Size(27, 23);
            this.team2add5point.TabIndex = 20;
            this.team2add5point.Text = "+5";
            this.team2add5point.UseVisualStyleBackColor = true;
            this.team2add5point.Visible = false;
            this.team2add5point.Click += new System.EventHandler(this.team2add5point_Click);
            // 
            // team2add4point
            // 
            this.team2add4point.Location = new System.Drawing.Point(245, 66);
            this.team2add4point.Name = "team2add4point";
            this.team2add4point.Size = new System.Drawing.Size(27, 23);
            this.team2add4point.TabIndex = 19;
            this.team2add4point.Text = "+4";
            this.team2add4point.UseVisualStyleBackColor = true;
            this.team2add4point.Visible = false;
            this.team2add4point.Click += new System.EventHandler(this.team2add4point_Click);
            // 
            // team2add1point
            // 
            this.team2add1point.Location = new System.Drawing.Point(212, 66);
            this.team2add1point.Name = "team2add1point";
            this.team2add1point.Size = new System.Drawing.Size(27, 23);
            this.team2add1point.TabIndex = 18;
            this.team2add1point.Text = "+1";
            this.team2add1point.UseVisualStyleBackColor = true;
            this.team2add1point.Visible = false;
            this.team2add1point.Click += new System.EventHandler(this.team2add1point_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(109, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Offical Timeout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // boxotools
            // 
            this.AcceptButton = this.jamStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 375);
            this.Controls.Add(this.setRootFolder);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "boxotools";
            this.Text = "TXRD Scoreboard Toolbox v0.1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolbox_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.jamTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarterTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quarterSecondUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarterMinuteUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jamSecondUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jamMinuteUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.points2UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.points1UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.score2UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.score1UpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jammer2PicPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jammer1PicPreview)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bannerClock)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.NumericUpDown jamTime;
        private System.Windows.Forms.Button jamStart;
        private System.Windows.Forms.NumericUpDown quarterTime;
        private System.Windows.Forms.Button jamStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timeOutTimer;
        private System.Windows.Forms.Button timeOutStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addPoints;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label points2;
        private System.Windows.Forms.Label points1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox team1Jammers;
        private System.Windows.Forms.PictureBox jammer1PicPreview;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox jammer2PicPreview;
        private System.Windows.Forms.ListBox team2Jammers;
        private System.Windows.Forms.Button debugton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button adTimerButton;
        private System.Windows.Forms.CheckedListBox bannerCheckList;
        private System.Windows.Forms.Timer adTimer;
        private System.Windows.Forms.TextBox bannerTimeSet;
        public System.Windows.Forms.NumericUpDown bannerClock;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button introPicClear;
        private System.Windows.Forms.NumericUpDown score1UpDown;
        private System.Windows.Forms.NumericUpDown score2UpDown;
        private System.Windows.Forms.CheckBox spaceToStart;
        private System.Windows.Forms.NumericUpDown points1UpDown;
        private System.Windows.Forms.NumericUpDown points2UpDown;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.NumericUpDown jamMinuteUpDown;
        private System.Windows.Forms.NumericUpDown jamSecondUpDown;
        private System.Windows.Forms.NumericUpDown quarterSecondUpDown;
        private System.Windows.Forms.NumericUpDown quarterMinuteUpDown;
        private System.Windows.Forms.Button team1;
        private System.Windows.Forms.Button team2;
        private System.Windows.Forms.CheckBox introActive;
        private System.Windows.Forms.CheckedListBox roster1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button clearPenaltyPic;
        private System.Windows.Forms.ListBox penaltyPicList;
        private System.Windows.Forms.Button hourTimerStart;
        private System.Windows.Forms.Button halftimeTimerStart;
        private System.Windows.Forms.Button quarterBreakTimerStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox roster2;
        private System.Windows.Forms.Button setRootFolder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button team1add1point;
        private System.Windows.Forms.Button team1add4point;
        private System.Windows.Forms.Button team1add5point;
        private System.Windows.Forms.Button team2add5point;
        private System.Windows.Forms.Button team2add4point;
        private System.Windows.Forms.Button team2add1point;
        private System.Windows.Forms.Button button3;
    }
}

