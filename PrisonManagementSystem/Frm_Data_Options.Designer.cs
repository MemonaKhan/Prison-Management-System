namespace PrisonManagementSystem
{
    partial class Frm_Data_Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Data_Options));
            this.btn_gender_wise = new System.Windows.Forms.Button();
            this.btn_status_wise = new System.Windows.Forms.Button();
            this.btn_court_wise = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_gender_wise
            // 
            this.btn_gender_wise.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_gender_wise.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gender_wise.Image = ((System.Drawing.Image)(resources.GetObject("btn_gender_wise.Image")));
            this.btn_gender_wise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gender_wise.Location = new System.Drawing.Point(39, 212);
            this.btn_gender_wise.Name = "btn_gender_wise";
            this.btn_gender_wise.Size = new System.Drawing.Size(274, 92);
            this.btn_gender_wise.TabIndex = 4;
            this.btn_gender_wise.Text = "Gender Wise";
            this.btn_gender_wise.UseVisualStyleBackColor = false;
            this.btn_gender_wise.Click += new System.EventHandler(this.btn_gender_wise_Click);
            // 
            // btn_status_wise
            // 
            this.btn_status_wise.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_status_wise.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_status_wise.Image = ((System.Drawing.Image)(resources.GetObject("btn_status_wise.Image")));
            this.btn_status_wise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_status_wise.Location = new System.Drawing.Point(324, 212);
            this.btn_status_wise.Name = "btn_status_wise";
            this.btn_status_wise.Size = new System.Drawing.Size(274, 92);
            this.btn_status_wise.TabIndex = 5;
            this.btn_status_wise.Text = "Status Wise";
            this.btn_status_wise.UseVisualStyleBackColor = false;
            this.btn_status_wise.Click += new System.EventHandler(this.btn_status_wise_Click);
            // 
            // btn_court_wise
            // 
            this.btn_court_wise.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_court_wise.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_court_wise.Image = ((System.Drawing.Image)(resources.GetObject("btn_court_wise.Image")));
            this.btn_court_wise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_court_wise.Location = new System.Drawing.Point(609, 212);
            this.btn_court_wise.Name = "btn_court_wise";
            this.btn_court_wise.Size = new System.Drawing.Size(274, 92);
            this.btn_court_wise.TabIndex = 6;
            this.btn_court_wise.Text = "Court Wise";
            this.btn_court_wise.UseVisualStyleBackColor = false;
            this.btn_court_wise.Click += new System.EventHandler(this.btn_court_wise_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_back.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(792, 480);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(110, 50);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Frm_Data_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 542);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_court_wise);
            this.Controls.Add(this.btn_status_wise);
            this.Controls.Add(this.btn_gender_wise);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Data_Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Data_Options";
            this.Load += new System.EventHandler(this.Frm_Data_Options_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_gender_wise;
        private System.Windows.Forms.Button btn_status_wise;
        private System.Windows.Forms.Button btn_court_wise;
        private System.Windows.Forms.Button btn_back;

    }
}