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
    public partial class FormInventoryManagement : Form
    {
        List<Book> books = new List<Book>();
        Book book = new Book();

        List<Author> authors = new List<Author>();
        Author author = new Author();

        public FormInventoryManagement()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-------------------------------------------------------------------Books---------------------------------------------//
        private void buttonAddBook_Click(object sender, EventArgs e)
        {

            if (textBoxISBN.Text == "" || textBoxTitle.Text == "" || textBoxUnitPrice.Text == "" || textBoxYearPublished.Text == "" || textBoxQOH.Text == "")
            {
                MessageBox.Show("Fields have been left blank, please fill before continuing.", "Failed");
            }
            else
            {
                book.ISBN = textBoxISBN.Text;
                book.Title = textBoxTitle.Text;
                book.UnitPrice = Convert.ToInt32(textBoxUnitPrice.Text);
                book.YearPublished = Convert.ToInt32(textBoxYearPublished.Text);
                book.QOH = Convert.ToInt32(textBoxQOH.Text);
                BookDA.Register(book);
            }
        }

        private void buttonListBook_Click(object sender, EventArgs e)
        {
            books = BookDA.ListBooks();
            var allPrograms = (from element in books
                               select element);

            dataGridViewResult.DataSource = allPrograms.ToList();
        }

        private void buttonSearchBook_Click(object sender, EventArgs e)
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

        //-------------------------------------------------------------------Authors---------------------------------------------//
        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            if (textBoxAuthorID.Text == "" || textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxEmail.Text == "")
            {
                MessageBox.Show("Fields have been left blank, please fill before continuing.", "Failed");
            }
            else
            {
                author.AuthorID = Convert.ToInt32(textBoxAuthorID.Text);
                author.FirstName = textBoxFirstName.Text;
                author.LastName = textBoxLastName.Text;
                author.Email = textBoxEmail.Text;
                AuthorDA.Register(author);
            }
        }

        private void buttonListAuthor_Click(object sender, EventArgs e)
        {
            authors = AuthorDA.ListAuthors();
            var allPrograms = (from element in authors
                               select element);

            dataGridViewResult.DataSource = allPrograms.ToList();
        }

        private void buttonSearchAuthor_Click(object sender, EventArgs e)
        {
            int choice = comboBoxSearch2.SelectedIndex;
            if (textBoxSearch2.Text == "")
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

                    case 0: //Author ID

                        {
                            authors = AuthorDA.Search(Convert.ToInt32(textBoxSearch2.Text), choice);

                            if (authors != null)
                            {
                                var results = (from element in authors
                                               select element);

                                dataGridViewResult.DataSource = results.ToList();
                            }
                            else
                            {
                                MessageBox.Show("Author not found!");
                            }
                            break;
                        }
                    case 1: //Title
                    case 2: //UnitPrice
                    case 3: //YearPublished
                        {
                            authors = AuthorDA.Search(textBoxSearch2.Text, choice);

                            if (authors != null)
                            {
                                var results = (from element in authors
                                               select element);

                                dataGridViewResult.DataSource = results.ToList();
                            }
                            else
                            {
                                MessageBox.Show("Author not found!");
                            }
                            break;
                        }


                    default:   // IF the Author NOT select an option on the  search combo box
                        break;
                }
            }
        }
        //-------------------------------------------Validations------------------------------------------//
        private void textBoxUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxYearPublished_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxQOH_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxAuthorID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
