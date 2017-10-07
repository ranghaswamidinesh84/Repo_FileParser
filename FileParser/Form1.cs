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
    public partial class form_fileparser : Form
    {
        public form_fileparser()
        {
            InitializeComponent();
        }

        private void label_file1_Click(object sender, EventArgs e)
        {

        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combobox_medicaid_id_selector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_file1_browse_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                textbox_file1.Text = path;
            }
        }

        private void button_file2_browse_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                textbox_file2.Text = path;
            }
        }

        private void button_file3_browse_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                textbox_file3.Text = path;
            }
        }

        private void button_parse_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(textbox_file1.Text +".parse"))
                {
                    File.Delete(textbox_file1.Text + ".parse");
                }

                if (File.Exists(textbox_file2.Text + ".parse"))
                {
                    File.Delete(textbox_file2.Text + ".parse");
                }

                if (File.Exists(textbox_file3.Text + ".parse"))
                {
                    File.Delete(textbox_file3.Text + ".parse");
                }
            }

            catch (Exception Excp)
            {
                MessageBox.Show("Error: " + Excp.Message);
                textbox_status.Text = "Older Files deletion Failed";
            }

            string file1_data;
            file1_data = "";

            try
            {
                StreamReader sr1 = new StreamReader(textbox_file1.Text);
                file1_data = sr1.ReadToEnd();
                file1_data = file1_data.Replace("\r\n", "").Trim();
                file1_data = file1_data.Replace("~", "~\r\n");
                sr1.Close();
                textbox_status.Text = "File1 Parsing Completed Successfully";
            }

            catch (Exception Excp)
            {
                MessageBox.Show("Error: " + Excp.Message);
                textbox_status.Text = "File1 Parsing Failed";
            }

            try
            {
                StreamWriter sw1 = new StreamWriter(textbox_file1.Text + ".parse");
                sw1.WriteLine(file1_data);
                sw1.Close();
                textbox_status.Text = "Parsed File1 Saved in the current path";
            }

            catch (Exception Excp)
            {
                MessageBox.Show("Error: " + Excp.Message);
                textbox_status.Text = "Parsed File1 couldn't be saved to current path";
            }

            if (textbox_file2.Text != "")
            {
                string file2_data;
                file2_data = "";

                try
                {
                    StreamReader sr2 = new StreamReader(textbox_file2.Text);
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
                    StreamWriter sw2 = new StreamWriter(textbox_file2.Text + ".parse");
                    sw2.WriteLine(file1_data);
                    sw2.Close();
                }

                catch (Exception Excp)
                {
                    MessageBox.Show("Error: " + Excp.Message);

                }
            }
        }

        private void button_extract_Click(object sender, EventArgs e)
        {

        }
    }
}

