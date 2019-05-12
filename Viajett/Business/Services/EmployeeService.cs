using Business.Interfaces;
using Domain;
using System;
using System.Collections.Generic;

namespace Business.Services
{
    public class EmployeeService : IEmployeeService
    {
        public void DeleteEmployee(Employee source)
        {
            throw new NotImplementedException();
        }

        public void DisableEmployee(Employee source)
        {
            throw new NotImplementedException();
        }

        public void EnableEmployee(Employee source)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetActiveEmployeesByTeam(Team team)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployeesByTeam(Team team)
        {
            throw new NotImplementedException();
        }

        public Employee GetCurrentEmployee(string emailAddress)
        {
            throw new NotImplementedException();
        }

        public void ReassignEmployee(Employee source, Team newTeam)
        {
            throw new NotImplementedException();
        }

        public Employee UpsertEmployee(Employee source)
        {
            throw new NotImplementedException();
        }
    }
}
