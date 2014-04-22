using System.Collections.Generic;
using EmployeeApp.DataAccess;
using EmployeeApp.Model;

namespace EmployeeApp.Manager
{
    internal class EmployeeManager
    {
        EmployeeGateWay anEmployeeGateway = new EmployeeGateWay();
        public string Save(Employee anEmployee)
        {
            
            return anEmployeeGateway.Save(anEmployee);
        }

        public Employee Get(int someEmployeeId)
        {
            return anEmployeeGateway.Get(someEmployeeId);
        }

        public List<ViewAllEmployee> GetAllByDepartment(int someDept)
        {
            return anEmployeeGateway.GetAllByDepartment(someDept);
        } 
    }
}