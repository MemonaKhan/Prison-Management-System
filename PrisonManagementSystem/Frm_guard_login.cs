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
    public partial class frm_grd_Log : Form
    {
        OleDbConnection con = new OleDbConnection();
       
        public frm_grd_Log()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;"; 
        }

        private void frm_guard_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\16.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn_switch_Click(object sender, EventArgs e)
        {
            frm_user f1 = new frm_user();
            f1.Show();
            con.Dispose();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from LOGIN where User_Type='" + label1.Text + "' and Password='" + txt_password.Text + "' ";
            OleDbDataReader read = cmd.ExecuteReader();
            int count = 0;
            while (read.Read())
            {
                count++;
            }

            if (count == 1)
            {
                MessageBox.Show("Welcome to Prison Management System");
                frm_grd_Block f2 = new frm_grd_Block();
                f2.Show();
                con.Dispose();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password is not correct...");
            }
            con.Close();
        }

        private void link_changePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_ChangePassword form = new Frm_ChangePassword();
            form.Show();
            this.Hide();
        }

    }
}
