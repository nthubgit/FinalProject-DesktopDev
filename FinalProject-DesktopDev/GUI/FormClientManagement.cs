using FinalProject_DesktopDev.Business;
using FinalProject_DesktopDev.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_DesktopDev.GUI
{
    public partial class FormClientManagement : Form
    {
        List<Client> clients = new List<Client>();
        Client client = new Client();
        public FormClientManagement()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxStreet.Text == "" || textBoxCity.Text == "" || textBoxPostalCode.Text == "" || maskedTextBoxPhoneNumber.Text == "" || maskedTextBoxFaxNumber.Text == "" || textBoxCreditLimit.Text == "")
            {
                MessageBox.Show("Fields have been left blank, please fill before continuing.");
            }
            else
            {
                client.Name = textBoxName.Text;
                client.Street = textBoxStreet.Text;
                client.City = textBoxCity.Text;
                client.PostalCode = textBoxPostalCode.Text;
                client.PhoneNumber = maskedTextBoxPhoneNumber.Text;
                client.FaxNumber = maskedTextBoxFaxNumber.Text;
                client.CreditLimit = Convert.ToInt32(textBoxCreditLimit.Text);
                ClientDA.Register(client);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            clients = ClientDA.ListClients();
            var allPrograms = (from element in clients
                               select element);

            dataGridViewResult.DataSource = allPrograms.ToList();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int choice = comboBoxSearch.SelectedIndex;
            if (textBoxSearch.Text == "")
            {
                MessageBox.Show("Missing query.", "Failed");

            }
            else
            {
                switch (choice)
                {
                    case -1: // IF the Employee NOT select any search option

                        MessageBox.Show("Please select at least one Search Option");
                        break;

                    case 0: //Name
                    case 1: //Street
                    case 2: //City
                    case 3: //Postal Code
                    case 4: //Phone Number
                    case 5: //Fax Number
                        {
                            clients = ClientDA.Search(textBoxSearch.Text, choice);

                            if (clients != null)
                            {
                                var results = (from element in clients
                                               select element);

                                dataGridViewResult.DataSource = results.ToList();
                            }
                            else
                            {
                                MessageBox.Show("Client not found!");
                            }
                            break;
                        }
                    case 6: //Credit Limit
                        {
                            int numericValue;
                            bool isNumber = int.TryParse(textBoxSearch.Text, out numericValue);

                            if (isNumber == true)
                            {
                                clients = ClientDA.Search(Convert.ToInt32(textBoxSearch.Text), choice);

                                if (clients != null)
                                {
                                    var results = (from element in clients
                                                   select element);

                                    dataGridViewResult.DataSource = results.ToList();
                                }
                                else
                                {
                                    MessageBox.Show("Client not found!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Query must be a number for this criteria!", "Failed");
                            }
                            break;
                        }

                    default:   // IF the Client NOT select an option on the search combo box
                        break;
                }
            }
        }

        //---------------------------------------------Validations---------------------------------------------//

        private void maskedTextBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void maskedTextBoxFaxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void textBoxCreditLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
