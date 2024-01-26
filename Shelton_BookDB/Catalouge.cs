using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelton_BookDB
{
    internal class Catalouge
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string edition { get; set; }
        public string publisher { get; set; }
        public string subject { get; set; }
        public string isbn { get; set; }

        public Catalouge(int id, string t, string e, string p, string s, string i)
        {

            ID = id;
            title = t;
            edition = e;
            publisher = p;
            subject = s;
            isbn = i;

        }

    }
}
