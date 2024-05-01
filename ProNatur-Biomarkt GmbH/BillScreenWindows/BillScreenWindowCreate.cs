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

namespace ProNatur_Biomarkt_GmbH.BillScreenWindows
{
    public partial class BillScreenWindowCreate : Form
    {
        ProductsScreen productsScreen = new ProductsScreen();
        BillScreen billScreen = new BillScreen();
        public BillScreenWindowCreate()

        {
            InitializeComponent();          
            billScreen.SqlShowBillings();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if(textboxCreateVorname.Text == "" || textboxCreatePreis.Text == "" || richtextboxCreateInhalt.Text == "")
            {
                MessageBox.Show("Fülle alle Felder aus um fort zu fahren.");
            }



            string rechnungsid = textboxCreateRID.Text;
            string vorname  = textboxCreateVorname.Text;
            string preis = textboxCreatePreis.Text;
            string richtext = richtextboxCreateInhalt.Text;
            string query = string.Format("insert into Billing values('{0}', '{1}', '{2}', '{3}')", rechnungsid, vorname, richtext, preis);
            productsScreen.ExecuteQuery(query);
            billScreen.SqlShowBillings();
            this.Hide();


        }

        public string RechnungsIdAendern(string id)
        {
            int rid = Int32.Parse(id);
            int reid = rid += 1;
            string idstring = "#320" + reid.ToString();
            textboxCreateRID.Text = idstring;
            return textboxCreateRID.Text;
         }


        
    }
}
