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
    public partial class frm_prs_dtl_dsp : Form
    {
        OleDbConnection con = new OleDbConnection();
        string u;
        bool c;
        int count;
        public frm_prs_dtl_dsp(string user, bool check)
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;";
            u = user;
            c = check;
           
        }

        private void frm_prs_dtl_dsp_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\34.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch; 

            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from PRISONER_DETAILS ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgv_prs_dtl.DataSource = dt;

            DataSet d = new DataSet();
            adap.Fill(d, "PRISONER_DETAILS");
            

            txt_P_id.Text = d.Tables["PRISONER_DETAILS"].Rows[0]["P_ID"].ToString();
            txt_B_id.Text = d.Tables["PRISONER_DETAILS"].Rows[0]["B_ID"].ToString();
            txt_prs_status.Text = d.Tables["PRISONER_DETAILS"].Rows[0]["P_Status"].ToString();
            txt_prs_doa.Text = d.Tables["PRISONER_DETAILS"].Rows[0]["P_DOA"].ToString();
            txt_prs_fir.Text = d.Tables["PRISONER_DETAILS"].Rows[0]["P_FIR"].ToString();
            txt_prs_crime.Text = d.Tables["PRISONER_DETAILS"].Rows[0]["P_Crime"].ToString();
            txt_prs_us.Text = d.Tables["PRISONER_DETAILS"].Rows[0]["P_US"].ToString();
            txt_prs_dop.Text = d.Tables["PRISONER_DETAILS"].Rows[0]["P_DOP"].ToString();
            txt_prs_court.Text = d.Tables["PRISONER_DETAILS"].Rows[0]["P_Court"].ToString();
            txt_prs_doi.Text = d.Tables["PRISONER_DETAILS"].Rows[0]["P_DOI"].ToString();
            txt_prs_dor.Text = d.Tables["PRISONER_DETAILS"].Rows[0]["P_DOR"].ToString();

            txt_search.Text = "Prisoner ID";
            txt_search.ForeColor = Color.Gray;

            con.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (c)
            {
                frm_Prs_info_Blk f1 = new frm_Prs_info_Blk(u);
                f1.Show();
                this.Hide();
            }
            else
            {
                frm_prs_dtl_mpl f1 = new frm_prs_dtl_mpl(u);
                f1.Show();
                this.Hide();
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from PRISONER_DETAILS", con);

            DataSet d = new DataSet();
            adap.Fill(d, "PRISONER_DETAILS");
            if (count > 0)
            {
                count = 0;
                txt_P_id.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_ID"].ToString();
                txt_B_id.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["B_ID"].ToString();
                txt_prs_status.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_Status"].ToString();
                txt_prs_doa.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOA"].ToString();
                txt_prs_fir.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_FIR"].ToString();
                txt_prs_crime.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_Crime"].ToString();
                txt_prs_us.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_US"].ToString();
                txt_prs_dop.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOP"].ToString();
                txt_prs_court.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_Court"].ToString();
                txt_prs_doi.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOI"].ToString();
                txt_prs_dor.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOR"].ToString();

                dgv_prs_dtl.ClearSelection();
                dgv_prs_dtl.Rows[count].Selected = true;
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
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from PRISONER_DETAILS", con);
            DataSet d = new DataSet();
            adap.Fill(d, "PRISONER_DETAILS");
            if (count > 0)
            {
                count--;
                txt_P_id.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_ID"].ToString();
                txt_B_id.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["B_ID"].ToString();
                txt_prs_status.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_Status"].ToString();
                txt_prs_doa.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOA"].ToString();
                txt_prs_fir.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_FIR"].ToString();
                txt_prs_crime.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_Crime"].ToString();
                txt_prs_us.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_US"].ToString();
                txt_prs_dop.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOP"].ToString();
                txt_prs_court.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_Court"].ToString();
                txt_prs_doi.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOI"].ToString();
                txt_prs_dor.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOR"].ToString();

                dgv_prs_dtl.ClearSelection();
                dgv_prs_dtl.Rows[count].Selected = true;
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
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from PRISONER_DETAILS", con);
            DataSet d = new DataSet();
            adap.Fill(d, "PRISONER_DETAILS");
            if (count < d.Tables["PRISONER_DETAILS"].Rows.Count - 1)
            {
                count++;
                txt_P_id.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_ID"].ToString();
                txt_B_id.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["B_ID"].ToString();
                txt_prs_status.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_Status"].ToString();
                txt_prs_doa.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOA"].ToString();
                txt_prs_fir.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_FIR"].ToString();
                txt_prs_crime.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_Crime"].ToString();
                txt_prs_us.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_US"].ToString();
                txt_prs_dop.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOP"].ToString();
                txt_prs_court.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_Court"].ToString();
                txt_prs_doi.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOI"].ToString();
                txt_prs_dor.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOR"].ToString();

                dgv_prs_dtl.ClearSelection();
                dgv_prs_dtl.Rows[count].Selected = true;
            }
            else
            {
                if (count == d.Tables["PRISONER_DETAILS"].Rows.Count - 1)
                    MessageBox.Show("You are already on Last record");
            }
            con.Close();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from PRISONER_DETAILS", con);
            DataSet d = new DataSet();
            adap.Fill(d, "PRISONER_DETAILS");
            if (count < d.Tables["PRISONER_DETAILS"].Rows.Count - 1)
            {
                count = d.Tables["PRISONER_DETAILS"].Rows.Count - 1;
                txt_P_id.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_ID"].ToString();
                txt_B_id.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["B_ID"].ToString();
                txt_prs_status.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_Status"].ToString();
                txt_prs_doa.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOA"].ToString();
                txt_prs_fir.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_FIR"].ToString();
                txt_prs_crime.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_Crime"].ToString();
                txt_prs_us.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_US"].ToString();
                txt_prs_dop.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOP"].ToString();
                txt_prs_court.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_Court"].ToString();
                txt_prs_doi.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOI"].ToString();
                txt_prs_dor.Text = d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOR"].ToString();

                dgv_prs_dtl.ClearSelection();
                dgv_prs_dtl.Rows[count].Selected = true;
            }
            else
            {
                if (count == d.Tables["PRISONER_DETAILS"].Rows.Count - 1)
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
            cmd.CommandText = "Select * from PRISONER_DETAILS where P_ID='" + text + "'";
            OleDbDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                txt_P_id.Text = read["P_ID"].ToString();
                txt_B_id.Text = read["B_ID"].ToString();
                txt_prs_status.Text = read["P_Status"].ToString();
                txt_prs_doa.Text = read["P_DOA"].ToString();
                txt_prs_fir.Text = read["P_FIR"].ToString();
                txt_prs_crime.Text = read["P_Crime"].ToString();
                txt_prs_us.Text = read["P_US"].ToString();
                txt_prs_dop.Text = read["P_DOP"].ToString();
                txt_prs_court.Text = read["P_Court"].ToString();
                txt_prs_doi.Text = read["P_DOI"].ToString();
                txt_prs_dor.Text = read["P_DOR"].ToString();
            }

            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from PRISONER_DETAILS ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgv_prs_dtl.DataSource = dt;


            for (int rowno = 0; rowno < dgv_prs_dtl.Rows.Count-1; rowno++)
            {
                if (txt_search.Text == dgv_prs_dtl.Rows[rowno].Cells[0].Value.ToString())
                {
                    dgv_prs_dtl.ClearSelection();
                    dgv_prs_dtl.Rows[rowno].Selected = true;
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

            e.Graphics.DrawString("Prisoner Detail", new Font("Arial", 32), Brushes.Black, new Point(25, 290));


            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 40));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Cyan, new Point(0, y += 10));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 10));

            e.Graphics.DrawString("P_ID", new Font("Arial", 12), Brushes.Black, new Point(25, 430));
            e.Graphics.DrawString("B_ID", new Font("Arial", 12), Brushes.Black, new Point(85, 430));
            e.Graphics.DrawString("Status", new Font("Arial", 12), Brushes.Black, new Point(140, 430));
            e.Graphics.DrawString("DOA", new Font("Arial", 12), Brushes.Black, new Point(235, 430));
            e.Graphics.DrawString("FIR", new Font("Arial", 12), Brushes.Black, new Point(335, 430));
            e.Graphics.DrawString("US", new Font("Arial", 12), Brushes.Black, new Point(445, 430));
            e.Graphics.DrawString("DOP", new Font("Arial", 12), Brushes.Black, new Point(525, 430));
            e.Graphics.DrawString("DOI", new Font("Arial", 12), Brushes.Black, new Point(625, 430));
            e.Graphics.DrawString("DOR", new Font("Arial", 12), Brushes.Black, new Point(725, 430));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, 450));

            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from PRISONER_DETAILS ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataSet d = new DataSet();
            adap.Fill(d, "PRISONER_DETAILS");
            y = 500;
            for (count = 0; count < d.Tables["PRISONER_DETAILS"].Rows.Count; count++)
            {
                DateTime doa = Convert.ToDateTime(d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOA"].ToString());
                e.Graphics.DrawString(d.Tables["PRISONER_DETAILS"].Rows[count]["P_ID"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(25, y));
                e.Graphics.DrawString(d.Tables["PRISONER_DETAILS"].Rows[count]["B_ID"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(85, y));
                e.Graphics.DrawString(d.Tables["PRISONER_DETAILS"].Rows[count]["P_Status"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(140, y));
                e.Graphics.DrawString(doa.ToString("MM/dd/yyyy"), new Font("Arial", 12), Brushes.Black, new Point(235, y));
                e.Graphics.DrawString(d.Tables["PRISONER_DETAILS"].Rows[count]["P_FIR"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(335, y));
                e.Graphics.DrawString(d.Tables["PRISONER_DETAILS"].Rows[count]["P_US"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(445, y));
                if (d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOP"].ToString() != "")
                {
                    DateTime dop = Convert.ToDateTime(d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOP"].ToString());
                    e.Graphics.DrawString(dop.ToString("MM/dd/yyyy"), new Font("Arial", 12), Brushes.Black, new Point(525, y));
                }
                if (d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOI"].ToString() != "")
                {
                    DateTime doi = Convert.ToDateTime(d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOI"].ToString());
                    e.Graphics.DrawString(doi.ToString("MM/dd/yyyy"), new Font("Arial", 12), Brushes.Black, new Point(625, y));
                }
                if (d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOR"].ToString() != "")
                {
                    DateTime dor = Convert.ToDateTime(d.Tables["PRISONER_DETAILS"].Rows[count]["P_DOR"].ToString());
                    e.Graphics.DrawString(dor.ToString("MM/dd/yyyy"), new Font("Arial", 12), Brushes.Black, new Point(725, y));
                }
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

            e.Graphics.DrawString("Prisoner Detail", new Font("Arial", 32), Brushes.Black, new Point(25, 290));


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
            e.Graphics.DrawString(label10.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 510));
            e.Graphics.DrawString(label11.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 560));
            

            e.Graphics.DrawString(txt_P_id.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 60));
            e.Graphics.DrawString(txt_B_id.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 110));
            e.Graphics.DrawString(txt_prs_status.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 160));
            e.Graphics.DrawString(txt_prs_doa.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 210));
            e.Graphics.DrawString(txt_prs_fir.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 260));
            e.Graphics.DrawString(txt_prs_crime.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 310));
            e.Graphics.DrawString(txt_prs_us.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 360));
            e.Graphics.DrawString(txt_prs_dop.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 410));
            e.Graphics.DrawString(txt_prs_court.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 460));
            e.Graphics.DrawString(txt_prs_doi.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 510));
            e.Graphics.DrawString(txt_prs_dor.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 560));
            

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 75));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 125));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 175));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 225));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 275));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 325));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 375));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 425));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 475));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 525));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 575));
            

        }

        private void btn_save_file_Click(object sender, EventArgs e)
        {
            tableDocument.Print();
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
