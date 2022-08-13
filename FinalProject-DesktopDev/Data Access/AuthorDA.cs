using FinalProject_DesktopDev.Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_DesktopDev.Data_Access
{
    public static class AuthorDA
    {
        private static string filePath = Application.StartupPath + @"\Authors.dat"; //custom path
        private static string fileTemp = Application.StartupPath + @"\Temp.dat"; //custom path for temp dat, used for better updating (replacing)/deleting

        public static void Register(Author author)
        {
            //fix later to check for unique AuthorIDs

            List<Author> listS = new List<Author>();
            listS = ListAuthors();
            bool dupe = false;

            foreach (Author a in listS)
            {
                if (a.AuthorID == author.AuthorID)
                {
                    MessageBox.Show("Duplicate ID, please enter a unique one.");
                    dupe = true;
                }
            }

            if (dupe == false)
            {
                ///check to see if exists - TBA
                StreamWriter sWriter = new StreamWriter(filePath, true); //true used to append
                sWriter.WriteLine(author.AuthorID + "," + author.FirstName + "," + author.LastName + "," + author.Email);
                sWriter.Close();
                MessageBox.Show("Registration complete.");
            }
        }
        public static List<Author> Search(int num, int choice) //Search for AuthorID
        {
            List<Author> listS = new List<Author>();
            bool found = false;
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            Console.WriteLine(num);

            while (line != null)
            {
                Author author = new Author();
                string[] fields = line.Split(',');
                if (num == Convert.ToInt32(fields[0]))
                {
                    author.AuthorID = Convert.ToInt32(fields[0]);
                    author.FirstName = fields[1];
                    author.LastName = fields[2];
                    author.Email = fields[3];
                    listS.Add(author);
                    found = true;
                }
                line = sReader.ReadLine();
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


        public static List<Author> Search(string text, int choice) //Search for FirstName, LastName, Email
        {
            List<Author> listS = new List<Author>();
            bool found = false;
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                Author author = new Author();
                string[] fields = line.Split(',');

                switch (choice)
                {
                    case 1:
                        {
                            if (text == fields[1]) //First Name
                            {
                                author.AuthorID = Convert.ToInt32(fields[0]);
                                author.FirstName = fields[1];
                                author.LastName = fields[2];
                                author.Email = fields[3];
                                listS.Add(author);
                                found = true;
                            }
                            line = sReader.ReadLine();
                            break;
                        }
                    case 2: //LastName
                        {
                            if (text == fields[2])
                            {
                                author.AuthorID = Convert.ToInt32(fields[0]);
                                author.FirstName = fields[1];
                                author.LastName = fields[2];
                                author.Email = fields[3];
                                listS.Add(author);
                                found = true;
                            }
                            line = sReader.ReadLine();
                            break;
                        }
                    case 3://Email
                        {
                            if (text == fields[3])
                            {
                                author.AuthorID = Convert.ToInt32(fields[0]);
                                author.FirstName = fields[1];
                                author.LastName = fields[2];
                                author.Email = fields[3];
                                listS.Add(author);
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

        public static List<Author> ListAuthors()
        {
            List<Author> listS = new List<Author>();
            ///check to see if exists - TBA
            StreamReader sReader = new StreamReader(filePath);

            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                Author allAuthor = new Author();
                allAuthor.AuthorID = Convert.ToInt32(fields[0]);
                allAuthor.FirstName = fields[1];
                allAuthor.LastName = fields[2];
                allAuthor.Email = fields[3];
                listS.Add(allAuthor);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return listS;
        }
    }
}
