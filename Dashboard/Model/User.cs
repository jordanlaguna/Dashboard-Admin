using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Model
{
    internal class User:Person
    {
        public int id_user { get; set; }

        public string password { get; set; }

        public string email { get; set; }

        public User(int id_person, DateTime birth_date, string identification, string name, string lastName, string secondName, int telephone, int id_user, string password, string email)
      : base(id_person, birth_date, identification, name, lastName, secondName, telephone)
        {
            this.id_user = id_user;
            this.password = password;
            this.email = email;
        }
    }
}
