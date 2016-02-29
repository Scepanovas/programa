using System;
using System.Windows.Forms;

namespace spammaster
{
    public partial class Taisom : Form
    {
        public Kontaktai ContactDetails { get; set; }

        public Taisom()
        {
            InitializeComponent();
        }

        //
        //
        //

        private void Taisom_Load(object sender, EventArgs e)
        {
            if (ContactDetails != null)
            {
                vardasTB.Text = ContactDetails.first_name;
                pavardeTB.Text = ContactDetails.last_name;
                elpastasTB.Text = ContactDetails.email;
            }
        }


        //
        //mygtuku nustatymai
        //

        private void issaugotiBTN_Click(object sender, EventArgs e)
        {
            if (ContactDetails == null)
                AddContact();
            else
                UpdateContact();
            Dispose();
        }

        private void atsauktiBTN_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        //
        //metodai
        //

        private void AddContact()
        {
            try
            {
                ContactDetails = new Kontaktai();
                ContactDetails.first_name = vardasTB.Text;
                ContactDetails.last_name = pavardeTB.Text;
                ContactDetails.email = elpastasTB.Text;

                KontaktuTvarkymas managerSendGrid = new KontaktuTvarkymas();
                EditContactsResponse response = managerSendGrid.EditContact(ContactDetails);

                if (response.error_count == 0)
                {
                    ContactDetails.id = response.persisted_recipients[0];

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(this, response.errors[0].message, "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error");
            }
        }

        private void UpdateContact()
        {
            try
            {
                ContactDetails.first_name = vardasTB.Text;
                ContactDetails.last_name = pavardeTB.Text;
                ContactDetails.email = elpastasTB.Text;

                KontaktuTvarkymas managerSendGrid = new KontaktuTvarkymas();
                EditContactsResponse response = managerSendGrid.EditContact(ContactDetails);

                if (response.error_count == 0)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(this, response.errors[0].message, "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error");
            }
        }
    }
}
