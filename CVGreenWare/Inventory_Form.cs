using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVGreenWare
{
    public partial class Inventory_Form : Form
    {
        public Inventory_Form()
        {
            InitializeComponent();
        }

        private void tblInventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblInventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.warehouseDatabaseDataSet);

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouseDatabaseDataSet.tblInventory' table. You can move, or remove it, as needed.
            this.tblInventoryTableAdapter.Fill(this.warehouseDatabaseDataSet.tblInventory);

        }
    }
}
