using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace PlayGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            countdownLabel.Visible = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Properties.Resources.startblipSound);
            sp.Play();
            Thread.Sleep(1500);
            startButton.Visible = false;

            countdownLabel.Visible = true;
            sp.Play();
            Refresh();
            Thread.Sleep(1000);

            countdownLabel.Text = "2...";
            sp.Play();
            Refresh();
            Thread.Sleep(1000);

            countdownLabel.Text = "1...";
            sp.Play();
            Refresh();
            Thread.Sleep(1000);

            countdownLabel.Text = "GO!!!";
            countdownLabel.ForeColor = Color.White;
            countdownLabel.BackColor = Color.Green;
            //countdownLabel.Size = new Size(100, 100);
            countdownLabel.Font = new Font("Showcard Gothic", 150, FontStyle.Bold);

           
            {
                BackColor = Color.SpringGreen;
                Thread.Sleep(100);
                Refresh();
                BackColor = Color.White;
                Thread.Sleep(100);
                Refresh();
                //loop above six lines infinitely for visual effect
            }

            SoundPlayer sp2 = new SoundPlayer(Properties.Resources.gofanfareSound);
            sp2.Play();
        }
    }
}
