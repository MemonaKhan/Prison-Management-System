namespace PrisonManagementSystem
{
    partial class Frm_Prs_GenderWise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Prs_GenderWise));
            this.dgv_select = new System.Windows.Forms.DataGridView();
            this.cmb_select = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_select)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_select
            // 
            this.dgv_select.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_select.Location = new System.Drawing.Point(14, 202);
            this.dgv_select.Name = "dgv_select";
            this.dgv_select.Size = new System.Drawing.Size(885, 331);
            this.dgv_select.TabIndex = 0;
            // 
            // cmb_select
            // 
            this.cmb_select.FormattingEnabled = true;
            this.cmb_select.Location = new System.Drawing.Point(314, 160);
            this.cmb_select.Name = "cmb_select";
            this.cmb_select.Size = new System.Drawing.Size(275, 21);
            this.cmb_select.TabIndex = 1;
            this.cmb_select.SelectedIndexChanged += new System.EventHandler(this.cmb_select_SelectedIndexChanged);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_back.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(802, 142);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 50);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-1, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(919, 55);
            this.label12.TabIndex = 34;
            this.label12.Text = "PRISONER GENDER WISE DATA       ";
            // 
            // Frm_Prs_GenderWise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 542);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.cmb_select);
            this.Controls.Add(this.dgv_select);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Prs_GenderWise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Prs_GenderWise";
            this.Load += new System.EventHandler(this.Frm_Prs_GenderWise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_select)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_select;
        private System.Windows.Forms.ComboBox cmb_select;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label12;
    }
}