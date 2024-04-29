using System;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class LoadingScreen : Form
    {
        private int loadingBarValue;
        public LoadingScreen() => InitializeComponent();
        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            LoadingBarTimer.Start();
        }

        private void LoadingBarTimer_Tick(object sender, EventArgs e)
        {
            loadingBarValue += 1;
            label2.Text = loadingBarValue.ToString() + "%";
            loadingProgressbar.Value = loadingBarValue;

            if (loadingBarValue >= loadingProgressbar.Maximum) 
            {
                LoadingBarTimer.Stop();

                MainMenuScreen mainMenuScreen = new MainMenuScreen();
                mainMenuScreen.Show();
                this.Hide();
            }
        }

    }
}
