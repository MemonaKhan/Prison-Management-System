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
    public partial class frm_grd_info_mpl : Form
    {
        OleDbConnection con = new OleDbConnection();
        string u;
        public frm_grd_info_mpl(string user)
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;";
            u = user;
           
        }

        private void frm_grd_info_mpl_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\33.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch; 
            
            txt_search.Text = "Guard ID";
            txt_search.ForeColor = Color.Gray;
            txt_B_id.Text = "";
            txt_G_id.Text = "";
            txt_grd_add.Text = "";
            txt_grd_name.Text = "";
            txt_grd_nic.Text = "";
            txt_grd_ph.Text = "";
            txt_grd_sal.Text = "";
            
            dtp_grd_jod.CustomFormat = " ";
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

        private void btn_grd_info_dsp_Click(object sender, EventArgs e)
        {
            frm_grd_info_dsp f1 = new frm_grd_info_dsp(u,false);
            f1.Show();
            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string text = txt_search.Text;
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from GUARD_INFO where G_ID='" + text + "'";
            OleDbDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                txt_G_id.Text = read["G_ID"].ToString();
                txt_grd_name.Text = read["G_Name"].ToString();
                txt_B_id.Text = read["B_ID"].ToString();
                txt_grd_add.Text = read["G_Address"].ToString();
                dtp_grd_jod.CustomFormat = "MM/dd/yyyy";
                dtp_grd_jod.Text = read["G_J_Date"].ToString();
                txt_grd_ph.Text = read["G_Phone"].ToString();
                txt_grd_sal.Text = read["G_Salary"].ToString();
                txt_grd_nic.Text = read["G_NIC"].ToString();
            }
            
            con.Close();
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            txt_search.ForeColor = Color.Black;
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            txt_search.Text = "Guard ID";
            txt_search.ForeColor = Color.Gray;

            txt_B_id.Text = "";
            txt_G_id.Text = "";
            txt_grd_add.Text = "";
            txt_grd_name.Text = "";
            txt_grd_nic.Text = "";
            txt_grd_ph.Text = "";
            txt_grd_sal.Text = "";
            txt_search.Text = "";

            dtp_grd_jod.CustomFormat = " ";
        }
        double grdno;
        private void btn_add_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into GUARD_INFO (G_ID,G_Name,B_ID,G_Address,G_J_Date,G_Phone,G_Salary,G_NIC) values ('" + txt_G_id.Text + "','" + txt_grd_name.Text + "','" + txt_B_id.Text + "','" + txt_grd_add.Text + "','" + dtp_grd_jod.Text + "','" + txt_grd_ph.Text + "','" + txt_grd_sal.Text + "','" + txt_grd_nic.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            cmd.CommandText = "Select No_GD from BLOCK_INFO where B_ID='" + txt_B_id.Text + "'";
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                grdno=double.Parse( read["No_GD"].ToString());
                grdno++;
            }
            con.Close();

            con.Open();
            cmd.CommandText = "Update BLOCK_INFO set No_GD ='" + grdno + "' where B_ID='" + txt_B_id.Text + "'";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Has Been Added");
            
            con.Close();

        }

        private void dtp_grd_jod_ValueChanged(object sender, EventArgs e)
        {
            dtp_grd_jod.CustomFormat = "MM/dd/yyyy";
        }

        private void dtp_grd_jod_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
                dtp_grd_jod.CustomFormat = " ";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            dtp_grd_jod.CustomFormat = "MM/dd/yyyy";
            string query = "Update GUARD_INFO set G_Name='" + txt_grd_name.Text + "',B_ID='" + txt_B_id.Text + "',G_Address='" + txt_grd_add.Text + "',G_J_Date='" + dtp_grd_jod.Text + "',G_Phone='" + txt_grd_ph.Text + "',G_Salary='" + txt_grd_sal.Text + "',G_NIC='" + txt_grd_nic.Text + "' where G_ID='" + txt_G_id.Text + "'";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Has Been Updated");
            con.Close();
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete from GUARD_INFO where G_ID='" + txt_G_id.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            cmd.CommandText = "Select No_GD from BLOCK_INFO where B_ID='" + txt_B_id.Text + "'";
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                grdno = double.Parse(read["No_GD"].ToString());
                grdno--;
            }
            con.Close();

            con.Open();
            cmd.CommandText = "Update BLOCK_INFO set No_GD ='" + grdno + "' where B_ID='" + txt_B_id.Text + "'";
            cmd.ExecuteNonQuery();

            txt_search.Text = "Guard ID";
            txt_search.ForeColor = Color.Gray;
            txt_B_id.Text = "";
            txt_G_id.Text = "";
            txt_grd_add.Text = "";
            txt_grd_name.Text = "";
            txt_grd_nic.Text = "";
            txt_grd_ph.Text = "";
            txt_grd_sal.Text = "";
            dtp_grd_jod.CustomFormat = " ";

            MessageBox.Show("Record Has Been Deleted");
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

            e.Graphics.DrawString("Guard Information", new Font("Arial", 32), Brushes.Black, new Point(25, 290));


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

            e.Graphics.DrawString(txt_G_id.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 60));
            e.Graphics.DrawString(txt_grd_name.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 110));
            e.Graphics.DrawString(txt_B_id.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 160));
            e.Graphics.DrawString(txt_grd_add.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 210));
            e.Graphics.DrawString(dtp_grd_jod.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 260));
            e.Graphics.DrawString(txt_grd_ph.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 310));
            e.Graphics.DrawString(txt_grd_sal.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 360));
            e.Graphics.DrawString(txt_grd_nic.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 410));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 75));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 125));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 175));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 225));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 275));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 325));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 375));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 425));
            
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
