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
    public partial class frm_Prs_info_Blk : Form
    {
        string u;
        public frm_Prs_info_Blk(string user)
        {
            InitializeComponent();
            u = user;
        }

        private void Frm_Prsn_Info_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\24.jpg");

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

        private void btn_prs1_Click(object sender, EventArgs e)
        {
            if (u == "admin")
            {
                frm_prs_info_dsp f1 = new frm_prs_info_dsp("admin", true);
                f1.Show();
                this.Hide();
            }
            else if (u == "supervisor")
            {
                frm_prs_info_mpl f1 = new frm_prs_info_mpl("supervisor");
                f1.Show();
                this.Hide();
            }
            else
            {
                if (u == "guard")
                {
                    frm_prs_info_dsp f1 = new frm_prs_info_dsp("guard", true);
                    f1.Show();
                    this.Hide();
                }
            }
        }

        private void btn_prs2_Click(object sender, EventArgs e)
        {
            if (u == "admin")
            {
                frm_prs_dtl_dsp f1 = new frm_prs_dtl_dsp("admin", true);
                f1.Show();
                this.Hide();
            }
            else if (u == "supervisor")
            {
                frm_prs_dtl_mpl f1 = new frm_prs_dtl_mpl("supervisor");
                f1.Show();
                this.Hide();
            }
            else
            {
                if (u == "guard")
                {
                    frm_prs_dtl_dsp f1 = new frm_prs_dtl_dsp("guard", true);
                    f1.Show();
                    this.Hide();
                }
            }
        }

        private void btn_prs3_Click(object sender, EventArgs e)
        {
            if (u == "admin")
            {
                Frm_Data_Options f1 = new Frm_Data_Options("admin");
                f1.Show();
                this.Hide();
            }
            else if (u == "supervisor")
            {
                Frm_Data_Options f1 = new Frm_Data_Options("supervisor");
                f1.Show();
                this.Hide();
            }
            else
            {
                if (u == "guard")
                {
                    Frm_Data_Options f1 = new Frm_Data_Options("guard");
                    f1.Show();
                    this.Hide();
                }
            }
           
        }

       

    }
}
