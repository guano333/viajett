using Domain;
using System;
using System.Collections.Generic;

namespace Data.Interfaces
{
    public interface ITaskEntryRepository
    {
        TaskEntry GetById(Guid taskEntry);
        IEnumerable<TaskEntry> GetAll();
        TaskEntry Upsert(TaskEntry source);
        void Delete(Guid TaskEntryId);
    }
}
