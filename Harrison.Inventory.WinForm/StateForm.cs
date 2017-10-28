using System;
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
    public partial class StateForm : Form,IStateView
    {
        IStatePresenter _statepresenter;
        public StateForm()
        {
            InitializeComponent();
            _statepresenter = new StatePresenter(this, new StateServices(new StateData()));
            _statepresenter.DefaultStateOrder();
            this.stategrid.Columns[0].Visible = false;
        }
        public SortType SortDirection { get; set; }
        public SortFieldType SortField { get; set; }
        public void givearrdata(DataTable states)
        {
            stategrid.DataSource = states;
        }
        private void StateForm_Load(object sender, EventArgs e)
        {
           
        }
        object ID;
        private void stategrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            edtbtn.Enabled = true;
            rmvbtn.Enabled = true;
            ID=stategrid.Rows[e.RowIndex].Cells[0].Value;
            statetxt.Text = stategrid.Rows[e.RowIndex].Cells[1].Value.ToString();

        }
        
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(statetxt.Text))
                MessageBox.Show("Enter a Name");
            else
            {
                _statepresenter.AddState(statetxt.Text);
                MessageBox.Show("State added");
                FormFunctions func = new FormFunctions();
                func.ClearTextBoxes(this);
                _statepresenter.DefaultStateOrder();


            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            DistrictForm district = new DistrictForm();
            district.Show();
        }

        private void cnclbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edtbtn_Click(object sender, EventArgs e)
        {
            _statepresenter.UpdateState(int.Parse(ID.ToString()), statetxt.Text);
            _statepresenter.DefaultStateOrder();
        }

        private void rmvbtn_Click(object sender, EventArgs e)
        {
            _statepresenter.DeleteState(ID);
            _statepresenter.DefaultStateOrder();
        }
    }
}
