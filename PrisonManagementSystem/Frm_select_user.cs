using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrisonManagementSystem
{
    public partial class frm_user : Form
    {
        public frm_user()
        {
            InitializeComponent();
        }

        private void btn_adm_Click(object sender, EventArgs e)
        {
            frm_adm_Log f1 = new frm_adm_Log();
            f1.Show();
            this.Hide();
        }

        private void btn_spr_Click(object sender, EventArgs e)
        {
            frm_spr_Log f2 = new frm_spr_Log();
            f2.Show();
            this.Hide();
        }

        private void btn_grd_Click(object sender, EventArgs e)
        {
            frm_grd_Log f3 = new frm_grd_Log();
            f3.Show(); 
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_user_Load(object sender, EventArgs e)
        {

        }
        int img = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (img == 8)
                img = 0;
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\"+img+".jpg");
            img++;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
        }
    }
}
