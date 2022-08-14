using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTODO.Class
{
    public class UserManager
    {
        private List<User> _users;

        public UserManager()
        {
            _users = new List<User>();

            _users.Add(new User(Guid.NewGuid(), "admin", "admin", "nimda"));
        }

        public User FindUser(string login, string password)
        {
            foreach (var user in _users)
            {
                if(user.Login == login && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }
        
        public bool UserExists(string login)
        {
            foreach(User user in _users)
            {
                if (user.Login == login)
                {
                    return true;
                }
                
            }
            return false;
        }

        public void AddUser(User user) => _users.Add(user);
    }
}
