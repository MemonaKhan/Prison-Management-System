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
    public partial class frm_blk_info_dsp : Form
    {
        OleDbConnection con = new OleDbConnection();
        string u;
        int count;
        public frm_blk_info_dsp(string user)
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;";
            u = user;
        }

        private void frm_blk_info_dsp_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\27.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch;

            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from BLOCK_INFO ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgv_blk_info.DataSource = dt;

            DataSet d = new DataSet();
            adap.Fill(d, "BLOCK_INFO");
            txt_B_id.Text = d.Tables["BLOCK_INFO"].Rows[0]["B_ID"].ToString();
            txt_grd_no.Text = d.Tables["BLOCK_INFO"].Rows[0]["No_GD"].ToString();
            txt_prs_no.Text = d.Tables["BLOCK_INFO"].Rows[0]["No_PR"].ToString();
            txt_W_id.Text = d.Tables["BLOCK_INFO"].Rows[0]["W_ID"].ToString();


            txt_search.Text = "Block ID";
            txt_search.ForeColor = Color.Gray;

            con.Close();
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

        private void btn_first_Click(object sender, EventArgs e)
        {
            
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from BLOCK_INFO", con);
            DataSet d = new DataSet();
            adap.Fill(d, "BLOCK_INFO");
            if (count > 0)
            {
                count = 0;
                txt_B_id.Text = d.Tables["BLOCK_INFO"].Rows[count]["B_ID"].ToString();
                txt_grd_no.Text = d.Tables["BLOCK_INFO"].Rows[count]["No_GD"].ToString();
                txt_prs_no.Text = d.Tables["BLOCK_INFO"].Rows[count]["No_PR"].ToString();
                txt_W_id.Text = d.Tables["BLOCK_INFO"].Rows[count]["W_ID"].ToString();

                dgv_blk_info.ClearSelection();
                dgv_blk_info.Rows[count].Selected = true;
            }
            else
            {
                if (count == 0)
                    MessageBox.Show("You are already on first record");
            }
            
            con.Close();
            
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from BLOCK_INFO", con);
            DataSet d = new DataSet();
            adap.Fill(d, "BLOCK_INFO");
            if (count > 0)
            {
                count--;
                txt_B_id.Text = d.Tables["BLOCK_INFO"].Rows[count]["B_ID"].ToString();
                txt_grd_no.Text = d.Tables["BLOCK_INFO"].Rows[count]["No_GD"].ToString();
                txt_prs_no.Text = d.Tables["BLOCK_INFO"].Rows[count]["No_PR"].ToString();
                txt_W_id.Text = d.Tables["BLOCK_INFO"].Rows[count]["W_ID"].ToString();

                dgv_blk_info.ClearSelection();
                dgv_blk_info.Rows[count].Selected = true;
            }
            else
            {
                if (count == 0)
                    MessageBox.Show("You are already on first record");
            }
            con.Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from BLOCK_INFO", con);
            DataSet d = new DataSet();
            adap.Fill(d, "BLOCK_INFO");
            if (count < d.Tables["BLOCK_INFO"].Rows.Count - 1)
            {
                count++;
                txt_B_id.Text = d.Tables["BLOCK_INFO"].Rows[count]["B_ID"].ToString();
                txt_grd_no.Text = d.Tables["BLOCK_INFO"].Rows[count]["No_GD"].ToString();
                txt_prs_no.Text = d.Tables["BLOCK_INFO"].Rows[count]["No_PR"].ToString();
                txt_W_id.Text = d.Tables["BLOCK_INFO"].Rows[count]["W_ID"].ToString();

                dgv_blk_info.ClearSelection();
                dgv_blk_info.Rows[count].Selected = true;
            }
            else
            {
                if (count == d.Tables["BLOCK_INFO"].Rows.Count - 1)
                    MessageBox.Show("You are already on Last record");
            }
            con.Close();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from BLOCK_INFO", con);
            DataSet d = new DataSet();
            adap.Fill(d, "BLOCK_INFO");
            if (count < d.Tables["BLOCK_INFO"].Rows.Count - 1)
            {
                count = d.Tables["BLOCK_INFO"].Rows.Count - 1;
                txt_B_id.Text = d.Tables["BLOCK_INFO"].Rows[count]["B_ID"].ToString();
                txt_grd_no.Text = d.Tables["BLOCK_INFO"].Rows[count]["No_GD"].ToString();
                txt_prs_no.Text = d.Tables["BLOCK_INFO"].Rows[count]["No_PR"].ToString();
                txt_W_id.Text = d.Tables["BLOCK_INFO"].Rows[count]["W_ID"].ToString();

                dgv_blk_info.ClearSelection();
                dgv_blk_info.Rows[count].Selected = true;
            }
            else
            {
                if (count == d.Tables["BLOCK_INFO"].Rows.Count - 1)
                    MessageBox.Show("You are already on Last record");
            }
            con.Close();
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
            cmd.CommandText = "Select * from BLOCK_INFO where B_ID='"+text+"'";
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txt_B_id.Text = read["B_ID"].ToString();
                txt_grd_no.Text = read["No_GD"].ToString();
                txt_prs_no.Text = read["No_PR"].ToString();
                txt_W_id.Text = read["W_ID"].ToString();
            }

            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from BLOCK_INFO ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgv_blk_info.DataSource = dt;

             
             for (int rowno = 0; rowno < dgv_blk_info.Rows.Count-1; rowno++)
            {
                if (txt_search.Text == dgv_blk_info.Rows[rowno].Cells[0].Value.ToString())
                {
                    dgv_blk_info.ClearSelection();
                    dgv_blk_info.Rows[rowno].Selected = true;
                }

            }

            con.Close();
        }

        private void recordDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int y = 300;
            int x = 30;
            Bitmap bmp = Properties.Resources.PMS_LOGO__;
            Image img = bmp;
            e.Graphics.DrawImage(img, 10, 25, 820, 200);

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, 250));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Cyan, new Point(0, 260));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, 270));

            e.Graphics.DrawString("Block Information", new Font("Arial", 32), Brushes.Black, new Point(25, y-10 ));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 40));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Cyan, new Point(0, y += 10));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 10));

            e.Graphics.DrawString(label1.Text, new Font("Arial", 14), Brushes.Black, new Point(x, y + 60));
            e.Graphics.DrawString(label2.Text, new Font("Arial", 14), Brushes.Black, new Point(x, y + 110));
            e.Graphics.DrawString(label3.Text, new Font("Arial", 14), Brushes.Black, new Point(x, y + 160));
            e.Graphics.DrawString(label4.Text, new Font("Arial", 14), Brushes.Black, new Point(x, y + 210));

            e.Graphics.DrawString(txt_B_id.Text, new Font("Arial", 14), Brushes.Black, new Point(x+300, y + 60));
            e.Graphics.DrawString(txt_grd_no.Text, new Font("Arial", 14), Brushes.Black, new Point(x+300, y + 110));
            e.Graphics.DrawString(txt_prs_no.Text, new Font("Arial", 14), Brushes.Black, new Point(x+300, y + 160));
            e.Graphics.DrawString(txt_W_id.Text, new Font("Arial", 14), Brushes.Black, new Point(x+300, y + 210));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 75));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 125));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 175));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 225));
        }

        private void tableDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int y = 300;
            
            Bitmap bmp = Properties.Resources.PMS_LOGO__;
            Image img = bmp;
            e.Graphics.DrawImage(img, 10, 25, 820, 200);

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, 250));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Cyan, new Point(0, 260));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, 270));

            e.Graphics.DrawString("Block Information", new Font("Arial", 32), Brushes.Black, new Point(25, y - 10));


            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 40));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Cyan, new Point(0, y += 10));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 10));

            e.Graphics.DrawString(label1.Text, new Font("Arial", 14), Brushes.Black, new Point(30, 430));
            e.Graphics.DrawString(label2.Text, new Font("Arial", 14), Brushes.Black, new Point(180, 430));
            e.Graphics.DrawString(label3.Text, new Font("Arial", 14), Brushes.Black, new Point(380, 430));
            e.Graphics.DrawString(label4.Text, new Font("Arial", 14), Brushes.Black, new Point(580, 430));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, 450));

            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from BLOCK_INFO ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataSet d = new DataSet();
            adap.Fill(d, "BLOCK_INFO");
            y = 500;
            for (count = 0; count < d.Tables["BLOCK_INFO"].Rows.Count; count++)
            {
                e.Graphics.DrawString(d.Tables["BLOCK_INFO"].Rows[count]["B_ID"].ToString(), new Font("Arial", 14), Brushes.Black, new Point(30, y));
                e.Graphics.DrawString(d.Tables["BLOCK_INFO"].Rows[count]["No_GD"].ToString(), new Font("Arial", 14), Brushes.Black, new Point(180, y));
                e.Graphics.DrawString(d.Tables["BLOCK_INFO"].Rows[count]["No_PR"].ToString(), new Font("Arial", 14), Brushes.Black, new Point(380, y));
                e.Graphics.DrawString(d.Tables["BLOCK_INFO"].Rows[count]["W_ID"].ToString(), new Font("Arial", 14), Brushes.Black, new Point(580, y));
                y = y + 40;
            }
            con.Close();
        }

        private void btn_print_table_Click(object sender, EventArgs e)
        {
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;
            printDialog.Document = tableDocument;
            printDialog.ShowDialog();

        }

        private void btn_save_file_Click(object sender, EventArgs e)
        {
            tableDocument.Print();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = recordDocument;
            printPreviewDialog.ShowDialog();
        }

        private void btn_print_rec_Click(object sender, EventArgs e)
        {
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;
            printDialog.Document = recordDocument;
            printDialog.ShowDialog();
        }

        

        

        

       
    }
}
