using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_DesktopDev.Business
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int UnitPrice { get; set; }
        public int YearPublished { get; set; }
        public int QOH { get; set; }
    }
}
