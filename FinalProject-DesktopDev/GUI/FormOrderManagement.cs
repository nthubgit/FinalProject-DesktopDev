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
        private void comboBoxBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fetches price
            //books = BookDA.Search(comboBoxBook.Text, 1);
            //textBoxPrice = books.
            books = BookDA.ListBooks();
            var allBooks = (from element in books
                            where element.Title == comboBoxBook.Text
                            select element.UnitPrice);

            textBoxPrice.Text = allBooks.First().ToString();

        }
        private void buttonList_Click(object sender, EventArgs e)
        {
            orders = OrderDA.ListOrders();
            var allPrograms = (from element in orders
                               orderby element.OrderID ascending
                               select element);

            dataGridViewResult.DataSource = allPrograms.ToList();
            //Consider adding sorting later
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (textBoxOrderID.Text == "" || textBoxClientName.Text == "" || comboBoxBook.Text == "" || textBoxQuantity.Text == "" || textBoxPrice.Text == "")
            {
                MessageBox.Show("Fields have been left blank, please fill before continuing.", "Failed");
            }
            else
            {
                order.OrderID = Convert.ToInt32(textBoxOrderID.Text);
                order.ClientName = textBoxClientName.Text;
                order.BookTitle = comboBoxBook.Text;
                order.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                order.TotalPrice = Convert.ToInt32(textBoxPrice.Text);
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

                        MessageBox.Show("Please select at least one Search Option", "Failed");
                        break;

                    case 0: //OrderID
                    case 3: //Quantity
                    case 4: //TotalPrice
                        {
                            int numericValue;
                            bool isNumber = int.TryParse(textBoxSearch.Text, out numericValue);

                            if (isNumber == true)
                            {
                                orders = OrderDA.Search(Convert.ToInt32(textBoxSearch.Text), choice);
                                
                                if (orders != null)
                                {
                                    var results = (from element in orders
                                                   select element);

                                    dataGridViewResult.DataSource = results.ToList();
                                }
                                else
                                {
                                    MessageBox.Show("Order not found!", "Failed");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Query must be a number for this criteria!", "Failed");
                            }
                            break;
                        }

                    case 1: //ClientName
                    case 2: //BookTitle
                        {
                            orders = OrderDA.Search(textBoxSearch.Text, choice);

                            if (orders != null)
                            {
                                var results = (from element in orders
                                               select element);

                                dataGridViewResult.DataSource = results.ToList();
                            }
                            else
                            {
                                MessageBox.Show("Order not found!", "Failed");
                            }
                            break;
                        }


                    default:   // IF the Order NOT select an option on the  search combo box
                        break;
                }
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (textBoxOrderID.Text == "")
            {
                MessageBox.Show("Must input Order ID to delete.", "Failed");
            }
            else
            {
                OrderDA.Delete(Convert.ToInt32(textBoxOrderID.Text));
            }
        }

        //-------------------------------------------------------Validations------------------------------------------//

        private void textBoxOrderID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}