using Test1.Models;
using Microsoft.Data.SqlClient;


namespace Test1.Dal
{
    public class GameToDevRepository
    {
        //        const string connectionString =
        //            "data source=DESKTOP-QFG274R\\SQL2022; initial catalog=test1; Integrated Security=true; trusted_connection=true";
        const string connectionString =
        "Data Source=DESKTOP-QFG274R\\SQL2022;Initial Catalog=test1;"
    + "Integrated Security=true; TrustServerCertificate=True";
        public List<GameToDev> GetGameDevs(int gameId)
        {
            var res = new List<GameToDev>();

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new(connectionString))
            {
                var gameID = gameId;
                var queryString = $"select Au.* from dbo.Game G inner join dbo.GameToDeveloper MTM on MTM.IdGame = G.Id inner join dbo.Company Au on Au.Id = MTM.IdCompany Where IdGame = {gameId};";

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
                        GameToDev GameDev = new GameToDev();

                        GameDev.Id = reader.GetInt32(0);
                        GameDev.Name = reader.GetString(1);
                        GameDev.Country = reader.GetString(2);
                        GameDev.CEO = reader.GetString(3);
                        GameDev.Estabilished = reader.GetString(4);
                        res.Add(GameDev);
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
