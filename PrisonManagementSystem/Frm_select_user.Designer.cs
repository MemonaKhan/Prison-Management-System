namespace PrisonManagementSystem
{
    partial class frm_user
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_user));
            this.btn_adm = new System.Windows.Forms.Button();
            this.btn_spr = new System.Windows.Forms.Button();
            this.btn_grd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_adm
            // 
            this.btn_adm.Image = ((System.Drawing.Image)(resources.GetObject("btn_adm.Image")));
            this.btn_adm.Location = new System.Drawing.Point(222, 182);
            this.btn_adm.Name = "btn_adm";
            this.btn_adm.Size = new System.Drawing.Size(120, 120);
            this.btn_adm.TabIndex = 0;
            this.btn_adm.UseVisualStyleBackColor = true;
            this.btn_adm.Click += new System.EventHandler(this.btn_adm_Click);
            // 
            // btn_spr
            // 
            this.btn_spr.Image = ((System.Drawing.Image)(resources.GetObject("btn_spr.Image")));
            this.btn_spr.Location = new System.Drawing.Point(402, 182);
            this.btn_spr.Name = "btn_spr";
            this.btn_spr.Size = new System.Drawing.Size(120, 120);
            this.btn_spr.TabIndex = 1;
            this.btn_spr.UseVisualStyleBackColor = true;
            this.btn_spr.Click += new System.EventHandler(this.btn_spr_Click);
            // 
            // btn_grd
            // 
            this.btn_grd.Image = ((System.Drawing.Image)(resources.GetObject("btn_grd.Image")));
            this.btn_grd.Location = new System.Drawing.Point(582, 182);
            this.btn_grd.Name = "btn_grd";
            this.btn_grd.Size = new System.Drawing.Size(120, 120);
            this.btn_grd.TabIndex = 2;
            this.btn_grd.UseVisualStyleBackColor = true;
            this.btn_grd.Click += new System.EventHandler(this.btn_grd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(230, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADMIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(381, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "SUPERVISOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(589, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "GUARD";
            // 
            // btn_exit
            // 
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(831, 510);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(69, 30);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 552);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_grd);
            this.Controls.Add(this.btn_spr);
            this.Controls.Add(this.btn_adm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select_User";
            this.Load += new System.EventHandler(this.frm_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adm;
        private System.Windows.Forms.Button btn_spr;
        private System.Windows.Forms.Button btn_grd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Timer timer1;
    }
}

