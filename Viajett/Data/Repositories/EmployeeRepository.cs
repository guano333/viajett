using Data.Interfaces;
using Domain;
using System;
using System.Collections.Generic;

namespace Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public void Delete(Guid employeeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(Guid employeeId)
        {
            throw new NotImplementedException();
        }

        public Employee Upsert(Employee source)
        {
            throw new NotImplementedException();
        }
    }
}
