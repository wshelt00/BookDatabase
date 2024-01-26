using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelton_BookDB
{
    internal class Book
    {

        public string ID;
        public int ident;
        public string title;
        public int year;
        public double cost;
        public string subject;
        public string isbn;
        public string edition;
        public string publisher;

        public Book(string id, string t, int y, double c, string s, string ibn, string e, string pub)
        {

            this.ID = id;
            this.title = t;
            this.year = y;
            this.cost = c;
            this.subject = s;
            this.isbn = ibn;
            this.edition = e;
            this.publisher = pub;


        }

        public Book(string id, string t)
        {

            this.ID = id;
            this.title = t;

        }

        public Book(int id)
        {
            ident = id;
        }

        public override string ToString()
        {

            return $"{ID} - {title}";

        }


        }

    }

