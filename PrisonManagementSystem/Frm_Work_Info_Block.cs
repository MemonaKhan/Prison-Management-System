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
    public partial class frm_work_Info_blk : Form
    {
        string u;
        public frm_work_Info_blk(string user)
        {
            InitializeComponent();
            u = user;
        }

        private void Frm_Work_Info_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\25.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            if (u == "admin")
            {
                frm_adm_Block f1 = new frm_adm_Block();
                f1.Show();
                this.Hide();
            }
            else if (u == "supervisor")
            {
                frm_spr_Block f1 = new frm_spr_Block();
                f1.Show();
                this.Hide();
            }
            else
            {
                if (u == "guard")
                {
                    frm_grd_Block f1 = new frm_grd_Block();
                    f1.Show();
                    this.Hide();
                }
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            if (u == "admin")
            {
                frm_adm_Log f1 = new frm_adm_Log();
                f1.Show();
                this.Hide();
            }
            else if (u == "supervisor")
            {
                frm_spr_Log f1 = new frm_spr_Log();
                f1.Show();
                this.Hide();
            }
            else
            {
                if (u == "guard")
                {
                    frm_grd_Log f1 = new frm_grd_Log();
                    f1.Show();
                    this.Hide();
                }
            }
        }

        private void btn_work1_Click(object sender, EventArgs e)
        {
            if (u == "admin")
            {
                frm_work_info_mpl f1 = new frm_work_info_mpl("admin");
                f1.Show();
                this.Hide();
            }
            else if (u == "supervisor")
            {
                frm_work_info_dsp f1 = new frm_work_info_dsp("supervisor",true);
                f1.Show();
                this.Hide();
            }
            else
            {
                if (u == "guard")
                {
                    frm_work_info_dsp f1 = new frm_work_info_dsp("guard",true);
                    f1.Show();
                    this.Hide();
                }
            }
        }

        private void btn_work2_Click(object sender, EventArgs e)
        {
            if (u == "admin")
            {
                frm_work_assign_dsp f1 = new frm_work_assign_dsp("admin",true);
                f1.Show();
                this.Hide();
            }
            else if (u == "supervisor")
            {
                frm_work_assign_dsp f1 = new frm_work_assign_dsp("supervisor",true);
                f1.Show();
                this.Hide();
            }
            else
            {
                if (u == "guard")
                {
                    frm_work_assign_mpl f1 = new frm_work_assign_mpl("guard");
                    f1.Show();
                    this.Hide();
                }
            }
        }
    }
}
