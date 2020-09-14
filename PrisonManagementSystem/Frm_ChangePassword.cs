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
    public partial class Frm_ChangePassword : Form
    {
        OleDbConnection con = new OleDbConnection();

        public Frm_ChangePassword()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;";
        }

        private void Frm_ChangePassword_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\18.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_new.Text ==txt_confirm.Text)
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE LOGIN SET [Password]='" + txt_new.Text + "' WHERE [Password]='" + txt_old.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Password has been changed successfully");
                con.Close();
                frm_user form = new frm_user();
                form.Show();
                this.Hide();
   
                
            }
            else
            {
                MessageBox.Show("Try Again!");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            frm_user form = new frm_user();
            form.Show();
            this.Hide();
   
        }
    }
}
