using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTODO.Class
{
    internal class Task
    {
        public int _id { get; set; }
        public Guid _author { get; set; }
        public string _title { get; set; }
        public string _description { get; set; }
        //private DateTime CreateTime { get; set; }
        public bool _isCompleted { get; set; }

        public Task(int id, Guid author, string title, string description, bool isFinished)
        {
            _id = id;
            _author = author;
            _title = title;
            _description = description;
            _isCompleted = isFinished;
        }





    }
}
