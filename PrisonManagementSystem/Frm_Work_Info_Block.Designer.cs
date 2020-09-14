namespace PrisonManagementSystem
{
    partial class frm_work_Info_blk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_work_Info_blk));
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_work2 = new System.Windows.Forms.Button();
            this.btn_work1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_home
            // 
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.Location = new System.Drawing.Point(12, 12);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(45, 45);
            this.btn_home.TabIndex = 1;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.Location = new System.Drawing.Point(813, 506);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(87, 34);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_work2
            // 
            this.btn_work2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_work2.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_work2.Image = ((System.Drawing.Image)(resources.GetObject("btn_work2.Image")));
            this.btn_work2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_work2.Location = new System.Drawing.Point(258, 318);
            this.btn_work2.Name = "btn_work2";
            this.btn_work2.Size = new System.Drawing.Size(415, 84);
            this.btn_work2.TabIndex = 3;
            this.btn_work2.Text = "Work Assigned";
            this.btn_work2.UseVisualStyleBackColor = false;
            this.btn_work2.Click += new System.EventHandler(this.btn_work2_Click);
            // 
            // btn_work1
            // 
            this.btn_work1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_work1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_work1.Image = ((System.Drawing.Image)(resources.GetObject("btn_work1.Image")));
            this.btn_work1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_work1.Location = new System.Drawing.Point(258, 217);
            this.btn_work1.Name = "btn_work1";
            this.btn_work1.Size = new System.Drawing.Size(415, 84);
            this.btn_work1.TabIndex = 2;
            this.btn_work1.Text = "Work Information";
            this.btn_work1.UseVisualStyleBackColor = false;
            this.btn_work1.Click += new System.EventHandler(this.btn_work1_Click);
            // 
            // frm_work_Info_blk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 552);
            this.Controls.Add(this.btn_work2);
            this.Controls.Add(this.btn_work1);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_work_Info_blk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work_Info_Block";
            this.Load += new System.EventHandler(this.Frm_Work_Info_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_work2;
        private System.Windows.Forms.Button btn_work1;
    }
}