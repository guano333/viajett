using Business.Interfaces;
using Data.Interfaces;
using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public void DeleteTask(Domain.Task source)
        {
            if (source != null)
            {
                _taskRepository.Delete(source.TaskId);
            }
        }

        public IEnumerable<Domain.Task> GetActiveTasksByTaskCategory(TaskCategory category)
        {
            if (category != null)
            {
                return _taskRepository.GetAll().Where(x => x.TaskCategoryId == category.TaskCategoryId && x.IsActive == true).ToList();
            }
            return new List<Task>();
        }

        public IEnumerable<Domain.Task> GetActiveTasksByTeam(Team team)
        {
            if (team != null)
            {
                return _taskRepository.GetAll().Where(x => x.TeamId == team.TeamId && x.IsActive == true).ToList();
            }
            return new List<Task>();
        }

        public IEnumerable<Domain.Task> GetAllTasksByTaskCategory(TaskCategory category)
        {
            if (category != null)
            {
                return _taskRepository.GetAll().Where(x => x.TaskCategoryId == category.TaskCategoryId).ToList();
            }
            return new List<Task>();
        }

        public IEnumerable<Domain.Task> GetAllTasksByTeam(Team team)
        {
            if (team != null)
            {
                return _taskRepository.GetAll()
                    //.Where(x => x.TeamId == team.TeamId)
                    .OrderBy(x => x.Name)
                    .ToList();
            }
            return new List<Task>();
        }

        public Domain.Task UpsertTask(Domain.Task source)
        {
            if (source != null)
            {
                _taskRepository.Upsert(source);
            }
            return source;
        }
    }
}
