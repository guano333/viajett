using Data.Interfaces;
using Domain;
using System;
using System.Collections.Generic;

namespace Data.Repositories
{
    public class TaskEntryRepository : ITaskEntryRepository
    {
        public void Delete(Guid TaskEntryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TaskEntry> GetAll()
        {
            throw new NotImplementedException();
        }

        public TaskEntry GetById(Guid taskEntry)
        {
            throw new NotImplementedException();
        }

        public TaskEntry Upsert(TaskEntry source)
        {
            throw new NotImplementedException();
        }
    }
}
