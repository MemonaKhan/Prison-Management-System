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
    public partial class Frm_Prs_CourtWise : Form
    {
        OleDbConnection con = new OleDbConnection();
        string u;
        public Frm_Prs_CourtWise(string user)
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;";
            u = user;
        }

        private void Frm_Prs_CourtWise_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\23.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch;

            cmb_select.Items.AddRange(new object[] { "", "District & session Hyderabad", "District & session Larkana",
            "District & session Sakkar","District & session Karachi","District & session Khairpur","District & session Shikarpur"});
        }

        private void cmb_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            com.CommandText = "Select * from PRISONER_DETAILS where P_Court='" + cmb_select.SelectedItem.ToString() + "'";
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable d = new DataTable("PRISONER_DETAILS");
            adap.Fill(d);
            dgv_select.DataSource = d;
            con.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Frm_Data_Options form = new Frm_Data_Options(u);
            form.Show();
            this.Hide();
        }
    }
}
