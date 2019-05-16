using Business.Interfaces;
using Data.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void DeleteEmployee(Employee source)
        {
            if (source != null)
            {
                _employeeRepository.Delete(source.EmployeeId);
            }
        }

        public void DisableEmployee(Employee source)
        {
            if (source != null)
            {
                source.IsActive = false;
                _employeeRepository.Upsert(source);
            }
        }

        public void EnableEmployee(Employee source)
        {
            if (source != null)
            {
                source.IsActive = true;
                _employeeRepository.Upsert(source);
            }
        }

        public IEnumerable<Employee> GetActiveEmployeesByTeam(Team team)
        {
            return _employeeRepository.GetAll()
                .Where(x => x.TeamId == team.TeamId && x.IsActive == true)
                .OrderBy(x => x.LastName)
                .ToList();
        }

        public IEnumerable<Employee> GetAllEmployeesByTeam(Team team)
        {
            return _employeeRepository.GetAll()
                .Where(x => x.TeamId == team.TeamId).ToList();
        }

        public Employee GetCurrentEmployee(string emailAddress)
        {
            throw new NotImplementedException();
        }

        public void ReassignEmployee(Employee source, Team newTeam)
        {
            if (source != null && newTeam != null)
            {
                source.TeamId = newTeam.TeamId;
                _employeeRepository.Upsert(source);
            }
        }

        public Employee UpsertEmployee(Employee source)
        {
            if (source != null)
            {
                _employeeRepository.Upsert(source);
            }
            return source;
        }
    }
}
