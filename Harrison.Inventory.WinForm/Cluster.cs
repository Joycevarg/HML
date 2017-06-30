using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Harrison.Inventory.WinForm
{
    public partial class clusterMaster : Form
    {
        public clusterMaster()
        {
            InitializeComponent();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
