using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Hasher
{
    public partial class Hasher : Form
    {
        public Hasher()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //this app coded By Rizer Coder
            //u can edit any thing but u should let the app (open source)
            //contact twitter : Rizer09
            string xC = this.comboBox1.SelectedItem.ToString();
            if (xC == "MD5")
            {
                string cmd5;
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                UTF8Encoding utf = new UTF8Encoding();
                cmd5 = (BitConverter.ToString(md5.ComputeHash(utf.GetBytes(textBox1.Text))));
                textBox2.Text = cmd5.Replace("-", "");
            }
            else if (xC == "SHA1")
            {
                string csha1;
                SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
                UTF8Encoding utf = new UTF8Encoding();
                csha1 = (BitConverter.ToString(sha1.ComputeHash(utf.GetBytes(textBox1.Text))));
                textBox2.Text = csha1.Replace("-", "");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedItem.ToString() == "MD5" || this.comboBox1.SelectedItem.ToString() == "SHA1")
            {
                button1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This App By Rizer\n2017-2018");
        }
    }
}
