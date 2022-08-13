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
            orders = OrderDA.ListOrders();
            var allPrograms = (from element in orders
                               select element);

            dataGridViewResult.DataSource = allPrograms.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (textBoxOrderID.Text == "" || textBoxClientName.Text == "" || comboBoxBook.Text == "" || textBoxPrice.Text == "" || textBoxQuantity.Text == "")
            {
                MessageBox.Show("Fields have been left blank, please fill before continuing.", "Failed");
            }
            else
            {
                order.OrderID = Convert.ToInt32(textBoxOrderID.Text);
                order.ClientName = textBoxClientName.Text;
                order.BookTitle = comboBoxBook.Text;
                order.Quantity = Convert.ToInt32(textBoxPrice.Text);
                order.TotalPrice = Convert.ToInt32(textBoxQuantity.Text);
                OrderDA.Register(order);
            }
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
                    case -1: // IF the Book NOT select any search option

                        MessageBox.Show("Please select at least one Search Option");
                        break;

                    case 0: //ISBN
                    case 1: //Title
                        {
                            books = BookDA.Search(textBoxSearch.Text, choice);

                            if (books != null)
                            {
                                var results = (from element in books
                                               select element);

                                dataGridViewResult.DataSource = results.ToList();
                            }
                            else
                            {
                                MessageBox.Show("Book not found!");
                            }
                            break;
                        }

                    case 2: //UnitPrice
                    case 3: //YearPublished
                    case 4: //QOH
                        {
                            books = BookDA.Search(Convert.ToInt32(textBoxSearch.Text), choice);

                            if (books != null)
                            {
                                var results = (from element in books
                                               select element);

                                dataGridViewResult.DataSource = results.ToList();
                            }
                            else
                            {
                                MessageBox.Show("Book not found!");
                            }
                            break;
                        }


                    default:   // IF the Book NOT select an option on the  search combo box
                        break;
                }
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}