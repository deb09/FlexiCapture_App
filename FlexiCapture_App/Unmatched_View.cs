using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexiCapture_App
{
    public partial class Unmatched_View : Form
    {
        public Unmatched_View()
        {
            InitializeComponent();
        }

        private void Unmatched_Icbs_Records_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Unmatched_Trans_Records_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Unmatched_Data ud = new Unmatched_Data();
            ud.Show();
        }
    }
}
