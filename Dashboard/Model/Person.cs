using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Model
{
    internal class Person
    {
      
        public int id_person { get; set; }
        public DateTime? birth_date { get; set; }
        public string identification { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string secondName { get; set; }
        public int telephone { get; set; }

        public Person( int id_person, DateTime? birth_date, string identification, string name, string lastName, string secondName, int telephone)
        {
            this.id_person = id_person;
            this.birth_date = birth_date;
            this.identification = identification;
            this.name = name;
            this.lastName = lastName;
            this.secondName = secondName;
            this.telephone = telephone;
        }
    }
}
