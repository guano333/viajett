using Data.Interfaces;
using Domain;
using System;
using System.Collections.Generic;

namespace Data.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public void Delete(Guid taskId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Task> GetAll()
        {
            throw new NotImplementedException();
        }

        public Domain.Task GetById(Guid taskId)
        {
            throw new NotImplementedException();
        }

        public Domain.Task Upsert(Domain.Task source)
        {
            throw new NotImplementedException();
        }
    }
}
