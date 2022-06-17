using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Model;
using System.Data;
using System.Windows.Forms;

namespace TestTask.Repository
{
    public class TaskRepository : BaseRepository, ITaskRepository
    {
        public TaskRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(Human human, Address address)
        {
            var dbPhoneNumbers = new List<string>();
            var dbAddress = new List<Address>();
            int id;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT PhoneNumber FROM dbo.Humen WHERE PhoneNumber = @phoneNumberCheck";
                command.Parameters.Add("@phoneNumberCheck", SqlDbType.NVarChar).Value = human.Number;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string phoneNumber = reader[0].ToString();
                        dbPhoneNumbers.Add(phoneNumber);
                    }
                }
                if (dbPhoneNumbers.Count != 0)
                {
                    throw new Exception("Такой номер уже есть в базе данных");
                }
                else
                {
                    command.CommandText = "SELECT * FROM dbo.Addresses WHERE Name=@AddressName AND House_number=@houseNumber;";
                    command.Parameters.Add("@AddressName", SqlDbType.NVarChar).Value = address.AddressName;
                    command.Parameters.Add("@houseNumber", SqlDbType.Int).Value = address.HouseNumber;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var addressModel = new Address();
                            addressModel.Id = (int)reader[0];
                            addressModel.AddressName = reader[1].ToString();
                            addressModel.HouseNumber = (int)reader[2];
                            dbAddress.Add(addressModel);
                        }
                    }
                    if (dbAddress.Count == 0)
                    {
                        command.CommandText = "INSERT INTO dbo.Addresses values (@Address_name, @house_Number); SELECT CAST(scope_identity() AS int);";
                        command.Parameters.Add("@Address_name", SqlDbType.NVarChar).Value = address.AddressName;
                        command.Parameters.Add("@house_Number", SqlDbType.Int).Value = address.HouseNumber;
                        id = (int)command.ExecuteScalar();
                    }
                    else
                    {
                        id = dbAddress.ElementAt(0).Id;
                    }
                    command.CommandText = "INSERT INTO dbo.Humen values (@name, @surname, @middlename, @birthday, @phoneNumber, @addressId, @flat)";
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = human.Name;
                    command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = human.Surname;
                    command.Parameters.Add("@middlename", SqlDbType.NVarChar).Value = human.MiddleName;
                    command.Parameters.Add("@birthday", SqlDbType.Date).Value = human.Birthday;
                    command.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = human.Number;
                    command.Parameters.Add("@addressId", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@flat", SqlDbType.Int).Value = human.Flat;
                    command.ExecuteNonQuery();
                }
            }
        }


        public IEnumerable<UserFormViewModel> SearchUsingConditions(UserFormViewModel model)
        {
            var humen = new List<UserFormViewModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT h.Name, h.Surname, h.Middle_name, h.Birthday, h.PhoneNumber, a.Name, a.House_number, h.Flat FROM dbo.Humen as h JOIN dbo.Addresses as a on h.Address_id=a.Id " +
                                      "WHERE (h.Name = @humanName OR @humanName IS NULL) " +
                                      "AND (h.Surname = @surname OR @surname IS NULL) " +
                                      "AND (h.Middle_name = @middleName OR @middleName IS NULL) " +
                                      "AND (h.Birthday = @birthday OR @birthday IS NULL) " +
                                      "AND (h.PhoneNumber = @phoneNumber OR @phoneNumber IS NULL) " +
                                      "AND (a.Name = @addressName OR @addressName IS NULL) " +
                                      "AND (a.House_number = @houseNumber OR @houseNumber IS NULL) " +
                                      "AND (h.Flat = @flat OR @flat IS NULL);";
                command.Parameters.Add("@humanName", SqlDbType.NVarChar).Value = model.Name.Equals("") ? DBNull.Value : model.Name;
                command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = model.Surname.Equals("") ? DBNull.Value : model.Surname;
                command.Parameters.Add("@middleName", SqlDbType.NVarChar).Value = model.MiddleName.Equals("") ? DBNull.Value : model.MiddleName;
                command.Parameters.Add("@birthday", SqlDbType.Date).Value = model.Birthday.Equals(null) ? DBNull.Value : model.Birthday;
                command.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = model.Number.Equals("") ? DBNull.Value : model.Number;
                command.Parameters.Add("@addressName", SqlDbType.NVarChar).Value = model.AddressName.Equals("") ? DBNull.Value : model.AddressName;
                command.Parameters.Add("@houseNumber", SqlDbType.Int).Value = model.HouseNumber == null ? DBNull.Value : model.HouseNumber;
                command.Parameters.Add("@flat", SqlDbType.Int).Value = model.Flat == null ? DBNull.Value : model.Flat;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userFormViewModel = new UserFormViewModel();
                        userFormViewModel.Name = reader[0].ToString();
                        userFormViewModel.Surname = reader[1].ToString();
                        userFormViewModel.MiddleName = reader[2].ToString();
                        userFormViewModel.Birthday = (DateTime)reader[3];
                        userFormViewModel.Number = reader[4].ToString();
                        userFormViewModel.AddressName = reader[5].ToString();
                        userFormViewModel.HouseNumber = (int)reader[6];
                        userFormViewModel.Flat = (int)reader[7];
                        humen.Add(userFormViewModel);
                    }
                }
            }
            return humen;
        }
    }
}
