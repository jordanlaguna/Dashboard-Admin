using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Model
{
    internal class Books
    {
        public int isbn { get; set; }
        public string authorBook { get; set; }
        public string title { get; set; }
        public string editorial { get; set; }
        public string available { get; set; }
        public DateTime releaseDate { get; set; }

        public Books(int isbn, string authorBook, string title, string editorial, string available, DateTime releaseDate)
        {
            this.isbn = isbn;
            this.authorBook = authorBook;
            this.title = title;
            this.editorial = editorial;
            this.available = available;
            this.releaseDate = releaseDate;
        }
    }
}
