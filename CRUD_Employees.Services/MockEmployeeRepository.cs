﻿using CRUD_Employees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CRUD_Employees.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee()
                {
                    Id = 0, Name = "Mary", Email = "mary@example.com", PhotoPath = "avatar2.png", Department = Dept.HR
                },
                new Employee()
                {
                    Id = 1, Name = "mark", Email = "mark@example.com", PhotoPath = "avatar.png", Department = Dept.IT
                },
                new Employee()
                {
                    Id = 2, Name = "Kolyan", Email = "demonick@example.com", PhotoPath = "avatar4.png", Department = Dept.IT
                },
                new Employee()
                {
                    Id = 3, Name = "Shawn", Email = "shawn@example.com", PhotoPath = "avatar5.png", Department = Dept.Payroll
                },
                new Employee()
                {
                    Id = 4, Name = "jenifer", Email = "jenifer@example.com", PhotoPath = "avatar3.png", Department = Dept.HR
                },
                new Employee()
                {
                    Id = 5, Name = "Sten", Email = "sten@example.com", Department = Dept.Payroll
                },

            };
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }
    }
}
