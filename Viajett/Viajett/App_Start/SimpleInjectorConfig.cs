using Business.Interfaces;
using Business.Services;
using Data.Interfaces;
using Data.Repositories;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System.Reflection;
using System.Web.Mvc;

namespace Viajett
{
    public class SimpleInjectorConfig
    {
        public static void RegisterDependencyInjection()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            //register services
            container.Register<IEmployeeService, EmployeeService>(Lifestyle.Scoped);
            container.Register<ITaskCategoryService, TaskCategoryService>(Lifestyle.Scoped);
            container.Register<ITaskEntryService, TaskEntryService>(Lifestyle.Scoped);
            container.Register<ITaskService, TaskService>(Lifestyle.Scoped);
            container.Register<ITeamService, TeamService>(Lifestyle.Scoped);
            container.Register<IReportingPeriodService, ReportingPeriodService>(Lifestyle.Scoped);

            //register repositories
            container.Register<IEmployeeRepository, EmployeeRepository>(Lifestyle.Scoped);
            container.Register<IReportingPeriodRepository, ReportingPeriodRepository>(Lifestyle.Scoped);
            container.Register<ITaskCategoryRepository, TaskCategoryRepository>(Lifestyle.Scoped);
            container.Register<ITaskEntryRepository, TaskEntryRepository>(Lifestyle.Scoped);
            container.Register<ITaskRepository, TaskRepository>(Lifestyle.Scoped);
            container.Register<ITeamRepository, TeamRepository>(Lifestyle.Scoped);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}