using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Model
{
    internal class Laptop
    {
        public string code { get; set; }
        public string trademark { get; set; }
        public string ubication { get; set; }
        public string available { get; set; }

        public Laptop(string code, string trademark, string ubication, string available)
        {
            this.code = code;
            this.trademark = trademark;
            this.ubication = ubication;
            this.available = available;
        }


    }
}
