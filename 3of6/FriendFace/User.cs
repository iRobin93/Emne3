using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    internal class User
    {
        public static List<User> Users = new List<User>();
        public static int HighestId = 0;
        public string Name { get; private set; }
        public string Email { get; private set; }

        public string Password { get; private set; }

        public int Id { get; private set; }
        public string Info { get; private set; }
        public List<User> friends { get; private set; } = new List<User>();
        

        

        public User(string name, string email, string password, string info) 
        {
            Name = name;
            Email = email;
            Password = password;
            Id = GetId();
            Info = info;
        }
        public void AddFriend()
        {
            
            Console.Clear();
            foreach (var user in Users)
            {
                if (user.Id != 1 && !friends.Contains(user))
                Console.WriteLine("Tast " + user.Id + " for å legge til " + user.Name);
                
            }

            var input = Console.ReadKey();
            foreach (var user in Users) 
            {
                if(input.KeyChar.ToString() == user.Id.ToString())
                    if (user.Id != 1 && !friends.Contains(user))
                        friends.Add(user);
            }
            
        }

        public void RemoveFriend()
        {
            Console.Clear();
            foreach (var friend in friends)
                Console.WriteLine(friend.Name + " ID: " + friend.Id);
            Console.WriteLine("Trykk en ID for å slette venn");
            var input = Console.ReadKey();
            foreach (var friend in friends)
            {
                if (friend.Id.ToString() == input.KeyChar.ToString())
                {
                    friends.Remove(friend);
                    return;
                }

            }
        }

        public void ShowFriends()
        {
            Console.Clear();
            foreach (var friend in friends)
                Console.WriteLine(friend.Name + " ID: " + friend.Id);
            Console.WriteLine("Trykk en tast for å gå tilbake til meny");
            Console.ReadKey();
        }

        public void WriteFriendInfo()
        {

        }

        public int GetId()
        {
            HighestId++;
            return HighestId;
        }
    }
}
