﻿namespace PrisonManagementSystem
{
    partial class frm_grd_info_dsp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_grd_info_dsp));
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_print_rec = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_print_table = new System.Windows.Forms.Button();
            this.txt_grd_nic = new System.Windows.Forms.TextBox();
            this.txt_grd_sal = new System.Windows.Forms.TextBox();
            this.txt_grd_add = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_grd_ph = new System.Windows.Forms.TextBox();
            this.txt_B_id = new System.Windows.Forms.TextBox();
            this.txt_grd_name = new System.Windows.Forms.TextBox();
            this.txt_G_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dgv_grd = new System.Windows.Forms.DataGridView();
            this.txt_grd_jd = new System.Windows.Forms.TextBox();
            this.btn_save_file = new System.Windows.Forms.Button();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.recordDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.tableDocument = new System.Drawing.Printing.PrintDocument();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grd)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_last
            // 
            this.btn_last.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_last.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last.ForeColor = System.Drawing.Color.White;
            this.btn_last.Location = new System.Drawing.Point(469, 491);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(100, 50);
            this.btn_last.TabIndex = 15;
            this.btn_last.Text = "Last Record";
            this.btn_last.UseVisualStyleBackColor = false;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_print_rec
            // 
            this.btn_print_rec.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_print_rec.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_rec.ForeColor = System.Drawing.Color.White;
            this.btn_print_rec.Location = new System.Drawing.Point(697, 491);
            this.btn_print_rec.Name = "btn_print_rec";
            this.btn_print_rec.Size = new System.Drawing.Size(100, 50);
            this.btn_print_rec.TabIndex = 17;
            this.btn_print_rec.Text = "Print Record";
            this.btn_print_rec.UseVisualStyleBackColor = false;
            this.btn_print_rec.Click += new System.EventHandler(this.btn_print_rec_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_back.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(812, 491);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 50);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_next.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Location = new System.Drawing.Point(354, 491);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(100, 50);
            this.btn_next.TabIndex = 14;
            this.btn_next.Text = "Next Record";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_previous.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.ForeColor = System.Drawing.Color.White;
            this.btn_previous.Location = new System.Drawing.Point(239, 491);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(100, 50);
            this.btn_previous.TabIndex = 13;
            this.btn_previous.Text = "Previous Record";
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_first
            // 
            this.btn_first.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_first.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_first.ForeColor = System.Drawing.Color.White;
            this.btn_first.Location = new System.Drawing.Point(124, 491);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(100, 50);
            this.btn_first.TabIndex = 12;
            this.btn_first.Text = "First Record";
            this.btn_first.UseVisualStyleBackColor = false;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_search.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(9, 491);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 50);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Search Record";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_preview.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.ForeColor = System.Drawing.Color.White;
            this.btn_preview.Location = new System.Drawing.Point(583, 491);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(100, 50);
            this.btn_preview.TabIndex = 16;
            this.btn_preview.Text = "Rec Print Preview";
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_print_table
            // 
            this.btn_print_table.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_print_table.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_table.ForeColor = System.Drawing.Color.White;
            this.btn_print_table.Location = new System.Drawing.Point(656, 435);
            this.btn_print_table.Name = "btn_print_table";
            this.btn_print_table.Size = new System.Drawing.Size(100, 50);
            this.btn_print_table.TabIndex = 9;
            this.btn_print_table.Text = "Print Table";
            this.btn_print_table.UseVisualStyleBackColor = false;
            this.btn_print_table.Click += new System.EventHandler(this.btn_print_table_Click);
            // 
            // txt_grd_nic
            // 
            this.txt_grd_nic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grd_nic.Location = new System.Drawing.Point(142, 393);
            this.txt_grd_nic.Name = "txt_grd_nic";
            this.txt_grd_nic.ReadOnly = true;
            this.txt_grd_nic.Size = new System.Drawing.Size(224, 26);
            this.txt_grd_nic.TabIndex = 8;
            // 
            // txt_grd_sal
            // 
            this.txt_grd_sal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grd_sal.Location = new System.Drawing.Point(142, 362);
            this.txt_grd_sal.Name = "txt_grd_sal";
            this.txt_grd_sal.ReadOnly = true;
            this.txt_grd_sal.Size = new System.Drawing.Size(224, 26);
            this.txt_grd_sal.TabIndex = 7;
            // 
            // txt_grd_add
            // 
            this.txt_grd_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grd_add.Location = new System.Drawing.Point(142, 269);
            this.txt_grd_add.Name = "txt_grd_add";
            this.txt_grd_add.ReadOnly = true;
            this.txt_grd_add.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_grd_add.Size = new System.Drawing.Size(224, 26);
            this.txt_grd_add.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 396);
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
            this.label7.Location = new System.Drawing.Point(30, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Salary:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Joining Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address:";
            // 
            // txt_grd_ph
            // 
            this.txt_grd_ph.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grd_ph.Location = new System.Drawing.Point(142, 331);
            this.txt_grd_ph.Name = "txt_grd_ph";
            this.txt_grd_ph.ReadOnly = true;
            this.txt_grd_ph.Size = new System.Drawing.Size(224, 26);
            this.txt_grd_ph.TabIndex = 6;
            // 
            // txt_B_id
            // 
            this.txt_B_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_B_id.Location = new System.Drawing.Point(142, 238);
            this.txt_B_id.Name = "txt_B_id";
            this.txt_B_id.ReadOnly = true;
            this.txt_B_id.Size = new System.Drawing.Size(224, 26);
            this.txt_B_id.TabIndex = 3;
            // 
            // txt_grd_name
            // 
            this.txt_grd_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grd_name.Location = new System.Drawing.Point(142, 207);
            this.txt_grd_name.Name = "txt_grd_name";
            this.txt_grd_name.ReadOnly = true;
            this.txt_grd_name.Size = new System.Drawing.Size(224, 26);
            this.txt_grd_name.TabIndex = 2;
            // 
            // txt_G_id
            // 
            this.txt_G_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_G_id.Location = new System.Drawing.Point(142, 176);
            this.txt_G_id.Name = "txt_G_id";
            this.txt_G_id.ReadOnly = true;
            this.txt_G_id.Size = new System.Drawing.Size(224, 26);
            this.txt_G_id.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phone No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Block ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 210);
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
            this.label1.Location = new System.Drawing.Point(30, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guard ID:";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(9, 454);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 31);
            this.txt_search.TabIndex = 10;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.Click += new System.EventHandler(this.txt_search_Click);
            // 
            // dgv_grd
            // 
            this.dgv_grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grd.Location = new System.Drawing.Point(386, 138);
            this.dgv_grd.Name = "dgv_grd";
            this.dgv_grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_grd.Size = new System.Drawing.Size(526, 291);
            this.dgv_grd.TabIndex = 19;
            // 
            // txt_grd_jd
            // 
            this.txt_grd_jd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grd_jd.Location = new System.Drawing.Point(142, 300);
            this.txt_grd_jd.Name = "txt_grd_jd";
            this.txt_grd_jd.ReadOnly = true;
            this.txt_grd_jd.Size = new System.Drawing.Size(224, 26);
            this.txt_grd_jd.TabIndex = 20;
            // 
            // btn_save_file
            // 
            this.btn_save_file.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_save_file.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_file.ForeColor = System.Drawing.Color.White;
            this.btn_save_file.Location = new System.Drawing.Point(550, 435);
            this.btn_save_file.Name = "btn_save_file";
            this.btn_save_file.Size = new System.Drawing.Size(100, 50);
            this.btn_save_file.TabIndex = 21;
            this.btn_save_file.Text = "Save as File";
            this.btn_save_file.UseVisualStyleBackColor = false;
            this.btn_save_file.Click += new System.EventHandler(this.btn_save_file_Click);
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
            // recordDocument
            // 
            this.recordDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.recordDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // tableDocument
            // 
            this.tableDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.tableDocument_PrintPage);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(608, 55);
            this.label9.TabIndex = 22;
            this.label9.Text = "GUARD INFORMATION";
            // 
            // frm_grd_info_dsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 552);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_save_file);
            this.Controls.Add(this.txt_grd_jd);
            this.Controls.Add(this.dgv_grd);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_grd_nic);
            this.Controls.Add(this.txt_grd_sal);
            this.Controls.Add(this.txt_grd_add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_grd_ph);
            this.Controls.Add(this.txt_B_id);
            this.Controls.Add(this.txt_grd_name);
            this.Controls.Add(this.txt_G_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_print_table);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_print_rec);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.btn_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_grd_info_dsp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guard_Info";
            this.Load += new System.EventHandler(this.frm_grd_info_dsp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_print_rec;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_print_table;
        private System.Windows.Forms.TextBox txt_grd_nic;
        private System.Windows.Forms.TextBox txt_grd_sal;
        private System.Windows.Forms.TextBox txt_grd_add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_grd_ph;
        private System.Windows.Forms.TextBox txt_B_id;
        private System.Windows.Forms.TextBox txt_grd_name;
        private System.Windows.Forms.TextBox txt_G_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dgv_grd;
        private System.Windows.Forms.TextBox txt_grd_jd;
        private System.Windows.Forms.Button btn_save_file;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument recordDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument tableDocument;
        private System.Windows.Forms.Label label9;
    }
}