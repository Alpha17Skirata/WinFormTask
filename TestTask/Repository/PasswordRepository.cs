using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Model;
using System.Data;
using System.Data.SqlClient;

namespace TestTask.Repository
{
    public class PasswordRepository : BaseRepository, IPasswordRepository
    {
        public PasswordRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public bool CheckPassword(Password password)
        {
            var passwords = new List<string>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT Password_value FROM dbo.Password WHERE Password_value = @password;";
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password.PasswordValue;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string passwrd = reader[0].ToString();
                        passwords.Add(passwrd);
                    }
                }
                if (passwords.Count != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void ChangePassword(Password password)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE dbo.Password SET Password_value = @password WHERE Id = @id;";
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password.PasswordValue;
                command.Parameters.Add("@id", SqlDbType.Int).Value = password.Id;
                command.ExecuteNonQuery();
            }
        }
    }
}
