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
    public partial class frm_grd_info_dsp : Form
    {
        OleDbConnection con = new OleDbConnection();
        string u; bool c;
        int count;
        public frm_grd_info_dsp(string user, bool check)
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;";
            u = user;
            c = check;
           
        }

        private void frm_grd_info_dsp_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\32.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch; 
            
            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from GUARD_INFO ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgv_grd.DataSource = dt;

            DataSet d = new DataSet();
            adap.Fill(d, "GUARD_INFO");
            txt_G_id.Text = d.Tables["GUARD_INFO"].Rows[0]["G_ID"].ToString();
            txt_grd_name.Text = d.Tables["GUARD_INFO"].Rows[0]["G_Name"].ToString();
            txt_B_id.Text = d.Tables["GUARD_INFO"].Rows[0]["B_ID"].ToString();
            txt_grd_add.Text = d.Tables["GUARD_INFO"].Rows[0]["G_Address"].ToString();
            txt_grd_jd.Text = d.Tables["GUARD_INFO"].Rows[0]["G_J_Date"].ToString();
            txt_grd_ph.Text = d.Tables["GUARD_INFO"].Rows[0]["G_Phone"].ToString();
            txt_grd_sal.Text = d.Tables["GUARD_INFO"].Rows[0]["G_Salary"].ToString();
            txt_grd_nic.Text = d.Tables["GUARD_INFO"].Rows[0]["G_NIC"].ToString();
            
            txt_search.Text = "Guard ID";
            txt_search.ForeColor = Color.Gray;

            con.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if(c)
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
                frm_grd_info_mpl f1 = new frm_grd_info_mpl(u);
                f1.Show();
                this.Hide();
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from GUARD_INFO", con);

            DataSet d = new DataSet();
            adap.Fill(d, "GUARD_INFO");
            if (count > 0)
            {
                count = 0;
                txt_G_id.Text = d.Tables["GUARD_INFO"].Rows[count]["G_ID"].ToString();
                txt_grd_name.Text = d.Tables["GUARD_INFO"].Rows[count]["G_Name"].ToString();
                txt_B_id.Text = d.Tables["GUARD_INFO"].Rows[count]["B_ID"].ToString();
                txt_grd_add.Text = d.Tables["GUARD_INFO"].Rows[count]["G_Address"].ToString();
                txt_grd_jd.Text = d.Tables["GUARD_INFO"].Rows[count]["G_J_Date"].ToString();
                txt_grd_ph.Text = d.Tables["GUARD_INFO"].Rows[count]["G_Phone"].ToString();
                txt_grd_sal.Text = d.Tables["GUARD_INFO"].Rows[count]["G_Salary"].ToString();
                txt_grd_nic.Text = d.Tables["GUARD_INFO"].Rows[count]["G_NIC"].ToString();
                
                dgv_grd.ClearSelection();
                dgv_grd.Rows[count].Selected = true;
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
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from GUARD_INFO", con);
            DataSet d = new DataSet();
            adap.Fill(d, "GUARD_INFO");
            if (count > 0)
            {
                count--;
                txt_G_id.Text = d.Tables["GUARD_INFO"].Rows[count]["G_ID"].ToString();
                txt_grd_name.Text = d.Tables["GUARD_INFO"].Rows[count]["G_Name"].ToString();
                txt_B_id.Text = d.Tables["GUARD_INFO"].Rows[count]["B_ID"].ToString();
                txt_grd_add.Text = d.Tables["GUARD_INFO"].Rows[count]["G_Address"].ToString();
                txt_grd_jd.Text = d.Tables["GUARD_INFO"].Rows[count]["G_J_Date"].ToString();
                txt_grd_ph.Text = d.Tables["GUARD_INFO"].Rows[count]["G_Phone"].ToString();
                txt_grd_sal.Text = d.Tables["GUARD_INFO"].Rows[count]["G_Salary"].ToString();
                txt_grd_nic.Text = d.Tables["GUARD_INFO"].Rows[count]["G_NIC"].ToString();

                dgv_grd.ClearSelection();
                dgv_grd.Rows[count].Selected = true;
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
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from GUARD_INFO", con);
            DataSet d = new DataSet();
            adap.Fill(d, "GUARD_INFO");
            if (count < d.Tables["GUARD_INFO"].Rows.Count - 1)
            {
                count++;
                txt_G_id.Text = d.Tables["GUARD_INFO"].Rows[count]["G_ID"].ToString();
                txt_grd_name.Text = d.Tables["GUARD_INFO"].Rows[count]["G_Name"].ToString();
                txt_B_id.Text = d.Tables["GUARD_INFO"].Rows[count]["B_ID"].ToString();
                txt_grd_add.Text = d.Tables["GUARD_INFO"].Rows[count]["G_Address"].ToString();
                txt_grd_jd.Text = d.Tables["GUARD_INFO"].Rows[count]["G_J_Date"].ToString();
                txt_grd_ph.Text = d.Tables["GUARD_INFO"].Rows[count]["G_Phone"].ToString();
                txt_grd_sal.Text = d.Tables["GUARD_INFO"].Rows[count]["G_Salary"].ToString();
                txt_grd_nic.Text = d.Tables["GUARD_INFO"].Rows[count]["G_NIC"].ToString();

                dgv_grd.ClearSelection();
                dgv_grd.Rows[count].Selected = true;
            }
            else
            {
                if (count == d.Tables["GUARD_INFO"].Rows.Count - 1)
                    MessageBox.Show("You are already on Last record");
            }
            con.Close();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from GUARD_INFO", con);
            DataSet d = new DataSet();
            adap.Fill(d, "GUARD_INFO");
            if (count < d.Tables["GUARD_INFO"].Rows.Count - 1)
            {
                count = d.Tables["GUARD_INFO"].Rows.Count - 1;
                txt_G_id.Text = d.Tables["GUARD_INFO"].Rows[count]["G_ID"].ToString();
                txt_grd_name.Text = d.Tables["GUARD_INFO"].Rows[count]["G_Name"].ToString();
                txt_B_id.Text = d.Tables["GUARD_INFO"].Rows[count]["B_ID"].ToString();
                txt_grd_add.Text = d.Tables["GUARD_INFO"].Rows[count]["G_Address"].ToString();
                txt_grd_jd.Text = d.Tables["GUARD_INFO"].Rows[count]["G_J_Date"].ToString();
                txt_grd_ph.Text = d.Tables["GUARD_INFO"].Rows[count]["G_Phone"].ToString();
                txt_grd_sal.Text = d.Tables["GUARD_INFO"].Rows[count]["G_Salary"].ToString();
                txt_grd_nic.Text = d.Tables["GUARD_INFO"].Rows[count]["G_NIC"].ToString();

                dgv_grd.ClearSelection();
                dgv_grd.Rows[count].Selected = true;
            }
            else
            {
                if (count == d.Tables["GUARD_INFO"].Rows.Count - 1)
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
            cmd.CommandText = "Select * from GUARD_INFO where G_ID='" + text + "'";
            OleDbDataReader read = cmd.ExecuteReader();
            
            while (read.Read())
            {
                txt_G_id.Text = read["G_ID"].ToString();
                txt_grd_name.Text = read["G_Name"].ToString();
                txt_B_id.Text = read["B_ID"].ToString();
                txt_grd_add.Text = read["G_Address"].ToString();
                txt_grd_jd.Text = read["G_J_Date"].ToString();
                txt_grd_ph.Text = read["G_Phone"].ToString();
                txt_grd_sal.Text = read["G_Salary"].ToString();
                txt_grd_nic.Text = read["G_NIC"].ToString();
            }

            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from GUARD_INFO ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgv_grd.DataSource = dt;


            for (int rowno = 0; rowno < dgv_grd.Rows.Count-1; rowno++)
            {
                if (txt_search.Text == dgv_grd.Rows[rowno].Cells[0].Value.ToString())
                {
                    dgv_grd.ClearSelection();
                    dgv_grd.Rows[rowno].Selected = true;
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

            e.Graphics.DrawString("Guard Information", new Font("Arial", 32), Brushes.Black, new Point(25, 290));


            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 40));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Cyan, new Point(0, y += 10));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 10));

            e.Graphics.DrawString("ID", new Font("Arial", 12), Brushes.Black, new Point(25, 430));
            e.Graphics.DrawString("Name", new Font("Arial", 12), Brushes.Black, new Point(100, 430));
            e.Graphics.DrawString("BlockID", new Font("Arial", 12), Brushes.Black, new Point(220, 430));
            e.Graphics.DrawString("Address", new Font("Arial", 12), Brushes.Black, new Point(300, 430));
            e.Graphics.DrawString("Joining Date", new Font("Arial", 12), Brushes.Black, new Point(390, 430));
            e.Graphics.DrawString("Phone No", new Font("Arial", 12), Brushes.Black, new Point(500, 430));
            e.Graphics.DrawString("Salary", new Font("Arial", 12), Brushes.Black, new Point(620, 430));
            e.Graphics.DrawString("NIC No", new Font("Arial", 12), Brushes.Black, new Point(700, 430));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, 450));

            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from GUARD_INFO ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataSet d = new DataSet();
            adap.Fill(d, "GUARD_INFO");
            y = 500;
            for (count = 0; count < d.Tables["GUARD_INFO"].Rows.Count; count++)
            {
                DateTime dt = Convert.ToDateTime(d.Tables["GUARD_INFO"].Rows[count]["G_J_Date"].ToString());
                e.Graphics.DrawString(d.Tables["GUARD_INFO"].Rows[count]["G_ID"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(25, y));
                e.Graphics.DrawString(d.Tables["GUARD_INFO"].Rows[count]["G_Name"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(100, y));
                e.Graphics.DrawString(d.Tables["GUARD_INFO"].Rows[count]["B_ID"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(220, y));
                e.Graphics.DrawString(d.Tables["GUARD_INFO"].Rows[count]["G_Address"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(300, y));
                e.Graphics.DrawString(dt.ToString("MM/dd/yyyy"), new Font("Arial", 12), Brushes.Black, new Point(390, y));
                e.Graphics.DrawString(d.Tables["GUARD_INFO"].Rows[count]["G_Phone"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(500, y));
                e.Graphics.DrawString(d.Tables["GUARD_INFO"].Rows[count]["G_Salary"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(620, y));
                e.Graphics.DrawString(d.Tables["GUARD_INFO"].Rows[count]["G_NIC"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(700, y));
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
            e.Graphics.DrawString(txt_grd_jd.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 260));
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
