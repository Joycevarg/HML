using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Harrison.Inventory.WinForm
{
    public partial class Tax_Details : Form
    {
        public Tax_Details()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
        }
    }
}