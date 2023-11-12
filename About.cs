using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColleiVoiceSpeaker
{
    public partial class About : Form
    {
        public Image[] images =
        {
            Properties.Resources._1,
            Properties.Resources._2,
            Properties.Resources._3,
            Properties.Resources._4,
            Properties.Resources._5,
        };
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            pictureBox1.Image = images[random.Next(images.Length)];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startURL("https://github.com/Rosalina129/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            startURL("https://space.bilibili.com/250609235?spm_id_from=333.1007.0.0/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            startURL("https://colleimadcat.com/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            startURL("https://genshinvoice.top/");
        }

        private void startURL(string url)
        {
            var psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
