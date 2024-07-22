using test4.Models;
using Microsoft.Data.SqlClient;


namespace test4.Dal
{
    public class UsersRepository
    {
        const string connectionString =
            "Data Source=ACER_NITRO_5\\SQL2022;Initial Catalog=test2;"
            + "Integrated Security=true; TrustServerCertificate=True";
        public List<Users> GetUsers()
        {
            var res = new List<Users>();

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new(connectionString))
            {
                var queryString = "select * from dbo.Users ;";

                // Create the Command and Parameter objects.
                SqlCommand command = new(queryString, connection);
                //command.Parameters.AddWithValue("@pricePoint", paramValue);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Users users = new Users();

                        users.Id = reader.GetInt32(0);
                        users.Name = reader.GetString(1);
                        users.LanstName = reader.GetString(2);
                        users.Password = reader.GetString(3);
                        res.Add(users);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return res;
        }



        public List<Users> GetUser(int Id)
        {
            var res = new List<Users>();

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new(connectionString))
            {
                var queryString = "select * from dbo.Users WHERE Id =@id;";

                SqlCommand command = new(queryString, connection);
                command.Parameters.Add(new SqlParameter("id", Id));

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    Users users = new Users();

                    users.Id = reader.GetInt32(0);
                    users.Name = reader.GetString(1);
                    users.LanstName = reader.GetString(2);
                    users.Password = reader.GetString(3);
                    res.Add(users);
                    
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return res;
            }

        }

        public void AddUser(Users u)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                var queryUpdate = "INSERT INTO dbo.Users (Name,LanstName,Password) VALUES (@Name , @LanstName, @Password)";

                SqlCommand cmdUpdate = new(queryUpdate, connection);
                cmdUpdate.Parameters.Add(new SqlParameter("Name",u.Name));
                cmdUpdate.Parameters.Add(new SqlParameter("LanstName", u.LanstName));
                cmdUpdate.Parameters.Add(new SqlParameter("Password", u.Password));
                cmdUpdate.ExecuteNonQuery();
            }
        }


        public void EditUser(Users u)
        {
               
            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                var queryUpdate = "update dbo.Users set Name = @name , LanstName = @lastName, Password = @password Where Id = @id;";

                SqlCommand cmdUpdate = new(queryUpdate, connection);
                cmdUpdate.Parameters.Add(new SqlParameter("id", u.Id));
                cmdUpdate.Parameters.Add(new SqlParameter("name", u.Name));
                cmdUpdate.Parameters.Add(new SqlParameter("lastName", u.LanstName));
                cmdUpdate.Parameters.Add(new SqlParameter("password", u.Password));
                cmdUpdate.ExecuteNonQuery();
            }

        }

        public void DeleteUser(int u)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                var queryUpdate = "UPDATE dbo.Sale SET IdUser = 1 WHERE IdUser = @IdUser;";
                SqlCommand cmdUpdate = new(queryUpdate, connection);
                cmdUpdate.Parameters.Add(new SqlParameter("IdUser", u));
                cmdUpdate.ExecuteNonQuery();

                var queryDelete = "DELETE FROM dbo.Users WHERE Id=@Id;";
                SqlCommand cmdDelete = new(queryDelete, connection);
                cmdDelete.Parameters.Add(new SqlParameter("Id", u));

                cmdDelete.ExecuteNonQuery();
            }

        }

    }
}
