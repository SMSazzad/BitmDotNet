using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using StudentApp.Model.Model;

namespace StudentRepository.Repository
{
    public class SRepository
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        string commandString;
        string connectionString = @"server=HP-PC; Database=student; Integrated Security=True";

        public int Save(Student student)
        {
            commandString = @"insert into info values('" + student.Name + "','" + student.RollNo + "','" + student.Contact + "','" + student.Email + "')";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecuted = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return isExecuted;
        }

        public DataTable Show()
        {
            commandString = @"select *from info";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public int Delete(string roll)
        {
            commandString = @"delete from info where Roll='"+roll+"'";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isDeleted = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return isDeleted;
        }

        public int Update(Student student, string roll)
        {
            commandString = @"update info set Roll='" + student.RollNo + "',Name='"+student.Name+"',Contact='"+student.Contact+"',Email='"+student.Email+"' where Roll = '"+roll+"'";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isUpdated = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return isUpdated;
        }

        public DataTable Search(string roll)
        {
            commandString = @"select *from info where Roll='"+roll+"'";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
    }
}
