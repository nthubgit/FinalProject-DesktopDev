using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_DesktopDev.Business;

namespace FinalProject_DesktopDev.Data_Access
{
    internal class Author_BookDA
    {
        private static string filePath = Application.StartupPath + @"\Author_Books.dat"; //custom path
        private static string fileTemp = Application.StartupPath + @"\Temp.dat"; //custom path for temp dat, used for better updating (replacing)/deleting

        public static void Register(Author_Book Author_Book)
        {
            //fix later to check for unique Author_BookIDs

            List<Author_Book> listS = new List<Author_Book>();
            listS = ListAuthor_Books();
            bool dupe = false;

            foreach (Author_Book a in listS)
            {
                if (a.AuthorID == Author_Book.AuthorID && a.ISBNFK == Author_Book.ISBNFK)
                {
                    MessageBox.Show("Duplicate IDs, please enter a unique combo.");
                    dupe = true;
                }
            }

            if (dupe == false)
            {
                ///check to see if exists - TBA
                StreamWriter sWriter = new StreamWriter(filePath, true); //true used to append
                sWriter.WriteLine(Author_Book.AuthorID + "," + Author_Book.ISBNFK);
                sWriter.Close();
                MessageBox.Show("Registration complete.");
            }
        }
        public static List<Author_Book> ListAuthor_Books()
        {
            List<Author_Book> listS = new List<Author_Book>();
            ///check to see if exists - TBA
            StreamReader sReader = new StreamReader(filePath);

            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                Author_Book allAuthor_Book = new Author_Book();
                allAuthor_Book.AuthorID = Convert.ToInt32(fields[0]);
                allAuthor_Book.ISBNFK = fields[1];
                listS.Add(allAuthor_Book);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return listS;
        }
    }
}
