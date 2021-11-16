using System;
using System.Collections.Generic;
using System.Text;

namespace studentmanagementsys
{

        class Day
        {
            string Date;
            List<Task> Tasks;

            public Day(string date)
            {
                this.Date = date;
            }

            void AddTask(Task task)
            {
                this.Tasks.Add(task);
            }

        }
}
