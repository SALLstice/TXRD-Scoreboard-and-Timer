using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TXRD_Scoreboard_and_Timer
{
    
    public partial class boxotools : Form
    {
        string rootFolder = Properties.Settings.Default.RootFolder;
        scoreboard scoreboard = new scoreboard();

        public boxotools()
        {
            InitializeComponent();
            scoreboard.Show();
            
            if (File.Exists(rootFolder + @"\TXRDRoot.sys"))
            { 
                string[] penaltyPics = System.IO.Directory.GetFiles(rootFolder + @"\Penalty Pics");
                penaltyPicList.Items.Clear();
                foreach (string fi in penaltyPics)
                {
                    string temp = Path.GetFileNameWithoutExtension(fi);
                    penaltyPicList.Items.Add(Path.GetFileNameWithoutExtension(fi));
                }
                
                string[] adPics = System.IO.Directory.GetFiles(rootFolder + @"\Ads");
                bannerCheckList.Items.Clear();
                foreach (string fi in adPics)
                {
                    string temp = Path.GetFileNameWithoutExtension(fi);
                    bannerCheckList.Items.Add(Path.GetFileNameWithoutExtension(fi));
                }
            }
        }

        private void jamStart_Click(object sender, EventArgs e)
        {
            jamMinuteUpDown.Value = 1;
            jamSecondUpDown.Value = 0;
            scoreboard.points1.Text = points1.Text = "0";
            if(quarterTime.Value == 0)
            {
                quarterMinuteUpDown.Value = 8;
            }

            timeOutTimer.Stop();
            GameTimer.Start();
            //jamStart.Enabled = false;
            //jamStop.Enabled = true;
            scoreboard.timeOutLabel.Visible = false;
            state.Text = "JAM RUNNING";
            state.ForeColor = System.Drawing.Color.Green;
            timeOutStart.Text = "Start Time Out";
            scoreboard.jamCount.Text = (Int32.Parse(scoreboard.jamCount.Text) + 1).ToString();
        }

        private void jamTimer_Tick(object sender, EventArgs e)
        {
            if ((jamSecondUpDown.Value == 0) && (jamMinuteUpDown.Value >= 1))
            {
                //jamMinuteUpDown.DownButton();
                //jamSecondUpDown.Value = 60;
            }

            if ((quarterSecondUpDown.Value == 0) && (quarterMinuteUpDown.Value >= 1))
            {
                quarterMinuteUpDown.DownButton();
                quarterSecondUpDown.Value = 60;
            }
            
            jamSecondUpDown.DownButton();
            quarterSecondUpDown.DownButton();
            
        }

        private void jamStop_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
            timeOutTimer.Stop();
            //jamStart.Enabled = true;
            //jamStop.Enabled = false;
            points1UpDown.Focus();

            state.Text = "HOLDING";
            state.ForeColor = System.Drawing.Color.Gray;
        }

        private void timeOutStart_Click(object sender, EventArgs e)
        {
            if (timeOutStart.Text == "Start Time Out")
            {
                timeOutTimer.Start();
                jamMinuteUpDown.Value = 2;
                timeOutStart.Text = "End Time Out";
                scoreboard.timeOutLabel.Visible = true;

                state.Text = "TIME OUT";
                state.ForeColor = System.Drawing.Color.Red;
            }
            else
            {

                timeOutTimer.Stop();
                timeOutStart.Text = "Start Time Out";
                scoreboard.timeOutLabel.Visible = false;

                state.Text = "HOLDING";
                state.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void timeOutTimer_Tick(object sender, EventArgs e)
        {
            if (state.Text == "TIME OUT")
            {
                jamSecondUpDown.DownButton();
            }else if (state.Text == "OFFICAL TIME OUT")
            {
                jamSecondUpDown.UpButton();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            points1.Text = points2.Text = scoreboard.points1.Text = scoreboard.points2.Text = "0";
            
            score1UpDown.Value = score1UpDown.Value + points1UpDown.Value;
            scoreboard.score1.Text = score1UpDown.Value.ToString(); ;
            scoreboard.points1.Text = points1.Text = points1UpDown.Value.ToString() ;
            
            score2UpDown.Value = score2UpDown.Value + points2UpDown.Value;
            scoreboard.score2.Text = score2UpDown.Value.ToString();
            scoreboard.points2.Text = points2.Text = points2UpDown.Value.ToString();
            
            points1UpDown.Value = 0;
            points2UpDown.Value = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            jammer1PicPreview.Image = Image.FromFile(rootFolder + "\\" + team1.Text + "\\" +  team1Jammers.Text + ".jpg");

            scoreboard.jammer1.Text = team1Jammers.Text;
            scoreboard.picture1.Image = jammer1PicPreview.Image = Image.FromFile(rootFolder + "\\" + team1.Text + "\\" + team1Jammers.Text + ".jpg");

        }

        private void team2Jammers_SelectedIndexChanged(object sender, EventArgs e)
        {
            jammer2PicPreview.Image = jammer2PicPreview.Image = Image.FromFile(rootFolder + "\\" + team2.Text + "\\" + team2Jammers.Text + ".jpg");

            scoreboard.jammer2.Text = team2Jammers.Text;
            scoreboard.picture2.Image = jammer2PicPreview.Image = Image.FromFile(rootFolder + "\\" + team2.Text + "\\" + team2Jammers.Text + ".jpg");
        }

        private void JamTimeOutput_ValueChanged(object sender, EventArgs e)
        {
            if ((jamTime.Value <= 0))
            {
                System.Media.SystemSounds.Asterisk.Play();
                GameTimer.Stop();
                //jamStop.Enabled = false;
                //jamStart.Enabled = true;
            }
        }

        private void quarterTimeOutput_ValueChanged(object sender, EventArgs e)
        {
            if ((quarterTime.Value <= 0))
            {
                System.Media.SystemSounds.Asterisk.Play();
                GameTimer.Stop();
                //jamStop.Enabled = false;
                //jamStart.Enabled = true;
            }
        }

        public void team1TextBox_TextChanged(object sender, EventArgs e)
        {
            scoreboard.team1.Text = team1.Text;
        }

        private void debugton_Click(object sender, EventArgs e)
        {
            debugton.Text = roster1.SelectedIndex.ToString();
        }

        private void team2TextBox_TextChanged(object sender, EventArgs e)
        {
            scoreboard.team2.Text = team2.Text;
        }

        private void bannerCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bannerCheckList.GetItemCheckState(bannerCheckList.SelectedIndex) == CheckState.Checked)
            {
                scoreboard.adBanner.Image = Image.FromFile(rootFolder + "\\Ads\\" + bannerCheckList.Text + ".jpg");
            }
            else
            {
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (adTimerButton.Text == "Start Banner")
            {
                bannerClock.Value = Int32.Parse(bannerTimeSet.Text);
                adTimer.Start();
                adTimerButton.Text = "Stop Banner";
            }
            else if (adTimerButton.Text == "Stop Banner")
            {
                adTimer.Stop();
                adTimerButton.Text = "Start Banner";
            }

        }

        private void adTimer_Tick(object sender, EventArgs e)
        {
            bannerClock.Value = bannerClock.Value - 1;

            if (bannerClock.Value == 0)
            {
                do
                {
                    if (bannerCheckList.SelectedIndex < bannerCheckList.Items.Count - 1)
                    {
                        bannerCheckList.SelectedIndex = bannerCheckList.SelectedIndex + 1;
                    } 
                    else
                    {
                        bannerCheckList.SelectedIndex = 0;
                    }
               } while (bannerCheckList.GetItemCheckState(bannerCheckList.SelectedIndex) != CheckState.Checked);
                    bannerClock.Value = Int32.Parse(bannerTimeSet.Text);
            }
        }

        private void introList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoreboard.overlayPic.Size = scoreboard.Size;
            scoreboard.overlayPic.BringToFront();
            scoreboard.overlayPic.Visible = true;
            if (roster1.SelectedIndex >= 0)
            {
                scoreboard.overlayPic.Image.Dispose();
                scoreboard.overlayPic.Image = Image.FromFile(rootFolder + team1.Text + "\\" + roster1.Text + ".jpg");
            }
            roster2.ClearSelected();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoreboard.overlayPic.Size = scoreboard.Size;
            scoreboard.overlayPic.BringToFront();
            scoreboard.overlayPic.Visible = true;
            if (roster2.SelectedIndex >= 0)
            {
                scoreboard.overlayPic.Image.Dispose();
                scoreboard.overlayPic.Image = Image.FromFile(rootFolder + team2.Text + "\\" + roster2.Text + ".jpg");
            }
         
            roster1.ClearSelected();
        }

        private void introPicClear_Click(object sender, EventArgs e)
        {
            roster1.ClearSelected();
            roster2.ClearSelected();
            scoreboard.overlayPic.Visible = false;
        }
        
        private void score1TextBox_TextChanged(object sender, EventArgs e)
        {
            scoreboard.score1.Text = score1UpDown.Text;
        }

        private void score1UpDown_ValueChanged(object sender, EventArgs e)
        {
            scoreboard.score1.Text = score1UpDown.Value.ToString();
        }

        private void score2UpDown_ValueChanged(object sender, EventArgs e)
        {
            scoreboard.score2.Text = score2UpDown.Value.ToString() ;
        }

        private void toolbox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((spaceToStart.Checked == true) && (e.KeyCode == Keys.Space))
            {
                if (jamStart.Enabled == true)
                {
                    jamStart_Click(sender, e);
                }
                else if (jamStop.Enabled == true)
                {
                    jamStop_Click(sender, e);
                }
            }
        }
        
        private void jamTime_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
        
        private void points1UpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space) { 
                e.SuppressKeyPress = true;
            }
        }

        private void points2UpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void points1UpDown_Enter(object sender, EventArgs e)
        {
            points1UpDown.Select(0, points1UpDown.Text.Length);
        }
        
        private void points2UpDown_Enter(object sender, EventArgs e)
        {
            points2UpDown.Select(0, points2UpDown.Text.Length);
        }

        private void jamMinuteUpDown_ValueChanged(object sender, EventArgs e)
        {
            jamTime.Value = (jamMinuteUpDown.Value * 60) + jamSecondUpDown.Value;

            scoreboard.jamMinute.Text = jamMinuteUpDown.Value.ToString();
        }

        private void jamSecondUpDown_ValueChanged(object sender, EventArgs e)
        {
            if(jamSecondUpDown.Value == 61)
            {
                jamMinuteUpDown.UpButton();
                jamSecondUpDown.Value = 0;
            }
            if ((jamSecondUpDown.Value == -1) && (jamMinuteUpDown.Value >= 1))
            {
                jamSecondUpDown.Value = 59;
                jamMinuteUpDown.DownButton();
            }
            else
            {
                //jamSecondUpDown.Value = 0;
            }

            jamTime.Value = (jamMinuteUpDown.Value * 60) + jamSecondUpDown.Value;
            scoreboard.jamSecond.Text = jamSecondUpDown.Value.ToString();
        }

        private void quarterMinuteUpDown_ValueChanged(object sender, EventArgs e)
        {

            quarterTime.Value = (quarterMinuteUpDown.Value * 60) + quarterSecondUpDown.Value;
            scoreboard.quarterMinute.Text = quarterMinuteUpDown.Value.ToString();
        }

        private void quarterSecondUpDown_ValueChanged(object sender, EventArgs e)
        {

            quarterTime.Value = (quarterMinuteUpDown.Value * 60) + quarterSecondUpDown.Value;
            scoreboard.quarterSecond.Text = quarterSecondUpDown.Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.SelectedPath = rootFolder;
            
            if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string team1 = fbd.SelectedPath; 
                string[] team1Roster = System.IO.Directory.GetFiles(fbd.SelectedPath);

                roster1.Items.Clear();

                foreach (string fi in team1Roster)
                {
                    string temp = Path.GetFileNameWithoutExtension(fi);
                    roster1.Items.Add(Path.GetFileNameWithoutExtension(fi));
                }
                scoreboard.team1.Text = this.team1.Text = Path.GetFileNameWithoutExtension(fbd.SelectedPath);

                scoreboard.team1Pic.Image = Image.FromFile(team1 + "\\" + this.team1.Text + ".jpg");
            }
            
            
        }

        private void team2_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.SelectedPath = rootFolder;
            
            if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string team2 = fbd.SelectedPath;
                string[] team2Roster = System.IO.Directory.GetFiles(fbd.SelectedPath);

                roster2.Items.Clear();

                foreach (string fi in team2Roster)
                {
                    string temp = Path.GetFileNameWithoutExtension(fi);
                    roster2.Items.Add(Path.GetFileNameWithoutExtension(fi));
                }
                scoreboard.team2.Text = this.team2.Text = Path.GetFileNameWithoutExtension(fbd.SelectedPath);
                scoreboard.team2Pic.Image = Image.FromFile(team2 + "\\" + this.team2.Text + ".jpg");
            }

        }
        
        private void roster1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            team1Jammers.Items.Clear();
            foreach (var Item in roster1.CheckedItems)
            {

                if (!team1Jammers.Items.Contains(Item))
                {
                    team1Jammers.Items.Add(Item);
                }

            }
            if (e.NewValue == CheckState.Checked)
                team1Jammers.Items.Add(roster1.Items[e.Index].ToString());
        }

        private void roster1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if ((roster1.SelectedIndex >= 0) & (introActive.Checked == true))
            {
                scoreboard.overlayPic.Size = scoreboard.Size;
                scoreboard.overlayPic.BringToFront();
                scoreboard.overlayPic.Visible = true;
            
                scoreboard.overlayPic.Image.Dispose();
                scoreboard.overlayPic.Image = Image.FromFile(rootFolder + "\\" + team1.Text + "\\" + roster1.Text + ".jpg");
            }

            roster2.ClearSelected();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (penaltyPicList.SelectedIndex >= 0)
            {
                scoreboard.overlayPic.Size = scoreboard.Size;
                scoreboard.overlayPic.BringToFront();
                scoreboard.overlayPic.Visible = true;

                scoreboard.overlayPic.Image.Dispose();
                if (File.Exists(rootFolder + "\\" + penaltyPicList.Text + ".png"))
                {
                    scoreboard.overlayPic.Image = Image.FromFile(rootFolder + "\\" + penaltyPicList.Text + ".png");
                }

            }

        }

        private void clearPenaltyPic_Click(object sender, EventArgs e)
        {
            penaltyPicList.ClearSelected();
            scoreboard.overlayPic.Visible = false;
        }

        private void hourTimerStart_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
            quarterMinuteUpDown.Value = 60;
            quarterSecondUpDown.Value = 0;
            GameTimer.Start();
        }

        private void halftimeTimerStart_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
            quarterMinuteUpDown.Value = 30;
            quarterSecondUpDown.Value = 0;
            GameTimer.Start();
        }

        private void quarterBreakTimerStart_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
            quarterMinuteUpDown.Value = 5;
            quarterSecondUpDown.Value = 0;
            GameTimer.Start();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            GameTimer.Stop();
            if (((17 - DateTime.Now.Hour) * 60) + (60 - DateTime.Now.Minute) >= 1)
            { 
                quarterMinuteUpDown.Value = ((17 - DateTime.Now.Hour) * 60) + (60 - DateTime.Now.Minute);
            }
            
            GameTimer.Start();
        }

        private void roster2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((roster2.SelectedIndex >= 0) & (introActive.Checked == true))
            {
                scoreboard.overlayPic.Size = scoreboard.Size;
                scoreboard.overlayPic.BringToFront();
                scoreboard.overlayPic.Visible = true;

                scoreboard.overlayPic.Image.Dispose();
                scoreboard.overlayPic.Image = Image.FromFile(rootFolder + "\\" + team2.Text + "\\" + roster2.Text + ".jpg");
            }

            roster1.ClearSelected();

        }

        private void roster2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            team2Jammers.Items.Clear();
            foreach (var Item in roster2.CheckedItems)
            {

                if (!team2Jammers.Items.Contains(Item))
                {
                    team2Jammers.Items.Add(Item);
                }

            }
            if (e.NewValue == CheckState.Checked)
                team2Jammers.Items.Add(roster2.Items[e.Index].ToString());

        }

        private void introActive_CheckedChanged(object sender, EventArgs e)
        {
            if (introActive.Checked == false)
            {
                introPicClear_Click(introPicClear,null);
            }
        }

        private void setRootFolder_Click(object sender, EventArgs e)
        {

        }

        private void showScoreboard_Click(object sender, EventArgs e)
        {
            scoreboard.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (points1UpDown.Visible == true)
            {
                points1UpDown.Visible = false;
                points2UpDown.Visible = false;
                addPoints.Visible = false;
                team1add1point.Visible = true;
                team1add4point.Visible = true;
                team1add5point.Visible = true;
                team2add1point.Visible = true;
                team2add4point.Visible = true;
                team2add5point.Visible = true;
            }
            else if (points1UpDown.Visible == false)
            {
                points1UpDown.Visible = true;
                points2UpDown.Visible = true;
                addPoints.Visible = true;
                team1add1point.Visible = false;
                team1add4point.Visible = false;
                team1add5point.Visible = false;
                team2add1point.Visible = false;
                team2add4point.Visible = false;
                team2add5point.Visible = false;
            }
        }

        private void team1add1point_Click(object sender, EventArgs e)
        {
            scoreboard.points1.Text = points1.Text = (Int32.Parse(points1.Text) + 1).ToString();
            score1UpDown.UpButton();
        }

        private void team1add4point_Click(object sender, EventArgs e)
        {
            scoreboard.points1.Text = points1.Text = (Int32.Parse(points1.Text) + 4).ToString();
            score1UpDown.UpButton();
            score1UpDown.UpButton();
            score1UpDown.UpButton();
            score1UpDown.UpButton();
        }

        private void team1add5point_Click(object sender, EventArgs e)
        {
            scoreboard.points1.Text = points1.Text = (Int32.Parse(points1.Text) + 5).ToString();
            score1UpDown.UpButton();
            score1UpDown.UpButton();
            score1UpDown.UpButton();
            score1UpDown.UpButton();
            score1UpDown.UpButton();
        }

        private void team2add1point_Click(object sender, EventArgs e)
        {
            scoreboard.points2.Text = points2.Text = (Int32.Parse(points2.Text) + 1).ToString();
            score2UpDown.UpButton();
        }

        private void team2add4point_Click(object sender, EventArgs e)
        {
            scoreboard.points2.Text = points2.Text = (Int32.Parse(points2.Text) + 4).ToString();
            score2UpDown.UpButton();
            score2UpDown.UpButton();
            score2UpDown.UpButton();
            score2UpDown.UpButton();
        }

        private void team2add5point_Click(object sender, EventArgs e)
        {
            scoreboard.points2.Text = points2.Text = (Int32.Parse(points2.Text) + 5).ToString();
            score2UpDown.UpButton();
            score2UpDown.UpButton();
            score2UpDown.UpButton();
            score2UpDown.UpButton();
            score2UpDown.UpButton();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jamSecondUpDown.Value = 0;
            jamMinuteUpDown.Value = 0;
            timeOutTimer.Start();

            scoreboard.timeOutLabel.Visible = true;

            state.Text = "OFFICAL TIME OUT";
            state.ForeColor = System.Drawing.Color.Red;
        }
    }
}
