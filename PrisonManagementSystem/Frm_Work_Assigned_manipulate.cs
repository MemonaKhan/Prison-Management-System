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
    public partial class frm_work_assign_mpl : Form
    {
        OleDbConnection con = new OleDbConnection();
        string u;
        public frm_work_assign_mpl(string user)
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;";
            u = user;
           
        }

        private void frm_work_assign_mpl_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\44.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch; 
            
            cmb_W_day.Items.AddRange(new object[] {"","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday" });
            
            txt_prs_id.Text = "";
            txt_s_no.Text = "";
            txt_search.Text = "S.No";
            txt_search.ForeColor = Color.Gray;
            txt_W_id.Text = "";
            dtp_W_time.CustomFormat = " ";
            cmb_W_day.SelectedIndex = 0;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (u == "admin")
            {
                frm_work_Info_blk f1 = new frm_work_Info_blk("admin");
                f1.Show();
                this.Hide();
            }
            else if (u == "supervisor")
            {
                frm_work_Info_blk f1 = new frm_work_Info_blk("supervisor");
                f1.Show();
                this.Hide();
            }
            else
            {
                if (u == "guard")
                {
                    frm_work_Info_blk f1 = new frm_work_Info_blk("guard");
                    f1.Show();
                    this.Hide();
                }
            }
        }

        private void btn_W_assign_dsp_Click(object sender, EventArgs e)
        {
            frm_work_assign_dsp f1 = new frm_work_assign_dsp(u, false);
            f1.Show();
            this.Hide();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_prs_id.Text = "";
            txt_s_no.Text = "";
            txt_search.Text = "S.No";
            txt_search.ForeColor = Color.Gray;
            txt_W_id.Text = "";
            dtp_W_time.CustomFormat = " ";
            cmb_W_day.SelectedIndex = 0;
        }

        private void dtp_W_time_MouseDown(object sender, MouseEventArgs e)
        {
            dtp_W_time.CustomFormat = "h:mm tt";
        }

        private void dtp_W_time_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode==Keys.Delete)||(e.KeyCode==Keys.Back))
                dtp_W_time.CustomFormat = " ";
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            txt_search.Text="";
            txt_search.ForeColor=Color.Black;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string text = txt_search.Text;
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from WORK_ASSIGN where S_No='" + text + "'";
            OleDbDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                txt_s_no.Text = read["S_No"].ToString();
                txt_W_id.Text = read["W_ID"].ToString();
                txt_prs_id.Text = read["P_ID"].ToString();
                dtp_W_time.CustomFormat = "h:mm tt";
                dtp_W_time.Text = read["W_Time"].ToString();
                cmb_W_day.Text = read["W_Day"].ToString();
            }
            con.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into WORK_ASSIGN ([S_No], [W_ID], [P_ID], [W_Time], [W_Day]) values ('" + txt_s_no.Text + "','"+txt_W_id.Text+"','" + txt_prs_id.Text + "','" + dtp_W_time.Text + "','" + cmb_W_day.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Has Been Added");
            con.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            dtp_W_time.CustomFormat = "h:mm tt";
            string query = "Update WORK_ASSIGN set [W_ID]='" + txt_W_id.Text + "',[P_ID]='" + txt_prs_id.Text + "',[W_Time]='" + dtp_W_time.Text + "',[W_Day]='" + cmb_W_day.Text + "' where [S_No]='" + txt_s_no.Text + "'";
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
            cmd.CommandText = "Delete from WORK_ASSIGN where ([S_No]='" + txt_s_no.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Has Been Deleted");
            con.Close();
            txt_prs_id.Text = "";
            txt_s_no.Text = "";
            txt_search.Text = "S.No";
            txt_search.ForeColor = Color.Gray;
            txt_W_id.Text = "";
            dtp_W_time.CustomFormat = " ";
            cmb_W_day.SelectedIndex = 0;
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

            e.Graphics.DrawString("Work Assignment", new Font("Arial", 32), Brushes.Black, new Point(25, 290));


            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 40));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Cyan, new Point(0, y += 10));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 10));

            e.Graphics.DrawString(label1.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 60));
            e.Graphics.DrawString(label2.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 110));
            e.Graphics.DrawString(label3.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 160));
            e.Graphics.DrawString(label4.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 210));
            e.Graphics.DrawString(label5.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 260));
            
            e.Graphics.DrawString(txt_s_no.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 60));
            e.Graphics.DrawString(txt_W_id.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 110));
            e.Graphics.DrawString(txt_prs_id.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 160));
            e.Graphics.DrawString(dtp_W_time.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 210));
            e.Graphics.DrawString(cmb_W_day.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 260));
            
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 75));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 125));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 175));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 225));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 275));
            
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
