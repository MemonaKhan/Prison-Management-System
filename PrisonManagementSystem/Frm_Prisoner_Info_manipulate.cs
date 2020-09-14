using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;


namespace PrisonManagementSystem
{
    public partial class frm_prs_info_mpl : Form
    {
        OleDbConnection con = new OleDbConnection();
        string u;

        public frm_prs_info_mpl(string user)
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;";
            u = user;
           
        }

        private void frm_prs_info_mpl_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\37.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch; 
            
            cmb_prs_gender.Items.AddRange(new object[] { "", "Male","Female" });
            
            txt_P_id.Text = "";
            txt_prs_add.Text = "";
            txt_prs_fname.Text = "";
            txt_prs_moi.Text = "";
            txt_prs_name.Text = "";
            txt_prs_nic.Text = "";
            txt_prs_ph.Text = "";
            txt_search.Text = "Prisoner ID";
            txt_search.ForeColor = Color.Gray;
            dtp_prs_dob.CustomFormat = " ";
            cmb_prs_gender.SelectedIndex = 0;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (u == "admin")
            {
                frm_Prs_info_Blk f1 = new frm_Prs_info_Blk("admin");
                f1.Show();
                this.Hide();
            }
            else if (u == "supervisor")
            {
                frm_Prs_info_Blk f1 = new frm_Prs_info_Blk("supervisor");
                f1.Show();
                this.Hide();
            }
            else
            {
                if (u == "guard")
                {
                    frm_Prs_info_Blk f1 = new frm_Prs_info_Blk("guard");
                    f1.Show();
                    this.Hide();
                }
            }
        }

        private void btn_prs_info_dsp_Click(object sender, EventArgs e)
        {
            frm_prs_info_dsp f1 = new frm_prs_info_dsp(u, false);
            f1.Show();
            this.Hide();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_P_id.Text = "";
            txt_prs_add.Text = "";
            txt_prs_fname.Text = "";
            txt_prs_moi.Text = "";
            txt_prs_name.Text = "";
            txt_prs_nic.Text = "";
            txt_prs_ph.Text = "";
            txt_search.Text = "Prisoner ID";
            txt_search.ForeColor = Color.Gray;
            dtp_prs_dob.CustomFormat = " ";
            cmb_prs_gender.SelectedIndex = 0;
        }

        private void dtp_prs_dob_ValueChanged(object sender, EventArgs e)
        {
            dtp_prs_dob.CustomFormat = "MM/dd/yyyy";
        }

        private void dtp_prs_dob_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
                dtp_prs_dob.CustomFormat = " ";
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
            cmd.CommandText = "Select * from PRISONER_INFO where P_ID='" + text + "'";
            OleDbDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                txt_P_id.Text = read["P_ID"].ToString();
                txt_prs_name.Text = read["P_Name"].ToString();
                txt_prs_fname.Text = read["P_F_Name"].ToString();
                txt_prs_add.Text = read["P_Address"].ToString();
                dtp_prs_dob.Text = read["P_DOB"].ToString();
                cmb_prs_gender.Text = read["P_Gender"].ToString();
                txt_prs_ph.Text = read["P_Phone"].ToString();
                txt_prs_nic.Text = read["P_NIC"].ToString();
                txt_prs_moi.Text = read["P_MOI"].ToString();

            }
            con.Close();
        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into PRISONER_INFO (P_ID,P_Name,P_F_Name,P_DOB,P_Gender,P_Phone,P_MOI,P_Address,P_NIC) values ('" + txt_P_id.Text + "','" + txt_prs_name.Text + "','" + txt_prs_fname.Text + "','" + dtp_prs_dob.Text + "','" + cmb_prs_gender.Text + "','" + txt_prs_ph.Text + "','" + txt_prs_moi.Text + "','" + txt_prs_add.Text + "','" + txt_prs_nic.Text + "')";
            
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Record Has Been Added");

            con.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            string query = "Update PRISONER_INFO set P_Name='" + txt_prs_name.Text + "',P_F_Name='" + txt_prs_fname.Text + "',P_DOB='" + dtp_prs_dob.Text + "',P_Gender='" + cmb_prs_gender.Text + "',P_Phone='" + txt_prs_ph.Text + "',P_MOI='" + txt_prs_moi.Text + "',P_Address='" + txt_prs_add.Text + "',P_NIC='" + txt_prs_nic.Text + "'where P_ID='" + txt_P_id.Text + "'";
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
            cmd.CommandText = "Delete from PRISONER_INFO where P_ID='" + txt_P_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Has Been Deleted");
            

            txt_P_id.Text = "";
            txt_prs_add.Text = "";
            txt_prs_fname.Text = "";
            txt_prs_moi.Text = "";
            txt_prs_name.Text = "";
            txt_prs_nic.Text = "";
            txt_prs_ph.Text = "";
            txt_search.Text = "Prisoner ID";
            txt_search.ForeColor = Color.Gray;
            dtp_prs_dob.CustomFormat = " ";
            cmb_prs_gender.SelectedIndex = 0;

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

            e.Graphics.DrawString("Prisoner Information", new Font("Arial", 32), Brushes.Black, new Point(25, 290));


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

            e.Graphics.DrawString(txt_P_id.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 60));
            e.Graphics.DrawString(txt_prs_name.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 110));
            e.Graphics.DrawString(txt_prs_fname.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 160));
            e.Graphics.DrawString(txt_prs_add.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 210));
            e.Graphics.DrawString(dtp_prs_dob.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 260));
            e.Graphics.DrawString(cmb_prs_gender.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 310));
            e.Graphics.DrawString(txt_prs_ph.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 360));
            e.Graphics.DrawString(txt_prs_nic.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 410));
            e.Graphics.DrawString(txt_prs_moi.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 460));

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
