using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PrisonManagementSystem
{
    public partial class frm_spr_Block : Form
    {
        OleDbConnection con = new OleDbConnection();

        public frm_spr_Block()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;";
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_spr_Log f1 = new frm_spr_Log();
            f1.Show();
            con.Dispose();
            this.Hide();

        }

        private void frm_spr_Block_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\11.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn_prs_info_Click(object sender, EventArgs e)
        {
            frm_Prs_info_Blk f1 = new frm_Prs_info_Blk("supervisor");
            f1.Show();
            con.Dispose();
            this.Hide();
        }

        private void btn_grd_info_Click(object sender, EventArgs e)
        {
            frm_grd_info_mpl f1 = new frm_grd_info_mpl("supervisor");
            f1.Show();
            con.Dispose();
            this.Hide();
        }

        private void btn_blk_info_Click(object sender, EventArgs e)
        {
            frm_blk_info_dsp f1 = new frm_blk_info_dsp("supervisor");
            f1.Show();
            con.Dispose();
            this.Hide();
        }

        private void btn_prc_info_Click(object sender, EventArgs e)
        {
            frm_purchase_dsp f1 = new frm_purchase_dsp("supervisor",true);
            f1.Show();
            con.Dispose();
            this.Hide();
        }

        private void btn_sale_info_Click(object sender, EventArgs e)
        {
            frm_sale_dsp f1 = new frm_sale_dsp("supervisor",true);
            f1.Show();
            con.Dispose();
            this.Hide();
        }

        private void btn_vst_info_Click(object sender, EventArgs e)
        {
            frm_visit_dsp f1 = new frm_visit_dsp("supervisor",true);
            f1.Show();
            con.Dispose();
            this.Hide();
        }

        private void btn_wrk_info_Click(object sender, EventArgs e)
        {
            frm_work_Info_blk f1 = new frm_work_Info_blk("supervisor");
            f1.Show();
            con.Dispose();
            this.Hide();
        }

        private void btn_fdbk_info_Click(object sender, EventArgs e)
        {
            frm_Fdbk_mpl f1 = new frm_Fdbk_mpl("supervisor");
            f1.Show();
            con.Dispose();
            this.Hide();
        }

    }
}
