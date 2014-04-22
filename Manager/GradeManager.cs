using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeApp.DataAccess;
using EmployeeApp.Model;

namespace EmployeeApp.Manager
{
    public class GradeManager
    {
        GradeGateway aGradeGateway = new GradeGateway();

        public string Save(Grade someGrade)
        {
            
            return aGradeGateway.Save(someGrade);
        }

        public List<Grade> GetAll()
        {
            return aGradeGateway.GetAll();
        }

        public Grade Get(int someGradeId)
        {
            return aGradeGateway.Get(someGradeId);
        }

        public string Assign(int employeeId, int gradeId)
        {
            return aGradeGateway.Assign(employeeId, gradeId);
        }
    }
}
