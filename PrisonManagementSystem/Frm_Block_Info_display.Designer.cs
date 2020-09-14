namespace PrisonManagementSystem
{
    partial class frm_blk_info_dsp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_blk_info_dsp));
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_print_rec = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_B_id = new System.Windows.Forms.TextBox();
            this.txt_grd_no = new System.Windows.Forms.TextBox();
            this.txt_prs_no = new System.Windows.Forms.TextBox();
            this.txt_W_id = new System.Windows.Forms.TextBox();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_print_table = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dgv_blk_info = new System.Windows.Forms.DataGridView();
            this.btn_save_file = new System.Windows.Forms.Button();
            this.recordDocument = new System.Drawing.Printing.PrintDocument();
            this.tableDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_blk_info)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_search.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(10, 492);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 50);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "Search Record";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_first
            // 
            this.btn_first.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_first.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_first.ForeColor = System.Drawing.Color.White;
            this.btn_first.Location = new System.Drawing.Point(125, 492);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(100, 50);
            this.btn_first.TabIndex = 8;
            this.btn_first.Text = "First Record";
            this.btn_first.UseVisualStyleBackColor = false;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_next.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Location = new System.Drawing.Point(355, 493);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(100, 50);
            this.btn_next.TabIndex = 10;
            this.btn_next.Text = "Next Record";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_previous.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.ForeColor = System.Drawing.Color.White;
            this.btn_previous.Location = new System.Drawing.Point(240, 492);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(100, 50);
            this.btn_previous.TabIndex = 9;
            this.btn_previous.Text = "Previous Record";
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_last
            // 
            this.btn_last.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_last.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last.ForeColor = System.Drawing.Color.White;
            this.btn_last.Location = new System.Drawing.Point(470, 492);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(100, 50);
            this.btn_last.TabIndex = 11;
            this.btn_last.Text = "Last Record";
            this.btn_last.UseVisualStyleBackColor = false;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_print_rec
            // 
            this.btn_print_rec.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_print_rec.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_rec.ForeColor = System.Drawing.Color.White;
            this.btn_print_rec.Location = new System.Drawing.Point(700, 492);
            this.btn_print_rec.Name = "btn_print_rec";
            this.btn_print_rec.Size = new System.Drawing.Size(100, 50);
            this.btn_print_rec.TabIndex = 13;
            this.btn_print_rec.Text = "Print Record";
            this.btn_print_rec.UseVisualStyleBackColor = false;
            this.btn_print_rec.Click += new System.EventHandler(this.btn_print_rec_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_back.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(815, 492);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 50);
            this.btn_back.TabIndex = 14;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Block ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "No: of Guards:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "No: of Prisoners:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Work ID:";
            // 
            // txt_B_id
            // 
            this.txt_B_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_B_id.Location = new System.Drawing.Point(192, 200);
            this.txt_B_id.Name = "txt_B_id";
            this.txt_B_id.ReadOnly = true;
            this.txt_B_id.Size = new System.Drawing.Size(155, 26);
            this.txt_B_id.TabIndex = 1;
            this.txt_B_id.TabStop = false;
            // 
            // txt_grd_no
            // 
            this.txt_grd_no.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grd_no.Location = new System.Drawing.Point(192, 241);
            this.txt_grd_no.Name = "txt_grd_no";
            this.txt_grd_no.ReadOnly = true;
            this.txt_grd_no.Size = new System.Drawing.Size(155, 26);
            this.txt_grd_no.TabIndex = 2;
            this.txt_grd_no.TabStop = false;
            // 
            // txt_prs_no
            // 
            this.txt_prs_no.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prs_no.Location = new System.Drawing.Point(192, 286);
            this.txt_prs_no.Name = "txt_prs_no";
            this.txt_prs_no.ReadOnly = true;
            this.txt_prs_no.Size = new System.Drawing.Size(155, 26);
            this.txt_prs_no.TabIndex = 3;
            this.txt_prs_no.TabStop = false;
            // 
            // txt_W_id
            // 
            this.txt_W_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_W_id.Location = new System.Drawing.Point(192, 331);
            this.txt_W_id.Name = "txt_W_id";
            this.txt_W_id.ReadOnly = true;
            this.txt_W_id.Size = new System.Drawing.Size(155, 26);
            this.txt_W_id.TabIndex = 4;
            this.txt_W_id.TabStop = false;
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_preview.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.ForeColor = System.Drawing.Color.White;
            this.btn_preview.Location = new System.Drawing.Point(585, 492);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(100, 50);
            this.btn_preview.TabIndex = 12;
            this.btn_preview.Text = "Rec Print Preview";
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_print_table
            // 
            this.btn_print_table.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_print_table.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_table.ForeColor = System.Drawing.Color.White;
            this.btn_print_table.Location = new System.Drawing.Point(568, 436);
            this.btn_print_table.Name = "btn_print_table";
            this.btn_print_table.Size = new System.Drawing.Size(100, 50);
            this.btn_print_table.TabIndex = 5;
            this.btn_print_table.Text = "Print Table";
            this.btn_print_table.UseVisualStyleBackColor = false;
            this.btn_print_table.Click += new System.EventHandler(this.btn_print_table_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.Black;
            this.txt_search.Location = new System.Drawing.Point(10, 459);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(103, 24);
            this.txt_search.TabIndex = 6;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.Click += new System.EventHandler(this.txt_search_Click);
            // 
            // dgv_blk_info
            // 
            this.dgv_blk_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_blk_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_blk_info.Location = new System.Drawing.Point(442, 139);
            this.dgv_blk_info.Name = "dgv_blk_info";
            this.dgv_blk_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_blk_info.Size = new System.Drawing.Size(438, 291);
            this.dgv_blk_info.TabIndex = 16;
            // 
            // btn_save_file
            // 
            this.btn_save_file.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_save_file.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_file.ForeColor = System.Drawing.Color.White;
            this.btn_save_file.Location = new System.Drawing.Point(674, 437);
            this.btn_save_file.Name = "btn_save_file";
            this.btn_save_file.Size = new System.Drawing.Size(100, 50);
            this.btn_save_file.TabIndex = 17;
            this.btn_save_file.Text = "Save as File";
            this.btn_save_file.UseVisualStyleBackColor = false;
            this.btn_save_file.Click += new System.EventHandler(this.btn_save_file_Click);
            // 
            // recordDocument
            // 
            this.recordDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.recordDocument_PrintPage);
            // 
            // tableDocument
            // 
            this.tableDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.tableDocument_PrintPage);
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
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(591, 55);
            this.label5.TabIndex = 18;
            this.label5.Text = "BLOCK INFORMATION";
            // 
            // frm_blk_info_dsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 552);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_save_file);
            this.Controls.Add(this.dgv_blk_info);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_print_table);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.txt_W_id);
            this.Controls.Add(this.txt_prs_no);
            this.Controls.Add(this.txt_grd_no);
            this.Controls.Add(this.txt_B_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Name = "frm_blk_info_dsp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Block_Info_Display";
            this.Load += new System.EventHandler(this.frm_blk_info_dsp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_blk_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_print_rec;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_B_id;
        private System.Windows.Forms.TextBox txt_grd_no;
        private System.Windows.Forms.TextBox txt_prs_no;
        private System.Windows.Forms.TextBox txt_W_id;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_print_table;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dgv_blk_info;
        private System.Windows.Forms.Button btn_save_file;
        private System.Drawing.Printing.PrintDocument recordDocument;
        private System.Drawing.Printing.PrintDocument tableDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Label label5;
    }
}