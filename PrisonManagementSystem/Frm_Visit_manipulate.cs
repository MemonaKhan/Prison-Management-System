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
    public partial class frm_visit_mpl : Form
    {
        OleDbConnection con = new OleDbConnection();
        string u;
        public frm_visit_mpl(string user)
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;";
            u = user;
        }

        private void frm_visit_mpl_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\42.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch; 
            
            cmb_relation.Items.AddRange(new object[] {"","Mother","Father","Husband","Wife","Brother","Sister",
            "Uncle","Aunt","Son","Daughter","Cousin", "Other"});
            
            txt_prs_id.Text = "";
            txt_search.Text = "Visit ID";
            txt_search.ForeColor = Color.Gray;
            txt_V_add.Text = "";
            txt_V_id.Text = "";
            txt_V_name.Text = "";
            txt_V_ph.Text = "";
            cmb_relation.SelectedIndex = 0;
            
            dtp_V_date.CustomFormat = " ";
            dtp_btime.CustomFormat = " ";
            dtp_etime.CustomFormat = " ";
        }

        private void btn_back_Click(object sender, EventArgs e)
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

        private void btn_visit_dsp_Click(object sender, EventArgs e)
        {
            frm_visit_dsp f1 = new frm_visit_dsp(u, false);
            f1.Show();
            this.Hide();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_prs_id.Text = "";
            txt_search.Text = "Visit ID";
            txt_search.ForeColor = Color.Gray;
            txt_V_add.Text = "";
            txt_V_id.Text = "";
            txt_V_name.Text = "";
            txt_V_ph.Text = "";
            cmb_relation.SelectedIndex = 0;
            dtp_V_date.CustomFormat = " ";
            dtp_btime.CustomFormat = " ";
            dtp_etime.CustomFormat = " ";
        }

        private void dtp_V_date_ValueChanged(object sender, EventArgs e)
        {
            dtp_V_date.CustomFormat = "MM/dd/yyyy";

        }


        private void dtp_btime_MouseDown(object sender, MouseEventArgs e)
        {
            dtp_btime.CustomFormat = "h:mm tt";
        }

        private void dtp_etime_MouseDown(object sender, MouseEventArgs e)
        {
            dtp_etime.CustomFormat = "h:mm tt";
        }

        private void dtp_V_date_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
                dtp_V_date.CustomFormat = " ";
        }

        private void dtp_btime_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
                dtp_btime.CustomFormat = " ";
        }

        private void dtp_etime_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
                dtp_etime.CustomFormat = " ";
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            txt_search.ForeColor = Color.Black;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string text = txt_search.Text;
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from VISIT_INFO where V_ID='" + text + "'";
            OleDbDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                dtp_V_date.CustomFormat = "MM/dd/yyyy";
                dtp_btime.CustomFormat = "hh:mm:tt";
                dtp_etime.CustomFormat = "hh:mm:tt";
                txt_V_id.Text = read["V_ID"].ToString();
                txt_prs_id.Text = read["P_ID"].ToString();
                txt_V_name.Text = read["V_Name"].ToString();
                txt_V_add.Text = read["V_Address"].ToString();
                cmb_relation.Text = read["V_P_Relation"].ToString();
                txt_V_ph.Text = read["V_Phone"].ToString();
                dtp_V_date.Text=read["V_Date"].ToString();
                dtp_btime.Text = read["B_Time"].ToString();
                dtp_etime.Text = read["E_Time"].ToString();
            }
            con.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into VISIT_INFO ([V_ID], [P_ID], [V_Name], [V_Phone], [V_Address], [V_P_Relation], [V_Date], [B_Time], [E_Time]) values ('" + txt_V_id.Text + "','" + txt_prs_id.Text+ "','" + txt_V_name.Text + "','" + txt_V_ph.Text + "','" + txt_V_add.Text + "','" + cmb_relation.Text + "','" + dtp_V_date.Text + "','"+dtp_btime.Text+"','"+dtp_etime.Text+"')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Has Been Added");
            con.Close();
        }

        private void recordDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int y = 300;

            Bitmap bmp = Properties.Resources.PMS_LOGO__;
            Image img = bmp;
            e.Graphics.DrawImage(img, 10, 25, 820, 200);

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, 250));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Cyan, new Point(0, 260));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, 270));

            e.Graphics.DrawString("Visit Information", new Font("Arial", 32), Brushes.Black, new Point(25, 290));


            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 40));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Cyan, new Point(0, y += 10));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 10));

            e.Graphics.DrawString(label1.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 60));
            e.Graphics.DrawString(label2.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 110));
            e.Graphics.DrawString(label3.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 160));
            e.Graphics.DrawString(label4.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 210));
            e.Graphics.DrawString(label5.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 260));
            e.Graphics.DrawString(label6.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 310));
            e.Graphics.DrawString(label7.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 360));
            e.Graphics.DrawString(label8.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 410));
            e.Graphics.DrawString(label9.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 460));

            e.Graphics.DrawString(txt_V_id.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 60));
            e.Graphics.DrawString(txt_prs_id.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 110));
            e.Graphics.DrawString(txt_V_name.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 160));
            e.Graphics.DrawString(txt_V_add.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 210));
            e.Graphics.DrawString(cmb_relation.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 260));
            e.Graphics.DrawString(txt_V_ph.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 310));
            e.Graphics.DrawString(dtp_V_date.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 360));
            e.Graphics.DrawString(dtp_btime.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 410));
            e.Graphics.DrawString(dtp_etime.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 460));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 75));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 125));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 175));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 225));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 275));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 325));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 375));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 425));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 475));
            
        }

        

        private void btn_preview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = recordDocument;
            printPreviewDialog.ShowDialog();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;
            printDialog.Document = recordDocument;
            printDialog.ShowDialog();
        }

    }
}
