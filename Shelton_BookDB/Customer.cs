using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelton_BookDB
{
    internal class Customer
    {

        public string fname;
        public string lname;
        public string ID;

        public Customer(string id, string ln, string fn)
        {
            fname = fn;
            lname = ln;
            ID = id;


        }

        public override string ToString()
        {

            return $"{ID} - {lname},{fname}";

        }

    }
}
