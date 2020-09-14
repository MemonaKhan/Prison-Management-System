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
    public partial class frm_work_assign_dsp : Form
    {
        OleDbConnection con = new OleDbConnection();
        string u;
        bool c;
        int count;
        public frm_work_assign_dsp(string user, bool check)
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;";
            u = user;
            c = check;
        }

        private void frm_work_assign_dsp_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\45.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch; 
            
            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from WORK_ASSIGN  ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgv_work_assign.DataSource = dt;

            DataSet d = new DataSet();
            adap.Fill(d, "WORK_ASSIGN");
            txt_s_no.Text = d.Tables["WORK_ASSIGN"].Rows[0]["S_No"].ToString();
            txt_W_id.Text = d.Tables["WORK_ASSIGN"].Rows[0]["W_ID"].ToString();
            txt_prs_id.Text = d.Tables["WORK_ASSIGN"].Rows[0]["P_ID"].ToString();
            txt_W_time.Text = d.Tables["WORK_ASSIGN"].Rows[0]["W_Time"].ToString();
            txt_W_day.Text = d.Tables["WORK_ASSIGN"].Rows[0]["W_Day"].ToString();

            txt_search.Text = "Work ID";
            txt_search.ForeColor = Color.Gray;


            con.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (c)
            {
                frm_work_Info_blk f1 = new frm_work_Info_blk(u);
                f1.Show();
                this.Hide();
            }
            else
            {
                frm_work_assign_mpl f1 = new frm_work_assign_mpl(u);
                f1.Show();
                this.Hide();
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from WORK_ASSIGN", con);

            DataSet d = new DataSet();
            adap.Fill(d, "WORK_ASSIGN");
            if (count > 0)
            {
                count = 0;
                txt_s_no.Text = d.Tables["WORK_ASSIGN"].Rows[count]["S_No"].ToString();
                txt_W_id.Text = d.Tables["WORK_ASSIGN"].Rows[count]["W_ID"].ToString();
                txt_prs_id.Text = d.Tables["WORK_ASSIGN"].Rows[count]["P_ID"].ToString();
                txt_W_time.Text = d.Tables["WORK_ASSIGN"].Rows[count]["W_Time"].ToString();
                txt_W_day.Text = d.Tables["WORK_ASSIGN"].Rows[count]["W_Day"].ToString();


                dgv_work_assign.ClearSelection();
                dgv_work_assign.Rows[count].Selected = true;
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
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from WORK_ASSIGN", con);
            DataSet d = new DataSet();
            adap.Fill(d, "WORK_ASSIGN");
            if (count > 0)
            {
                count--;
                txt_s_no.Text = d.Tables["WORK_ASSIGN"].Rows[count]["S_No"].ToString();
                txt_W_id.Text = d.Tables["WORK_ASSIGN"].Rows[count]["W_ID"].ToString();
                txt_prs_id.Text = d.Tables["WORK_ASSIGN"].Rows[count]["P_ID"].ToString();
                txt_W_time.Text = d.Tables["WORK_ASSIGN"].Rows[count]["W_Time"].ToString();
                txt_W_day.Text = d.Tables["WORK_ASSIGN"].Rows[count]["W_Day"].ToString();


                dgv_work_assign.ClearSelection();
                dgv_work_assign.Rows[count].Selected = true;
            
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
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from WORK_ASSIGN", con);
            DataSet d = new DataSet();
            adap.Fill(d, "WORK_ASSIGN");
            if (count < d.Tables["WORK_ASSIGN"].Rows.Count - 1)
            {
                count++;
                txt_s_no.Text = d.Tables["WORK_ASSIGN"].Rows[count]["S_No"].ToString();
                txt_W_id.Text = d.Tables["WORK_ASSIGN"].Rows[count]["W_ID"].ToString();
                txt_prs_id.Text = d.Tables["WORK_ASSIGN"].Rows[count]["P_ID"].ToString();
                txt_W_time.Text = d.Tables["WORK_ASSIGN"].Rows[count]["W_Time"].ToString();
                txt_W_day.Text = d.Tables["WORK_ASSIGN"].Rows[count]["W_Day"].ToString();


                dgv_work_assign.ClearSelection();
                dgv_work_assign.Rows[count].Selected = true;
            }
            else
            {
                if (count == d.Tables["WORK_ASSIGN"].Rows.Count - 1)
                    MessageBox.Show("You are already on Last record");
            }
            con.Close();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from WORK_ASSIGN", con);
            DataSet d = new DataSet();
            adap.Fill(d, "WORK_ASSIGN");
            if (count < d.Tables["WORK_ASSIGN"].Rows.Count - 1)
            {
                count = d.Tables["VISIT_INFO"].Rows.Count - 1;
                txt_s_no.Text = d.Tables["WORK_ASSIGN"].Rows[count]["S_No"].ToString();
                txt_W_id.Text = d.Tables["WORK_ASSIGN"].Rows[count]["W_ID"].ToString();
                txt_prs_id.Text = d.Tables["WORK_ASSIGN"].Rows[count]["P_ID"].ToString();
                txt_W_time.Text = d.Tables["WORK_ASSIGN"].Rows[count]["W_Time"].ToString();
                txt_W_day.Text = d.Tables["WORK_ASSIGN"].Rows[count]["W_Day"].ToString();


                dgv_work_assign.ClearSelection();
                dgv_work_assign.Rows[count].Selected = true;
            }
            else
            {
                if (count == d.Tables["WORK_ASSIGN"].Rows.Count - 1)
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
            cmd.CommandText = "Select * from WORK_ASSIGN where W_ID='" + text + "'";
            OleDbDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                txt_s_no.Text = read["S_No"].ToString();
                txt_W_id.Text = read["W_ID"].ToString();
                txt_prs_id.Text =read["P_ID"].ToString();
                txt_W_time.Text = read["W_Time"].ToString();
                txt_W_day.Text = read["W_Day"].ToString();
            }

            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from WORK_ASSIGN ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgv_work_assign.DataSource = dt;
            

            for (int rowno = 0; rowno < dgv_work_assign.Rows.Count-1; rowno++)
            {
                if (txt_search.Text == dgv_work_assign.Rows[rowno].Cells[0].Value.ToString())
                {
                    dgv_work_assign.ClearSelection();
                    dgv_work_assign.Rows[rowno].Selected = true;
                }

            }

            con.Close();
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

            e.Graphics.DrawString("Work Assignment", new Font("Arial", 32), Brushes.Black, new Point(25, 290));


            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 40));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Cyan, new Point(0, y += 10));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 10));

            e.Graphics.DrawString("S_No", new Font("Arial", 12), Brushes.Black, new Point(30, 430));
            e.Graphics.DrawString("W_ID", new Font("Arial", 12), Brushes.Black, new Point(130, 430));
            e.Graphics.DrawString("P_ID", new Font("Arial", 12), Brushes.Black, new Point(230, 430));
            e.Graphics.DrawString("Time", new Font("Arial", 12), Brushes.Black, new Point(330, 430));
            e.Graphics.DrawString("Day", new Font("Arial", 12), Brushes.Black, new Point(460, 430));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, 450));

            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from WORK_ASSIGN ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataSet d = new DataSet();
            adap.Fill(d, "WORK_ASSIGN");
            y = 500;
            for (count = 0; count < d.Tables["WORK_ASSIGN"].Rows.Count; count++)
            {
                DateTime dt = Convert.ToDateTime(d.Tables["WORK_ASSIGN"].Rows[count]["W_Time"].ToString());
                e.Graphics.DrawString(d.Tables["WORK_ASSIGN"].Rows[count]["S_No"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(30, y));
                e.Graphics.DrawString(d.Tables["WORK_ASSIGN"].Rows[count]["W_ID"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(130, y));
                e.Graphics.DrawString(d.Tables["WORK_ASSIGN"].Rows[count]["P_ID"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(230, y));
                e.Graphics.DrawString(dt.ToString("h:mm tt"), new Font("Arial", 12), Brushes.Black, new Point(330, y));
                e.Graphics.DrawString(d.Tables["WORK_ASSIGN"].Rows[count]["W_Day"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(460, y));
                y = y + 40;
            }
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
            e.Graphics.DrawString(txt_W_time.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 210));
            e.Graphics.DrawString(txt_W_day.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 260));
            
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 75));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 125));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 175));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 225));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 275));
            
        }

        private void btn_print_table_Click(object sender, EventArgs e)
        {
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;
            printDialog.Document = recordDocument;
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
