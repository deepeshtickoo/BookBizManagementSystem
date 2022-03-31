using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBizManagementSystem
{
    internal class Book
    {
        int isbn { get; set; }
        string title { get; set; }
        int unitPrice  { get; set; }
        int yearPublished { get; set; }
        int qoh { get; set; }

        Book (int i, string t, int p, int y, int q)
        {
            isbn = i;
            title = t;
            unitPrice = p;
            yearPublished = y;
            qoh = q;

        }

        

    }
}
