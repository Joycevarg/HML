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
    public partial class clusterMaster : Form,IClusterView
    {
        IClusterPresenter _iclusterpresenter;
        object ID;
        public clusterMaster()
        {   
            InitializeComponent();            
            _iclusterpresenter = new ClusterPresenter(this, new ClusterServices(new ClusterData()));
            _iclusterpresenter.DefaultClusterOrder();
            this.clustergrid.Columns[0].Visible = false;
        }
       
        public SortType SortDirection { get; set; }
        public SortFieldType SortField { get; set; }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void givearrdata(DataTable districts)
        {
            clustergrid.DataSource = districts;
        }
     
        private void clusterMaster_Load(object sender, EventArgs e)
        {

        }
        private void clustergrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            editbtn.Enabled = true;
            dltbtn.Enabled = true;
            ID = clustergrid.Rows[e.RowIndex].Cells[0].Value;
            clustertxt.Text = clustergrid.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clustertxt.Text))
                MessageBox.Show("Enter a name");
            else
            {
                _iclusterpresenter.AddCluster(clustertxt.Text);
                MessageBox.Show("Cluster added");
                clustertxt.Text = "";
                _iclusterpresenter.DefaultClusterOrder();

            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            _iclusterpresenter.UpdateCluster(int.Parse(ID.ToString()), clustertxt.Text);
            _iclusterpresenter.DefaultClusterOrder();
        }

        private void dltbtn_Click(object sender, EventArgs e)
        {
            _iclusterpresenter.DeleteCluster(ID);
            _iclusterpresenter.DefaultClusterOrder();
        }
    }
}
