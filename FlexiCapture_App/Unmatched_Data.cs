using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        private void unmatched_icbs_data()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\System_db.accdb; Persist Security Info=False;");
                con.Open();
                string cmd = "SELECT Unmatched_Icbs.ID, Unmatched_Icbs.Date, Unmatched_Icbs.acct_name, Unmatched_Icbs.acct_num, Unmatched_Icbs.amount FROM Unmatched_Icbs INNER JOIN Unmatched_Trans ON(Unmatched_Icbs.amount = Unmatched_Trans.amount) AND(Unmatched_Icbs.acct_num = Unmatched_Trans.acct_num) AND(Unmatched_Icbs.Date = Unmatched_Trans.Date) AND(Unmatched_Icbs.acct_name = Unmatched_Trans.acct_name)";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    Unmatched_Icbs_Records.Items.Clear();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            ListViewItem aa = new ListViewItem(rdr.GetValue(0).ToString());
                            aa.SubItems.Add(DateTime.Parse(rdr.GetValue(1).ToString()).ToString("MM/dd/yyyy"));
                            aa.SubItems.Add(rdr.GetValue(2).ToString());
                            aa.SubItems.Add(rdr.GetValue(3).ToString());
                            aa.SubItems.Add(String.Format("{0:n}", Double.Parse(rdr.GetValue(4).ToString())));
                            Unmatched_Icbs_Records.Items.Add(aa);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void unmatched_trans_data()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\System_db.accdb; Persist Security Info=False;");
                con.Open();
                string cmd = "SELECT Unmatched_Trans.ID, Unmatched_Trans.Date, Unmatched_Trans.acct_name, Unmatched_Trans.acct_num, Unmatched_Trans.amount FROM Unmatched_Icbs INNER JOIN Unmatched_Trans ON(Unmatched_Icbs.amount = Unmatched_Trans.amount) AND(Unmatched_Icbs.acct_num = Unmatched_Trans.acct_num) AND(Unmatched_Icbs.Date = Unmatched_Trans.Date) AND(Unmatched_Icbs.acct_name = Unmatched_Trans.acct_name)";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    Unmatched_Trans_Records.Items.Clear();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            ListViewItem aa = new ListViewItem(rdr.GetValue(0).ToString());
                            aa.SubItems.Add(DateTime.Parse(rdr.GetValue(1).ToString()).ToString("MM/dd/yyyy"));
                            aa.SubItems.Add(rdr.GetValue(2).ToString());
                            aa.SubItems.Add(rdr.GetValue(3).ToString());
                            aa.SubItems.Add(String.Format("{0:n}", Double.Parse(rdr.GetValue(4).ToString())));
                            Unmatched_Trans_Records.Items.Add(aa);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //unmatched_trans_data();
            //unmatched_icbs_data();

        }
    }
}
