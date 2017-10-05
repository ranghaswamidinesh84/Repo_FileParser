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

namespace FileParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                textBox1.Text = path;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                textBox2.Text = path;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                textBox3.Text = path;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(textBox1.Text +".parse"))
                {
                    File.Delete(textBox1.Text + ".parse");
                }

                if (File.Exists(textBox2.Text + ".parse"))
                {
                    File.Delete(textBox2.Text + ".parse");
                }

                if (File.Exists(textBox3.Text + ".parse"))
                {
                    File.Delete(textBox3.Text + ".parse");
                }
            }

            catch (Exception Excp)
            {
                MessageBox.Show("Error: " + Excp.Message);
            }

            string file1_data;
            file1_data = "";

            try
            {
                StreamReader sr1 = new StreamReader(textBox1.Text);
                file1_data = sr1.ReadToEnd();
                file1_data = file1_data.Replace("\r\n", "").Trim();
                file1_data = file1_data.Replace("~", "~\r\n");
                sr1.Close();
            }

            catch (Exception Excp)
            {
                MessageBox.Show("Error: " + Excp.Message);
            }

            try
            {
                StreamWriter sw1 = new StreamWriter(textBox1.Text + ".parse");
                sw1.WriteLine(file1_data);
                sw1.Close();
            }

            catch (Exception Excp)
            {
                MessageBox.Show("Error: " + Excp.Message);
            }

            if (textBox2.Text != "")
            {
                string file2_data;
                file2_data = "";

                try
                {
                    StreamReader sr2 = new StreamReader(textBox2.Text);
                    file2_data = sr2.ReadToEnd();
                    file2_data = file2_data.Replace("\r\n", "").Trim();
                    file2_data = file2_data.Replace("~", "~\r\n");
                    sr2.Close();
                }

                catch (Exception Excp)
                {
                    MessageBox.Show("Error: " + Excp.Message);
                }

                try
                {
                    StreamWriter sw2 = new StreamWriter(textBox2.Text + ".parse");
                    sw2.WriteLine(file1_data);
                    sw2.Close();
                }

                catch (Exception Excp)
                {
                    MessageBox.Show("Error: " + Excp.Message);
                    }
                }
            }
    }
}

