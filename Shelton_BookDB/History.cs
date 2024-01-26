using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelton_BookDB
{
    internal class History
    {

        public int ID { get; set; }

        public string book { get; set; }

        public DateOnly checkOut { get; set; }

        public DateOnly dueDate { get; set; }

        public History(int id, string b, DateOnly co, DateOnly dd)
        {

            this.ID = id;
            this.book = b;
            this.checkOut = co;
            this.dueDate = dd;

        }

    }
}
