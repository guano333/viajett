using Data.Interfaces;
using Domain;
using System;
using System.Collections.Generic;

namespace Data.Repositories
{
    public class TaskCategoryRepository : ITaskCategoryRepository
    {
        public void Delete(Guid taskCategoryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TaskCategory> GetAll()
        {
            throw new NotImplementedException();
        }

        public TaskCategory GetById(Guid taskCategory)
        {
            throw new NotImplementedException();
        }

        public TaskCategory Upsert(TaskCategory source)
        {
            throw new NotImplementedException();
        }
    }
}
