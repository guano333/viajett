using Business.Interfaces;
using Domain;
using System;
using System.Collections.Generic;

namespace Business.Services
{
    public class TaskEntryService : ITaskEntryService
    {
        public void DeleteTaskEntry(TaskEntry source)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TaskEntry> GetTaskEntriesByEmployee(Employee source, int year, ReportingPeriod reportingPeriod)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TaskEntry> GetTaskEntriesByTeam(Team source, int year, ReportingPeriod reportingPeriod)
        {
            throw new NotImplementedException();
        }

        public TaskEntry UpsertTaskEntry(TaskEntry source)
        {
            throw new NotImplementedException();
        }
    }
}
