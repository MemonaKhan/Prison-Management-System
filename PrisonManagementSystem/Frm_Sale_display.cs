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
    public partial class frm_sale_dsp : Form
    {
        OleDbConnection con = new OleDbConnection();
        string u;
        bool c;
        int count;
        public frm_sale_dsp(string user, bool check)
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;";
            u = user;
            c = check;
        }

        private void frm_sale_dsp_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\41.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch; 
            
            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select I_ID,B_ID,I_Name,Price,Quantity,T_Amount,Month from PURCHASE_SALE_INFO where Type= 'Sale' ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgv_sale.DataSource = dt;

            DataSet d = new DataSet();
            adap.Fill(d, "PURCHASE_SALE_INFO");
            txt_I_id.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[0]["I_ID"].ToString();
            txt_B_ID.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[0]["B_ID"].ToString();
            txt_i_name.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[0]["I_Name"].ToString();
            txt_i_price.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[0]["Price"].ToString();
            txt_i_qty.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[0]["Quantity"].ToString();
            txt_i_t_amt.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[0]["T_Amount"].ToString();
            txt_i_month.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[0]["Month"].ToString();

            txt_search.Text = "Item ID";
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
                frm_sale_mpl f1 = new frm_sale_mpl(u);
                f1.Show();
                this.Hide();
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select I_ID,B_ID,I_Name,Price,Quantity,T_Amount,Month from PURCHASE_SALE_INFO where Type= 'Sale' ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);

            DataSet d = new DataSet();
            adap.Fill(d, "PURCHASE_SALE_INFO");
            if (count > 0)
            {
                count = 0;
                txt_I_id.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["I_ID"].ToString();
                txt_B_ID.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["B_ID"].ToString();
                txt_i_name.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["I_Name"].ToString();
                txt_i_price.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["Price"].ToString();
                txt_i_qty.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["Quantity"].ToString();
                txt_i_t_amt.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["T_Amount"].ToString();
                txt_i_month.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["Month"].ToString();


                dgv_sale.ClearSelection();
                dgv_sale.Rows[count].Selected = true;
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
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select I_ID,B_ID,I_Name,Price,Quantity,T_Amount,Month from PURCHASE_SALE_INFO where Type= 'Sale' ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataSet d = new DataSet();
            adap.Fill(d, "PURCHASE_SALE_INFO");
            if (count > 0)
            {
                count--;
                txt_I_id.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["I_ID"].ToString();
                txt_B_ID.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["B_ID"].ToString();
                txt_i_name.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["I_Name"].ToString();
                txt_i_price.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["Price"].ToString();
                txt_i_qty.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["Quantity"].ToString();
                txt_i_t_amt.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["T_Amount"].ToString();
                txt_i_month.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["Month"].ToString();


                dgv_sale.ClearSelection();
                dgv_sale.Rows[count].Selected = true;

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
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select I_ID,B_ID,I_Name,Price,Quantity,T_Amount,Month from PURCHASE_SALE_INFO where Type= 'Sale' ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataSet d = new DataSet();
            adap.Fill(d, "PURCHASE_SALE_INFO");
            if (count < d.Tables["PURCHASE_SALE_INFO"].Rows.Count - 1)
            {
                count++;
                txt_I_id.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["I_ID"].ToString();
                txt_B_ID.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["B_ID"].ToString();
                txt_i_name.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["I_Name"].ToString();
                txt_i_price.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["Price"].ToString();
                txt_i_qty.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["Quantity"].ToString();
                txt_i_t_amt.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["T_Amount"].ToString();
                txt_i_month.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["Month"].ToString();


                dgv_sale.ClearSelection();
                dgv_sale.Rows[count].Selected = true;
            }
            else
            {
                if (count == d.Tables["PURCHASE_SALE_INFO"].Rows.Count - 1)
                    MessageBox.Show("You are already on Last record");
            }
            con.Close();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select I_ID,B_ID,I_Name,Price,Quantity,T_Amount,Month from PURCHASE_SALE_INFO where Type= 'Sale' ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataSet d = new DataSet();
            adap.Fill(d, "PURCHASE_SALE_INFO");
            if (count < d.Tables["PURCHASE_SALE_INFO"].Rows.Count - 1)
            {
                count = d.Tables["PURCHASE_SALE_INFO"].Rows.Count - 1;
                txt_I_id.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["I_ID"].ToString();
                txt_B_ID.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["B_ID"].ToString();
                txt_i_name.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["I_Name"].ToString();
                txt_i_price.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["Price"].ToString();
                txt_i_qty.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["Quantity"].ToString();
                txt_i_t_amt.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["T_Amount"].ToString();
                txt_i_month.Text = d.Tables["PURCHASE_SALE_INFO"].Rows[count]["Month"].ToString();


                dgv_sale.ClearSelection();
                dgv_sale.Rows[count].Selected = true;
            }
            else
            {
                if (count == d.Tables["PURCHASE_SALE_INFO"].Rows.Count - 1)
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
            cmd.CommandText = "Select * from PURCHASE_SALE_INFO where I_ID='" + text + "'";
            OleDbDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                txt_I_id.Text = read["I_ID"].ToString();
                txt_B_ID.Text = read["B_ID"].ToString();
                txt_i_name.Text = read["I_Name"].ToString();
                txt_i_price.Text = read["Price"].ToString();
                txt_i_qty.Text = read["Quantity"].ToString();
                txt_i_t_amt.Text = read["T_Amount"].ToString();
                txt_i_month.Text = read["Month"].ToString();
            }

            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select I_ID,B_ID,I_Name,Price,Quantity,T_Amount,Month from PURCHASE_SALE_INFO where Type= 'Sale' ";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgv_sale.DataSource = dt;


            for (int rowno = 0; rowno < dgv_sale.Rows.Count-1; rowno++)
            {
                if (txt_search.Text == dgv_sale.Rows[rowno].Cells[0].Value.ToString())
                {
                    dgv_sale.ClearSelection();
                    dgv_sale.Rows[rowno].Selected = true;
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

            e.Graphics.DrawString("Sale Information", new Font("Arial", 32), Brushes.Black, new Point(25, 290));


            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 40));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Cyan, new Point(0, y += 10));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 10));

            e.Graphics.DrawString("ID", new Font("Arial", 12), Brushes.Black, new Point(35, 430));
            e.Graphics.DrawString("Block", new Font("Arial", 12), Brushes.Black, new Point(100, 430));
            e.Graphics.DrawString("Name", new Font("Arial", 12), Brushes.Black, new Point(220, 430));
            e.Graphics.DrawString("Quantity", new Font("Arial", 12), Brushes.Black, new Point(330, 430));
            e.Graphics.DrawString("Price", new Font("Arial", 12), Brushes.Black, new Point(440, 430));
            e.Graphics.DrawString("Month", new Font("Arial", 12), Brushes.Black, new Point(540, 430));
            e.Graphics.DrawString("Total", new Font("Arial", 12), Brushes.Black, new Point(630, 430));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, 450));

            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "Select * from PURCHASE_SALE_INFO where Type= 'Sale'";
            com.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataSet d = new DataSet();
            adap.Fill(d, "PURCHASE_SALE_INFO");
            y = 500;
            for (count = 0; count < d.Tables["PURCHASE_SALE_INFO"].Rows.Count; count++)
            {
                e.Graphics.DrawString(d.Tables["PURCHASE_SALE_INFO"].Rows[count]["I_ID"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(35, y));
                e.Graphics.DrawString(d.Tables["PURCHASE_SALE_INFO"].Rows[count]["B_ID"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(100, y));
                e.Graphics.DrawString(d.Tables["PURCHASE_SALE_INFO"].Rows[count]["I_Name"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(220, y));
                e.Graphics.DrawString(d.Tables["PURCHASE_SALE_INFO"].Rows[count]["Quantity"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(350, y));
                e.Graphics.DrawString(d.Tables["PURCHASE_SALE_INFO"].Rows[count]["Price"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(440, y));
                e.Graphics.DrawString(d.Tables["PURCHASE_SALE_INFO"].Rows[count]["Month"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(540, y));
                e.Graphics.DrawString(d.Tables["PURCHASE_SALE_INFO"].Rows[count]["T_Amount"].ToString(), new Font("Arial", 12), Brushes.Black, new Point(630, y));

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

            e.Graphics.DrawString("Sale Information", new Font("Arial", 32), Brushes.Black, new Point(25, 290));


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

            e.Graphics.DrawString(txt_I_id.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 60));
            e.Graphics.DrawString(txt_B_ID.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 110));
            e.Graphics.DrawString(txt_i_name.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 160));
            e.Graphics.DrawString(txt_i_qty.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 210));
            e.Graphics.DrawString(txt_i_price.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 260));
            e.Graphics.DrawString(txt_i_month.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 310));
            e.Graphics.DrawString(txt_i_t_amt.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 360));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 75));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 125));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 175));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 225));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 275));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 325));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 375));
           
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
