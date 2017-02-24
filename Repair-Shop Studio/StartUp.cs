using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repair_Shop_Studio
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void StartUp_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (progressBar1.Value ==50)
            {

            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Close();
                return;
            }
            progressBar1.Value++;
            label1.Text = "loading...  %"+progressBar1.Value.ToString();
        }
    }
}
