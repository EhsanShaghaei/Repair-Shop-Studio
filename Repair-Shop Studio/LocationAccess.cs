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
    public partial class LocationAccess : Form
    {
        public LocationAccess()
        {
            InitializeComponent();
        }

        private void locationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.locationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBRepairShopDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBRepairShopDataSet.Locations' table. You can move, or remove it, as needed.
            this.locationsTableAdapter.Fill(this.dBRepairShopDataSet.Locations);

        }
    }
}
