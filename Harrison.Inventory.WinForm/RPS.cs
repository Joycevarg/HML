﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;
using Harrison.Inventory.Presenter;
using Harrison.Inventory.Service;

namespace Harrison.Inventory.WinForm
{
    public partial class RPSdetails : Form, IRPSView
    {
        private IRPSPresenter rpspresenter;
        GridForm gridfrm;
        public RPSdetails()
        {
            InitializeComponent();
            rpspresenter = new RPSPresenter(this, new RPSServices(new RPSData()));
            rpspresenter.setVendorValues();
        }

        private void RPS_Load(object sender, EventArgs e)
        {

        }
        public void setVendorNames(DataTable vendors)
        {
            VendorNameCombo.ValueMember = "VENDOR_ID";
            VendorNameCombo.DisplayMember = "VENDOR_NAME";
            VendorNameCombo.DataSource = vendors;

        }
        public SortType SortDirection { get; set; }
        public SortFieldType SortField { get; set; }

        public void givearrdata(DataTable rpss)
        {
            gridfrm = new GridForm(rpss);
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridbtn_Click(object sender, EventArgs e)
        {
            rpspresenter.DefaultRPSOrder();
            gridfrm.Show();

        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rpsNametxt.Text))
                MessageBox.Show("Enter a name");
            else
            {
                rpspresenter.AddRPS(int.Parse(VendorNameCombo.SelectedValue.ToString()), rpsNametxt.Text, contactNametxt.Text, contactNotxt.Text, routeDetlstxt.Text, remarktxt.Text);
                MessageBox.Show("RPS added");
            }



        }
    }
}
