using ProNatur_Biomarkt_GmbH.BillScreenWindows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class BillScreen : Form
    {
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\kenko\Documents\Pro-Natur Biomarkt GmbH.mdf;Integrated Security = True; Connect Timeout = 30");
        int lastSelectedProductKey;


        public BillScreen()
        {
            InitializeComponent();
            SqlShowBillings();
        }

        private void btnBillScreenShow_Click(object sender, EventArgs e)
        {
            string idString = billingDGV.SelectedRows[0].Cells[1].Value.ToString();
            string vorname = billingDGV.SelectedRows[0].Cells[2].Value.ToString();
            string text = billingDGV.SelectedRows[0].Cells[3].Value.ToString();
            string price = billingDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst eine Rechnung aus.");
                return;
            }
            
            BillScreenShowWindow billScreenShowWindow = new BillScreenShowWindow();
            billScreenShowWindow.BillScreenRechnungsNummer(idString, vorname, text, price);
            billScreenShowWindow.Show();
            
        }

        private void btnBillScreenCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnBillScreenEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnBillScreenDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnBillScreenBack_Click(object sender, EventArgs e)
        {
            MainMenuScreen mainMenu = new MainMenuScreen();
            mainMenu.Show();
            this.Hide();
        }

        private void SqlShowBillings()
        {
            databaseConnection.Open();
            string query = "select * from Billing";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            billingDGV.DataSource = dataSet.Tables[0];
            billingDGV.Columns[0].Visible = false;
            databaseConnection.Close();
        }

        public void billingDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastSelectedProductKey = (int)billingDGV.SelectedRows[0].Cells[0].Value;
        }


 
    }
}
