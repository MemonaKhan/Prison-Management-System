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
    public partial class frm_visit_dsp : Form
    {
        OleDbConnection con = new OleDbConnection();
        string u;
        bool c;
        int count;
        public frm_visit_dsp(string user, bool check)
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;";
            u = user;
            c = check;
        }

        private void frm_visit_dsp_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\43.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch; 
            
            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from VISIT_INFO ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            
            dgv_visit.DataSource = dt;
            dgv_visit.Columns["B_Time"].DefaultCellStyle.Format = "h:mm tt";
            dgv_visit.Columns["E_Time"].DefaultCellStyle.Format = "h:mm tt";

            DataSet d = new DataSet();
            adap.Fill(d, "VISIT_INFO");
            txt_V_id.Text = d.Tables["VISIT_INFO"].Rows[0]["V_ID"].ToString();
            txt_prs_id.Text = d.Tables["VISIT_INFO"].Rows[0]["P_ID"].ToString();
            txt_V_name.Text = d.Tables["VISIT_INFO"].Rows[0]["V_Name"].ToString();
            txt_V_add.Text = d.Tables["VISIT_INFO"].Rows[0]["V_Address"].ToString();
            txt_relation.Text = d.Tables["VISIT_INFO"].Rows[0]["V_P_Relation"].ToString();
            txt_V_ph.Text = d.Tables["VISIT_INFO"].Rows[0]["V_Phone"].ToString();
            txt_V_date.Text = d.Tables["VISIT_INFO"].Rows[0]["V_Date"].ToString();
            txt_btime.Text = d.Tables["VISIT_INFO"].Rows[0]["B_Time"].ToString();
            txt_etime.Text = d.Tables["VISIT_INFO"].Rows[0]["E_Time"].ToString();

            txt_search.Text = "Visit ID";
            txt_search.ForeColor = Color.Gray;

            con.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (c)
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
            else
            {
                frm_visit_mpl f1 = new frm_visit_mpl(u);
                f1.Show();
                this.Hide();
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from VISIT_INFO", con);

            DataSet d = new DataSet();
            adap.Fill(d, "VISIT_INFO");
            if (count > 0)
            {
                count = 0;
                txt_V_id.Text = d.Tables["VISIT_INFO"].Rows[count]["V_ID"].ToString();
                txt_prs_id.Text = d.Tables["VISIT_INFO"].Rows[count]["P_ID"].ToString();
                txt_V_name.Text = d.Tables["VISIT_INFO"].Rows[count]["V_Name"].ToString();
                txt_V_add.Text = d.Tables["VISIT_INFO"].Rows[count]["V_Address"].ToString();
                txt_relation.Text = d.Tables["VISIT_INFO"].Rows[count]["V_P_Relation"].ToString();
                txt_V_ph.Text = d.Tables["VISIT_INFO"].Rows[count]["V_Phone"].ToString();
                txt_V_date.Text = d.Tables["VISIT_INFO"].Rows[count]["V_Date"].ToString();
                txt_btime.Text = d.Tables["VISIT_INFO"].Rows[count]["B_Time"].ToString();
                txt_etime.Text = d.Tables["VISIT_INFO"].Rows[count]["E_Time"].ToString();


                dgv_visit.ClearSelection();
                dgv_visit.Rows[count].Selected = true;
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
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from VISIT_INFO", con);
            DataSet d = new DataSet();
            adap.Fill(d, "VISIT_INFO");
            if (count > 0)
            {
                count--;
                txt_V_id.Text = d.Tables["VISIT_INFO"].Rows[count]["V_ID"].ToString();
                txt_prs_id.Text = d.Tables["VISIT_INFO"].Rows[count]["P_ID"].ToString();
                txt_V_name.Text = d.Tables["VISIT_INFO"].Rows[count]["V_Name"].ToString();
                txt_V_add.Text = d.Tables["VISIT_INFO"].Rows[count]["V_Address"].ToString();
                txt_relation.Text = d.Tables["VISIT_INFO"].Rows[count]["V_P_Relation"].ToString();
                txt_V_ph.Text = d.Tables["VISIT_INFO"].Rows[count]["V_Phone"].ToString();
                txt_V_date.Text = d.Tables["VISIT_INFO"].Rows[count]["V_Date"].ToString();
                txt_btime.Text = d.Tables["VISIT_INFO"].Rows[count]["B_Time"].ToString();
                txt_etime.Text = d.Tables["VISIT_INFO"].Rows[count]["E_Time"].ToString();


                dgv_visit.ClearSelection();
                dgv_visit.Rows[count].Selected = true;
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
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from VISIT_INFO", con);
            DataSet d = new DataSet();
            adap.Fill(d, "VISIT_INFO");
            if (count < d.Tables["VISIT_INFO"].Rows.Count - 1)
            {
                count++;
                txt_V_id.Text = d.Tables["VISIT_INFO"].Rows[count]["V_ID"].ToString();
                txt_prs_id.Text = d.Tables["VISIT_INFO"].Rows[count]["P_ID"].ToString();
                txt_V_name.Text = d.Tables["VISIT_INFO"].Rows[count]["V_Name"].ToString();
                txt_V_add.Text = d.Tables["VISIT_INFO"].Rows[count]["V_Address"].ToString();
                txt_relation.Text = d.Tables["VISIT_INFO"].Rows[count]["V_P_Relation"].ToString();
                txt_V_ph.Text = d.Tables["VISIT_INFO"].Rows[count]["V_Phone"].ToString();
                txt_V_date.Text = d.Tables["VISIT_INFO"].Rows[count]["V_Date"].ToString();
                txt_btime.Text = d.Tables["VISIT_INFO"].Rows[count]["B_Time"].ToString();
                txt_etime.Text = d.Tables["VISIT_INFO"].Rows[count]["E_Time"].ToString();


                dgv_visit.ClearSelection();
                dgv_visit.Rows[count].Selected = true;
            }
            else
            {
                if (count == d.Tables["VISIT_INFO"].Rows.Count - 1)
                    MessageBox.Show("You are already on Last record");
            }
            con.Close();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from VISIT_INFO", con);
            DataSet d = new DataSet();
            adap.Fill(d, "VISIT_INFO");
            if (count < d.Tables["VISIT_INFO"].Rows.Count - 1)
            {
                count = d.Tables["VISIT_INFO"].Rows.Count - 1;
                txt_V_id.Text = d.Tables["VISIT_INFO"].Rows[count]["V_ID"].ToString();
                txt_prs_id.Text = d.Tables["VISIT_INFO"].Rows[count]["P_ID"].ToString();
                txt_V_name.Text = d.Tables["VISIT_INFO"].Rows[count]["V_Name"].ToString();
                txt_V_add.Text = d.Tables["VISIT_INFO"].Rows[count]["V_Address"].ToString();
                txt_relation.Text = d.Tables["VISIT_INFO"].Rows[count]["V_P_Relation"].ToString();
                txt_V_ph.Text = d.Tables["VISIT_INFO"].Rows[count]["V_Phone"].ToString();
                txt_V_date.Text = d.Tables["VISIT_INFO"].Rows[count]["V_Date"].ToString();
                txt_btime.Text = d.Tables["VISIT_INFO"].Rows[count]["B_Time"].ToString();
                txt_etime.Text = d.Tables["VISIT_INFO"].Rows[count]["E_Time"].ToString();


                dgv_visit.ClearSelection();
                dgv_visit.Rows[count].Selected = true;
            }
            else
            {
                if (count == d.Tables["VISIT_INFO"].Rows.Count - 1)
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
            cmd.CommandText = "Select * from VISIT_INFO where V_ID='" + text + "'";
            OleDbDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                txt_V_id.Text = read["V_ID"].ToString();
                txt_prs_id.Text = read["P_ID"].ToString();
                txt_V_name.Text = read["V_Name"].ToString();
                txt_V_add.Text = read["V_Address"].ToString();
                txt_relation.Text = read["V_P_Relation"].ToString();
                txt_V_ph.Text =read["V_Phone"].ToString();
                txt_V_date.Text = read["V_Date"].ToString();
                txt_btime.Text = read["B_Time"].ToString();
                txt_etime.Text = read["E_Time"].ToString();
            }

            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from VISIT_INFO ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgv_visit.DataSource = dt;


            for (int rowno = 0; rowno < dgv_visit.Rows.Count-1; rowno++)
            {
                if (txt_search.Text == dgv_visit.Rows[rowno].Cells[0].Value.ToString())
                {
                    dgv_visit.ClearSelection();
                    dgv_visit.Rows[rowno].Selected = true;
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

            e.Graphics.DrawString("Visit Information", new Font("Arial", 32), Brushes.Black, new Point(25, 290));


            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 40));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Cyan, new Point(0, y += 10));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 10));

            e.Graphics.DrawString("V_ID", new Font("Arial", 12), Brushes.Black, new Point(15, 430));
            e.Graphics.DrawString("P_ID", new Font("Arial", 12), Brushes.Black, new Point(85, 430));
            e.Graphics.DrawString("V_Name", new Font("Arial", 12), Brushes.Black, new Point(155, 430));
            e.Graphics.DrawString("Address", new Font("Arial", 12), Brushes.Black, new Point(250, 430));
            e.Graphics.DrawString("Relation", new Font("Arial", 12), Brushes.Black, new Point(350, 430));
            e.Graphics.DrawString("V_Phone", new Font("Arial", 12), Brushes.Black, new Point(435, 430));
            e.Graphics.DrawString("V_Date", new Font("Arial", 12), Brushes.Black, new Point(550, 430));
            e.Graphics.DrawString("B_Time", new Font("Arial", 12), Brushes.Black, new Point(650, 430));
            e.Graphics.DrawString("E_Time", new Font("Arial", 12), Brushes.Black, new Point(750, 430));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, 450));

            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from VISIT_INFO ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataSet d = new DataSet();
            adap.Fill(d, "VISIT_INFO");
            y = 500;
            for (count = 0; count < d.Tables["VISIT_INFO"].Rows.Count; count++)
            {
                DateTime dt = Convert.ToDateTime(d.Tables["VISIT_INFO"].Rows[count]["V_Date"].ToString());
                DateTime bt = Convert.ToDateTime(d.Tables["VISIT_INFO"].Rows[count]["B_Time"].ToString());
                DateTime et = Convert.ToDateTime(d.Tables["VISIT_INFO"].Rows[count]["E_Time"].ToString());
                e.Graphics.DrawString(d.Tables["VISIT_INFO"].Rows[count]["V_ID"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(15, y));
                e.Graphics.DrawString(d.Tables["VISIT_INFO"].Rows[count]["P_ID"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(85, y));
                e.Graphics.DrawString(d.Tables["VISIT_INFO"].Rows[count]["V_Name"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(155, y));
                e.Graphics.DrawString(d.Tables["VISIT_INFO"].Rows[count]["V_Address"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(250, y));
                e.Graphics.DrawString(d.Tables["VISIT_INFO"].Rows[count]["V_P_Relation"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(350, y));
                e.Graphics.DrawString(d.Tables["VISIT_INFO"].Rows[count]["V_Phone"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(435, y));
                e.Graphics.DrawString(dt.ToString("MM/dd/yyyy"), new Font("Arial", 12), Brushes.Black, new Point(550, y));
                e.Graphics.DrawString(bt.ToString("h:mm tt"), new Font("Arial", 12), Brushes.Black, new Point(650, y));
                e.Graphics.DrawString(et.ToString("h:mm tt"), new Font("Arial", 12), Brushes.Black, new Point(750, y)); 
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
            e.Graphics.DrawString(txt_relation.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 260));
            e.Graphics.DrawString(txt_V_ph.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 310));
            e.Graphics.DrawString(txt_V_date.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 360));
            e.Graphics.DrawString(txt_btime.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 410));
            e.Graphics.DrawString(txt_etime.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 460));
            
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

        private void btn_print_rec_Click(object sender, EventArgs e)
        {
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;
            printDialog.Document = recordDocument;
            printDialog.ShowDialog();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = recordDocument;
            printPreviewDialog.ShowDialog();
        }



        
       
    }
}
