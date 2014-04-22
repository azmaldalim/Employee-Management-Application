using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeApp.Model
{
    public class Grade
    {
        public int Id { set; get; }
        public string GradeLevel { set; get; }
        public double BasicAmount { set; get; }
        public double MedicalAllowance { set; get; }
        public double HouseRent { set; get; }
        public double GetTotalSalary()
        {
            return BasicAmount + GetHouseRentAmount() + GetMedicalAmount();
        }

        public double GetMedicalAmount()
        {
            return (BasicAmount*MedicalAllowance)/100;
        }

        public double GetHouseRentAmount()
        {
            return (BasicAmount * HouseRent) / 100;
        }

    }

    
}
