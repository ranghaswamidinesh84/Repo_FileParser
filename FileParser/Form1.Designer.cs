﻿namespace FileParser
{
    partial class form_fileparser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_file1 = new System.Windows.Forms.Label();
            this.button_file1_browse = new System.Windows.Forms.Button();
            this.textbox_file1 = new System.Windows.Forms.TextBox();
            this.button_parse = new System.Windows.Forms.Button();
            this.button_extract = new System.Windows.Forms.Button();
            this.button_quit = new System.Windows.Forms.Button();
            this.label_medicaid_id_segment = new System.Windows.Forms.Label();
            this.combobox_medicaid_id_selector = new System.Windows.Forms.ComboBox();
            this.textbox_file2 = new System.Windows.Forms.TextBox();
            this.button_file2_browse = new System.Windows.Forms.Button();
            this.label_file2 = new System.Windows.Forms.Label();
            this.textbox_file3 = new System.Windows.Forms.TextBox();
            this.button_file3_browse = new System.Windows.Forms.Button();
            this.label_file3 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.textbox_status = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_file1
            // 
            this.label_file1.AutoSize = true;
            this.label_file1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_file1.Location = new System.Drawing.Point(18, 43);
            this.label_file1.Name = "label_file1";
            this.label_file1.Size = new System.Drawing.Size(139, 25);
            this.label_file1.TabIndex = 0;
            this.label_file1.Text = "Select  File1:";
            this.label_file1.Click += new System.EventHandler(this.label_file1_Click);
            // 
            // button_file1_browse
            // 
            this.button_file1_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_file1_browse.Location = new System.Drawing.Point(389, 33);
            this.button_file1_browse.Name = "button_file1_browse";
            this.button_file1_browse.Size = new System.Drawing.Size(118, 45);
            this.button_file1_browse.TabIndex = 1;
            this.button_file1_browse.Text = "Browse";
            this.button_file1_browse.UseVisualStyleBackColor = true;
            this.button_file1_browse.Click += new System.EventHandler(this.button_file1_browse_Click);
            // 
            // textbox_file1
            // 
            this.textbox_file1.Enabled = false;
            this.textbox_file1.Location = new System.Drawing.Point(185, 44);
            this.textbox_file1.Name = "textbox_file1";
            this.textbox_file1.Size = new System.Drawing.Size(176, 26);
            this.textbox_file1.TabIndex = 2;
            // 
            // button_parse
            // 
            this.button_parse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_parse.Location = new System.Drawing.Point(24, 289);
            this.button_parse.Name = "button_parse";
            this.button_parse.Size = new System.Drawing.Size(133, 45);
            this.button_parse.TabIndex = 3;
            this.button_parse.Text = "Parse";
            this.button_parse.UseVisualStyleBackColor = true;
            this.button_parse.Click += new System.EventHandler(this.button_parse_Click);
            // 
            // button_extract
            // 
            this.button_extract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_extract.Location = new System.Drawing.Point(199, 289);
            this.button_extract.Name = "button_extract";
            this.button_extract.Size = new System.Drawing.Size(133, 45);
            this.button_extract.TabIndex = 4;
            this.button_extract.Text = "Extract";
            this.button_extract.UseVisualStyleBackColor = true;
            this.button_extract.Click += new System.EventHandler(this.button_extract_Click);
            // 
            // button_quit
            // 
            this.button_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_quit.Location = new System.Drawing.Point(374, 289);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(133, 45);
            this.button_quit.TabIndex = 5;
            this.button_quit.Text = "Quit";
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // label_medicaid_id_segment
            // 
            this.label_medicaid_id_segment.AutoSize = true;
            this.label_medicaid_id_segment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_medicaid_id_segment.Location = new System.Drawing.Point(19, 227);
            this.label_medicaid_id_segment.Name = "label_medicaid_id_segment";
            this.label_medicaid_id_segment.Size = new System.Drawing.Size(225, 25);
            this.label_medicaid_id_segment.TabIndex = 6;
            this.label_medicaid_id_segment.Text = "Medicaid ID Segment:";
            // 
            // combobox_medicaid_id_selector
            // 
            this.combobox_medicaid_id_selector.FormattingEnabled = true;
            this.combobox_medicaid_id_selector.Items.AddRange(new object[] {
            "REF*0F*",
            "REF{0F{",
            "REF*ABB*"});
            this.combobox_medicaid_id_selector.Location = new System.Drawing.Point(264, 224);
            this.combobox_medicaid_id_selector.Name = "combobox_medicaid_id_selector";
            this.combobox_medicaid_id_selector.Size = new System.Drawing.Size(243, 28);
            this.combobox_medicaid_id_selector.TabIndex = 8;
            this.combobox_medicaid_id_selector.SelectedIndexChanged += new System.EventHandler(this.combobox_medicaid_id_selector_SelectedIndexChanged);
            // 
            // textbox_file2
            // 
            this.textbox_file2.Enabled = false;
            this.textbox_file2.Location = new System.Drawing.Point(185, 107);
            this.textbox_file2.Name = "textbox_file2";
            this.textbox_file2.Size = new System.Drawing.Size(176, 26);
            this.textbox_file2.TabIndex = 11;
            // 
            // button_file2_browse
            // 
            this.button_file2_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_file2_browse.Location = new System.Drawing.Point(389, 96);
            this.button_file2_browse.Name = "button_file2_browse";
            this.button_file2_browse.Size = new System.Drawing.Size(118, 45);
            this.button_file2_browse.TabIndex = 10;
            this.button_file2_browse.Text = "Browse";
            this.button_file2_browse.UseVisualStyleBackColor = true;
            this.button_file2_browse.Click += new System.EventHandler(this.button_file2_browse_Click);
            // 
            // label_file2
            // 
            this.label_file2.AutoSize = true;
            this.label_file2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_file2.Location = new System.Drawing.Point(18, 106);
            this.label_file2.Name = "label_file2";
            this.label_file2.Size = new System.Drawing.Size(139, 25);
            this.label_file2.TabIndex = 9;
            this.label_file2.Text = "Select  File2:";
            // 
            // textbox_file3
            // 
            this.textbox_file3.Enabled = false;
            this.textbox_file3.Location = new System.Drawing.Point(185, 170);
            this.textbox_file3.Name = "textbox_file3";
            this.textbox_file3.Size = new System.Drawing.Size(176, 26);
            this.textbox_file3.TabIndex = 14;
            // 
            // button_file3_browse
            // 
            this.button_file3_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_file3_browse.Location = new System.Drawing.Point(389, 159);
            this.button_file3_browse.Name = "button_file3_browse";
            this.button_file3_browse.Size = new System.Drawing.Size(118, 45);
            this.button_file3_browse.TabIndex = 13;
            this.button_file3_browse.Text = "Browse";
            this.button_file3_browse.UseVisualStyleBackColor = true;
            this.button_file3_browse.Click += new System.EventHandler(this.button_file3_browse_Click);
            // 
            // label_file3
            // 
            this.label_file3.AutoSize = true;
            this.label_file3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_file3.Location = new System.Drawing.Point(18, 169);
            this.label_file3.Name = "label_file3";
            this.label_file3.Size = new System.Drawing.Size(139, 25);
            this.label_file3.TabIndex = 12;
            this.label_file3.Text = "Select  File3:";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(19, 373);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(150, 25);
            this.label_status.TabIndex = 15;
            this.label_status.Text = "Parser Status:";
            // 
            // textbox_status
            // 
            this.textbox_status.Enabled = false;
            this.textbox_status.Location = new System.Drawing.Point(199, 374);
            this.textbox_status.Name = "textbox_status";
            this.textbox_status.Size = new System.Drawing.Size(308, 26);
            this.textbox_status.TabIndex = 16;
            this.textbox_status.Text = "Utility Initialized";
            this.textbox_status.TextChanged += new System.EventHandler(this.textbox_status_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Extractor Status:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(199, 423);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 26);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Utility Initialized";
            // 
            // form_fileparser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 470);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_status);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.textbox_file3);
            this.Controls.Add(this.button_file3_browse);
            this.Controls.Add(this.label_file3);
            this.Controls.Add(this.textbox_file2);
            this.Controls.Add(this.button_file2_browse);
            this.Controls.Add(this.label_file2);
            this.Controls.Add(this.combobox_medicaid_id_selector);
            this.Controls.Add(this.label_medicaid_id_segment);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.button_extract);
            this.Controls.Add(this.button_parse);
            this.Controls.Add(this.textbox_file1);
            this.Controls.Add(this.button_file1_browse);
            this.Controls.Add(this.label_file1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_fileparser";
            this.Text = "Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_file1;
        private System.Windows.Forms.Button button_file1_browse;
        private System.Windows.Forms.TextBox textbox_file1;
        private System.Windows.Forms.Button button_parse;
        private System.Windows.Forms.Button button_extract;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.Label label_medicaid_id_segment;
        private System.Windows.Forms.ComboBox combobox_medicaid_id_selector;
        private System.Windows.Forms.TextBox textbox_file2;
        private System.Windows.Forms.Button button_file2_browse;
        private System.Windows.Forms.Label label_file2;
        private System.Windows.Forms.TextBox textbox_file3;
        private System.Windows.Forms.Button button_file3_browse;
        private System.Windows.Forms.Label label_file3;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.TextBox textbox_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

