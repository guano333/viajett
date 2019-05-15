using Data.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public void Delete(Guid taskId)
        {
            using (var context = new Viajett())
            {
                var task = context.Tasks.Where(x => x.TaskId == taskId).FirstOrDefault();
                if (task != null)
                {
                    context.Tasks.Remove(task);
                    context.SaveChanges();
                }
            }

        }

        public IEnumerable<Task> GetAll()
        {
            using (var context = new Viajett())
            {
                return context.Tasks.ToList();
            }
        }

        public Task GetById(Guid taskId)
        {
            using (var context = new Viajett())
            {
                var task = context.Tasks.Where(x => x.TaskId == taskId).FirstOrDefault();
                return task;
            }
        }

        public Task Upsert(Task source)
        {
            if (source != null)
            {
                using (var context = new Viajett())
                {
                    var task = context.Tasks.Where(x => x.TaskId == source.TaskId).FirstOrDefault();
                    if (task != null)
                    {
                        //update
                        task.TeamId = source.TeamId;
                        task.Name = source.Name;
                        task.Description = source.Description;
                        task.TaskCategoryId = source.TaskCategoryId;
                        task.IsActive = source.IsActive;
                        context.SaveChanges();
                        return task;
                    }
                    else
                    {
                        //insert
                        context.Tasks.Add(source);
                        context.SaveChanges();
                        return task;
                    }
                }
            }
            return null;

        }
    }
}
