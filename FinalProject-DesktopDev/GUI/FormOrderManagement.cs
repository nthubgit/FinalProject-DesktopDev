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
using FinalProject_DesktopDev.Business;

namespace FinalProject_DesktopDev.GUI
{
    public partial class FormOrderManagement : Form
    {
        List<Client> clients = new List<Client>();
        Client client = new Client();
        List<Order> orders = new List<Order>();
        Order order = new Order();
        List<Book> books = new List<Book>();
        Book book = new Book();

        public FormOrderManagement()
        {
            InitializeComponent();
        }

        private void FormOrderManagement_Load(object sender, EventArgs e)
        {
            //fills combobox with all the books upon load

            books = BookDA.ListBooks();
            var allBooks = (from element in books
                               select element.Title);

            comboBoxBook.DisplayMember = "Title";
            comboBoxBook.DataSource = allBooks.ToList();
        }

        private void buttonFindClient_Click(object sender, EventArgs e)
        {
            int choice = comboBoxOrderMethod.SelectedIndex;
            if (textBoxQuery.Text == "")
            {
                MessageBox.Show("Missing query.", "Failed");

            }
            else
            {
                switch (choice)
                {
                    case -1: // If nothing selected

                        MessageBox.Show("Please select at least one Search Option");
                        break;

                    case 0: //Phone Number
                        {
                            clients = ClientDA.Search(textBoxQuery.Text, choice + 4); //need to increment choice to reuse existing search function, lazy

                            if (clients != null)
                            {
                                var results = (from element in clients
                                               select element.Name); //getting just the client name to fill the textbox

                                textBoxClientName.Text = results.FirstOrDefault().ToString();
                            }
                            else
                            {
                                MessageBox.Show("No client with that number/email found!");
                            }
                            break;
                        }
                    case 1: //Fax Number
                        {
                            clients = ClientDA.Search(textBoxQuery.Text, choice+4); //need to increment choice to reuse existing search function, lazy
                            if (clients != null)
                            {
                                var results = (from element in clients
                                               select element.Name); //getting just the client name to fill the textbox

                                textBoxClientName.Text = results.FirstOrDefault().ToString();
                            }
                            else
                            {
                                MessageBox.Show("No client with that number/email found!");
                            }
                            break;
                        }

                    default:   
                        break;
                }
            }
        }

        private void textBoxOrderID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void buttonList_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
