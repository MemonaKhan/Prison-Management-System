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
    public partial class frm_Fdbk_mpl : Form
    {
        OleDbConnection con = new OleDbConnection();
        string u;
        

        public frm_Fdbk_mpl(string user)
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2nd semester\OOPs\Prison_Project_Data\PrisonMS.accdb;
Persist Security Info=False;";
            u = user;
           
        }

        int obd;
        int ctw;
        int intg;
        int intv;
        int tw;
        int wpd;
        int em;

        private void frm_Fdbk_mpl_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\2nd semester\OOPs\Prison_Project_Data\backgrond\30.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch;

            txt_b_id.Text = "";
            txt_comment.Text = "";
            txt_fdbk_id.Text = "";
            txt_U_id.Text = "";
            txt_p_id.Text = "";
            dtp_dofdbk.CustomFormat = " ";
            obd = 0; ctw = 0; intg = 0; intv = 0; tw = 0; wpd = 0; em = 0;
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

        private void btn_fdbk_dsp_Click(object sender, EventArgs e)
        {
            frm_Fdbk_dsp f1 = new frm_Fdbk_dsp(u);
            f1.Show();
            this.Hide();
        }

        private void dtp_dofdbk_ValueChanged(object sender, EventArgs e)
        {
            dtp_dofdbk.CustomFormat = "MM/dd/yyyy";
        }

        private void dtp_dofdbk_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode==Keys.Back)||(e.KeyCode==Keys.Delete))
                dtp_dofdbk.CustomFormat= " ";
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_b_id.Text = "";
            txt_comment.Text = "";
            txt_fdbk_id.Text = "";
            txt_U_id.Text = "";
            txt_p_id.Text = "";
            dtp_dofdbk.CustomFormat = " ";
            obd = 0; ctw = 0; intg = 0; intv = 0; tw = 0; wpd = 0; em = 0;
            obd1.Checked = false; obd2.Checked = false; obd3.Checked = false; obd4.Checked = false; obd5.Checked = false;
            ctw1.Checked = false; ctw2.Checked = false; ctw3.Checked = false; ctw4.Checked = false; ctw5.Checked = false;
            intg1.Checked = false; intg2.Checked = false; intg3.Checked = false; intg4.Checked = false; intg5.Checked = false;
            intv1.Checked = false; intv2.Checked = false; intv3.Checked = false; intv4.Checked = false; intv5.Checked = false;
            tw1.Checked = false; tw2.Checked = false; tw3.Checked = false; tw4.Checked = false; tw5.Checked = false;
            wpd1.Checked = false; wpd2.Checked = false; wpd3.Checked = false; wpd4.Checked = false; wpd5.Checked = false;
            em1.Checked = false; em2.Checked = false; em3.Checked = false; em4.Checked = false; em5.Checked = false;
        }

        private void obd1_CheckedChanged(object sender, EventArgs e)
        {
            obd = 1;
        }

        private void obd2_CheckedChanged(object sender, EventArgs e)
        {
            obd = 2;
        }

        private void obd3_CheckedChanged(object sender, EventArgs e)
        {
            obd = 3;
        }

        private void obd4_CheckedChanged(object sender, EventArgs e)
        {
            obd = 4;
        }

        private void obd5_CheckedChanged(object sender, EventArgs e)
        {
            obd = 5;
        }

        private void ctw1_CheckedChanged(object sender, EventArgs e)
        {
            ctw = 1;
        }

        private void ctw2_CheckedChanged(object sender, EventArgs e)
        {
            ctw = 2;
        }

        private void ctw3_CheckedChanged(object sender, EventArgs e)
        {
            ctw = 3;
        }

        private void ctw4_CheckedChanged(object sender, EventArgs e)
        {
            ctw = 4;
        }

        private void ctw5_CheckedChanged(object sender, EventArgs e)
        {
            ctw = 5;
        }

        private void intg1_CheckedChanged(object sender, EventArgs e)
        {
            intg = 1;
        }

        private void intg2_CheckedChanged(object sender, EventArgs e)
        {
            intg = 2;
        }

        private void intg3_CheckedChanged(object sender, EventArgs e)
        {
            intg = 3;
        }

        private void intg4_CheckedChanged(object sender, EventArgs e)
        {
            intg = 4;
        }

        private void intg5_CheckedChanged(object sender, EventArgs e)
        {
            intg = 5;
        }

        private void intv1_CheckedChanged(object sender, EventArgs e)
        {
            intv = 1;
        }

        private void intv2_CheckedChanged(object sender, EventArgs e)
        {
            intv = 2;
        }

        private void intv3_CheckedChanged(object sender, EventArgs e)
        {
            intv = 3;
        }

        private void intv4_CheckedChanged(object sender, EventArgs e)
        {
            intv = 4;
        }

        private void intv5_CheckedChanged(object sender, EventArgs e)
        {
            intv = 5;
        }

        private void tw1_CheckedChanged(object sender, EventArgs e)
        {
            tw = 1;
        }

        private void tw2_CheckedChanged(object sender, EventArgs e)
        {
            tw = 2;
        }

        private void tw3_CheckedChanged(object sender, EventArgs e)
        {
            tw = 3;
        }

        private void tw4_CheckedChanged(object sender, EventArgs e)
        {
            tw = 4;
        }

        private void tw5_CheckedChanged(object sender, EventArgs e)
        {
            tw = 5;
        }

        private void wpd1_CheckedChanged(object sender, EventArgs e)
        {
            wpd = 1;
        }

        private void wpd2_CheckedChanged(object sender, EventArgs e)
        {
            wpd = 2;
        }

        private void wpd3_CheckedChanged(object sender, EventArgs e)
        {
            wpd = 3;
        }

        private void wpd4_CheckedChanged(object sender, EventArgs e)
        {
            wpd = 4;
        }

        private void wpd5_CheckedChanged(object sender, EventArgs e)
        {
            wpd = 5;
        }

        private void em1_CheckedChanged(object sender, EventArgs e)
        {
            em = 1;
        }

        private void em2_CheckedChanged(object sender, EventArgs e)
        {
            em = 2;
        }

        private void em3_CheckedChanged(object sender, EventArgs e)
        {
            em = 3;
        }

        private void em4_CheckedChanged(object sender, EventArgs e)
        {
            em = 4;
        }

        private void em5_CheckedChanged(object sender, EventArgs e)
        {
            em = 5;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into FEEDBACK (FB_ID, DOF, P_ID, B_ID, U_ID, CMT, OBD, CAP_Work, INTG, INTV, TM_Work, WPD, EM) values ('" + txt_fdbk_id.Text + "','" + dtp_dofdbk.Text + "','" + txt_p_id.Text + "','" + txt_b_id.Text + "','"+txt_U_id.Text+"','"+txt_comment.Text+"','"+obd+"','"+ctw+"','"+intg+"','"+intv+"','"+tw+"','"+wpd+"','"+em+"')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("FeedBack Has Been Saved");
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

            e.Graphics.DrawString("FEEDBACK Information", new Font("Arial", 32), Brushes.Black, new Point(25, 290));


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
            e.Graphics.DrawString(label12.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 610));
            e.Graphics.DrawString(label13.Text, new Font("Arial", 14), Brushes.Black, new Point(30, y + 660));

            e.Graphics.DrawString(txt_fdbk_id.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 60));
            e.Graphics.DrawString(dtp_dofdbk.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 110));
            e.Graphics.DrawString(txt_p_id.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 160));
            e.Graphics.DrawString(txt_b_id.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 210));
            e.Graphics.DrawString(txt_U_id.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 260));
            e.Graphics.DrawString(txt_comment.Text, new Font("Arial", 14), Brushes.Black, new Point(330, y + 310));
            e.Graphics.DrawString(obd.ToString(), new Font("Arial", 14), Brushes.Black, new Point(330, y + 360));
            e.Graphics.DrawString(ctw.ToString(), new Font("Arial", 14), Brushes.Black, new Point(330, y + 410));
            e.Graphics.DrawString(intg.ToString(), new Font("Arial", 14), Brushes.Black, new Point(330, y + 460));
            e.Graphics.DrawString(intv.ToString(), new Font("Arial", 14), Brushes.Black, new Point(330, y + 510));
            e.Graphics.DrawString(tw.ToString(), new Font("Arial", 14), Brushes.Black, new Point(330, y + 560));
            e.Graphics.DrawString(wpd.ToString(), new Font("Arial", 14), Brushes.Black, new Point(330, y + 610));
            e.Graphics.DrawString(em.ToString(), new Font("Arial", 14), Brushes.Black, new Point(330, y + 660));

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
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 625));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14), Brushes.Black, new Point(0, y + 675));

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
