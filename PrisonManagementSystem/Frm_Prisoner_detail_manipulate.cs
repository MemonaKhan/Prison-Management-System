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
    public partial class frm_prs_dtl_mpl : Form
    {
        OleDbConnection con = new OleDbConnection();
        string u;
        public frm_prs_dtl_mpl(string user)
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;";
            u = user;
           
        }

        private void frm_prs_dtl_mpl_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\35.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch; 

            cmb_prs_status.Items.AddRange(new object[] { "", "Convicted", "Under Trial" });
            cmb_prs_court.Items.AddRange(new object[] { "", "District & session Hyderabad", "District & session Larkana",
            "District & session Sakkar","District & session Karachi","District & session Khairpur","District & session Shikarpur"});

            txt_search.Text = "Prisoner ID";
            txt_search.ForeColor = Color.Gray;
            txt_B_id.Text = "";
            txt_P_id.Text = "";
            txt_prs_fir.Text = "";
            txt_prs_us.Text = "";
            txt_prs_crime.Text = "";
            dtp_prs_doa.CustomFormat = " ";
            dtp_prs_doi.CustomFormat = " ";
            dtp_prs_dop.CustomFormat = " ";
            dtp_prs_dor.CustomFormat = " ";
            cmb_prs_court.SelectedIndex = 0;
            cmb_prs_status.SelectedIndex = 0;

            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (u == "admin")
            {
                frm_Prs_info_Blk f1 = new frm_Prs_info_Blk("admin");
                f1.Show();
                this.Hide();
            }
            else if (u == "supervisor")
            {
                frm_Prs_info_Blk f1 = new frm_Prs_info_Blk("supervisor");
                f1.Show();
                this.Hide();
            }
            else
            {
                if (u == "guard")
                {
                    frm_Prs_info_Blk f1 = new frm_Prs_info_Blk("guard");
                    f1.Show();
                    this.Hide();
                }
            }
        }

        private void btn_prs_dtl_dsp_Click(object sender, EventArgs e)
        {
            frm_prs_dtl_dsp f1 = new frm_prs_dtl_dsp(u,false);
            f1.Show();
            this.Hide();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            txt_search.ForeColor = Color.Gray;
            txt_B_id.Text = "";
            txt_P_id.Text = "";
            txt_prs_fir.Text = "";
            txt_prs_us.Text = "";
            txt_prs_crime.Text = "";
            dtp_prs_doa.CustomFormat = " ";
            dtp_prs_doi.CustomFormat = " ";
            dtp_prs_dop.CustomFormat = " ";
            dtp_prs_dor.CustomFormat = " ";
            cmb_prs_court.SelectedIndex = 0;
            cmb_prs_status.SelectedIndex = 0;
        }

        private void dtp_prs_doa_ValueChanged(object sender, EventArgs e)
        {
            dtp_prs_doa.CustomFormat = "MM/dd/yyyy";
        }

        private void dtp_prs_dop_ValueChanged(object sender, EventArgs e)
        {
            dtp_prs_dop.CustomFormat = "MM/dd/yyyy";
        }

        private void dtp_prs_doi_ValueChanged(object sender, EventArgs e)
        {
            dtp_prs_doi.CustomFormat = "MM/dd/yyyy";
        }

        private void dtp_prs_dor_ValueChanged(object sender, EventArgs e)
        {
            dtp_prs_dor.CustomFormat = "MM/dd/yyyy";
        }

        private void dtp_prs_doa_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
                dtp_prs_doa.CustomFormat = " ";
        }

        private void dtp_prs_dop_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
                dtp_prs_dop.CustomFormat = " ";
        }

        private void dtp_prs_doi_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
                dtp_prs_doi.CustomFormat = " ";
        }

        private void dtp_prs_dor_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
                dtp_prs_dor.CustomFormat = " ";
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
                dtp_prs_doa.CustomFormat = "MM/dd/yyyy";

                txt_P_id.Text = read["P_ID"].ToString();
                txt_B_id.Text = read["B_ID"].ToString();
                cmb_prs_status.Text = read["P_Status"].ToString();
                dtp_prs_doa.Text = read["P_DOA"].ToString();
                txt_prs_fir.Text = read["P_FIR"].ToString();
                txt_prs_crime.Text = read["P_Crime"].ToString();
                txt_prs_us.Text = read["P_US"].ToString();
                if (read["P_DOP"].ToString() != "")
                {
                    dtp_prs_dop.CustomFormat = "MM/dd/yyyy";
                    dtp_prs_dop.Text = read["P_DOP"].ToString();
                }
                if (read["P_DOI"].ToString() != "")
                {
                    dtp_prs_doi.CustomFormat = "MM/dd/yyyy";
                    dtp_prs_doi.Text = read["P_DOI"].ToString();
                }
                if (read["P_DOR"].ToString() != "")
                {
                    dtp_prs_dor.CustomFormat = "MM/dd/yyyy";
                    dtp_prs_dor.Text = read["P_DOR"].ToString();
                }
                cmb_prs_court.Text = read["P_Court"].ToString();
                
            }
            con.Close();
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            txt_search.ForeColor = Color.Black;
        }
        double prsno;
        private void btn_add_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            if (cmb_prs_status.Text=="Convicted")
                cmd.CommandText = "Insert into PRISONER_DETAILS (P_ID,B_ID,P_Status,P_DOA,P_FIR,P_Crime,P_US,P_DOI,P_DOR,P_Court) values ('" + txt_P_id.Text + "','" + txt_B_id.Text + "','" + cmb_prs_status.Text + "','" + dtp_prs_doa.Text + "','" + txt_prs_fir.Text + "','" + txt_prs_crime.Text + "','" + txt_prs_us.Text + "','" + dtp_prs_doi.Text + "','" + dtp_prs_dor.Text + "','" + cmb_prs_court.Text + "')";
            
            if(cmb_prs_status.Text=="Under Trial")
                cmd.CommandText = "Insert into PRISONER_DETAILS (P_ID,B_ID,P_Status,P_DOA,P_FIR,P_Crime,P_US,P_DOP,P_Court) values ('" + txt_P_id.Text + "','" + txt_B_id.Text + "','" + cmb_prs_status.Text + "','" + dtp_prs_doa.Text + "','" + txt_prs_fir.Text + "','" + txt_prs_crime.Text + "','" + txt_prs_us.Text + "','" + dtp_prs_dop.Text + "','" + cmb_prs_court.Text + "')";
            
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            cmd.CommandText = "Select No_PR from BLOCK_INFO where B_ID='" + txt_B_id.Text + "'";
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                prsno = double.Parse(read["No_PR"].ToString());
                prsno++;
            }
            con.Close();

            con.Open();
            cmd.CommandText = "Update BLOCK_INFO set No_PR ='" + prsno + "' where B_ID='" + txt_B_id.Text + "'";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Has Been Added");

            con.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            if (cmb_prs_status.Text == "Convicted")
                cmd.CommandText = "Update PRISONER_DETAILS set B_ID='" + txt_B_id.Text + "',P_Status='" + cmb_prs_status.Text + "',P_DOA='" + dtp_prs_doa.Text + "',P_FIR='" + txt_prs_fir.Text + "',P_Crime='" + txt_prs_crime.Text + "',P_US='" + txt_prs_us.Text + "',P_DOI='" + dtp_prs_doi.Text + "',P_DOR='" + dtp_prs_dor.Text + "',P_Court='" + cmb_prs_court.Text + "' where P_ID='" + txt_P_id.Text + "'";

            if (cmb_prs_status.Text == "Under Trial")
                cmd.CommandText = "Update PRISONER_DETAILS set B_ID='" + txt_B_id.Text + "',P_Status='" + cmb_prs_status.Text + "',P_DOA='" + dtp_prs_doa.Text + "',P_FIR='" + txt_prs_fir.Text + "',P_Crime='" + txt_prs_crime.Text + "',P_US='" + txt_prs_us.Text + "',P_DOP='" + dtp_prs_dop.Text + "',P_Court='" + cmb_prs_court.Text + "' where P_ID='" + txt_P_id.Text + "'";
            
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Has Been Updated");
            con.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete from PRISONER_DETAILS where P_ID='" + txt_P_id.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            cmd.CommandText = "Select No_PR from BLOCK_INFO where B_ID='" + txt_B_id.Text + "'";
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                prsno = double.Parse(read["No_PR"].ToString());
                prsno--;
            }
            con.Close();

            con.Open();
            cmd.CommandText = "Update BLOCK_INFO set No_PR ='" + prsno + "' where B_ID='" + txt_B_id.Text + "'";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Has Been Deleted");
            con.Close();
            txt_search.Text = "";
            txt_search.ForeColor = Color.Gray;
            txt_B_id.Text = "";
            txt_P_id.Text = "";
            txt_prs_fir.Text = "";
            txt_prs_us.Text = "";
            txt_prs_crime.Text = "";
            dtp_prs_doa.CustomFormat = " ";
            dtp_prs_doi.CustomFormat = " ";
            dtp_prs_dop.CustomFormat = " ";
            dtp_prs_dor.CustomFormat = " ";
            cmb_prs_court.SelectedIndex = 0;
            cmb_prs_status.SelectedIndex = 0;

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
            e.Graphics.DrawString(cmb_prs_status.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 160));
            e.Graphics.DrawString(dtp_prs_doa.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 210));
            e.Graphics.DrawString(txt_prs_fir.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 260));
            e.Graphics.DrawString(txt_prs_crime.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 310));
            e.Graphics.DrawString(txt_prs_us.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 360));
            e.Graphics.DrawString(dtp_prs_dop.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 410));
            e.Graphics.DrawString(cmb_prs_court.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 460));
            e.Graphics.DrawString(dtp_prs_doi.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 510));
            e.Graphics.DrawString(dtp_prs_dor.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 560));


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
