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
    public partial class Models_Access : Form
    {
        public Models_Access()
        {
            InitializeComponent();
        }

        private void typesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBRepairShopDataSet);

        }

        private void Models_Access_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBRepairShopDataSet.Types' table. You can move, or remove it, as needed.
            this.typesTableAdapter.Fill(this.dBRepairShopDataSet.Types);

        }
    }
}
