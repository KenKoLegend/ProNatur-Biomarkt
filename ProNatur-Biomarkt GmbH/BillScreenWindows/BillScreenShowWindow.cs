using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ProNatur_Biomarkt_GmbH;
namespace ProNatur_Biomarkt_GmbH.BillScreenWindows
{
    public partial class BillScreenShowWindow : Form 

        {
        public BillScreenShowWindow()
        {
            InitializeComponent();
            BillScreen billScreen = new BillScreen();
            billScreen.SqlShowBillings();
        }
        
        public string BillScreenRechnungsNummer(string idstring, string vorname, string text, string price)
        {   
            valueRechnungsID.Text = idstring;
            valueVorname.Text = vorname;
            valueRichTextInhalt.Text = text;
            textboxPrice.Text = price + "€";
            return valueRechnungsID.Text;

        }
        
    }
}
