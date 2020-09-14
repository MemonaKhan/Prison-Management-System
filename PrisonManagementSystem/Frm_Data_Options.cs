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
    public partial class Frm_Data_Options : Form
    {
        
        string u;
        public Frm_Data_Options(string user)
        {
            InitializeComponent();
            u = user;
        }

        private void btn_gender_wise_Click(object sender, EventArgs e)
        {
            Frm_Prs_GenderWise form = new Frm_Prs_GenderWise(u);
            form.Show();
            this.Hide();
        }

        private void btn_status_wise_Click(object sender, EventArgs e)
        {
            Frm_Prs_StatusWise form = new Frm_Prs_StatusWise(u);
            form.Show();
            this.Hide();
        }

        private void btn_court_wise_Click(object sender, EventArgs e)
        {
            Frm_Prs_CourtWise form = new Frm_Prs_CourtWise(u);
            form.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_Prs_info_Blk form = new frm_Prs_info_Blk(u);
            form.Show();
            this.Hide();
        }

        private void Frm_Data_Options_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\26.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
