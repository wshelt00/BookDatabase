using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelton_BookDB
{
    internal class Author
    {

        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public Author(int id, string fn, string ln) { 
        
            this.ID = id;
            this.FName = fn;
            this.LName = ln;

        }

        public Author(string fn, string ln)
        {

            this.FName = fn;
            this.LName = ln;

        }

        public override string ToString()
        {

            return $"{FName}, {LName}";

        }

    }
}
