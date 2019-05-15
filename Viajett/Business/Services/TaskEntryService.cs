using Business.Interfaces;
using Data.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class TaskEntryService : ITaskEntryService
    {
        private readonly ITaskEntryRepository _taskEntryRepository;
        private readonly IEmployeeRepository _employeeRepository;

        public TaskEntryService(ITaskEntryRepository taskEntryRepository,
            IEmployeeRepository employeeRepository)
        {
            _taskEntryRepository = taskEntryRepository;
            _employeeRepository = employeeRepository;
        }

        public void DeleteTaskEntry(TaskEntry source)
        {
            if (source != null)
            {
                _taskEntryRepository.Delete(source.TaskEntryId);
            }
        }

        public IEnumerable<TaskEntry> GetTaskEntriesByEmployee(Employee source, ReportingPeriod reportingPeriod)
        {
            return _taskEntryRepository.GetAll()
                .Where(x => x.ReportingPeriodId == reportingPeriod.ReportingPeriodId 
                    && x.EmployeeId == source.EmployeeId)
                .ToList();
        }

        public IEnumerable<TaskEntry> GetTaskEntriesByTeam(Team source, ReportingPeriod reportingPeriod)
        {
            if (source != null && reportingPeriod != null)
            {
                var teamMembers = _employeeRepository.GetAll().Where(x => x.TeamId == source.TeamId).ToList();
                return _taskEntryRepository.GetAll()
                    .Where(x => x.ReportingPeriodId == reportingPeriod.ReportingPeriodId &&
                    IsTeamMember(teamMembers, x.EmployeeId))
                    .ToList();
            }
            return new List<TaskEntry>();
        }

        private bool IsTeamMember(IList<Employee> teamMembers, Guid employeeId)
        {
            foreach(var teamMember in teamMembers)
            {
                if (teamMember.EmployeeId == employeeId)
                {
                    return true;
                }
            }
            return false;
        }

        public TaskEntry UpsertTaskEntry(TaskEntry source)
        {
            if (source != null)
            {
                source = _taskEntryRepository.Upsert(source);
            }
            return source;
        }

    }
}
