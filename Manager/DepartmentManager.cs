using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeApp.DataAccess;
using EmployeeApp.Model;

namespace EmployeeApp.Manager
{
    class DepartmentManager
    {
        DepartmentGateway aDepartmentGateway = new DepartmentGateway();
        public string Save(Department aDepartment)
        {
            if (aDepartment.Name.Length <= 5)
            {
                return "Department name must be 6 (or more) char long";
            }

            if (aDepartmentGateway.Get(aDepartment.Code) != null)
            {
                return "Code of this department already exists in your system";
            }

            return aDepartmentGateway.Save(aDepartment);
        }

        public List<Department> GetAll()
        {
            return aDepartmentGateway.GetAll();
        }

        public List<Employee> GetAllEmployees(int theDepartmentId)
        {
            return aDepartmentGateway.GetAllEmployees(theDepartmentId);
        } 
    }
}
