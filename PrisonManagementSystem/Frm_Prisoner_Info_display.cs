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
    public partial class frm_prs_info_dsp : Form
    {
        OleDbConnection con = new OleDbConnection();
        string u;
        bool c;
        int count;
        public frm_prs_info_dsp(string user, bool check)
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;";
            u = user;
            c = check;
           
        }
        
        private void frm_prs_info_dsp_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\36.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch; 

            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from PRISONER_INFO ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgv_prs_info.DataSource = dt;

            DataSet d = new DataSet();
            adap.Fill(d, "PRISONER_INFO");
            txt_P_id.Text = d.Tables["PRISONER_INFO"].Rows[0]["P_ID"].ToString();
            txt_prs_name.Text = d.Tables["PRISONER_INFO"].Rows[0]["P_Name"].ToString();
            txt_prs_fname.Text = d.Tables["PRISONER_INFO"].Rows[0]["P_F_Name"].ToString();
            txt_prs_add.Text = d.Tables["PRISONER_INFO"].Rows[0]["P_Address"].ToString();
            txt_prs_dob.Text = d.Tables["PRISONER_INFO"].Rows[0]["P_DOB"].ToString();
            txt_prs_gender.Text = d.Tables["PRISONER_INFO"].Rows[0]["P_Gender"].ToString();
            txt_prs_ph.Text = d.Tables["PRISONER_INFO"].Rows[0]["P_Phone"].ToString();
            txt_prs_nic.Text = d.Tables["PRISONER_INFO"].Rows[0]["P_NIC"].ToString();
            txt_prs_moi.Text = d.Tables["PRISONER_INFO"].Rows[0]["P_MOI"].ToString();

            con.Close();
            txt_search.Text = "Prisoner ID";
            txt_search.ForeColor = Color.Gray;


            
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
                frm_prs_info_mpl f1 = new frm_prs_info_mpl(u);
                f1.Show();
                this.Hide();
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from PRISONER_INFO", con);

            DataSet d = new DataSet();
            adap.Fill(d, "PRISONER_INFO");
            if (count > 0)
            {
                count = 0;
                txt_P_id.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_ID"].ToString();
                txt_prs_name.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_Name"].ToString();
                txt_prs_fname.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_F_Name"].ToString();
                txt_prs_add.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_Address"].ToString();
                txt_prs_dob.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_DOB"].ToString();
                txt_prs_gender.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_Gender"].ToString();
                txt_prs_ph.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_Phone"].ToString();
                txt_prs_nic.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_NIC"].ToString();
                txt_prs_moi.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_MOI"].ToString();


                dgv_prs_info.ClearSelection();
                dgv_prs_info.Rows[count].Selected = true;
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
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from PRISONER_INFO", con);
            DataSet d = new DataSet();
            adap.Fill(d, "PRISONER_INFO");
            if (count > 0)
            {
                count--;
                txt_P_id.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_ID"].ToString();
                txt_prs_name.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_Name"].ToString();
                txt_prs_fname.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_F_Name"].ToString();
                txt_prs_add.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_Address"].ToString();
                txt_prs_dob.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_DOB"].ToString();
                txt_prs_gender.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_Gender"].ToString();
                txt_prs_ph.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_Phone"].ToString();
                txt_prs_nic.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_NIC"].ToString();
                txt_prs_moi.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_MOI"].ToString();


                dgv_prs_info.ClearSelection();
                dgv_prs_info.Rows[count].Selected = true;
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
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from PRISONER_INFO", con);
            DataSet d = new DataSet();
            adap.Fill(d, "PRISONER_INFO");
            if (count < d.Tables["PRISONER_INFO"].Rows.Count - 1)
            {
                count++;
                txt_P_id.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_ID"].ToString();
                txt_prs_name.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_Name"].ToString();
                txt_prs_fname.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_F_Name"].ToString();
                txt_prs_add.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_Address"].ToString();
                txt_prs_dob.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_DOB"].ToString();
                txt_prs_gender.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_Gender"].ToString();
                txt_prs_ph.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_Phone"].ToString();
                txt_prs_nic.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_NIC"].ToString();
                txt_prs_moi.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_MOI"].ToString();


                dgv_prs_info.ClearSelection();
                dgv_prs_info.Rows[count].Selected = true;
            }
            else
            {
                if (count == d.Tables["PRISONER_INFO"].Rows.Count - 1)
                    MessageBox.Show("You are already on Last record");
            }
            con.Close();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from PRISONER_INFO", con);
            DataSet d = new DataSet();
            adap.Fill(d, "PRISONER_INFO");
            if (count < d.Tables["PRISONER_INFO"].Rows.Count - 1)
            {
                count = d.Tables["PRISONER_INFO"].Rows.Count - 1;
                txt_P_id.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_ID"].ToString();
                txt_prs_name.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_Name"].ToString();
                txt_prs_fname.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_F_Name"].ToString();
                txt_prs_add.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_Address"].ToString();
                txt_prs_dob.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_DOB"].ToString();
                txt_prs_gender.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_Gender"].ToString();
                txt_prs_ph.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_Phone"].ToString();
                txt_prs_nic.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_NIC"].ToString();
                txt_prs_moi.Text = d.Tables["PRISONER_INFO"].Rows[count]["P_MOI"].ToString();


                dgv_prs_info.ClearSelection();
                dgv_prs_info.Rows[count].Selected = true;
            }
            else
            {
                if (count == d.Tables["PRISONER_INFO"].Rows.Count - 1)
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
            cmd.CommandText = "Select * from PRISONER_INFO where P_ID='" + text + "'";
            OleDbDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                txt_P_id.Text = read["P_ID"].ToString();
                txt_prs_name.Text = read["P_Name"].ToString();
                txt_prs_fname.Text = read["P_F_Name"].ToString();
                txt_prs_add.Text = read["P_Address"].ToString();
                txt_prs_dob.Text = read["P_DOB"].ToString();
                txt_prs_gender.Text = read["P_Gender"].ToString();
                txt_prs_ph.Text = read["P_Phone"].ToString();
                txt_prs_nic.Text = read["P_NIC"].ToString();
                txt_prs_moi.Text = read["P_MOI"].ToString();
               
            }

            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from PRISONER_INFO ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgv_prs_info.DataSource = dt;


            for (int rowno = 0; rowno < dgv_prs_info.Rows.Count-1; rowno++)
            {
                if (txt_search.Text == dgv_prs_info.Rows[rowno].Cells[0].Value.ToString())
                {
                    dgv_prs_info.ClearSelection();
                    dgv_prs_info.Rows[rowno].Selected = true;
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

            e.Graphics.DrawString("Prisoner Information", new Font("Arial", 32), Brushes.Black, new Point(25, 290));


            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 40));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Cyan, new Point(0, y += 10));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 10));

            e.Graphics.DrawString("ID", new Font("Arial", 12), Brushes.Black, new Point(15, 430));
            e.Graphics.DrawString("Name", new Font("Arial", 12), Brushes.Black, new Point(70, 430));
            e.Graphics.DrawString("Father", new Font("Arial", 12), Brushes.Black, new Point(200, 430));
            e.Graphics.DrawString("Address", new Font("Arial", 12), Brushes.Black, new Point(310, 430));
            e.Graphics.DrawString("Birth", new Font("Arial", 12), Brushes.Black, new Point(410, 430));
            e.Graphics.DrawString("Gender", new Font("Arial", 12), Brushes.Black, new Point(520, 430));
            e.Graphics.DrawString("Phone", new Font("Arial", 12), Brushes.Black, new Point(585, 430));
            e.Graphics.DrawString("NIC No", new Font("Arial", 12), Brushes.Black, new Point(700, 430));
           e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, 450));

            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from PRISONER_INFO ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataSet d = new DataSet();
            adap.Fill(d, "PRISONER_INFO");
            y = 500;
            for (count = 0; count < d.Tables["PRISONER_INFO"].Rows.Count; count++)
            {
                DateTime dt = Convert.ToDateTime(d.Tables["PRISONER_INFO"].Rows[count]["P_DOB"].ToString());
                e.Graphics.DrawString(d.Tables["PRISONER_INFO"].Rows[count]["P_ID"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(15, y));
                e.Graphics.DrawString(d.Tables["PRISONER_INFO"].Rows[count]["P_Name"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(70, y));
                e.Graphics.DrawString(d.Tables["PRISONER_INFO"].Rows[count]["P_F_Name"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(200, y));
                e.Graphics.DrawString(d.Tables["PRISONER_INFO"].Rows[count]["P_Address"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(310, y));
                e.Graphics.DrawString(dt.ToString("MM/dd/yyyy"), new Font("Arial", 12), Brushes.Black, new Point(410, y));
                e.Graphics.DrawString(d.Tables["PRISONER_INFO"].Rows[count]["P_Gender"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(520, y));
                e.Graphics.DrawString(d.Tables["PRISONER_INFO"].Rows[count]["P_Phone"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(585, y));
                e.Graphics.DrawString(d.Tables["PRISONER_INFO"].Rows[count]["P_NIC"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(700, y));
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
            e.Graphics.DrawString(txt_prs_dob.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 260));
            e.Graphics.DrawString(txt_prs_gender.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 310));
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
            printPreviewDialog.Show();
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
