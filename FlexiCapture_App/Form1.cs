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
using System.Configuration;

namespace FlexiCapture_App
{

    public partial class Customer_Information : Form
    {

        public Customer_Information()
        {
            InitializeComponent();
            
            this.CenterToScreen();
           
            pnl_config.Hide();
            pnl_info.Hide();
            pnl_main.Show();

           
        }

        private void import_from_flexiCapture()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\D\Desktop\System_db.accdb; Persist Security Info=False;");
                con.Open();
                /** string cmd = "INSERT INTO[Scanned_Trans] SELECT* FROM[MS Access; DATABASE =" + tb_data_source.Text + "].[" + tb_table_name.Text + "]";
                 {
                     OleDbCommand command = new OleDbCommand(cmd, con);
                     OleDbDataReader rdr = command.ExecuteReader();
                     MessageBox.Show("Imported");
                 }**/

                string query = "SELECT * INTO [Scanned_Trans] FROM ["+ tb_table_name.Text +"] IN '" + tb_data_source.Text + "'";
                using (OleDbCommand sqlCeCommand = new OleDbCommand(query, con))
                {
                    sqlCeCommand.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void import_from_icbs()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\D\Desktop\System_db.accdb; Persist Security Info=False;");
                con.Open();
                /** string cmd = "INSERT INTO[Scanned_Trans] SELECT* FROM[MS Access; DATABASE =" + tb_data_source.Text + "].[" + tb_table_name.Text + "]";
                 {
                     OleDbCommand command = new OleDbCommand(cmd, con);
                     OleDbDataReader rdr = command.ExecuteReader();
                     MessageBox.Show("Imported");
                 }**/

                string query = "SELECT * INTO [ICBS_Trans] FROM [" + tb_table_name_icbs.Text + "] IN '" + tb_data_source_icbs.Text + "'";
                using (OleDbCommand sqlCeCommand = new OleDbCommand(query, con))
                {
                    sqlCeCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void load_data()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + tb_data_source.Text + "; Persist Security Info=False;");
                con.Open();
                string cmd = "SELECT * FROM [" + tb_table_name.Text + "]";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    lv_data.Items.Clear();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            ListViewItem aa = new ListViewItem(rdr.GetValue(0).ToString());
                            aa.SubItems.Add(DateTime.Parse(rdr.GetValue(1).ToString()).ToString("MM/dd/yyyy"));
                            aa.SubItems.Add(rdr.GetValue(2).ToString());
                            aa.SubItems.Add(rdr.GetValue(3).ToString());
                            aa.SubItems.Add(String.Format("{0:n}", Double.Parse(rdr.GetValue(4).ToString())));
                            lv_data.Items.Add(aa);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void load_icbs()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + tb_data_source_icbs.Text + "; Persist Security Info=False;");
                con.Open();
                string cmd = "SELECT * FROM [" + tb_table_name_icbs.Text + "]";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    lv_icbs.Items.Clear();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            ListViewItem aa = new ListViewItem(rdr.GetValue(0).ToString());
                            aa.SubItems.Add(DateTime.Parse(rdr.GetValue(1).ToString()).ToString("MM/dd/yyyy"));
                            aa.SubItems.Add(rdr.GetValue(2).ToString());
                            aa.SubItems.Add(rdr.GetValue(3).ToString());
                            aa.SubItems.Add(String.Format("{0:n}", Double.Parse(rdr.GetValue(4).ToString())));
                            lv_icbs.Items.Add(aa);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void btn_ok_Click(object sender, EventArgs e)
        {

            pnl_main.Show();
            pnl_config.Hide();
            import_from_flexiCapture();
            load_data();
        }



        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile_browse = new OpenFileDialog();

            openfile_browse.InitialDirectory = @"C:\";
            openfile_browse.Title = "Browse Database";

            openfile_browse.CheckFileExists = true;
            openfile_browse.CheckPathExists = true;

            openfile_browse.DefaultExt = "accdb";
            openfile_browse.Filter = "Access files (*.accdb)|*.accdb";
            openfile_browse.FilterIndex = 2;
            openfile_browse.RestoreDirectory = true;


            openfile_browse.ReadOnlyChecked = true;
            openfile_browse.ShowReadOnly = true;


            if (openfile_browse.ShowDialog() == DialogResult.OK)

            {
                tb_data_source.Text = openfile_browse.FileName;
            }
        }

        private void Setup_ScanFiles_Click(object sender, EventArgs e)
        {
            pnl_main.Hide();
            pnl_config.Show();

        }


        private void btn_load_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void pnl_info_Paint(object sender, PaintEventArgs e)
        {
            
            if (lv_data.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = lv_data.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                tb_acc_name.Text = lv_data.SelectedItems[0].SubItems[2].Text;
                tb_acc_num.Text = lv_data.SelectedItems[0].SubItems[3].Text;
                tb_transac_date.Text = lv_data.SelectedItems[0].SubItems[1].Text;
                tb_amt.Text = String.Format("{0:n}", Double.Parse(lv_data.SelectedItems[0].SubItems[4].Text));
            }
            
        }

        private void lv_data_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pnl_info.Show();
            
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            pnl_info.Hide();
        }

        private void iCDBSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_icbs.Hide();
            pnl_config_icbs.Show();
        }

        private void btn_browse_icbs_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile_browse_icbs = new OpenFileDialog();

            openfile_browse_icbs.InitialDirectory = @"C:\";
            openfile_browse_icbs.Title = "Browse Database";

            openfile_browse_icbs.CheckFileExists = true;
            openfile_browse_icbs.CheckPathExists = true;

            openfile_browse_icbs.DefaultExt = "accdb";
            openfile_browse_icbs.Filter = "Access files (*.accdb)|*.accdb";
            openfile_browse_icbs.FilterIndex = 2;
            openfile_browse_icbs.RestoreDirectory = true;


            openfile_browse_icbs.ReadOnlyChecked = true;
            openfile_browse_icbs.ShowReadOnly = true;


            if (openfile_browse_icbs.ShowDialog() == DialogResult.OK)

            {
                tb_data_source_icbs.Text = openfile_browse_icbs.FileName;
            }
        }

        private void btn_ok_icbs_Click(object sender, EventArgs e)
        {
            import_from_icbs();
            load_icbs();
            pnl_config_icbs.Hide();
            pnl_icbs.Show();
        }

        private void lv_icbs_DoubleClick(object sender, EventArgs e)
        {
            pnl_info_icbs.Show();
        }

        private void pnl_info_icbs_Paint(object sender, PaintEventArgs e)
        {
            if (lv_icbs.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = lv_icbs.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                tb_acc_name_icbs.Text = lv_icbs.SelectedItems[0].SubItems[2].Text;
                tb_acc_num_icbs.Text = lv_icbs.SelectedItems[0].SubItems[3].Text;
                tb_transac_date_icbs.Text = lv_icbs.SelectedItems[0].SubItems[1].Text;
                tb_amt_icbs.Text = String.Format("{0:n}", Double.Parse(lv_icbs.SelectedItems[0].SubItems[4].Text));
            }
        }

        private void btn_exit_icbs_Click(object sender, EventArgs e)
        {
            pnl_info_icbs.Hide();
        }

        private void matchedTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lv_data_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
