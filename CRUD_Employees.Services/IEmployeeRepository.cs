using CRUD_Employees.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Employees.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
    }
}
