using FinalProject_DesktopDev.Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_DesktopDev.Data_Access
{
    public static class BookDA
    {
        private static string filePath = Application.StartupPath + @"\Books.dat"; //custom path
        private static string fileTemp = Application.StartupPath + @"\Temp.dat"; //custom path for temp dat, used for better updating (replacing)/deleting

        public static int Register(Book book, Business.Publisher publisher, Author_Book author_book)
        {

            List<Book> listS = new List<Book>();
            listS = ListBooks();

            foreach (Book b in listS)
            {
                if (b.ISBN == book.ISBN)
                {
                    MessageBox.Show("Duplicate ISBN, please enter a unique one.");
                    return 1;
                }
            }
            int result = PublisherDA.Register(publisher, author_book);
            if (result == 1)
            {
                ///check to see if exists - TBA
                StreamWriter sWriter = new StreamWriter(filePath, true); //true used to append
                sWriter.WriteLine(book.ISBN + "," + book.Title + "," + book.UnitPrice + "," + book.YearPublished + "," + book.QOH);
                sWriter.Close();
                return 1;
            }
            else
            {
                return 0; //failed
            }
        }
        
        public static List<Book> Search(int num, int choice) //Search for UnitPrice, Postal Code, Phone Number, Fax Number
        {
            List<Book> listS = new List<Book>();
            bool found = false;
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            Console.WriteLine(num);

            while (line != null)
            {
                Book book = new Book();
                string[] fields = line.Split(',');
                switch (choice)
                {
                    case 2: //UnitPrice
                        {
                            if (num == Convert.ToInt32(fields[2]))
                            {
                                book.ISBN = fields[0];
                                book.Title = fields[1];
                                book.UnitPrice = Convert.ToInt32(fields[2]);
                                book.YearPublished = Convert.ToInt32(fields[3]);
                                book.QOH = Convert.ToInt32(fields[4]);
                                listS.Add(book);
                                found = true;
                            }
                            line = sReader.ReadLine();
                            break;
                        }
                    case 3: //YearPublished
                        {
                            if (num == Convert.ToInt32(fields[3]))
                            {
                                book.ISBN = fields[0];
                                book.Title = fields[1];
                                book.UnitPrice = Convert.ToInt32(fields[2]);
                                book.YearPublished = Convert.ToInt32(fields[3]);
                                book.QOH = Convert.ToInt32(fields[4]);
                                listS.Add(book);
                                found = true;
                            }
                            line = sReader.ReadLine();
                            break;
                        }
                    case 4: //QOH
                        {
                            if (num == Convert.ToInt32(fields[4]))
                            {
                                book.ISBN = fields[0];
                                book.Title = fields[1];
                                book.UnitPrice = Convert.ToInt32(fields[2]);
                                book.YearPublished = Convert.ToInt32(fields[3]);
                                book.QOH = Convert.ToInt32(fields[4]);
                                listS.Add(book);
                                found = true;
                            }
                            line = sReader.ReadLine();
                            break;
                        }
                    default:
                        break;
                }

            }
            if (found == false)
            {
                sReader.Close();
                return null;
            }
            else
            {
                sReader.Close();
                return listS;
            }
        }


        public static List<Book> Search(string text, int choice) //Search for ISBN, Title
        {
            List<Book> listS = new List<Book>();
            bool found = false;
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                Book book = new Book();
                string[] fields = line.Split(',');

                switch (choice)
                {
                    case 0: //ISBN
                        {
                            if (text == fields[0])
                            {
                                book.ISBN = fields[0];
                                book.Title = fields[1];
                                book.UnitPrice = Convert.ToInt32(fields[2]);
                                book.YearPublished = Convert.ToInt32(fields[3]);
                                book.QOH = Convert.ToInt32(fields[4]);
                                listS.Add(book);
                                found = true;
                            }
                            line = sReader.ReadLine();
                            break;
                        }
                    case 1: //Title
                        {
                            if (text == fields[1])
                            {
                                book.ISBN = fields[0];
                                book.Title = fields[1];
                                book.UnitPrice = Convert.ToInt32(fields[2]);
                                book.YearPublished = Convert.ToInt32(fields[3]);
                                book.QOH = Convert.ToInt32(fields[4]);
                                listS.Add(book);
                                found = true;
                            }
                            line = sReader.ReadLine();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            if (found == false)
            {
                sReader.Close();
                return null;
            }
            else
            {
                sReader.Close();
                return listS;
            }
        }

        public static List<Book> ListBooks() 
        {
            List<Book> listS = new List<Book>();
            ///check to see if exists - TBA
            StreamReader sReader = new StreamReader(filePath);

            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                Book allBook = new Book();
                allBook.ISBN = fields[0];
                allBook.Title = fields[1];
                allBook.UnitPrice = Convert.ToInt32(fields[2]);
                allBook.YearPublished = Convert.ToInt32(fields[3]);
                allBook.QOH = Convert.ToInt32(fields[4]);
                listS.Add(allBook);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return listS;
        }
        public static String Transaction(string BookTitle, int Quantity) //Finds the book based on BookTitle, then updates DB
        {
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            Book book = new Book();
            int oldQOH = 0;
            //Search
            while (line != null)
            {
                string[] fields = line.Split(',');

                if (BookTitle == fields[1])
                {
                    oldQOH = Convert.ToInt32(fields[4]);
                    book.ISBN = fields[0];
                    book.Title = fields[1];
                    book.UnitPrice = (Convert.ToInt32(fields[2]));
                    book.YearPublished = (Convert.ToInt32(fields[3]));
                    book.QOH = (Convert.ToInt32(fields[4]));
                    break;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            //Check to see there are enough books before completing transaction
            MessageBox.Show(oldQOH.ToString());
            MessageBox.Show(Quantity.ToString());
            int quantityCheck = oldQOH - Quantity;
            if (quantityCheck < 0)
            {
                MessageBox.Show("Insufficient QOH! Cancelling transaction.");
                return null;
            }
            //Update

            StreamWriter sWriter = new StreamWriter(fileTemp, true);
            StreamReader sReader2 = new StreamReader(filePath);
            String line2 = sReader2.ReadLine();

            while (line2 != null)
            {
                string[] fields = line2.Split(',');
                if (fields[0] != book.ISBN) //unique
                {
                    sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4]);
                }

                line2 = sReader2.ReadLine();
            }
            sWriter.WriteLine(book.ISBN + "," + book.Title + "," + book.UnitPrice + "," + book.YearPublished + "," + book.QOH);
            sReader2.Close();
            sWriter.Close();
            File.Delete(filePath);
            File.Move(fileTemp, filePath);
            string result = book.Title + " QOH: " + oldQOH + "=>" + book.QOH + "\n";
            return result;
        }
        public static void ReverseTransaction(string BookTitle, int Quantity) //Finds the book based on BookTitle, then updates DB
        {
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            Book book = new Book();
            int oldQOH = 0;
            //Search
            while (line != null)
            {
                string[] fields = line.Split(',');

                if (BookTitle == fields[1])
                {
                    oldQOH = Convert.ToInt32(fields[4]);
                    book.ISBN = fields[0];
                    book.Title = fields[1];
                    book.UnitPrice = (Convert.ToInt32(fields[2]));
                    book.YearPublished = (Convert.ToInt32(fields[3]));
                    book.QOH = (Convert.ToInt32(fields[4]) + Quantity);
                    break;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            //Update

            StreamWriter sWriter = new StreamWriter(fileTemp, true);
            StreamReader sReader2 = new StreamReader(filePath);
            String line2 = sReader2.ReadLine();

            while (line2 != null)
            {
                string[] fields = line2.Split(',');
                if (fields[0] != book.ISBN) //unique
                {
                    sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4]);
                }

                line2 = sReader2.ReadLine();
            }
            sWriter.WriteLine(book.ISBN + "," + book.Title + "," + book.UnitPrice + "," + book.YearPublished + "," + book.QOH);
            sReader2.Close();
            sWriter.Close();
            File.Delete(filePath);
            File.Move(fileTemp, filePath);
            MessageBox.Show("Reverse transaction complete!" + "\n" +
                book.Title + "'s QOH: " + oldQOH + "=>" + book.QOH);
        }
    }
}

