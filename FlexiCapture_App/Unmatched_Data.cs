using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FlexiCapture_App
{
    public partial class Unmatched_Data : Form
    {
        public Unmatched_Data()
        {
            InitializeComponent();
        }

        private void Unmatched_Data_Load(object sender, EventArgs e)
        {
           
        }
        private void scanned_force_match(int icbs_id)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\TVVS.accdb; Persist Security Info=False;");
                con.Open();
                string cmd = "update scanned_trans set match_code='F', match_ref = " + icbs_id + " where acct_num=" + txt_scan_acct_num.Text + "";
                OleDbCommand command = new OleDbCommand(cmd, con);
                OleDbDataReader rdr = command.ExecuteReader();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void icbs_force_match(int scan_id)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\TVVS.accdb; Persist Security Info=False;");
                con.Open();
                string cmd = "update icbs_trans set match_code='F', match_ref = " + scan_id + " where acct_num=" + txt_icbs_acct_num.Text + "";
                OleDbCommand command = new OleDbCommand(cmd, con);
                OleDbDataReader rdr = command.ExecuteReader();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private static int get_id(string acct_num, string table_name)
        {
            int var_id = 0;
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\TVVS.accdb; Persist Security Info=False;");
                con.Open();
                string cmd = "SELECT * FROM "+ table_name +" where acct_num = "+ acct_num +"";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            var_id = Convert.ToInt32(rdr.GetValue(0).ToString());
                        }
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return var_id;
        }
        private void btn_force_match_Click(object sender, EventArgs e)
        {
            string acct_scan_num = txt_scan_acct_num.Text;
            string acct_icbs_num = txt_icbs_acct_num.Text;
            int scan_id = get_id(acct_scan_num, "scanned_trans");
            int icbs_id = get_id(acct_icbs_num, "icbs_trans");
            Unmatched_View uv = new Unmatched_View();
            uv.Hide();
            scanned_force_match(icbs_id);
            icbs_force_match(scan_id);
            MessageBox.Show("Force Match Successful", "Information", MessageBoxButtons.OK ,MessageBoxIcon.Information);
            uv.Unmatched_Icbs_Records.Update();
            uv.Show();
            this.Hide();
            
        }
    }
}
