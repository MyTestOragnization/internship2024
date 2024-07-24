using Test1.Models;
using Microsoft.Data.SqlClient;


namespace Test1.Dal
{
    public class SGRepository
    {
        //        const string connectionString =
        //            "data source=DESKTOP-QFG274R\\SQL2022; initial catalog=test1; Integrated Security=true; trusted_connection=true";
        const string connectionString =
        "Data Source=DESKTOP-QFG274R\\SQL2022;Initial Catalog=test1;"
    + "Integrated Security=true; TrustServerCertificate=True";
        public List<SG> GetSGames(string GName)
        {
            var res = new List<SG>();

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new(connectionString))
            {
                var queryString = $"select * from dbo.Game Where Name = '{GName}';";

                // Create the Command and Parameter objects.
                SqlCommand command = new(queryString, connection);
                //command.Parameters.AddWithValue("GName", GName);
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
                        SG SG = new SG();

                        SG.Id = reader.GetInt32(0);
                        SG.Name = reader.GetString(1);
                        SG.Genre = reader.GetString(2);
                        SG.Release = reader.GetString(3);
                        SG.Price = reader.GetString(4);
                        res.Add(SG);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }

                return res;
            }
        }
    }
}
