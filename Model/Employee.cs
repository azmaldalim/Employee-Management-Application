using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeApp.Model
{
    class Employee
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string Contact { set; get; }
        public DateTime JoiningDate { set; get; }
        public int DepartmentId { set; get; }
    }
}
