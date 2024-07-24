using Test1.Models;
using Microsoft.Data.SqlClient;


namespace Test1.Dal
{
    public class GameToPubRepository
    {
        //        const string connectionString =
        //            "data source=DESKTOP-QFG274R\\SQL2022; initial catalog=test1; Integrated Security=true; trusted_connection=true";
        const string connectionString =
        "Data Source=DESKTOP-QFG274R\\SQL2022;Initial Catalog=test1;"
    + "Integrated Security=true; TrustServerCertificate=True";
        public List<GameToPub> GetGamePubs(int gameId)
        {
            var res = new List<GameToPub>();

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new(connectionString))
            {
                var gameID = gameId;
                var queryString = $"select Au.* from dbo.Game G inner join dbo.GameToPublisher MTM on MTM.IdGame = G.Id inner join dbo.Company Au on Au.Id = MTM.IdCompany Where IdGame = {gameID};";

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
                        GameToPub GamePub = new GameToPub();

                        GamePub.Id = reader.GetInt32(0);
                        GamePub.Name = reader.GetString(1);
                        GamePub.Country = reader.GetString(2);
                        GamePub.CEO = reader.GetString(3);
                        GamePub.Estabilished = reader.GetString(4);
                        res.Add(GamePub);
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
