using Data.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    public class TaskEntryRepository : ITaskEntryRepository
    {
        public void Delete(Guid taskEntryId)
        {
            using (var context = new Viajett())
            {
                var taskEntry = context.TaskEntries.Where(x => x.TaskEntryId == taskEntryId).FirstOrDefault();
                if (taskEntry != null)
                {
                    context.TaskEntries.Remove(taskEntry);
                    context.SaveChanges();
                }
            }
        }

        public IEnumerable<TaskEntry> GetAll()
        {
            using (var context = new Viajett())
            {
                return context.TaskEntries.ToList();
            }

        }

        public TaskEntry GetById(Guid taskEntryId)
        {
            using (var context = new Viajett())
            {
                var taskEntry = context.TaskEntries.Where(x => x.TaskEntryId == taskEntryId).FirstOrDefault();
                return taskEntry;
            }
        }

        public TaskEntry Upsert(TaskEntry source)
        {
            if (source != null)
            {
                using (var context = new Viajett())
                {
                    var taskEntry = context.TaskEntries.Where(x => x.TaskEntryId == source.TaskEntryId).FirstOrDefault();
                    if (taskEntry != null)
                    {
                        //update
                        taskEntry.EmployeeId = source.EmployeeId;
                        taskEntry.ReportingPeriodId = source.ReportingPeriodId;
                        taskEntry.TaskId = source.TaskId;
                        taskEntry.Hours = source.Hours;
                        context.SaveChanges();
                        return taskEntry;
                    }
                    else
                    {
                        //insert
                        context.TaskEntries.Add(source);
                        context.SaveChanges();
                        return taskEntry;
                    }
                }
            }
            return null;

        }
    }
}
