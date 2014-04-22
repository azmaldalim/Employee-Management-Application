using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using EmployeeApp.Model;
using System.Configuration;

namespace EmployeeApp.DataAccess
{
    class DepartmentGateway
    {
        private string connectionString = null;

        public DepartmentGateway()
        {
            connectionString =
                ConfigurationManager.ConnectionStrings["employeemanagementDBConectionString"].ConnectionString;
        }

        public string Save(Department aDepartment)
        {
            string query = "INSERT INTO t_department(name, code) VALUES ('" + aDepartment.Name + "','" + aDepartment.Code + "')";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return "Department saved";
        }

        public Department Get(string code)
        {
            string query = "SELECT * FROM t_department WHERE code = '" + code + "'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                sqlDataReader.Read();
                Department aDepartment = new Department();
                aDepartment.Name = sqlDataReader[1].ToString();
                aDepartment.Code = sqlDataReader[2].ToString();
                sqlConnection.Close();
                return aDepartment;
            }

            sqlConnection.Close();
            return null;
        }

        public List<Department> GetAll()
        {
            string query = "SELECT * FROM t_department";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            List<Department> departments = new List<Department>();
            while(sqlDataReader.Read())
            {
                Department aDepartment = new Department();
                aDepartment.Id = Convert.ToInt32(sqlDataReader[0]); 
                aDepartment.Name = sqlDataReader[1].ToString();
                aDepartment.Code = sqlDataReader[2].ToString();
                departments.Add(aDepartment);
                
            }

            sqlConnection.Close();
            return departments;
            
        }

        public List<Employee> GetAllEmployees(int theDeaprtmentId)
        {
            string query = "SELECT * FROM t_employee WHERE department_id = '"+ theDeaprtmentId + "'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            List<Employee> employees = new List<Employee>();
            while (sqlDataReader.Read())
            {
                Employee aEmployee = new Employee();
                aEmployee.Id = Convert.ToInt32(sqlDataReader[0]);
                aEmployee.Name = sqlDataReader[1].ToString();
                aEmployee.Email = sqlDataReader[2].ToString();
                aEmployee.Contact = sqlDataReader[3].ToString();
                aEmployee.DepartmentId = Convert.ToInt32(sqlDataReader[4]);
                aEmployee.JoiningDate = Convert.ToDateTime(sqlDataReader[5]);
                employees.Add(aEmployee);

            }

            sqlConnection.Close();
            return employees;
        }
    }
}
