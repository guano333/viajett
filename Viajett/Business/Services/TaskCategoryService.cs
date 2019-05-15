using Business.Interfaces;
using Data.Interfaces;
using Domain;

namespace Business.Services
{
    public class TaskCategoryService : ITaskCategoryService
    {
        private readonly ITaskCategoryRepository _taskCategoryRepository;
        public TaskCategoryService(ITaskCategoryRepository taskCategoryRepository)
        {
            _taskCategoryRepository = taskCategoryRepository;
        }

        public void DeleteTaskCategory(TaskCategory source)
        {
            if (source != null)
            {
                _taskCategoryRepository.Delete(source.TaskCategoryId);
            }
        }

        public TaskCategory UpsertTaskCategory(TaskCategory source)
        {
            if (source != null)
            {
                source = _taskCategoryRepository.Upsert(source);
            }
            return source;
        }
    }
}
