using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reddit_Prototype.Classes
{
    public class User
    {
        private string _username;
        private string _password;
        private string _email;

        private static int _id = 0;

        private int _userID;

        private DateTime _creationDate;

        private int _karma;

        public string Username { get { return _username; } }

        public User(string username, string password, string email)
        {
            this._username = username;
            this._password = password;
            this._email = email;
            this._creationDate = DateTime.Now;
            this._karma = 0;
            _id++;
            this._userID = _id;
        }
    }
}
