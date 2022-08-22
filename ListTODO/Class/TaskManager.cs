using System;
using System.Collections.Generic;

namespace ListTODO.Class
{
    internal class TaskManager
    {
        private List<Task> _tasks;

        public TaskManager()
        {
            _tasks = new List<Task>();
        }

        public List<Task> FindAllUserTasks(Guid idUser)
        {
            List<Task> userTasks = new List<Task>();
            foreach (var task in _tasks)
            {
                if (task._author == idUser)
                {
                    userTasks.Add(task);
                }
            }
            return userTasks;
        }

        public Task FindTask(int id)
        {
            foreach (Task task in _tasks)
            {
                if (task._id == id)
                {
                    return task;
                }

            }
            return null;
        }

        public void AddTask(Task task)
        {
            _tasks.Add(task);
        }

        public void RemoveTask(int taskId)
        {
            Task task = FindTask(taskId);
            _tasks.Remove(task);
        }

        public int NextId()
        {
            int nextId = 0;

            foreach (Task task in _tasks)
            {
                if (task._id > nextId) nextId = task._id;
            }

            return nextId;
        }

    }
}

