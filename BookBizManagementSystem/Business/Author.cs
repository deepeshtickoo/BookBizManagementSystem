using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBizManagementSystem
{
    internal class Author
    {
        int ID { get; }
        static int count { get; set; } = 0;
        string fName { get; set; }
        string lName { get; set; }
        string email { get; set; }

        Author(string f, string l, string e) {
            fName = f;
            lName = l;
            email = e;
            ID = count;
            count++; 
        }

    }
}
