using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.Mail;
using spammaster.Properties;
using SendGrid;

namespace spammaster
{
    public partial class Skydine : Form
    {
        private BindingList<Kontaktai> contactList;

        public Skydine()
        {
            InitializeComponent();

        }

        //
        // Keičiam skydinės langą tik atidarius
        //

        private void Skydine_Load(object sender, EventArgs e)
        {
            lauktiB.Hide();
            redaguotigBTN.Hide();
            naujasgBTN.Hide();
            trintigBTN.Hide();
            infoL.Hide();

            //contactList = new BindingList<Kontaktai>();
            //dataGrid.DataSource = contactList;

            //KontaktuTvarkymas managerSendGrid = new KontaktuTvarkymas();
            //List<Kontaktai> list = managerSendGrid.GetContacts(100, 1);
            //if (list != null)
            //{
            //    foreach (Kontaktai c in list)
            //    {
            //        contactList.Add(c);
            //    }
            //}
        }

        //
        //Mygtuku nustatymai
        //

        private void failasBTN_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(failasTB.Text))
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    failasTB.Text = ofd.FileName;
                    failasBTN.Text = "Atkabinti";
                }
            }
            else
            {
                failasTB.Text = String.Empty;
                failasBTN.Text = "Pridėti failą";
            }
        }
        private void siustiBTN_Click(object sender, EventArgs e)
        {
            siusti();
        }
        private void griztiBTN_Click(object sender, EventArgs e)
        {
            ApiKey f1 = new ApiKey();
            this.Hide();
            f1.Show();
        }

        private void isjungtiBTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tikrai norite išeiti?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void naujasgBTN_Click(object sender, EventArgs e)
        {
            Taisom dlg = new Taisom();
            DialogResult dr = dlg.ShowDialog();
            if (dr == DialogResult.OK)
            {
                contactList.Add(dlg.ContactDetails);
            }
        }
        private void redaguotigBTN_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nieko nepasirinkote");
                return;
            }

            DataGridViewRow row = dataGrid.SelectedRows[0];
            Kontaktai c = row.DataBoundItem as Kontaktai;
            if (c != null)
            {
                Taisom dialog = new Taisom();
                dialog.ContactDetails = c;
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show(this, "Klaida");
            }

        }
        private void trintigBTN_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nieko nepasirinkote");
                return;
            }

            DataGridViewRow row = dataGrid.SelectedRows[0];
            Kontaktai c = row.DataBoundItem as Kontaktai;

            if (DialogResult.Yes == MessageBox.Show(this, "Ar tikrai norite ištrinti kontaktą?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                KontaktuTvarkymas managerSendGrid = new KontaktuTvarkymas();
                String response = managerSendGrid.DeleteContact(c);
                if (String.IsNullOrEmpty(response))
                {
                    contactList.Remove(c);
                }
                else
                {
                    MessageBox.Show(this, response, "Klaida");
                }
            }
        }

        //
        //Paveiksliuku nustatymai
        //

        private void pridetigPB_Click(object sender, EventArgs e)
        {
            
            pridetigPB.Image = Resources.yes;
            taisytigPB.Image = Resources.no;
            timer1.Start();
            lauktiB.Show();
            dataGrid.Hide();
            redaguotigBTN.Hide();
            naujasgBTN.Hide();
            trintigBTN.Hide();
            KontaktuTvarkymas managerSendGrid = new KontaktuTvarkymas();
            List<Kontaktai> list = managerSendGrid.GetContacts(100, 1);
            if (list != null)
            {
                gavejuList.DataSource = list;
            }
            infoL.Show();
            Controls.Add(gavejuList);
            gavejuList.Show();
            lauktiB.Hide();

        }

        private void taisytigPB_Click(object sender, EventArgs e)
        {

            pridetigPB.Image = Resources.no;
            taisytigPB.Image = Resources.yes;
            timer1.Start();
            lauktiB.Show();
            infoL.Hide();
            gavejuList.Hide();
            contactList = new BindingList<Kontaktai>();
            dataGrid.DataSource = contactList;
            KontaktuTvarkymas managerSendGrid = new KontaktuTvarkymas();
            List<Kontaktai> list = managerSendGrid.GetContacts(100, 1);
            if (list != null)
            {
                foreach (Kontaktai c in list)
                {
                    contactList.Add(c);
                }
            }
            Controls.Add(dataGrid);
            dataGrid.Show();
            redaguotigBTN.Show();
            naujasgBTN.Show();
            trintigBTN.Show();  
            lauktiB.Hide();

        }

        //
        //saraso dvigubo paspaudimo nustatymai
        //

        private void gavejuList_DoubleClick(object sender, EventArgs e)
        {
            if (gavejuList.SelectedIndex > -1)
            {
                Kontaktai c = gavejuList.SelectedItem as Kontaktai;
                if (String.IsNullOrEmpty(gavejaiTB.Text))
                {
                    gavejaiTB.Text = c.email;
                }
                else
                {
                    gavejaiTB.Text += "; " + c.email;
                }
            }
        }

        //
        //Laikmačio (progress barui) nustatymai
        //

        private void timer1_Tick(object sender, EventArgs e)
        {
            lauktiB.Increment(1);
        }

        //
        //Metodai
        //

        private void siusti()
        {
            try
            {

                String[] gavejai = gavejaiTB.Text.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < gavejai.Length; i++)
                    gavejai[i] = gavejai[i].Trim();

                SendGridMessage myMessage = new SendGridMessage();
                myMessage.AddTo(gavejai);
                myMessage.From = new MailAddress(jusuelTB.Text);
                myMessage.Subject = temaTB.Text;
                myMessage.Text = tekstasTB.Text;
                if (!String.IsNullOrEmpty(failasTB.Text))
                    myMessage.AddAttachment(failasTB.Text);

                // Create a Web transport, using API Key
                var transportWeb = new Web(Settings.Default["key"].ToString());

                // Send the email.
                if (gavejaiTB.Text.Length == 0 || tekstasTB.Text.Length == 0 || temaTB.Text.Length == 0)
                {
                    MessageBox.Show("Neužpildėte reikiamų laukų (Gavėjai/tema/tekstas)");
                    
                }
                else
                {
                    transportWeb.DeliverAsync(myMessage).Wait();
                    MessageBox.Show("Žinutė išsiųsta");
                    gavejaiTB.Text = null;
                    temaTB.Text = null;
                    tekstasTB.Text = null;
                    failasTB.Text = null;
                    failasBTN.Text = "Pridėti failą";
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
