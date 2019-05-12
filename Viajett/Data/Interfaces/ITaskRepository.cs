using Domain;
using System;
using System.Collections.Generic;

namespace Data.Interfaces
{
    public interface ITaskRepository
    {
        Task GetById(Guid taskId);
        IEnumerable<Task> GetAll();
        Task Upsert(Task source);
        void Delete(Guid taskId);
    }
}
