namespace PrisonManagementSystem
{
    partial class frm_visit_mpl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_visit_mpl));
            this.cmb_relation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_etime = new System.Windows.Forms.DateTimePicker();
            this.txt_V_ph = new System.Windows.Forms.TextBox();
            this.txt_V_add = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_V_name = new System.Windows.Forms.TextBox();
            this.txt_prs_id = new System.Windows.Forms.TextBox();
            this.txt_V_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.dtp_V_date = new System.Windows.Forms.DateTimePicker();
            this.dtp_btime = new System.Windows.Forms.DateTimePicker();
            this.btn_visit_dsp = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.recordDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_relation
            // 
            this.cmb_relation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_relation.FormattingEnabled = true;
            this.cmb_relation.Location = new System.Drawing.Point(635, 218);
            this.cmb_relation.Name = "cmb_relation";
            this.cmb_relation.Size = new System.Drawing.Size(224, 27);
            this.cmb_relation.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(481, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Begin Time of Visit:";
            // 
            // dtp_etime
            // 
            this.dtp_etime.CustomFormat = "  ";
            this.dtp_etime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_etime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_etime.Location = new System.Drawing.Point(635, 372);
            this.dtp_etime.Name = "dtp_etime";
            this.dtp_etime.ShowUpDown = true;
            this.dtp_etime.Size = new System.Drawing.Size(224, 26);
            this.dtp_etime.TabIndex = 9;
            this.dtp_etime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_etime_KeyDown);
            this.dtp_etime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtp_etime_MouseDown);
            // 
            // txt_V_ph
            // 
            this.txt_V_ph.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_V_ph.Location = new System.Drawing.Point(635, 258);
            this.txt_V_ph.Name = "txt_V_ph";
            this.txt_V_ph.Size = new System.Drawing.Size(224, 26);
            this.txt_V_ph.TabIndex = 6;
            // 
            // txt_V_add
            // 
            this.txt_V_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_V_add.Location = new System.Drawing.Point(182, 333);
            this.txt_V_add.Multiline = true;
            this.txt_V_add.Name = "txt_V_add";
            this.txt_V_add.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_V_add.Size = new System.Drawing.Size(224, 64);
            this.txt_V_add.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(482, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Visit Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(482, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phone No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(482, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "End Time of Visit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address:";
            // 
            // txt_V_name
            // 
            this.txt_V_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_V_name.Location = new System.Drawing.Point(182, 294);
            this.txt_V_name.Name = "txt_V_name";
            this.txt_V_name.Size = new System.Drawing.Size(224, 26);
            this.txt_V_name.TabIndex = 3;
            // 
            // txt_prs_id
            // 
            this.txt_prs_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prs_id.Location = new System.Drawing.Point(182, 255);
            this.txt_prs_id.Name = "txt_prs_id";
            this.txt_prs_id.Size = new System.Drawing.Size(224, 26);
            this.txt_prs_id.TabIndex = 2;
            // 
            // txt_V_id
            // 
            this.txt_V_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_V_id.Location = new System.Drawing.Point(182, 216);
            this.txt_V_id.Name = "txt_V_id";
            this.txt_V_id.Size = new System.Drawing.Size(224, 26);
            this.txt_V_id.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(481, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Relation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Visitor Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prisoner ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visit ID:";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(25, 457);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(138, 31);
            this.txt_search.TabIndex = 11;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.Click += new System.EventHandler(this.txt_search_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_new.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(585, 494);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(100, 50);
            this.btn_new.TabIndex = 17;
            this.btn_new.Text = "New Record";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_print.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(700, 494);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(100, 50);
            this.btn_print.TabIndex = 18;
            this.btn_print.Text = "Print Record";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_back.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(815, 494);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 50);
            this.btn_back.TabIndex = 19;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_add.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(469, 494);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 50);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Add Record";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_search.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(43, 494);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 50);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "Search Record";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dtp_V_date
            // 
            this.dtp_V_date.CustomFormat = " ";
            this.dtp_V_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_V_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_V_date.Location = new System.Drawing.Point(635, 297);
            this.dtp_V_date.Name = "dtp_V_date";
            this.dtp_V_date.Size = new System.Drawing.Size(224, 26);
            this.dtp_V_date.TabIndex = 7;
            this.dtp_V_date.ValueChanged += new System.EventHandler(this.dtp_V_date_ValueChanged);
            this.dtp_V_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_V_date_KeyDown);
            // 
            // dtp_btime
            // 
            this.dtp_btime.CustomFormat = " ";
            this.dtp_btime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_btime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_btime.Location = new System.Drawing.Point(635, 336);
            this.dtp_btime.Name = "dtp_btime";
            this.dtp_btime.ShowUpDown = true;
            this.dtp_btime.Size = new System.Drawing.Size(224, 26);
            this.dtp_btime.TabIndex = 8;
            this.dtp_btime.Value = new System.DateTime(2019, 6, 3, 20, 18, 11, 0);
            this.dtp_btime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_btime_KeyDown);
            this.dtp_btime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtp_btime_MouseDown);
            // 
            // btn_visit_dsp
            // 
            this.btn_visit_dsp.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_visit_dsp.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visit_dsp.ForeColor = System.Drawing.Color.White;
            this.btn_visit_dsp.Location = new System.Drawing.Point(815, 438);
            this.btn_visit_dsp.Name = "btn_visit_dsp";
            this.btn_visit_dsp.Size = new System.Drawing.Size(100, 50);
            this.btn_visit_dsp.TabIndex = 10;
            this.btn_visit_dsp.Text = "Display Visit Info";
            this.btn_visit_dsp.UseVisualStyleBackColor = false;
            this.btn_visit_dsp.Click += new System.EventHandler(this.btn_visit_dsp_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_preview.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.ForeColor = System.Drawing.Color.White;
            this.btn_preview.Location = new System.Drawing.Point(700, 438);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(100, 50);
            this.btn_preview.TabIndex = 52;
            this.btn_preview.Text = "Print Preview";
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // recordDocument
            // 
            this.recordDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.recordDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(126, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(559, 55);
            this.label12.TabIndex = 53;
            this.label12.Text = "VISIT INFORMATION";
            // 
            // frm_visit_mpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 552);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.btn_visit_dsp);
            this.Controls.Add(this.dtp_btime);
            this.Controls.Add(this.dtp_V_date);
            this.Controls.Add(this.cmb_relation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_etime);
            this.Controls.Add(this.txt_V_ph);
            this.Controls.Add(this.txt_V_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_V_name);
            this.Controls.Add(this.txt_prs_id);
            this.Controls.Add(this.txt_V_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_visit_mpl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visit_Info";
            this.Load += new System.EventHandler(this.frm_visit_mpl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_relation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_etime;
        private System.Windows.Forms.TextBox txt_V_ph;
        private System.Windows.Forms.TextBox txt_V_add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_V_name;
        private System.Windows.Forms.TextBox txt_prs_id;
        private System.Windows.Forms.TextBox txt_V_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker dtp_V_date;
        private System.Windows.Forms.DateTimePicker dtp_btime;
        private System.Windows.Forms.Button btn_visit_dsp;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument recordDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Label label12;

    }
}