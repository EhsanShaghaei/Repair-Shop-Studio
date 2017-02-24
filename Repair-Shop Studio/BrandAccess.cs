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
    public partial class BrandAccess : Form
    {
        public BrandAccess()
        {
            InitializeComponent();
        }

        private void brandsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.brandsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBRepairShopDataSet);

        }

        private void BrandAccess_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBRepairShopDataSet.Brands' table. You can move, or remove it, as needed.
            this.brandsTableAdapter.Fill(this.dBRepairShopDataSet.Brands);

        }
    }
}
