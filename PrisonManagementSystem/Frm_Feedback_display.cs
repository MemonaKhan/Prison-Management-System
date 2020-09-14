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
    public partial class frm_Fdbk_dsp : Form
    {
        OleDbConnection con = new OleDbConnection();
        string u;
        int count;
        public frm_Fdbk_dsp(string user)
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;";
            u = user;
        }

        private void frm_Fdbk_dsp_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\28.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch;

            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from FEEDBACK ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgv_fdbk.DataSource = dt;

            txt_search.Text = "FeedBack ID";
            txt_search.ForeColor = Color.Gray;

            con.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_Fdbk_mpl f1 = new frm_Fdbk_mpl(u);
            f1.Show();
            this.Hide();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from FEEDBACK", con);

            DataSet d = new DataSet();
            adap.Fill(d, "FEEDBACK");
            if (count > 0)
            {
                count = 0;
                dgv_fdbk.ClearSelection();
                dgv_fdbk.Rows[count].Selected = true;
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
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from FEEDBACK", con);
            DataSet d = new DataSet();
            adap.Fill(d, "FEEDBACK");
            if (count > 0)
            {
                count--;
                dgv_fdbk.ClearSelection();
                dgv_fdbk.Rows[count].Selected = true;
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
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from FEEDBACK", con);
            DataSet d = new DataSet();
            adap.Fill(d, "FEEDBACK");
            if (count < d.Tables["FEEDBACK"].Rows.Count - 1)
            {
                count++;
                dgv_fdbk.ClearSelection();
                dgv_fdbk.Rows[count].Selected = true;
            }
            else
            {
                if (count == d.Tables["FEEDBACK"].Rows.Count - 1)
                    MessageBox.Show("You are already on Last record");
            }
            con.Close();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from FEEDBACK", con);
            DataSet d = new DataSet();
            adap.Fill(d, "FEEDBACK");
            if (count < d.Tables["FEEDBACK"].Rows.Count - 1)
            {
                count = d.Tables["FEEDBACK"].Rows.Count - 1;
                dgv_fdbk.ClearSelection();
                dgv_fdbk.Rows[count].Selected = true;
            }
            else
            {
                if (count == d.Tables["FEEDBACK"].Rows.Count - 1)
                    MessageBox.Show("You are already on Last record");
            }
            con.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from FEEDBACK ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgv_fdbk.DataSource = dt;


            for (int rowno = 0; rowno < dgv_fdbk.Rows.Count-1; rowno++)
            {
                if (txt_search.Text == dgv_fdbk.Rows[rowno].Cells[0].Value.ToString())
                {
                    dgv_fdbk.ClearSelection();
                    dgv_fdbk.Rows[rowno].Selected = true;
                }

            }
            con.Close();

        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            txt_search.ForeColor = Color.Black;
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

            e.Graphics.DrawString("FEEDBACK Information", new Font("Arial", 32), Brushes.Black, new Point(25, 290));


            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 40));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Cyan, new Point(0, y += 10));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 10));

            e.Graphics.DrawString("ID", new Font("Arial", 12), Brushes.Black, new Point(25, 430));
            e.Graphics.DrawString("Date", new Font("Arial", 12), Brushes.Black, new Point(100, 430));
            e.Graphics.DrawString("P_ID", new Font("Arial", 12), Brushes.Black, new Point(200, 430));
            e.Graphics.DrawString("B_ID", new Font("Arial", 12), Brushes.Black, new Point(260, 430));
            e.Graphics.DrawString("OBD", new Font("Arial", 12), Brushes.Black, new Point(360, 430));
            e.Graphics.DrawString("W_CAP", new Font("Arial", 12), Brushes.Black, new Point(430, 430));
            e.Graphics.DrawString("INTG", new Font("Arial", 12), Brushes.Black, new Point(500, 430));
            e.Graphics.DrawString("INTV", new Font("Arial", 12), Brushes.Black, new Point(570, 430));
            e.Graphics.DrawString("T_W", new Font("Arial", 12), Brushes.Black, new Point(640, 430));
            e.Graphics.DrawString("WPD", new Font("Arial", 12), Brushes.Black, new Point(710, 430));
            e.Graphics.DrawString("E_MAT", new Font("Arial", 12), Brushes.Black, new Point(780, 430));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, 450));
            
            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from FEEDBACK ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataSet d = new DataSet();
            adap.Fill(d, "FEEDBACK");
            y = 500;
            for (count = 0; count < d.Tables["FEEDBACK"].Rows.Count; count++)
            {
                DateTime dt = Convert.ToDateTime(d.Tables["FEEDBACK"].Rows[count]["DOF"].ToString());
                e.Graphics.DrawString(d.Tables["FEEDBACK"].Rows[count]["FB_ID"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(25, y));
                e.Graphics.DrawString(dt.ToString("MM/dd/yyyy"), new Font("Arial", 12), Brushes.Black, new Point(100, y));
                e.Graphics.DrawString(d.Tables["FEEDBACK"].Rows[count]["P_ID"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(200, y));
                e.Graphics.DrawString(d.Tables["FEEDBACK"].Rows[count]["B_ID"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(260, y));
                e.Graphics.DrawString(d.Tables["FEEDBACK"].Rows[count]["OBD"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(360, y));
                e.Graphics.DrawString(d.Tables["FEEDBACK"].Rows[count]["CAP_Work"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(430, y));
                e.Graphics.DrawString(d.Tables["FEEDBACK"].Rows[count]["INTG"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(500, y));
                e.Graphics.DrawString(d.Tables["FEEDBACK"].Rows[count]["INTV"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(570, y));
                e.Graphics.DrawString(d.Tables["FEEDBACK"].Rows[count]["TM_Work"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(640, y));
                e.Graphics.DrawString(d.Tables["FEEDBACK"].Rows[count]["WPD"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(710, y));
                e.Graphics.DrawString(d.Tables["FEEDBACK"].Rows[count]["EM"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(780, y));
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

        private void btn_preview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = tableDocument;
            
            printPreviewDialog.ShowDialog();
        }
    }
}
