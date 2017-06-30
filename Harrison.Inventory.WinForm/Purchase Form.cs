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
    public partial class Purchase_Form : Form
    {
        public Purchase_Form()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_bttn_Click(object sender, EventArgs e)
        {
            string conquery = "Data Source=(local);Initial Catalog=HML_PURCHASE;User ID=Joyce;Password=tiger1234";
            string insertquery = "INSERT INTO testpurchaseform VALUES (@val1,@val2,@val3,@val4,@val5,@val6,@val7)";
            using (SqlConnection con = new SqlConnection(conquery)) 
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = insertquery;
                    com.Parameters.Add("@val1", SqlDbType.NVarChar).Value = InvoiceNo.Text;
                    com.Parameters.Add("@val2", SqlDbType.VarChar).Value = VendorName.Text;
                    com.Parameters.Add("@val3", SqlDbType.VarChar).Value =  FrrNotxt.Text;
                    com.Parameters.Add("@val4", SqlDbType.VarChar).Value = Datetxt.Text;
                    com.Parameters.Add("@val5", SqlDbType.VarChar).Value = lpcNotxt.Text;
                    com.Parameters.Add("@val6", SqlDbType.Int).Value=barrelqty.Text;
                    com.Parameters.Add("@val7", SqlDbType.Float).Value = wetwttxt.Text;
                    try
                    {
                        con.Open();
                        com.ExecuteNonQuery();
                        MessageBox.Show("saved");
                        Purchase_Form newform = new Purchase_Form();
                        newform.Show();
                        this.Dispose();
                    }
                    catch (SqlException es)
                    {
                        MessageBox.Show(es.Message);
                    }

                    

                    


                }

            }


        }
    }
}
