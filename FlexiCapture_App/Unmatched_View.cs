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
    public partial class Unmatched_View : Form
    {
        public Unmatched_View()
        {
            InitializeComponent();
        }

        private void Unmatched_View_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\System_db.accdb; Persist Security Info=False;");
                con.Open();
                string cmd = "SELECT * FROM Unmatched_Trans";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    Unmatched_Trans.Items.Clear();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            ListViewItem aa = new ListViewItem(rdr.GetValue(0).ToString());
                            aa.SubItems.Add(DateTime.Parse(rdr.GetValue(1).ToString()).ToString("MM/dd/yyyy"));
                            aa.SubItems.Add(rdr.GetValue(2).ToString());
                            aa.SubItems.Add(rdr.GetValue(3).ToString());
                            aa.SubItems.Add(String.Format("{0:n}", Double.Parse(rdr.GetValue(4).ToString())));
                            Unmatched_Trans.Items.Add(aa);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
