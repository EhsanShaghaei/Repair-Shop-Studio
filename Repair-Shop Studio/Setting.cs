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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void btn_DeviceBrands_Click(object sender, EventArgs e)
        {
            BrandAccess brandaccess = new BrandAccess();
            brandaccess.ShowDialog();
        }

        private void btn_locations_Click(object sender, EventArgs e)
        {
            LocationAccess locationAccess = new LocationAccess();
            locationAccess.ShowDialog();
        }

        private void btn_models_Click(object sender, EventArgs e)
        {
            Models_Access model_access = new Models_Access();
            model_access.ShowDialog();
        }
    }
}
