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
    public partial class frm_purchase_mpl : Form
    {
        OleDbConnection con = new OleDbConnection();
        string u;
        public frm_purchase_mpl(string user)
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;";
            u = user;
           
        }

        private void frm_purchase_mpl_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\40.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch; 
            
            cmb_i_month.Items.AddRange(new object[] {"","January","February","March","April","May","June","July",
            "August","September","October","November","December"});
            
            txt_B_ID.Text = "";
            txt_I_id.Text = "";
            txt_i_name.Text = "";
            txt_i_price.Text = "";
            txt_i_qty.Text = "";
            txt_i_t_amt.Text = "";
            txt_search.Text = "Item ID";
            txt_search.ForeColor = Color.Gray;
            cmb_i_month.SelectedIndex = 0;
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

        private void btn_purchase_dsp_Click(object sender, EventArgs e)
        {
            frm_purchase_dsp f1 = new frm_purchase_dsp(u,false);
            f1.Show();
            this.Hide();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_B_ID.Text = "";
            txt_I_id.Text = "";
            txt_i_name.Text = "";
            txt_i_price.Text = "";
            txt_i_qty.Text = "";
            txt_i_t_amt.Text = "";
            txt_search.Text = "Prisoner ID";
            txt_search.ForeColor = Color.Gray;
            cmb_i_month.SelectedIndex = 0;
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
            cmd.CommandText = "Select * from PURCHASE_SALE_INFO where I_ID='" + text + "' and Type = 'Purchase'";
            OleDbDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                txt_I_id.Text = read["I_ID"].ToString();
                txt_B_ID.Text = read["B_ID"].ToString();
                txt_i_name.Text = read["I_Name"].ToString();
                txt_i_price.Text = read["Price"].ToString();
                txt_i_qty.Text = read["Quantity"].ToString();
                txt_i_t_amt.Text = read["T_Amount"].ToString();
                cmb_i_month.Text = read["Month"].ToString();
            }
            con.Close();
        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into PURCHASE_SALE_INFO ([I_ID], [B_ID], [I_Name], [Price], [Quantity], [T_Amount], [Month], [Type]) values ('" + txt_I_id.Text + "','" + txt_B_ID.Text + "','" + txt_i_name.Text + "','" + txt_i_price.Text + "','" + txt_i_qty.Text + "','" + txt_i_t_amt.Text + "','" + cmb_i_month.Text + "','Purchase')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Has Been Added");
            con.Close();
           

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            string query = "Update PURCHASE_SALE_INFO set [B_ID]='" + txt_B_ID.Text + "',[I_Name]='" + txt_i_name.Text + "',[Price]='" + txt_i_price.Text + "',[Quantity]='" + txt_i_qty.Text + "',[T_Amount]='" + txt_i_t_amt.Text + "',[Month]='" + cmb_i_month.Text + "',[Type]='Purchase' where [I_ID]='" + txt_I_id.Text + "'";
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
            cmd.CommandText = "Delete from PURCHASE_SALE_INFO where [I_ID]='" + txt_I_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Has Been Deleted");
            con.Close();
            txt_B_ID.Text = "";
            txt_I_id.Text = "";
            txt_i_name.Text = "";
            txt_i_price.Text = "";
            txt_i_qty.Text = "";
            txt_i_t_amt.Text = "";
            txt_search.Text = "Prisoner ID";
            txt_search.ForeColor = Color.Gray;
            cmb_i_month.SelectedIndex = 0;
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

            e.Graphics.DrawString("Purchase Information", new Font("Arial", 32), Brushes.Black, new Point(25, 290));


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
            e.Graphics.DrawString(cmb_i_month.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 310));
            e.Graphics.DrawString(txt_i_t_amt.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 360));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 75));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 125));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 175));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 225));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 275));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 325));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 375));
           
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
