namespace PrisonManagementSystem
{
    partial class frm_prs_info_mpl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_prs_info_mpl));
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.cmb_prs_gender = new System.Windows.Forms.ComboBox();
            this.txt_prs_moi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_prs_dob = new System.Windows.Forms.DateTimePicker();
            this.txt_prs_nic = new System.Windows.Forms.TextBox();
            this.txt_prs_ph = new System.Windows.Forms.TextBox();
            this.txt_prs_add = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_prs_fname = new System.Windows.Forms.TextBox();
            this.txt_prs_name = new System.Windows.Forms.TextBox();
            this.txt_P_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_prs_info_dsp = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.recordDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(41, 457);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(143, 31);
            this.txt_search.TabIndex = 11;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.Click += new System.EventHandler(this.txt_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_delete.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(470, 494);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 50);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Delete Record";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.btn_add.Location = new System.Drawing.Point(354, 494);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 50);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Add Record";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_update.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(239, 494);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 50);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Update Record";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_search.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(64, 494);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 50);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "Search Record";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cmb_prs_gender
            // 
            this.cmb_prs_gender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_prs_gender.FormattingEnabled = true;
            this.cmb_prs_gender.Location = new System.Drawing.Point(620, 254);
            this.cmb_prs_gender.Name = "cmb_prs_gender";
            this.cmb_prs_gender.Size = new System.Drawing.Size(188, 27);
            this.cmb_prs_gender.TabIndex = 6;
            // 
            // txt_prs_moi
            // 
            this.txt_prs_moi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prs_moi.Location = new System.Drawing.Point(620, 372);
            this.txt_prs_moi.Name = "txt_prs_moi";
            this.txt_prs_moi.Size = new System.Drawing.Size(188, 26);
            this.txt_prs_moi.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(448, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mark of Identification:";
            // 
            // dtp_prs_dob
            // 
            this.dtp_prs_dob.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_prs_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_prs_dob.Location = new System.Drawing.Point(620, 216);
            this.dtp_prs_dob.Name = "dtp_prs_dob";
            this.dtp_prs_dob.Size = new System.Drawing.Size(188, 26);
            this.dtp_prs_dob.TabIndex = 5;
            this.dtp_prs_dob.ValueChanged += new System.EventHandler(this.dtp_prs_dob_ValueChanged);
            this.dtp_prs_dob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_prs_dob_KeyDown);
            // 
            // txt_prs_nic
            // 
            this.txt_prs_nic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prs_nic.Location = new System.Drawing.Point(620, 333);
            this.txt_prs_nic.Name = "txt_prs_nic";
            this.txt_prs_nic.Size = new System.Drawing.Size(188, 26);
            this.txt_prs_nic.TabIndex = 8;
            // 
            // txt_prs_ph
            // 
            this.txt_prs_ph.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prs_ph.Location = new System.Drawing.Point(620, 294);
            this.txt_prs_ph.Name = "txt_prs_ph";
            this.txt_prs_ph.Size = new System.Drawing.Size(188, 26);
            this.txt_prs_ph.TabIndex = 7;
            // 
            // txt_prs_add
            // 
            this.txt_prs_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prs_add.Location = new System.Drawing.Point(185, 333);
            this.txt_prs_add.Multiline = true;
            this.txt_prs_add.Name = "txt_prs_add";
            this.txt_prs_add.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_prs_add.Size = new System.Drawing.Size(196, 64);
            this.txt_prs_add.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(448, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "NIC No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(448, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phone No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address:";
            // 
            // txt_prs_fname
            // 
            this.txt_prs_fname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prs_fname.Location = new System.Drawing.Point(185, 294);
            this.txt_prs_fname.Name = "txt_prs_fname";
            this.txt_prs_fname.Size = new System.Drawing.Size(196, 26);
            this.txt_prs_fname.TabIndex = 3;
            // 
            // txt_prs_name
            // 
            this.txt_prs_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prs_name.Location = new System.Drawing.Point(185, 255);
            this.txt_prs_name.Name = "txt_prs_name";
            this.txt_prs_name.Size = new System.Drawing.Size(196, 26);
            this.txt_prs_name.TabIndex = 2;
            // 
            // txt_P_id
            // 
            this.txt_P_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P_id.Location = new System.Drawing.Point(185, 216);
            this.txt_P_id.Name = "txt_P_id";
            this.txt_P_id.Size = new System.Drawing.Size(196, 26);
            this.txt_P_id.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(448, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Father Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prisoner ID:";
            // 
            // btn_prs_info_dsp
            // 
            this.btn_prs_info_dsp.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_prs_info_dsp.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prs_info_dsp.ForeColor = System.Drawing.Color.White;
            this.btn_prs_info_dsp.Location = new System.Drawing.Point(777, 438);
            this.btn_prs_info_dsp.Name = "btn_prs_info_dsp";
            this.btn_prs_info_dsp.Size = new System.Drawing.Size(138, 50);
            this.btn_prs_info_dsp.TabIndex = 10;
            this.btn_prs_info_dsp.Text = "Display Prisoner Info";
            this.btn_prs_info_dsp.UseVisualStyleBackColor = false;
            this.btn_prs_info_dsp.Click += new System.EventHandler(this.btn_prs_info_dsp_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_preview.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.ForeColor = System.Drawing.Color.White;
            this.btn_preview.Location = new System.Drawing.Point(654, 438);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(117, 50);
            this.btn_preview.TabIndex = 49;
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
            this.label12.Location = new System.Drawing.Point(62, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(683, 55);
            this.label12.TabIndex = 50;
            this.label12.Text = "PRISONER INFORMATION";
            // 
            // frm_prs_info_mpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 552);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.btn_prs_info_dsp);
            this.Controls.Add(this.cmb_prs_gender);
            this.Controls.Add(this.txt_prs_moi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtp_prs_dob);
            this.Controls.Add(this.txt_prs_nic);
            this.Controls.Add(this.txt_prs_ph);
            this.Controls.Add(this.txt_prs_add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_prs_fname);
            this.Controls.Add(this.txt_prs_name);
            this.Controls.Add(this.txt_P_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_prs_info_mpl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prisoner_Prsonal_Info";
            this.Load += new System.EventHandler(this.frm_prs_info_mpl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cmb_prs_gender;
        private System.Windows.Forms.TextBox txt_prs_moi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_prs_dob;
        private System.Windows.Forms.TextBox txt_prs_nic;
        private System.Windows.Forms.TextBox txt_prs_ph;
        private System.Windows.Forms.TextBox txt_prs_add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_prs_fname;
        private System.Windows.Forms.TextBox txt_prs_name;
        private System.Windows.Forms.TextBox txt_P_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_prs_info_dsp;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument recordDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Label label12;

    }
}