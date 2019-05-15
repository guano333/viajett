using Domain;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface ITaskEntryService
    {
        TaskEntry UpsertTaskEntry(TaskEntry source);
        void DeleteTaskEntry(TaskEntry source);
        IEnumerable<TaskEntry> GetTaskEntriesByEmployee(Employee source, ReportingPeriod reportingPeriod);
        IEnumerable<TaskEntry> GetTaskEntriesByTeam(Team source, ReportingPeriod reportingPeriod);
    }
}
