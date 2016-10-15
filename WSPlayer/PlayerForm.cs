using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSPlayer
{
    public partial class PlayerForm : Form
    {
        public PlayerForm()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.settings.volume = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 3;
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 5;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 10;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 15;
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void axWindowsMediaPlayer1_KeyPressEvent(object sender, AxWMPLib._WMPOCXEvents_KeyPressEvent e)
        {
        }

        private void PlayerForm_KeyDown(object sender, KeyEventArgs e)
        {
            
            switch (e.KeyCode)
            {
                case Keys.F5:
                    button1_Click(sender, e);
                    break;
                case Keys.F6:
                    button2_Click(sender, e);
                    break;
                case Keys.F7:
                    button3_Click(sender, e);
                    break;
                case Keys.F8:
                    button4_Click(sender, e);
                    break;
                case Keys.F9:
                    button6_Click(sender, e);
                    break;
                case Keys.F10:
                    button7_Click(sender, e);
                    break;
                case Keys.F11:
                    button3_Click(sender, e);
                    break;
                case Keys.F12:
                    button4_Click(sender, e);
                    break;
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowDialog();
            var lista = Directory.GetFiles(fd.SelectedPath);

            comboBox1.Items.Clear();
            comboBox1.SelectedText = "";

            foreach (var f in lista)
            {

                comboBox1.Items.Add(f);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 3;
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void button7_Click(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 5;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 10;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 15;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
