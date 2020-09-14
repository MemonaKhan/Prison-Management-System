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
    public partial class frm_work_info_mpl : Form
    {
        OleDbConnection con = new OleDbConnection();
        string u;
        public frm_work_info_mpl(string user)
        {

            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;";
            u = user;
           
        }

        private void frm_work_info_mpl_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\48.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch; 
            
            cmb_W_type.Items.AddRange(new object[]{"","Individual","Group"});

            txt_search.Text = "Work ID";
            txt_search.ForeColor = Color.Gray;
            txt_W_desc.Text = "";
            txt_W_id.Text = "";
            txt_W_name.Text = "";
            cmb_W_type.SelectedIndex = 0;
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

        private void btn_W_info_dsp_Click(object sender, EventArgs e)
        {
            frm_work_info_dsp f1 = new frm_work_info_dsp(u, false);
            f1.Show();
            this.Hide();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_search.Text = "Work ID";
            txt_search.ForeColor = Color.Gray;
            txt_W_desc.Text = "";
            txt_W_id.Text = "";
            txt_W_name.Text = "";
            cmb_W_type.SelectedIndex = 0;
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
            cmd.CommandText = "Select * from WORK_INFO where W_ID='" + text + "'";
            OleDbDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                txt_W_id.Text = read["W_ID"].ToString();
                txt_W_name.Text = read["W_Name"].ToString();
                cmb_W_type.Text = read["W_Type"].ToString();
                txt_W_desc.Text = read["DESC"].ToString();
            }
            con.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into WORK_INFO ([W_ID], [W_Name], [W_Type], [DESC]) values ('" + txt_W_id.Text + "','" + txt_W_name.Text + "','" + cmb_W_type.Text + "','" + txt_W_desc.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Has Been Added");
            con.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update WORK_INFO set [W_Name]='" + txt_W_name.Text + "', [W_Type]='" + cmb_W_type.Text + "', [DESC]='" + txt_W_desc.Text + "' where ([W_ID]='" + txt_W_id.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Has Been Updated");
            con.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete from WORK_INFO where ([W_ID]='" + txt_W_id.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Has Been Deleted");
            con.Close();
            txt_search.Text = "Work ID";
            txt_search.ForeColor = Color.Gray;
            txt_W_desc.Text = "";
            txt_W_id.Text = "";
            txt_W_name.Text = "";
            cmb_W_type.SelectedIndex = 0;
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

            e.Graphics.DrawString("Work Information", new Font("Arial", 32), Brushes.Black, new Point(25, 290));


            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 40));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Cyan, new Point(0, y += 10));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y += 10));

            e.Graphics.DrawString(label1.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 60));
            e.Graphics.DrawString(label2.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 110));
            e.Graphics.DrawString(label3.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 160));
            e.Graphics.DrawString(label4.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 210));

            e.Graphics.DrawString(txt_W_id.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 60));
            e.Graphics.DrawString(txt_W_name.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 110));
            e.Graphics.DrawString(cmb_W_type.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 160));
            e.Graphics.DrawString(txt_W_desc.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 210));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 75));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 125));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 175));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 225));
         
        }


        private void btn_preview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = recordDocument;
            printPreviewDialog.Show();
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
