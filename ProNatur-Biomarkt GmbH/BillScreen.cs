using ProNatur_Biomarkt_GmbH.BillScreenWindows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class BillScreen : Form
    {
        int lastSelectedProductKey;
        public BillScreen()
        {
            InitializeComponent();
        }

        private void btnBillScreenShow_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst eine Rechnung aus.");
                return;
            }
            BillScreenShowWindow billScreenShowWindow = new BillScreenShowWindow();
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
    }
}
