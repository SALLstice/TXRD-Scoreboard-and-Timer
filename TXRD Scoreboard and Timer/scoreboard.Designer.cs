namespace TXRD_Scoreboard_and_Timer
{
    partial class scoreboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scoreboard));
            this.score1 = new System.Windows.Forms.Label();
            this.team1 = new System.Windows.Forms.Label();
            this.team2 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.quarterMinute = new System.Windows.Forms.Label();
            this.quarterSecond = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jamMinute = new System.Windows.Forms.Label();
            this.points1 = new System.Windows.Forms.Label();
            this.points2 = new System.Windows.Forms.Label();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.jammer1 = new System.Windows.Forms.Label();
            this.jammer2 = new System.Windows.Forms.Label();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.adBanner = new System.Windows.Forms.PictureBox();
            this.overlayPic = new System.Windows.Forms.PictureBox();
            this.jamSecond = new System.Windows.Forms.Label();
            this.timeOutLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jamCount = new System.Windows.Forms.Label();
            this.quarterCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txrdLogo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.team1Pic = new System.Windows.Forms.PictureBox();
            this.team2Pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overlayPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txrdLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team1Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.Location = new System.Drawing.Point(73, 245);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(70, 76);
            this.score1.TabIndex = 0;
            this.score1.Text = "0";
            this.score1.Click += new System.EventHandler(this.team1Score_Click);
            // 
            // team1
            // 
            this.team1.AutoSize = true;
            this.team1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1.Location = new System.Drawing.Point(27, 204);
            this.team1.Name = "team1";
            this.team1.Size = new System.Drawing.Size(154, 46);
            this.team1.TabIndex = 1;
            this.team1.Text = "Team 1";
            // 
            // team2
            // 
            this.team2.AutoSize = true;
            this.team2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2.Location = new System.Drawing.Point(538, 204);
            this.team2.Name = "team2";
            this.team2.Size = new System.Drawing.Size(154, 46);
            this.team2.TabIndex = 3;
            this.team2.Text = "Team 2";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.Location = new System.Drawing.Point(592, 240);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(70, 76);
            this.score2.TabIndex = 2;
            this.score2.Text = "0";
            // 
            // quarterMinute
            // 
            this.quarterMinute.AutoSize = true;
            this.quarterMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quarterMinute.Location = new System.Drawing.Point(303, 111);
            this.quarterMinute.Name = "quarterMinute";
            this.quarterMinute.Size = new System.Drawing.Size(29, 31);
            this.quarterMinute.TabIndex = 4;
            this.quarterMinute.Text = "0";
            // 
            // quarterSecond
            // 
            this.quarterSecond.AutoSize = true;
            this.quarterSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quarterSecond.Location = new System.Drawing.Point(366, 111);
            this.quarterSecond.Name = "quarterSecond";
            this.quarterSecond.Size = new System.Drawing.Size(29, 31);
            this.quarterSecond.TabIndex = 5;
            this.quarterSecond.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // jamMinute
            // 
            this.jamMinute.AutoSize = true;
            this.jamMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jamMinute.Location = new System.Drawing.Point(301, 169);
            this.jamMinute.Name = "jamMinute";
            this.jamMinute.Size = new System.Drawing.Size(42, 46);
            this.jamMinute.TabIndex = 7;
            this.jamMinute.Text = "0";
            // 
            // points1
            // 
            this.points1.AutoSize = true;
            this.points1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points1.Location = new System.Drawing.Point(149, 317);
            this.points1.Name = "points1";
            this.points1.Size = new System.Drawing.Size(16, 17);
            this.points1.TabIndex = 8;
            this.points1.Text = "0";
            // 
            // points2
            // 
            this.points2.AutoSize = true;
            this.points2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points2.Location = new System.Drawing.Point(651, 316);
            this.points2.Name = "points2";
            this.points2.Size = new System.Drawing.Size(16, 17);
            this.points2.TabIndex = 9;
            this.points2.Text = "0";
            // 
            // picture1
            // 
            this.picture1.Location = new System.Drawing.Point(27, 352);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(154, 116);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture1.TabIndex = 10;
            this.picture1.TabStop = false;
            // 
            // jammer1
            // 
            this.jammer1.AutoSize = true;
            this.jammer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jammer1.Location = new System.Drawing.Point(57, 471);
            this.jammer1.Name = "jammer1";
            this.jammer1.Size = new System.Drawing.Size(126, 31);
            this.jammer1.TabIndex = 11;
            this.jammer1.Text = "Jammer1";
            // 
            // jammer2
            // 
            this.jammer2.AutoSize = true;
            this.jammer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jammer2.Location = new System.Drawing.Point(545, 471);
            this.jammer2.Name = "jammer2";
            this.jammer2.Size = new System.Drawing.Size(126, 31);
            this.jammer2.TabIndex = 13;
            this.jammer2.Text = "Jammer2";
            // 
            // picture2
            // 
            this.picture2.Location = new System.Drawing.Point(551, 352);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(127, 116);
            this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture2.TabIndex = 12;
            this.picture2.TabStop = false;
            // 
            // adBanner
            // 
            this.adBanner.Location = new System.Drawing.Point(0, 512);
            this.adBanner.Name = "adBanner";
            this.adBanner.Size = new System.Drawing.Size(714, 76);
            this.adBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adBanner.TabIndex = 14;
            this.adBanner.TabStop = false;
            // 
            // overlayPic
            // 
            this.overlayPic.Image = global::TXRD_Scoreboard_and_Timer.Properties.Resources.Eduskater;
            this.overlayPic.Location = new System.Drawing.Point(1, 1);
            this.overlayPic.Name = "overlayPic";
            this.overlayPic.Size = new System.Drawing.Size(31, 35);
            this.overlayPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.overlayPic.TabIndex = 15;
            this.overlayPic.TabStop = false;
            this.overlayPic.Visible = false;
            // 
            // jamSecond
            // 
            this.jamSecond.AutoSize = true;
            this.jamSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jamSecond.Location = new System.Drawing.Point(374, 169);
            this.jamSecond.Name = "jamSecond";
            this.jamSecond.Size = new System.Drawing.Size(42, 46);
            this.jamSecond.TabIndex = 16;
            this.jamSecond.Text = "0";
            // 
            // timeOutLabel
            // 
            this.timeOutLabel.AutoSize = true;
            this.timeOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOutLabel.ForeColor = System.Drawing.Color.Red;
            this.timeOutLabel.Location = new System.Drawing.Point(284, 142);
            this.timeOutLabel.Name = "timeOutLabel";
            this.timeOutLabel.Size = new System.Drawing.Size(152, 31);
            this.timeOutLabel.TabIndex = 17;
            this.timeOutLabel.Text = "TIME OUT";
            this.timeOutLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 46);
            this.label2.TabIndex = 18;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Jam";
            // 
            // jamCount
            // 
            this.jamCount.AutoSize = true;
            this.jamCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jamCount.Location = new System.Drawing.Point(398, 240);
            this.jamCount.Name = "jamCount";
            this.jamCount.Size = new System.Drawing.Size(18, 20);
            this.jamCount.TabIndex = 20;
            this.jamCount.Text = "0";
            // 
            // quarterCount
            // 
            this.quarterCount.AutoSize = true;
            this.quarterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quarterCount.Location = new System.Drawing.Point(295, 240);
            this.quarterCount.Name = "quarterCount";
            this.quarterCount.Size = new System.Drawing.Size(18, 20);
            this.quarterCount.TabIndex = 22;
            this.quarterCount.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Quarter";
            // 
            // txrdLogo
            // 
            this.txrdLogo.Image = ((System.Drawing.Image)(resources.GetObject("txrdLogo.Image")));
            this.txrdLogo.Location = new System.Drawing.Point(1, 1);
            this.txrdLogo.Name = "txrdLogo";
            this.txrdLogo.Size = new System.Drawing.Size(714, 79);
            this.txrdLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txrdLogo.TabIndex = 23;
            this.txrdLogo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // team1Pic
            // 
            this.team1Pic.Location = new System.Drawing.Point(63, 86);
            this.team1Pic.Name = "team1Pic";
            this.team1Pic.Size = new System.Drawing.Size(100, 100);
            this.team1Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.team1Pic.TabIndex = 26;
            this.team1Pic.TabStop = false;
            // 
            // team2Pic
            // 
            this.team2Pic.Location = new System.Drawing.Point(567, 86);
            this.team2Pic.Name = "team2Pic";
            this.team2Pic.Size = new System.Drawing.Size(100, 100);
            this.team2Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.team2Pic.TabIndex = 27;
            this.team2Pic.TabStop = false;
            // 
            // scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 587);
            this.Controls.Add(this.team2Pic);
            this.Controls.Add(this.team1Pic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txrdLogo);
            this.Controls.Add(this.quarterCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.jamCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quarterSecond);
            this.Controls.Add(this.quarterMinute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeOutLabel);
            this.Controls.Add(this.jamSecond);
            this.Controls.Add(this.overlayPic);
            this.Controls.Add(this.adBanner);
            this.Controls.Add(this.jammer2);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.jammer1);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.points2);
            this.Controls.Add(this.points1);
            this.Controls.Add(this.jamMinute);
            this.Controls.Add(this.team2);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.team1);
            this.Controls.Add(this.score1);
            this.Name = "scoreboard";
            this.Text = "Display";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.scoreboard_FormClosing);
            this.SizeChanged += new System.EventHandler(this.scoreboard_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overlayPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txrdLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team1Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label score1;
        public System.Windows.Forms.Label team1;
        public System.Windows.Forms.Label team2;
        public System.Windows.Forms.Label score2;
        public System.Windows.Forms.Label quarterMinute;
        public System.Windows.Forms.Label quarterSecond;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label jamMinute;
        public System.Windows.Forms.PictureBox picture1;
        public System.Windows.Forms.Label jammer1;
        public System.Windows.Forms.Label jammer2;
        public System.Windows.Forms.PictureBox picture2;
        public System.Windows.Forms.PictureBox adBanner;
        public System.Windows.Forms.PictureBox overlayPic;
        public System.Windows.Forms.Label points1;
        public System.Windows.Forms.Label points2;
        public System.Windows.Forms.Label jamSecond;
        public System.Windows.Forms.Label timeOutLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label jamCount;
        public System.Windows.Forms.Label quarterCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox txrdLogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.PictureBox team1Pic;
        public System.Windows.Forms.PictureBox team2Pic;
    }
}