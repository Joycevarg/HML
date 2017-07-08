using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Harrison.Inventory.Presenter;

namespace Harrison.Inventory.WinForm
{
    public partial class GridForm : Form
    {
        public GridForm(DataTable vendors)
        {
            InitializeComponent();
            grid.DataSource = vendors;
        }
       

        private void GridForm_Load(object sender, EventArgs e)
        {
            
        }

        

      
    }
}
