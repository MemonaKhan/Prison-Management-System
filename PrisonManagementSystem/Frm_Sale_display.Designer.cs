namespace PrisonManagementSystem
{
    partial class frm_sale_dsp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sale_dsp));
            this.txt_i_t_amt = new System.Windows.Forms.TextBox();
            this.txt_i_qty = new System.Windows.Forms.TextBox();
            this.txt_i_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_i_name = new System.Windows.Forms.TextBox();
            this.txt_B_ID = new System.Windows.Forms.TextBox();
            this.txt_I_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_print_table = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_print_rec = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_sale = new System.Windows.Forms.DataGridView();
            this.txt_i_month = new System.Windows.Forms.TextBox();
            this.btn_save_file = new System.Windows.Forms.Button();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.recordDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.tableDocument = new System.Drawing.Printing.PrintDocument();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sale)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_i_t_amt
            // 
            this.txt_i_t_amt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_i_t_amt.Location = new System.Drawing.Point(161, 385);
            this.txt_i_t_amt.Name = "txt_i_t_amt";
            this.txt_i_t_amt.ReadOnly = true;
            this.txt_i_t_amt.Size = new System.Drawing.Size(224, 26);
            this.txt_i_t_amt.TabIndex = 7;
            // 
            // txt_i_qty
            // 
            this.txt_i_qty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_i_qty.Location = new System.Drawing.Point(161, 292);
            this.txt_i_qty.Name = "txt_i_qty";
            this.txt_i_qty.ReadOnly = true;
            this.txt_i_qty.Size = new System.Drawing.Size(224, 26);
            this.txt_i_qty.TabIndex = 4;
            // 
            // txt_i_price
            // 
            this.txt_i_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_i_price.Location = new System.Drawing.Point(161, 323);
            this.txt_i_price.Name = "txt_i_price";
            this.txt_i_price.ReadOnly = true;
            this.txt_i_price.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_i_price.Size = new System.Drawing.Size(224, 26);
            this.txt_i_price.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Price:";
            // 
            // txt_i_name
            // 
            this.txt_i_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_i_name.Location = new System.Drawing.Point(161, 261);
            this.txt_i_name.Name = "txt_i_name";
            this.txt_i_name.ReadOnly = true;
            this.txt_i_name.Size = new System.Drawing.Size(224, 26);
            this.txt_i_name.TabIndex = 3;
            // 
            // txt_B_ID
            // 
            this.txt_B_ID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_B_ID.Location = new System.Drawing.Point(161, 230);
            this.txt_B_ID.Name = "txt_B_ID";
            this.txt_B_ID.ReadOnly = true;
            this.txt_B_ID.Size = new System.Drawing.Size(224, 26);
            this.txt_B_ID.TabIndex = 2;
            // 
            // txt_I_id
            // 
            this.txt_I_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_I_id.Location = new System.Drawing.Point(161, 199);
            this.txt_I_id.Name = "txt_I_id";
            this.txt_I_id.ReadOnly = true;
            this.txt_I_id.Size = new System.Drawing.Size(224, 26);
            this.txt_I_id.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Month:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Item Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 230);
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
            this.label1.Location = new System.Drawing.Point(33, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item ID:";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(11, 458);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 31);
            this.txt_search.TabIndex = 9;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.Click += new System.EventHandler(this.txt_search_Click);
            // 
            // btn_print_table
            // 
            this.btn_print_table.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_print_table.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_table.ForeColor = System.Drawing.Color.White;
            this.btn_print_table.Location = new System.Drawing.Point(640, 450);
            this.btn_print_table.Name = "btn_print_table";
            this.btn_print_table.Size = new System.Drawing.Size(127, 32);
            this.btn_print_table.TabIndex = 8;
            this.btn_print_table.Text = "Print Table";
            this.btn_print_table.UseVisualStyleBackColor = false;
            this.btn_print_table.Click += new System.EventHandler(this.btn_print_table_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_preview.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.ForeColor = System.Drawing.Color.White;
            this.btn_preview.Location = new System.Drawing.Point(585, 495);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(100, 48);
            this.btn_preview.TabIndex = 15;
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
            this.btn_last.Location = new System.Drawing.Point(471, 495);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(100, 48);
            this.btn_last.TabIndex = 14;
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
            this.btn_print_rec.Location = new System.Drawing.Point(699, 495);
            this.btn_print_rec.Name = "btn_print_rec";
            this.btn_print_rec.Size = new System.Drawing.Size(100, 48);
            this.btn_print_rec.TabIndex = 16;
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
            this.btn_back.Location = new System.Drawing.Point(814, 495);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 48);
            this.btn_back.TabIndex = 17;
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
            this.btn_next.Location = new System.Drawing.Point(356, 495);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(100, 48);
            this.btn_next.TabIndex = 13;
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
            this.btn_previous.Location = new System.Drawing.Point(241, 495);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(100, 48);
            this.btn_previous.TabIndex = 12;
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
            this.btn_first.Location = new System.Drawing.Point(126, 495);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(100, 48);
            this.btn_first.TabIndex = 11;
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
            this.btn_search.Location = new System.Drawing.Point(11, 495);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 48);
            this.btn_search.TabIndex = 10;
            this.btn_search.TabStop = false;
            this.btn_search.Text = "Search Record";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv_sale
            // 
            this.dgv_sale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sale.Location = new System.Drawing.Point(435, 142);
            this.dgv_sale.Name = "dgv_sale";
            this.dgv_sale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sale.Size = new System.Drawing.Size(479, 291);
            this.dgv_sale.TabIndex = 18;
            // 
            // txt_i_month
            // 
            this.txt_i_month.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_i_month.Location = new System.Drawing.Point(161, 354);
            this.txt_i_month.Name = "txt_i_month";
            this.txt_i_month.ReadOnly = true;
            this.txt_i_month.Size = new System.Drawing.Size(224, 26);
            this.txt_i_month.TabIndex = 19;
            // 
            // btn_save_file
            // 
            this.btn_save_file.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_save_file.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_file.ForeColor = System.Drawing.Color.White;
            this.btn_save_file.Location = new System.Drawing.Point(500, 450);
            this.btn_save_file.Name = "btn_save_file";
            this.btn_save_file.Size = new System.Drawing.Size(134, 32);
            this.btn_save_file.TabIndex = 33;
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
            this.label12.Location = new System.Drawing.Point(50, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(549, 55);
            this.label12.TabIndex = 35;
            this.label12.Text = "SALE INFORMATION";
            // 
            // frm_sale_dsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 552);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_save_file);
            this.Controls.Add(this.txt_i_month);
            this.Controls.Add(this.dgv_sale);
            this.Controls.Add(this.txt_i_t_amt);
            this.Controls.Add(this.txt_i_qty);
            this.Controls.Add(this.txt_i_price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_i_name);
            this.Controls.Add(this.txt_B_ID);
            this.Controls.Add(this.txt_I_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
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
            this.Name = "frm_sale_dsp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale_Info";
            this.Load += new System.EventHandler(this.frm_sale_dsp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_i_t_amt;
        private System.Windows.Forms.TextBox txt_i_qty;
        private System.Windows.Forms.TextBox txt_i_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_i_name;
        private System.Windows.Forms.TextBox txt_B_ID;
        private System.Windows.Forms.TextBox txt_I_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_print_table;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_print_rec;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_sale;
        private System.Windows.Forms.TextBox txt_i_month;
        private System.Windows.Forms.Button btn_save_file;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument recordDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument tableDocument;
        private System.Windows.Forms.Label label12;

    }
}