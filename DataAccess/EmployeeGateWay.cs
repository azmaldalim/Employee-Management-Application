using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using EmployeeApp.Model;
using System.Configuration;

namespace EmployeeApp.DataAccess
{
    internal class EmployeeGateWay
    {
        private string connectionString = null;

        public EmployeeGateWay()
        {
            connectionString =
                ConfigurationManager.ConnectionStrings["employeemanagementDBConectionString"].ConnectionString;
        }

        public string Save(Employee anEmployee)
        {
            string query = "INSERT INTO t_employee(name, email, contact, department_id, joiningdate)" +
                           " VALUES ('" + anEmployee.Name + "','" + anEmployee.Email + "','" +
                           anEmployee.Contact + "'," + anEmployee.DepartmentId + ",'" + anEmployee.JoiningDate + "')";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return "Employee saved";
        }

        public Employee Get(int employeeId)
        {
            string query = "SELECT * FROM t_employee WHERE id = '" + employeeId + "'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                sqlDataReader.Read();
                Employee aEmployee = new Employee();
                aEmployee.Name = sqlDataReader[1].ToString();
                aEmployee.Email = sqlDataReader[2].ToString();
                aEmployee.Contact = sqlDataReader[3].ToString();
                aEmployee.DepartmentId = Convert.ToInt32(sqlDataReader[4]);
                aEmployee.JoiningDate = Convert.ToDateTime(sqlDataReader[5]);
                sqlConnection.Close();
                return aEmployee;
            }

            sqlConnection.Close();
            return null;
        }

        public List<ViewAllEmployee> GetAllByDepartment(int someDeptId)
        {
            string query = "SELECT t_employee.id, t_employee.name, t_employee.email, t_employee.department_id, t_grade.id, t_grade.basicAmount, t_grade.medicalAllowence, t_grade.houseRent FROM t_employee INNER JOIN t_employee_grade ON t_employee.id=t_employee_grade.employee_id INNER JOIN t_grade ON t_employee_grade.grade_id=t_grade.id WHERE department_id = " + someDeptId +"";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();



            List<ViewAllEmployee> viewAllEmployees = new List<ViewAllEmployee>();
            while (sqlDataReader.Read())
            {
                ViewAllEmployee aViewAllEmployee = new ViewAllEmployee();
                aViewAllEmployee.Id = Convert.ToInt32(sqlDataReader[0]);
                aViewAllEmployee.Name = sqlDataReader[1].ToString();
                aViewAllEmployee.Email = sqlDataReader[2].ToString();
                aViewAllEmployee.DepartmentId = (int)sqlDataReader[3];
                aViewAllEmployee.GradeId = (int)sqlDataReader[4];
                aViewAllEmployee.BasicAmount = (double)sqlDataReader[5];
                aViewAllEmployee.MedicalAmount = (double)sqlDataReader[6];
                aViewAllEmployee.HouseRent = (double)sqlDataReader[7];
                viewAllEmployees.Add(aViewAllEmployee);

            }

            sqlConnection.Close();
            return viewAllEmployees;

        }
    }
}