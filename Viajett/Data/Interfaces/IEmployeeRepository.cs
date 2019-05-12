using Domain;
using System;
using System.Collections.Generic;

namespace Data.Interfaces
{
    public interface IEmployeeRepository
    {
        Employee GetById(Guid employeeId);
        IEnumerable<Employee> GetAll();
        Employee Upsert(Employee source);
        void Delete(Guid employeeId);
    }
}
