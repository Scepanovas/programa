using System;
using System.Windows.Forms;
using spammaster.Properties;
using System.Net.NetworkInformation;

namespace spammaster
{
    public partial class ApiKey : Form   
    {


        public ApiKey()
        {
            InitializeComponent();
        }

        //
        //Pakoreguojam langa tik jam atsidarius
        //

        private void ApiKey_Load(object sender, EventArgs e)
        {
            CheckForInternetConnection();

            if (Settings.Default["key"].ToString().Length == 0)
            {
                CheckForInternetConnection();
                busenaPB.Image = Resources.nera;
                testiBTN.Enabled = false;
                busenaL.Text = ("SendGrid API rakto nėra, jei norite tęsti įkelkite raktą");

            }


            else if (Settings.Default["key"].ToString().Length == 69)
            {
                busenaPB.Image = Resources.geras;
                busenaL.Text = ("SendGrid API raktas užkrautas, galite tęsti arba atnaujinti raktą");
            }

            else
            {
                busenaPB.Image = Resources.blogas;
                testiBTN.Enabled = false;
                busenaL.Text = ("SendGrid API raktas įvestas klaidingai, jei norite tęsti atnaujinkite raktą");
            }
        }

        //
        //Mygtuku konfiguracijos
        //

        private void ikeltiraktaBTN_Click(object sender, EventArgs e)
        {
                Settings.Default["key"] = apiKeyTB.Text;
                Settings.Default.Save();
                if (Settings.Default["key"].ToString().Length == 0)
                    {
                    busenaPB.Image = Resources.nera;
                    testiBTN.Enabled = false;
                    busenaL.Text = ("SendGrid API rakto nėra, jei norite tęsti įkelkite raktą");

                    }
                   
                else if (Settings.Default["key"].ToString().Length == 69)
                    {
                    busenaPB.Image = Resources.geras;
                    testiBTN.Enabled = true;
                    busenaL.Text = ("SendGrid API raktas užkrautas, galite tęsti arba atnaujinti raktą");
                    }
                else
                    {
                    busenaPB.Image = Resources.blogas;
                    testiBTN.Enabled = false;
                    busenaL.Text = ("SendGrid API raktas įvestas klaidingai, jei norite tęsti atnaujinkite raktą");
                    }
            apiKeyTB.Text = "";
        }

        private void testiBTN_Click(object sender, EventArgs e)
        {
                Skydine f2 = new Skydine();
                this.Hide();
                f2.Show();
        }

        private void iseitBTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tikrai norite išeiti?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //
        //Meniu nustatymai
        //

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SendGrid API raktas bus naudojamas tapatybės atpažinimui siunčiant laiškus, bei gaunant kontaktų sąrašą.");
        }

        private void išeitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tikrai norite išeiti?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //
        //Tikrinam interneto rysi
        //

        private void CheckForInternetConnection()
        {
            try {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                if (reply.Status == IPStatus.Success)

                {
                }
            }
            catch
            {
                internetL.Text = "Nėra interneto, susitvarkykit ir iš naujo įsijunkite programą!!!";
                testiBTN.Enabled = false;
                ikeltiraktaBTN.Enabled = false;
            }
        }
    }
}
