using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.entity
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Address { get; set; }

        public User(int id, string username, string password, string email, string role, string address)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
            Role = role;
            Address = address;
        }

        public User() { }
    }
}
