using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTODO.Class
{
    public class UserManager
    {
        private List<User> users;

        public UserManager()
        {
            users = new List<User>();

            users.Add(new User(Guid.NewGuid(), "admin", "admin", "nimda"));
        }

        public User FindUser(string login, string password)
        {
            foreach (var user in users)
            {
                if(user.Login == login && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }


    }
}
