using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexiCapture_App
{
    public partial class ScanForm : Form
    {
        public ScanForm()
        {
            InitializeComponent();
            
        }

        private void load_progressbar()
        {
            progress_Bar.Minimum = 0;
            progress_Bar.Maximum = 100;
            for(int i=0;i<100;i++)
            {
                progress_Bar.Value = i;
                Thread.Sleep(20);
            }
        }

        private void ScanForm_Load(object sender, EventArgs e)
        {
            load_progressbar();
        }
    }
}
