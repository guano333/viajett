using Domain;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface ITaskService
    {
        Task UpsertTask(Task source);
        void DeleteTask(Task source);
        IEnumerable<Task> GetAllTasksByTeam(Team team);
        IEnumerable<Task> GetActiveTasksByTeam(Team team);
        IEnumerable<Task> GetAllTasksByTaskCategory(TaskCategory category);
        IEnumerable<Task> GetActiveTasksByTaskCategory(TaskCategory category);
    }
}
