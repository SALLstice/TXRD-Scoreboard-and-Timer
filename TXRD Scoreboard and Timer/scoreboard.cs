using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TXRD_Scoreboard_and_Timer
{
    public partial class scoreboard : Form

    {

        
        public scoreboard()
        {
            InitializeComponent();
           // this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void team1Score_Click(object sender, EventArgs e)
        {

        }

        private void scoreboard_SizeChanged(object sender, EventArgs e)
        {
            int sizeX = this.Size.Width;
            int sizeY = this.Size.Height;

            label4.Text = "win size: =" + sizeY.ToString();
            label6.Text = "banner loc: " + ((0.81 * sizeY)).ToString();

            team1.Location = new Point(30, 90);
            team1.Size = new Size(154,46);
            
            txrdLogo.Size = new Size(this.Size.Width, 79);

            adBanner.Location = new Point(0, (Int32)(0.81 * sizeY));
            adBanner.Size = new Size(sizeX, (Int32)(0.1310 * sizeY));
        }

        private void scoreboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel= true;
        }


    }
}
