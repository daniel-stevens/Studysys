using System;
using System.Collections.Generic;

namespace studentmanagementsys

{
    class Task
    {
        public string TaskName;
        public string Description;
        public List<User> Owners = new List<User>();


        public Task()
        {
            
        }

        public void AddOwner(User user)
        {
            Owners.Add(user);
        }

        public void AddDescription(string description)
        {
            this.Description = description;
        }

        public void AddTitle(string title)
        {
            this.TaskName = title;
        }
    }
    
}
