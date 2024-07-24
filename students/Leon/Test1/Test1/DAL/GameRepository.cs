using Test1.Models;
using Microsoft.Data.SqlClient;


namespace Test1.Dal
{
    public class GameRepository
    {
        //        const string connectionString =
        //            "data source=DESKTOP-QFG274R\\SQL2022; initial catalog=test1; Integrated Security=true; trusted_connection=true";
        const string connectionString =
        "Data Source=DESKTOP-QFG274R\\SQL2022;Initial Catalog=test1;"
    + "Integrated Security=true; TrustServerCertificate=True";
        public List<Game> GetGames()
        {
            var res = new List<Game>();

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new(connectionString))
            {
                var queryString = "select * from dbo.Game ;";

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
                        Game Game = new Game();

                        Game.Id = reader.GetInt32(0);
                        Game.Name = reader.GetString(1);
                        Game.Genre = reader.GetString(2);
                        Game.Release = reader.GetString(3);
                        Game.Price = reader.GetString(4);
                        res.Add(Game);
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
