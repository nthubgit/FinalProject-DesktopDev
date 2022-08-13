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
    public static class PublisherDA
    {
        private static string filePath = Application.StartupPath + @"\Publishers.dat"; //custom path
        private static string fileTemp = Application.StartupPath + @"\Temp.dat"; //custom path for temp dat, used for better updating (replacing)/deleting

        public static int Register(Publisher Publisher,Author_Book author_book)
        {
            //fix later to check for unique PublisherIDs

            List<Publisher> listS = new List<Publisher>();
            listS = ListPublishers();

            foreach (Publisher a in listS)
            {
                if (a.PublisherID == Publisher.PublisherID)
                {
                    MessageBox.Show("Duplicate Publisher ID, please enter a unique one.");
                    return 0; //fail return
                }
            }
            int result = Author_BookDA.Register(author_book);
            if (result == 1)
            {
                ///check to see if exists - TBA
                StreamWriter sWriter = new StreamWriter(filePath, true); //true used to append
                sWriter.WriteLine(Publisher.PublisherID + "," + Publisher.Name + "," + Publisher.ISBNFK);
                sWriter.Close();
                return 1;
            }
            else
            {
                return 0; //failed
            }
        }
        public static List<Publisher> ListPublishers()
        {
            List<Publisher> listS = new List<Publisher>();
            ///check to see if exists - TBA
            StreamReader sReader = new StreamReader(filePath);

            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                Publisher allPublisher = new Publisher();
                allPublisher.PublisherID = Convert.ToInt32(fields[0]);
                allPublisher.Name = fields[1];
                allPublisher.ISBNFK = fields[2];
                listS.Add(allPublisher);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return listS;
        }
    }
}
