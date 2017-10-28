using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Harrison.Inventory.Presenter;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.WinForm
{
    public partial class ClusterDistrictMap : Form,IClusterDistrictView
    {
        IClusterDistrictPresenter _clusterdistrictpresenter;
        public ClusterDistrictMap()
        {
            InitializeComponent();
            _clusterdistrictpresenter = new ClusterDistrictPresenter(this, new ClusterDistrictservice(new ClusterDistrictData()));
            _clusterdistrictpresenter.DefaultClusterDistrictOrder();
            this.clusterdistrictgrid.Columns[0].Visible = false;
            this.clusterdistrictgrid.Columns[1].Visible = false;
            _clusterdistrictpresenter.SetClusterNames();
            _clusterdistrictpresenter.SetDistrictNames();
            
        }
        public SortType SortDirection { get; set; }
        public SortFieldType SortField { get; set; }
        public void givearrdata(DataTable clusterdistricts)
        {
            clusterdistrictgrid.DataSource = clusterdistricts;
        }
        public void setDistrictValues(DataTable districts)
        {
            DistrictCombo.ValueMember = "DISTRICT_ID";
            DistrictCombo.DisplayMember = "DISTRICT NAME";
            DistrictCombo.DataSource = districts;
        }
        public void setClusterValues(DataTable clusters)
        {
            ClusterCombo.ValueMember = "CLUSTER_ID";
            ClusterCombo.DisplayMember = "CLUSTER NAME";
            ClusterCombo.DataSource = clusters;
        }

        private void ClusterDistrictMap_Load(object sender, EventArgs e)
        {

        }
        private void clusterdistrictgrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            edtbtn.Enabled = true;
            dltbtn.Enabled = true;
            ClusterCombo.SelectedValue = clusterdistrictgrid.Rows[e.RowIndex].Cells[0].Value;
            DistrictCombo.SelectedValue = clusterdistrictgrid.Rows[e.RowIndex].Cells[1].Value;
        }
        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            _clusterdistrictpresenter.AddClusterDistrict(int.Parse(DistrictCombo.SelectedValue.ToString()), int.Parse(ClusterCombo.SelectedValue.ToString()));
            MessageBox.Show("Cluster-District Map added");
            _clusterdistrictpresenter.DefaultClusterDistrictOrder();
            FormFunctions form = new FormFunctions();
            form.ClearTextBoxes(this);
        }

        private void edtbtn_Click(object sender, EventArgs e)
        {
            _clusterdistrictpresenter.UpdateClusterDistrict(int.Parse(DistrictCombo.SelectedValue.ToString()), int.Parse(ClusterCombo.SelectedValue.ToString()));
            _clusterdistrictpresenter.DefaultClusterDistrictOrder();
        }

        private void dltbtn_Click(object sender, EventArgs e)
        {
            _clusterdistrictpresenter.DeleteClusterDistrict(DistrictCombo.SelectedValue);
            _clusterdistrictpresenter.DefaultClusterDistrictOrder();
        }

       

      
    }
}
