using Business.Interfaces;
using Domain;
using System;
using System.Collections.Generic;

namespace Business.Services
{
    public class TaskService : ITaskService
    {
        public void DeleteTask(Domain.Task source)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Task> GetActiveTasksByTaskCategory(TaskCategory category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Task> GetActiveTasksByTeam(Team team)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Task> GetAllTasksByTaskCategory(TaskCategory category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Task> GetAllTasksByTeam(Team team)
        {
            throw new NotImplementedException();
        }

        public Domain.Task UpsertTask(Domain.Task source)
        {
            throw new NotImplementedException();
        }
    }
}
