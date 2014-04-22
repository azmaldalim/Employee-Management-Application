using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using EmployeeApp.Model;

namespace EmployeeApp.DataAccess
{
    public class GradeGateway
    {
        private string connectionString = null;

        public GradeGateway()
        {
            connectionString =
                ConfigurationManager.ConnectionStrings["employeemanagementDBConectionString"].ConnectionString;
        }

        public string Save(Grade aGrade)
        {
            string query = "INSERT INTO t_grade VALUES ('" + aGrade.GradeLevel + "'," + aGrade.BasicAmount + "," + aGrade.MedicalAllowance + "," + aGrade.HouseRent + ")";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return "Grade saved";
        }

        public List<Grade> GetAll()
        {
            string query = "SELECT * FROM t_grade";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            List<Grade> grades = new List<Grade>();
            while (sqlDataReader.Read())
            {
                Grade aGrade = new Grade();
                aGrade.Id = Convert.ToInt32(sqlDataReader[0]);
                aGrade.GradeLevel = sqlDataReader[1].ToString();
                aGrade.BasicAmount = Convert.ToDouble(sqlDataReader[2]);
                aGrade.MedicalAllowance = Convert.ToDouble(sqlDataReader[3]);
                aGrade.HouseRent = Convert.ToDouble(sqlDataReader[4]);
                grades.Add(aGrade);

            }

            sqlConnection.Close();
            return grades;

        }

        public Grade Get(int gradeId)
        {
            string query = "SELECT * FROM t_grade WHERE id = '" + gradeId + "'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                sqlDataReader.Read();
                Grade aGrade = new Grade();
                aGrade.GradeLevel = sqlDataReader[1].ToString();
                aGrade.BasicAmount = Convert.ToDouble(sqlDataReader[2]);
                aGrade.MedicalAllowance = Convert.ToDouble(sqlDataReader[3]);
                aGrade.HouseRent = Convert.ToDouble(sqlDataReader[4]);
                sqlConnection.Close();
                return aGrade;
            }

            sqlConnection.Close();
            return null;
        }

        public string Assign(int employeeId, int gradeId)
        {
            string query = "INSERT INTO t_employee_grade VALUES (" + employeeId + "," + gradeId + ")";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return "Grade Assigned";
        }
    }
}
