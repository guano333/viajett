using Data.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public void Delete(Guid employeeId)
        {
            using (var context = new Viajett())
            {
                var employee = context.Employees.Where(x => x.EmployeeId == employeeId).FirstOrDefault();
                if (employee != null)
                {
                    context.Employees.Remove(employee);
                    context.SaveChanges();
                }
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            using (var context = new Viajett())
            {
                return context.Employees.ToList();
            }
        }

        public Employee GetById(Guid employeeId)
        {
            using (var context = new Viajett())
            {
                var employee = context.Employees.Where(x => x.EmployeeId == employeeId).FirstOrDefault();
                return employee;
            }
        }

        public Employee Upsert(Employee source)
        {
            if (source != null) {
                using (var context = new Viajett())
                {
                    var employee = context.Employees.Where(x => x.EmployeeId == source.EmployeeId).FirstOrDefault();
                    if (employee != null)
                    {
                        //update
                        employee.EmailAddress = source.EmailAddress;
                        employee.FirstName = source.FirstName;
                        employee.IsActive = source.IsActive;
                        employee.LastName = source.LastName;
                        employee.TeamId = source.TeamId;
                        context.SaveChanges();
                        return employee;
                    }
                    else
                    {
                        //insert
                        context.Employees.Add(source);
                        context.SaveChanges();
                        return employee;
                    }
                }
            }
            return null;
         }

    }
}
