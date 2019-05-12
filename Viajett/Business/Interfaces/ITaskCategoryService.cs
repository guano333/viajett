using Domain;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface ITaskCategoryService
    {
        TaskCategory UpsertTaskCategory(TaskCategory source);
        void DeleteTaskCategory(TaskCategory source);
    }
}
