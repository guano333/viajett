using Domain;
using System;
using System.Collections.Generic;

namespace Data.Interfaces
{
    public interface ITaskCategoryRepository
    {
        TaskCategory GetById(Guid taskCategory);
        IEnumerable<TaskCategory> GetAll();
        TaskCategory Upsert(TaskCategory source);
        void Delete(Guid taskCategoryId);
    }
}
