using Data.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    public class TaskCategoryRepository : ITaskCategoryRepository
    {
        public void Delete(Guid taskCategoryId)
        {
            using (var context = new Viajett())
            {
                var taskCategory = context.TaskCategories.Where(x => x.TaskCategoryId == taskCategoryId).FirstOrDefault();
                if (taskCategory != null)
                {
                    context.TaskCategories.Remove(taskCategory);
                    context.SaveChanges();
                }
            }
        }

        public IEnumerable<TaskCategory> GetAll()
        {
            using (var context = new Viajett())
            {
                return context.TaskCategories.ToList();
            }
        }

        public TaskCategory GetById(Guid taskCategoryId)
        {
            using (var context = new Viajett())
            {
                var taskCategory = context.TaskCategories.Where(x => x.TaskCategoryId == taskCategoryId).FirstOrDefault();
                return taskCategory;
            }

        }

        public TaskCategory Upsert(TaskCategory source)
        {
            if (source != null)
            {
                using (var context = new Viajett())
                {
                    var taskCategory = context.TaskCategories.Where(x => x.TaskCategoryId == source.TaskCategoryId).FirstOrDefault();
                    if (taskCategory != null)
                    {
                        //update
                        taskCategory.CategoryName = source.CategoryName;
                        context.SaveChanges();
                        return taskCategory;
                    }
                    else
                    {
                        //insert
                        context.TaskCategories.Add(source);
                        context.SaveChanges();
                        return taskCategory;
                    }
                }
            }
            return null;

        }
    }
}
