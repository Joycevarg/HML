using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Harrison.Inventory.Presenter;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.WinForm
{
    public partial class DistrictForm : Form,IDistrictView
    {
        IDistrictPresenter _idistrictpresenter;
        public DistrictForm()
        {
            InitializeComponent();
            _idistrictpresenter= new DistrictPresenter(this,new DistrictServices(new DistrictData()));
            _idistrictpresenter.DefaultDistrictOrder();
            

        }
        public SortType SortDirection { get; set; }
        public SortFieldType SortField { get; set; }
        private void DistrictForm_Load(object sender, EventArgs e)
        {

        }
        public void givearrdata(List<District> districts)
        {
            dist.DataSource = districts;
        }

        private void DistrictGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
