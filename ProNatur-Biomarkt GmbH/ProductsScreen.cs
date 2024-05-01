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
        private int lastSelectedProductKey;
      
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
            string query = string.Format("insert into Products values('{0}','{1}','{2}','{3}')", productName, productBrand, productCategory, productPrice);
            ExecuteQuery(query);

            ClearAllFields();
            showProducts();
        }
        
        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus.");
                return;
            }
            string productName = textboxProductName.Text;
            string productBrand = textboxProductBrand.Text;
            string productCategory = comboboxProductCategory.Text;
            string productPrice = textboxProductPrice.Text;

            string query = string.Format("update Products set Name='{0}', Brand='{1}', Category='{2}', Price='{3}' where Id={4}"
                , productName, productBrand, productCategory, productPrice, lastSelectedProductKey);

            ExecuteQuery(query);

            ClearAllFields();
            showProducts();
        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            if(lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus.");
                return;
            }
            string query = string.Format("delete from Products where Id={0};", lastSelectedProductKey);
            ExecuteQuery(query);
            ClearAllFields();
            showProducts();
        }

        public void showProducts()
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

        private void productsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textboxProductName.Text = productsDGV.SelectedRows[0].Cells[1].Value.ToString();
            textboxProductBrand.Text = productsDGV.SelectedRows[0].Cells[2].Value.ToString();
            comboboxProductCategory.Text = productsDGV.SelectedRows[0].Cells[3].Value.ToString();
            textboxProductPrice.Text = productsDGV.SelectedRows[0].Cells[4].Value.ToString();
            // Primary Key
            lastSelectedProductKey = (int)productsDGV.SelectedRows[0].Cells[0].Value;
        }
        //Database Connection open and close
        public void ExecuteQuery(string query)
        {
            databaseConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();
            databaseConnection.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuScreen mainMenuScreen = new MainMenuScreen();
            mainMenuScreen.Show();
            this.Hide();
        }
    }
}
