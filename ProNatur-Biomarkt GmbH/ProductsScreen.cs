using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class ProductsScreen : Form
    {
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\kenko\Documents\Pro-Natur Biomarkt GmbH.mdf;Integrated Security = True; Connect Timeout = 30");

        public ProductsScreen()
        {
            InitializeComponent();
            showProducts();
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            if(textboxProductName.Text == "" || textboxProductBrand.Text == "" || textboxProductPrice.Text == "" || comboboxProductCategory.Text == "")
            {
                MessageBox.Show("Bitte fülle alle Werte aus.");
                return;
            }
            string productName = textboxProductName.Text;
            string productBrand = textboxProductBrand.Text;
            string productCategory = comboboxProductCategory.Text;
            string productPrice = textboxProductPrice.Text;

            databaseConnection.Open();
            string query = string.Format("insert into Products values('{0}','{1}','{2}','{3}')", productName, productBrand, productCategory, productPrice);
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();
            databaseConnection.Close();


            ClearAllFields();
            showProducts();
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            showProducts();
        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            showProducts();
        }

        private void showProducts()
        {
            databaseConnection.Open();

            string query = "select * from Products";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            productsDGV.DataSource = dataSet.Tables[0];

            productsDGV.Columns[0].Visible = false;

            databaseConnection.Close();
        }

        private void ClearAllFields ()
        {
            textboxProductBrand.Clear();
            textboxProductName.Clear();
            textboxProductPrice.Clear();
            comboboxProductCategory.SelectedItem = null;
        }
    }
}
