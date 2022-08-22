using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTODO.Class
{
    public class User
    {
        public Guid _id { get; set; }
        public string _name { get; set; }
        public string _login { get; set; }
        public string _password { get; set; }

        public User(Guid id, string name, string login, string password)
        {
            _id = id;
            _name = name;
            _login = login;
            _password = password;
        }
    }
}
