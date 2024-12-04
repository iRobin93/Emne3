using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    internal class user
    {
        private string _id;
        private string _name;
        private string _email;
        private string _password;


        public user(string id, string name, string password)
        {
            _id = id;
            _name = name;
            _password = password;
        }
        public void AddFriend()
        {

        }

        public void RemoveFriend() 
        {
        
        }
    }
}
