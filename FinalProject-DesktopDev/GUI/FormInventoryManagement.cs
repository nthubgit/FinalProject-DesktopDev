using FinalProject_DesktopDev.Business;
using FinalProject_DesktopDev.Data_Access;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        List<Publisher> publishers = new List<Publisher>();
        Publisher publisher = new Publisher();

        List<Author_Book> author_books = new List<Author_Book>();
        Author_Book author_book = new Author_Book();

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

            if (textBoxISBN.Text == "" || textBoxTitle.Text == "" || textBoxUnitPrice.Text == "" || textBoxYearPublished.Text == "" || textBoxQOH.Text == "" || textBoxPublisherID.Text == "" || textBoxPublisherName.Text == "" || textBoxBookAuthorID.Text == "")
            {
                MessageBox.Show("Fields have been left blank, please fill before continuing.", "Failed");
            }
            else
            {
                //filling publisher
                publisher.PublisherID = Convert.ToInt32(textBoxPublisherID.Text);
                publisher.Name = textBoxPublisherName.Text;
                publisher.ISBNFK = textBoxISBN.Text;
                //filing author_book
                author_book.AuthorID = Convert.ToInt32(textBoxBookAuthorID.Text);
                author_book.ISBNFK = textBoxISBN.Text;
                //filling book
                book.ISBN = textBoxISBN.Text;
                book.Title = textBoxTitle.Text;
                book.UnitPrice = Convert.ToInt32(textBoxUnitPrice.Text);
                book.YearPublished = Convert.ToInt32(textBoxYearPublished.Text);
                book.QOH = Convert.ToInt32(textBoxQOH.Text);
                //confirming that authorID entered exists (can't add a book for an unregistered author)
                authors = AuthorDA.ListAuthors();
                bool flag = false;
                foreach (Author a in authors)
                {
                    if (Convert.ToInt32(a.AuthorID) == Convert.ToInt32(textBoxBookAuthorID.Text))
                    {
                        flag = true;
                    }
                }
                if (flag) //authorID exists
                { 
                    //trying register
                    int result = BookDA.Register(book, publisher, author_book);
                    if (result == 1)
                    {
                        MessageBox.Show("Registration complete.");
                    }
                    else
                    {
                        MessageBox.Show("Registration failed.");
                    }
                }
                else //failed
                {
                    MessageBox.Show("Author ID not found! Please confirm that the author exists.");
                }
            }
        }

        private void buttonListBook_Click(object sender, EventArgs e)
        {
            books = BookDA.ListBooks();
            authors = AuthorDA.ListAuthors();
            author_books = Author_BookDA.ListAuthor_Books();
            publishers = PublisherDA.ListPublishers();

            var allPrograms = (from b in books
                               join p in publishers on b.ISBN equals p.ISBNFK
                               orderby b.Title
                               select new { ISBN = b.ISBN, Title = b.Title, PublisherName = p.Name, Price = b.UnitPrice, YearPublished = b.YearPublished, QOH = b.QOH });

            //var allPrograms = (from element in books
            //                   select element);


            //var allPrograms = (from ab in author_books
            //                   join a in authors on ab.AuthorID equals a.AuthorID
            //                   join b in books on ab.ISBNFK equals b.ISBN
            //                   join p in publishers on ab.ISBNFK equals p.ISBNFK
            //                   orderby a.AuthorID
            //                   select new { ISBN = b.ISBN, Title = b.Title, PublisherName = p.Name, Price = b.UnitPrice, YearPublished = b.YearPublished, QOH = b.QOH, AuthorID = a.AuthorID, LastName = a.LastName, FirstName = a.FirstName }); ;

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
                            int numericValue;
                            bool isNumber = int.TryParse(textBoxSearch.Text, out numericValue);

                            if (isNumber == true) 
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
                                    MessageBox.Show("Book not found!", "Failed");
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Query must be a number for this criteria!", "Failed");
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
            books = BookDA.ListBooks();
            authors = AuthorDA.ListAuthors();
            author_books = Author_BookDA.ListAuthor_Books();
            publishers = PublisherDA.ListPublishers();

            var allPrograms = (from ab in author_books
                        join a in authors on ab.AuthorID equals a.AuthorID
                        join b in books on ab.ISBNFK equals b.ISBN
                        orderby a.AuthorID ascending
                        select new { ISBN = b.ISBN, Title = b.Title, AuthorID = a.AuthorID, LastName = a.LastName, FirstName = a.FirstName });

            //var allPrograms = (from element in authors
            //                   select element);

            dataGridViewResult.DataSource = allPrograms.ToList();

        }

        private void buttonListAllAuthors_Click(object sender, EventArgs e)
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
        //-------------------------------------------Publishers--------------------------------------------//
        //private void buttonAddPublisher_Click(object sender, EventArgs e)
        //{
        //    if (textBoxPublisherID.Text == "" || textBoxPublisherName.Text == "")
        //    {
        //        MessageBox.Show("Fields have been left blank, please fill before continuing.", "Failed");
        //    }
        //    else
        //    {
        //        publisher.PublisherID = Convert.ToInt32(textBoxPublisherID.Text);
        //        publisher.Name = textBoxPublisherName.Text;
        //        PublisherDA.Register(publisher);
        //    }
        //}

        private void buttonListPublisher_Click(object sender, EventArgs e)
        {
            publishers = PublisherDA.ListPublishers();
            var allPrograms = (from element in publishers
                               select element).Distinct();

            dataGridViewResult.DataSource = allPrograms.ToList();
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

        private void textBoxPublisherID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxBookAuthorID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

    }
}
