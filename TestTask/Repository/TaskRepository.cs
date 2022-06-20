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

        public void Add(HumanModel humanModel, AddressModel addressModel, PhoneNumberModel phoneNumberModel)
        {
                var dbAddress = new List<AddressModel>();
                int addressId;
                int phoneNumberId = default(int);
                string? phoneNumber = default(string?);
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM dbo.Addresses " +
                                          "WHERE Name=@AddressName " +
                                          "AND House_number=@houseNumber;";
                    command.Parameters.Add("@AddressName", SqlDbType.NVarChar).Value = addressModel.AddressName;
                    command.Parameters.Add("@houseNumber", SqlDbType.Int).Value = addressModel.HouseNumber;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var addressModelCheck = new AddressModel();
                            addressModel.Id = (int)reader[0];
                            addressModel.AddressName = reader[1].ToString();
                            addressModel.HouseNumber = (int)reader[2];
                            dbAddress.Add(addressModel);
                        }
                    }
                    if (dbAddress.Count == 0)
                    {
                        command.CommandText = "INSERT INTO dbo.Addresses values (@Address_name, @house_Number); " +
                                              "SELECT CAST(scope_identity() AS int);";
                        command.Parameters.Add("@Address_name", SqlDbType.NVarChar).Value = addressModel.AddressName;
                        command.Parameters.Add("@house_Number", SqlDbType.Int).Value = addressModel.HouseNumber;
                        addressId = (int)command.ExecuteScalar();
                        command.CommandText = "SELECT Id FROM dbo.Numbers " +
                                              "WHERE Phone_number = @phoneNumberCheck;";
                        command.Parameters.Add("@phoneNumberCheck", SqlDbType.NVarChar).Value = phoneNumberModel.Number;
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                phoneNumberId = (int)reader[0];
                            }
                        }
                        if (phoneNumberId != 0)
                        {
                            throw new Exception("Такой номер уже привязан к другому адрессу");
                        }
                        else
                        {
                            command.CommandText = "INSERT INTO dbo.Numbers values (@phoneNumber); " +
                                                  "SELECT CAST(scope_identity() AS int);";
                            command.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = phoneNumberModel.Number;
                            phoneNumberId = (int)command.ExecuteScalar();
                            command.CommandText = "INSERT INTO dbo.Humen values (@name, @surname, @middlename, @birthday, @phoneNumberId, @addressId, @flat);";
                            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = humanModel.Name;
                            command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = humanModel.Surname;
                            command.Parameters.Add("@middlename", SqlDbType.NVarChar).Value = humanModel.MiddleName;
                            command.Parameters.Add("@birthday", SqlDbType.Date).Value = humanModel.Birthday;
                            command.Parameters.Add("@phoneNumberId", SqlDbType.Int).Value = phoneNumberId;
                            command.Parameters.Add("@addressId", SqlDbType.Int).Value = addressId;
                            command.Parameters.Add("@flat", SqlDbType.Int).Value = humanModel.Flat;
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        addressId = dbAddress.ElementAt(0).Id;
                        command.CommandText = "SELECT n.Id, n.Phone_number FROM dbo.Humen as h " +
                                              "JOIN dbo.Numbers as n ON h.Number_id = n.Id " +
                                              "WHERE h.Flat = @flat1 " +
                                              "AND h.Address_id = @address_Id;";
                        command.Parameters.Add("@flat1", SqlDbType.Int).Value = humanModel.Flat;
                        command.Parameters.Add("@address_Id", SqlDbType.Int).Value = addressId;
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                phoneNumberId = (int)reader[0];
                                phoneNumber = reader[1].ToString();
                            }
                        }
                        if (phoneNumberId != 0)
                        {
                            if (phoneNumber.Equals(phoneNumberModel.Number))
                            {
                                command.CommandText = "INSERT INTO dbo.Humen values (@name1, @surname1, @middlename1, @birthday1, @phoneNumberId1, @address_Id1, @flat2);";
                                command.Parameters.Add("@name1", SqlDbType.NVarChar).Value = humanModel.Name;
                                command.Parameters.Add("@surname1", SqlDbType.NVarChar).Value = humanModel.Surname;
                                command.Parameters.Add("@middlename1", SqlDbType.NVarChar).Value = humanModel.MiddleName;
                                command.Parameters.Add("@birthday1", SqlDbType.Date).Value = humanModel.Birthday;
                                command.Parameters.Add("@phoneNumberId1", SqlDbType.Int).Value = phoneNumberId;
                                command.Parameters.Add("@address_Id1", SqlDbType.Int).Value = addressId;
                                command.Parameters.Add("@flat2", SqlDbType.Int).Value = humanModel.Flat;
                                command.ExecuteNonQuery();
                            }
                            else
                            {
                                throw new Exception("К этой квартире уже прикреплен другой номер");
                            }
                        }
                        else
                        {
                            command.CommandText = "SELECT Id FROM dbo.Numbers " +
                                                  "WHERE Phone_number = @phoneNumberCheck1;";
                            command.Parameters.Add("@phoneNumberCheck1", SqlDbType.NVarChar).Value = phoneNumberModel.Number;
                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    phoneNumberId = (int)reader[0];
                                }
                            }
                            if (phoneNumberId != 0)
                            {
                                throw new Exception("Такой номер уже привязан к другой квартире");
                            }
                            else
                            {
                                command.CommandText = "INSERT INTO dbo.Numbers values (@phoneNumber1); " +
                                                      "SELECT CAST(scope_identity() AS int);";
                                command.Parameters.Add("@phoneNumber1", SqlDbType.NVarChar).Value = phoneNumberModel.Number;
                                phoneNumberId = (int)command.ExecuteScalar();
                                command.CommandText = "INSERT INTO dbo.Humen values (@name1, @surname1, @middlename1, @birthday1, @phoneNumberId1, @address_Id1, @flat2);";
                                command.Parameters.Add("@name1", SqlDbType.NVarChar).Value = humanModel.Name;
                                command.Parameters.Add("@surname1", SqlDbType.NVarChar).Value = humanModel.Surname;
                                command.Parameters.Add("@middlename1", SqlDbType.NVarChar).Value = humanModel.MiddleName;
                                command.Parameters.Add("@birthday1", SqlDbType.Date).Value = humanModel.Birthday;
                                command.Parameters.Add("@phoneNumberId1", SqlDbType.Int).Value = phoneNumberId;
                                command.Parameters.Add("@address_Id1", SqlDbType.Int).Value = addressId;
                                command.Parameters.Add("@flat2", SqlDbType.Int).Value = humanModel.Flat;
                                command.ExecuteNonQuery();
                            }
                        }
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
                command.CommandText = "SELECT h.Name, h.Surname, h.Middle_name, h.Birthday, n.Phone_number, a.Name, a.House_number, h.Flat FROM dbo.Humen as h " +
                                      "JOIN dbo.Addresses as a ON h.Address_id = a.Id " +
                                      "JOIN dbo.Numbers as n ON h.Number_id = n.Id " +
                                      "WHERE (h.Name = @humanName OR @humanName IS NULL) " +
                                      "AND (h.Surname = @surname OR @surname IS NULL) " +
                                      "AND (h.Middle_name = @middleName OR @middleName IS NULL) " +
                                      "AND (h.Birthday = @birthday OR @birthday IS NULL) " +
                                      "AND (n.Phone_number = @phoneNumber OR @phoneNumber IS NULL) " +
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
