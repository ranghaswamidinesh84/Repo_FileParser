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

            if (textbox_file1.Text == "" && textbox_file2.Text == "" && textbox_file3.Text == "" )
            {
                MessageBox.Show("At Least One file should be selected","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (textbox_file1.Text != "")
                {
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
                        textbox_status.Text = "File2 Parsing Completed Successfully";
                    }

                    catch (Exception Excp)
                    {
                        MessageBox.Show("Error: " + Excp.Message);
                        textbox_status.Text = "File2 Parsing Failed";
                    }

                    try
                    {
                        StreamWriter sw2 = new StreamWriter(textbox_file2.Text + ".parse");
                        sw2.WriteLine(file2_data);
                        sw2.Close();
                        textbox_status.Text = "Parsed File2 Saved in the current path";
                    }

                    catch (Exception Excp)
                    {
                        MessageBox.Show("Error: " + Excp.Message);
                        textbox_status.Text = "Parsed File2 couldn't be saved to current path";
                    }
                }

                if (textbox_file3.Text != "")
                {
                    string file3_data;
                    file3_data = "";

                    try
                    {
                        StreamReader sr3 = new StreamReader(textbox_file3.Text);
                        file3_data = sr3.ReadToEnd();
                        file3_data = file3_data.Replace("\r\n", "").Trim();
                        file3_data = file3_data.Replace("~", "~\r\n");
                        sr3.Close();
                        textbox_status.Text = "File3 Parsing Completed Successfully";
                    }

                    catch (Exception Excp)
                    {
                        MessageBox.Show("Error: " + Excp.Message);
                        textbox_status.Text = "File3 Parsing Failed";
                    }

                    try
                    {
                        StreamWriter sw3 = new StreamWriter(textbox_file3.Text + ".parse");
                        sw3.WriteLine(file3_data);
                        sw3.Close();
                        textbox_status.Text = "Parsed File3 Saved in the current path";
                    }

                    catch (Exception Excp)
                    {
                        MessageBox.Show("Error: " + Excp.Message);
                        textbox_status.Text = "Parsed File3 couldn't be saved to current path";
                    }

                }
            }
        }

        private void button_extract_Click(object sender, EventArgs e)
        {
            string selecteditem = combobox_medicaid_id_selector.GetItemText(combobox_medicaid_id_selector.SelectedItem);
            if (selecteditem == "")
            {
                MessageBox.Show("Medicaid ID Segment Not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string parse_file1_data;
                parse_file1_data = "";

                try
                {
                    StreamReader psr1 = new StreamReader(textbox_file3.Text + ".parse");
                    parse_file1_data = psr1.ReadToEnd();
                    parse_file1_data = parse_file1_data.Replace("\r\n", "").Trim();
                    parse_file1_data = parse_file1_data.Replace("~", "~\r\n");
                    psr1.Close();
                    textbox_status.Text = "File1 Parsing Completed Successfully";
                }

                catch (Exception Excp)
                {
                    MessageBox.Show("Error: " + Excp.Message);
                    textbox_status.Text = "File3 Parsing Failed";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_status_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

