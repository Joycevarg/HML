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
        public StateForm()
        {
            InitializeComponent();
            IStatePresenter _statepresenter = new StatePresenter(this, new StateServices(new StateData()));
            _statepresenter.DefaultStateOrder();
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
    }
}
