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
    public partial class ConfirmBox : Form
    {
        public ConfirmBox(string message)
        {
            InitializeComponent();
            Messagelbl.Text = message;
        }

      
       

    }
}
