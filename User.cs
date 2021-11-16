using System;

namespace studentmanagementsys
{
    class User
    {
        public string Username;
        public string Name;
        public int ID;

        public User(string Username, string name, int iD)
        {
            this.Username = Username;
            this.Name = name;
            this.ID = iD;
        }
    }
}
