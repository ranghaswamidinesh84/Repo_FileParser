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

        bool parsing_file1_complete { get; set; }
        bool parsing_file2_complete { get; set; }
        bool parsing_file3_complete { get; set; }

        public form_fileparser()
        {
            InitializeComponent();
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            parsing_file1_complete = false;
            parsing_file2_complete = false;
            parsing_file3_complete = false;

            richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : Preparing for Parsing Files\n");
            richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : Cleaning Up Old Parsed Files\n");

            try
            {
                if (File.Exists(textbox_file1.Text + ".parse"))
                {
                    File.Delete(textbox_file1.Text + ".parse");
                    richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : Parsed Old File1 is deleted Successfully\n");
                }

                if (File.Exists(textbox_file2.Text + ".parse"))
                {
                    File.Delete(textbox_file2.Text + ".parse");
                    richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : Parsed Old File2 is deleted Successfully\n");
                }

                if (File.Exists(textbox_file3.Text + ".parse"))
                {
                    File.Delete(textbox_file3.Text + ".parse");
                    richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : Parsed Old File3 is deleted Successfully\n");
                }
            }

            catch (Exception Excp)
            {
                MessageBox.Show("Error: " + Excp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : " + Excp.Message + "\n");
            }

            if (textbox_file1.Text == "" && textbox_file2.Text == "" && textbox_file3.Text == "" )
            {
                MessageBox.Show("At Least One file should be selected","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : At Least One file should be selected\n");
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
                        parsing_file1_complete = true;
                        richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : File1 Parsing Completed\n");
                    }

                    catch (Exception Excp)
                    {
                        MessageBox.Show("Error: " + Excp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : " + Excp.Message + "\n");
                    }

                    try
                    {
                        StreamWriter sw1 = new StreamWriter(textbox_file1.Text + ".parse");
                        sw1.WriteLine(file1_data);
                        sw1.Close();
                    }

                    catch (Exception Excp)
                    {
                        MessageBox.Show("Error: " + Excp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : " + Excp.Message + "\n");
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
                        parsing_file2_complete = true;
                        richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : File2 Parsing Completed\n");
                    }

                    catch (Exception Excp)
                    {
                        MessageBox.Show("Error: " + Excp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : " + Excp.Message + "\n");
                    }

                    try
                    {
                        StreamWriter sw2 = new StreamWriter(textbox_file2.Text + ".parse");
                        sw2.WriteLine(file2_data);
                        sw2.Close();
                    }

                    catch (Exception Excp)
                    {
                        MessageBox.Show("Error: " + Excp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : " + Excp.Message + "\n");
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
                        parsing_file3_complete = true;
                        richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : File3 Parsing Completed\n");
                    }

                    catch (Exception Excp)
                    {
                        MessageBox.Show("Error: " + Excp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : " + Excp.Message + "\n");
                    }

                    try
                    {
                        StreamWriter sw3 = new StreamWriter(textbox_file3.Text + ".parse");
                        sw3.WriteLine(file3_data);
                        sw3.Close();
                    }

                    catch (Exception Excp)
                    {
                        MessageBox.Show("Error: " + Excp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : " + Excp.Message + "\n");
                    }

                }
            }
        }

        private void button_extract_Click(object sender, EventArgs e)
        {
            string selecteditem = combobox_medicaid_id_selector.GetItemText(combobox_medicaid_id_selector.SelectedItem);
            
            if (!parsing_file1_complete && !parsing_file2_complete && !parsing_file3_complete)
            {
                MessageBox.Show("Parsing not Completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : " + "Parsing not Completed\n");
            }
            if (selecteditem == "")
            {
                MessageBox.Show("Medicaid ID Segment Not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : " + "Medicaid ID Segment Not selected\n");
            }
            else
            {
                if (parsing_file1_complete)
                {
                    if (textbox_file1.Text != "")
                    {
                        string parse_file1_data;
                        parse_file1_data = "";
                        richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : " + "File1 Extraction in progress\n");

                        try
                        {
                            StreamReader psr1 = new StreamReader(textbox_file1.Text + ".parse");
                            StreamWriter psw1 = new StreamWriter(textbox_file1.Text + ".mdcdnum");

                            while ((parse_file1_data = psr1.ReadLine()) != null)
                            {
                                if (parse_file1_data.StartsWith(selecteditem, StringComparison.InvariantCultureIgnoreCase))
                                {
                                    parse_file1_data = parse_file1_data.ToUpper();
                                    parse_file1_data = parse_file1_data.Replace(selecteditem.ToUpper(), "");
                                    parse_file1_data = parse_file1_data.Replace("~", "");
                                    psw1.WriteLine(parse_file1_data);
                                }
                            }
                            richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : " + "File1 Extraction Completed\n");
                            psw1.Close();
                        }

                        catch (Exception Excp)
                        {
                            MessageBox.Show("Error: " + Excp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : " + Excp.Message + "\n");
                        }
                    }
                }

                if (parsing_file2_complete)
                {
                    if (textbox_file2.Text != "")
                    {
                        string parse_file2_data;
                        parse_file2_data = "";
                        richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : " + "File2 Extraction in progress\n");

                        try
                        {
                            StreamReader psr2 = new StreamReader(textbox_file2.Text + ".parse");
                            StreamWriter psw2 = new StreamWriter(textbox_file2.Text + ".mdcdnum");

                            while ((parse_file2_data = psr2.ReadLine()) != null)
                            {
                                if (parse_file2_data.StartsWith(selecteditem, StringComparison.InvariantCultureIgnoreCase))
                                {
                                    parse_file2_data = parse_file2_data.ToUpper();
                                    parse_file2_data = parse_file2_data.Replace(selecteditem.ToUpper(), "");
                                    parse_file2_data = parse_file2_data.Replace("~", "");
                                    psw2.WriteLine(parse_file2_data);
                                }
                            }
                            richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : " + "File2 Extraction Completed\n");
                            psw2.Close();
                        }

                        catch (Exception Excp)
                        {
                            MessageBox.Show("Error: " + Excp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : " + Excp.Message + "\n");
                        }
                    }
                }

                if (parsing_file3_complete)
                {
                    if (textbox_file3.Text != "")
                    {
                        string parse_file3_data;
                        parse_file3_data = "";
                        richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : " + "File2 Extraction in progress\n");

                        try
                        {
                            StreamReader psr3 = new StreamReader(textbox_file3.Text + ".parse");
                            StreamWriter psw3 = new StreamWriter(textbox_file3.Text + ".mdcdnum");

                            while ((parse_file3_data = psr3.ReadLine()) != null)
                            {
                                if (parse_file3_data.StartsWith(selecteditem, StringComparison.InvariantCultureIgnoreCase))
                                {
                                    parse_file3_data = parse_file3_data.ToUpper();
                                    parse_file3_data = parse_file3_data.Replace(selecteditem.ToUpper(), "");
                                    parse_file3_data = parse_file3_data.Replace("~", "");
                                    psw3.WriteLine(parse_file3_data);
                                }
                            }
                            richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : " + "File3 Extraction Completed\n");
                            psw3.Close();
                        }

                        catch (Exception Excp)
                        {
                            MessageBox.Show("Error: " + Excp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : " + Excp.Message + "\n");
                        }
                    }
                }
            }
        }

        private void form_fileparser_Load(object sender, EventArgs e)
        {
            richtextbox_status.AppendText("Log Messages:\n");
            richtextbox_status.AppendText("---------------------");
            richtextbox_status.SelectAll();
            richtextbox_status.SelectionFont = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            richtextbox_status.AppendText("\n\n");
            richtextbox_status.AppendText(DateTime.Now.ToShortTimeString() + " : Utility Initilized\n");
        }
    }
}

