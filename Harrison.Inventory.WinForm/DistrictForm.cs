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
        object ID;
        public DistrictForm()
        {
            InitializeComponent();
            _idistrictpresenter= new DistrictPresenter(this,new DistrictServices(new DistrictData()));
            _idistrictpresenter.DefaultDistrictOrder();
            this.districtgrid.Columns[0].Visible = false;
            this.districtgrid.Columns[2].Visible = false;
            _idistrictpresenter.setStateNames();
            

        }
        public SortType SortDirection { get; set; }
        public SortFieldType SortField { get; set; }
        public void setStateValues(DataTable states)
        {
            statecombo.ValueMember = "STATE_ID";
            statecombo.DisplayMember = "STATE NAME";
            statecombo.DataSource = states;

        }
        private void DistrictForm_Load(object sender, EventArgs e)
        {

        }
        private void districtgrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            editbtn.Enabled = true;
            dltbtn.Enabled = true;
            ID = districtgrid.Rows[e.RowIndex].Cells[0].Value;
            districttxt.Text = districtgrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            statecombo.SelectedValue = districtgrid.Rows[e.RowIndex].Cells[2].Value;
        }
        public void givearrdata(DataTable districts)
        {
            districtgrid.DataSource = districts;
        }

        private void DistrictGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(districttxt.Text))
                MessageBox.Show("Enter a name");
            else {
                _idistrictpresenter.AddDistrict(districttxt.Text, int.Parse(statecombo.SelectedValue.ToString()));
                MessageBox.Show("District Added");
                districttxt.Text = "";
                _idistrictpresenter.DefaultDistrictOrder();

            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            _idistrictpresenter.UpdateDistrict(int.Parse(ID.ToString()), districttxt.Text, int.Parse(statecombo.SelectedValue.ToString()));
            _idistrictpresenter.DefaultDistrictOrder();
        }

        private void dltbtn_Click(object sender, EventArgs e)
        {
            _idistrictpresenter.DeleteDistrict(ID);
            _idistrictpresenter.DefaultDistrictOrder();
        }
    }
}
