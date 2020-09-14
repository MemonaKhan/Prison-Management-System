namespace PrisonManagementSystem
{
    partial class frm_prs_dtl_dsp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_prs_dtl_dsp));
            this.label9 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_prs_us = new System.Windows.Forms.TextBox();
            this.txt_prs_fir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_B_id = new System.Windows.Forms.TextBox();
            this.txt_P_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_print_table = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_print_rec = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_prs_dtl = new System.Windows.Forms.DataGridView();
            this.txt_prs_status = new System.Windows.Forms.TextBox();
            this.txt_prs_doa = new System.Windows.Forms.TextBox();
            this.txt_prs_crime = new System.Windows.Forms.TextBox();
            this.txt_prs_dop = new System.Windows.Forms.TextBox();
            this.txt_prs_doi = new System.Windows.Forms.TextBox();
            this.txt_prs_dor = new System.Windows.Forms.TextBox();
            this.txt_prs_court = new System.Windows.Forms.TextBox();
            this.btn_save_file = new System.Windows.Forms.Button();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.recordDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.tableDocument = new System.Drawing.Printing.PrintDocument();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prs_dtl)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Court Name:";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(11, 470);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 13;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.Click += new System.EventHandler(this.txt_search_Click);
            // 
            // txt_prs_us
            // 
            this.txt_prs_us.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prs_us.Location = new System.Drawing.Point(194, 304);
            this.txt_prs_us.Name = "txt_prs_us";
            this.txt_prs_us.ReadOnly = true;
            this.txt_prs_us.Size = new System.Drawing.Size(224, 26);
            this.txt_prs_us.TabIndex = 7;
            // 
            // txt_prs_fir
            // 
            this.txt_prs_fir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prs_fir.Location = new System.Drawing.Point(194, 242);
            this.txt_prs_fir.Name = "txt_prs_fir";
            this.txt_prs_fir.ReadOnly = true;
            this.txt_prs_fir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_prs_fir.Size = new System.Drawing.Size(224, 26);
            this.txt_prs_fir.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Date of Production:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Under section:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "FIR No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date of Admission:";
            // 
            // txt_B_id
            // 
            this.txt_B_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_B_id.Location = new System.Drawing.Point(194, 149);
            this.txt_B_id.Name = "txt_B_id";
            this.txt_B_id.ReadOnly = true;
            this.txt_B_id.Size = new System.Drawing.Size(224, 26);
            this.txt_B_id.TabIndex = 2;
            // 
            // txt_P_id
            // 
            this.txt_P_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P_id.Location = new System.Drawing.Point(193, 118);
            this.txt_P_id.Name = "txt_P_id";
            this.txt_P_id.ReadOnly = true;
            this.txt_P_id.Size = new System.Drawing.Size(224, 26);
            this.txt_P_id.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Crime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Block ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prisoner ID:";
            // 
            // btn_print_table
            // 
            this.btn_print_table.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_print_table.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_table.ForeColor = System.Drawing.Color.White;
            this.btn_print_table.Location = new System.Drawing.Point(699, 451);
            this.btn_print_table.Name = "btn_print_table";
            this.btn_print_table.Size = new System.Drawing.Size(124, 32);
            this.btn_print_table.TabIndex = 12;
            this.btn_print_table.Text = "Print Table";
            this.btn_print_table.UseVisualStyleBackColor = false;
            this.btn_print_table.Click += new System.EventHandler(this.btn_print_table_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_preview.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.ForeColor = System.Drawing.Color.White;
            this.btn_preview.Location = new System.Drawing.Point(585, 496);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(100, 48);
            this.btn_preview.TabIndex = 19;
            this.btn_preview.TabStop = false;
            this.btn_preview.Text = "Rec Print Preview";
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_last
            // 
            this.btn_last.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_last.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last.ForeColor = System.Drawing.Color.White;
            this.btn_last.Location = new System.Drawing.Point(471, 496);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(100, 48);
            this.btn_last.TabIndex = 18;
            this.btn_last.TabStop = false;
            this.btn_last.Text = "Last Record";
            this.btn_last.UseVisualStyleBackColor = false;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_print_rec
            // 
            this.btn_print_rec.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_print_rec.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_rec.ForeColor = System.Drawing.Color.White;
            this.btn_print_rec.Location = new System.Drawing.Point(699, 496);
            this.btn_print_rec.Name = "btn_print_rec";
            this.btn_print_rec.Size = new System.Drawing.Size(100, 48);
            this.btn_print_rec.TabIndex = 20;
            this.btn_print_rec.TabStop = false;
            this.btn_print_rec.Text = "Print Record";
            this.btn_print_rec.UseVisualStyleBackColor = false;
            this.btn_print_rec.Click += new System.EventHandler(this.btn_print_rec_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_back.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(814, 496);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 48);
            this.btn_back.TabIndex = 21;
            this.btn_back.TabStop = false;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_next.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Location = new System.Drawing.Point(356, 496);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(100, 48);
            this.btn_next.TabIndex = 17;
            this.btn_next.TabStop = false;
            this.btn_next.Text = "Next Record";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_previous.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.ForeColor = System.Drawing.Color.White;
            this.btn_previous.Location = new System.Drawing.Point(241, 496);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(100, 48);
            this.btn_previous.TabIndex = 16;
            this.btn_previous.TabStop = false;
            this.btn_previous.Text = "Previous Record";
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_first
            // 
            this.btn_first.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_first.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_first.ForeColor = System.Drawing.Color.White;
            this.btn_first.Location = new System.Drawing.Point(126, 496);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(100, 48);
            this.btn_first.TabIndex = 15;
            this.btn_first.TabStop = false;
            this.btn_first.Text = "First Record";
            this.btn_first.UseVisualStyleBackColor = false;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_search.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(11, 496);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 48);
            this.btn_search.TabIndex = 14;
            this.btn_search.TabStop = false;
            this.btn_search.Text = "Search Record";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 433);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Date of Release:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Date of Imprisonment:";
            // 
            // dgv_prs_dtl
            // 
            this.dgv_prs_dtl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prs_dtl.Location = new System.Drawing.Point(435, 118);
            this.dgv_prs_dtl.Name = "dgv_prs_dtl";
            this.dgv_prs_dtl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_prs_dtl.Size = new System.Drawing.Size(479, 327);
            this.dgv_prs_dtl.TabIndex = 22;
            // 
            // txt_prs_status
            // 
            this.txt_prs_status.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prs_status.Location = new System.Drawing.Point(193, 180);
            this.txt_prs_status.Name = "txt_prs_status";
            this.txt_prs_status.ReadOnly = true;
            this.txt_prs_status.Size = new System.Drawing.Size(224, 26);
            this.txt_prs_status.TabIndex = 23;
            // 
            // txt_prs_doa
            // 
            this.txt_prs_doa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prs_doa.Location = new System.Drawing.Point(194, 211);
            this.txt_prs_doa.Name = "txt_prs_doa";
            this.txt_prs_doa.ReadOnly = true;
            this.txt_prs_doa.Size = new System.Drawing.Size(224, 26);
            this.txt_prs_doa.TabIndex = 24;
            // 
            // txt_prs_crime
            // 
            this.txt_prs_crime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prs_crime.Location = new System.Drawing.Point(194, 273);
            this.txt_prs_crime.Name = "txt_prs_crime";
            this.txt_prs_crime.ReadOnly = true;
            this.txt_prs_crime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_prs_crime.Size = new System.Drawing.Size(224, 26);
            this.txt_prs_crime.TabIndex = 25;
            // 
            // txt_prs_dop
            // 
            this.txt_prs_dop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prs_dop.Location = new System.Drawing.Point(194, 335);
            this.txt_prs_dop.Name = "txt_prs_dop";
            this.txt_prs_dop.ReadOnly = true;
            this.txt_prs_dop.Size = new System.Drawing.Size(224, 26);
            this.txt_prs_dop.TabIndex = 26;
            // 
            // txt_prs_doi
            // 
            this.txt_prs_doi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prs_doi.Location = new System.Drawing.Point(193, 397);
            this.txt_prs_doi.Name = "txt_prs_doi";
            this.txt_prs_doi.ReadOnly = true;
            this.txt_prs_doi.Size = new System.Drawing.Size(224, 26);
            this.txt_prs_doi.TabIndex = 27;
            // 
            // txt_prs_dor
            // 
            this.txt_prs_dor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prs_dor.Location = new System.Drawing.Point(194, 428);
            this.txt_prs_dor.Name = "txt_prs_dor";
            this.txt_prs_dor.ReadOnly = true;
            this.txt_prs_dor.Size = new System.Drawing.Size(224, 26);
            this.txt_prs_dor.TabIndex = 28;
            // 
            // txt_prs_court
            // 
            this.txt_prs_court.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prs_court.Location = new System.Drawing.Point(193, 366);
            this.txt_prs_court.Name = "txt_prs_court";
            this.txt_prs_court.ReadOnly = true;
            this.txt_prs_court.Size = new System.Drawing.Size(224, 26);
            this.txt_prs_court.TabIndex = 29;
            // 
            // btn_save_file
            // 
            this.btn_save_file.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_save_file.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_file.ForeColor = System.Drawing.Color.White;
            this.btn_save_file.Location = new System.Drawing.Point(562, 451);
            this.btn_save_file.Name = "btn_save_file";
            this.btn_save_file.Size = new System.Drawing.Size(131, 32);
            this.btn_save_file.TabIndex = 30;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(85, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(531, 55);
            this.label12.TabIndex = 31;
            this.label12.Text = "PRISONER DETAILS";
            // 
            // frm_prs_dtl_dsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 552);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_save_file);
            this.Controls.Add(this.txt_prs_court);
            this.Controls.Add(this.txt_prs_dor);
            this.Controls.Add(this.txt_prs_doi);
            this.Controls.Add(this.txt_prs_dop);
            this.Controls.Add(this.txt_prs_crime);
            this.Controls.Add(this.txt_prs_doa);
            this.Controls.Add(this.txt_prs_status);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_prs_us);
            this.Controls.Add(this.txt_prs_fir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_B_id);
            this.Controls.Add(this.txt_P_id);
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
            this.Controls.Add(this.dgv_prs_dtl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_prs_dtl_dsp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prisoner_Prison_Detail";
            this.Load += new System.EventHandler(this.frm_prs_dtl_dsp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prs_dtl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txt_prs_us;
        private System.Windows.Forms.TextBox txt_prs_fir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_B_id;
        private System.Windows.Forms.TextBox txt_P_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_print_table;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_print_rec;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_prs_dtl;
        private System.Windows.Forms.TextBox txt_prs_status;
        private System.Windows.Forms.TextBox txt_prs_doa;
        private System.Windows.Forms.TextBox txt_prs_crime;
        private System.Windows.Forms.TextBox txt_prs_dop;
        private System.Windows.Forms.TextBox txt_prs_doi;
        private System.Windows.Forms.TextBox txt_prs_dor;
        private System.Windows.Forms.TextBox txt_prs_court;
        private System.Windows.Forms.Button btn_save_file;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument recordDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument tableDocument;
        private System.Windows.Forms.Label label12;


    }
}