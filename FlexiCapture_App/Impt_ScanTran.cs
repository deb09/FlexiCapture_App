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
using System.Threading;

namespace FlexiCapture_App
{
    public partial class Impt_ScanTran : Form
    {
        public Impt_ScanTran()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        

        private void Impt_ScanTran_Load(object sender, EventArgs e)
        {
           
        }

        private void import_from_flexiCapture()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\D\Desktop\System_db.accdb; Persist Security Info=False;");
                con.Open();
              
                string query = "SELECT * INTO [Scanned_Trans] FROM [" + tb_table_name.Text + "] IN '" + tb_data_source.Text + "'";
                using (OleDbCommand sqlCeCommand = new OleDbCommand(query, con))
                {
                    sqlCeCommand.ExecuteNonQuery();
                    MessageBox.Show("Import Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void openfile_browse_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            import_from_flexiCapture();
        }

        private void btn_browse_Click(object sender, EventArgs e)
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
                tb_data_source.Text = openfile_browse_icbs.FileName;
            }
        }
    }
}
