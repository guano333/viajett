using Domain;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface IEmployeeService
    {
        Employee GetCurrentEmployee(string emailAddress);
        Employee UpsertEmployee(Employee source);
        void DeleteEmployee(Employee source);
        IEnumerable<Employee> GetAllEmployeesByTeam(Team team);
        IEnumerable<Employee> GetActiveEmployeesByTeam(Team team);
        void EnableEmployee(Employee source);
        void DisableEmployee(Employee source);
        void ReassignEmployee(Employee source, Team newTeam);
    }
}
