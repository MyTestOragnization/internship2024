using test4.Models;
using Microsoft.Data.SqlClient;


namespace test4.Dal
{
    public class AlbumRepository
    {
        const string connectionString =
            "Data Source=ACER_NITRO_5\\SQL2022;Initial Catalog=test2;"
            + "Integrated Security=true; TrustServerCertificate=True";
        public List<Album> GetAlbumy()
        {
            var res = new List<Album>();

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new(connectionString))
            {
                var queryString = "select * from dbo.Album ;";

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
                        Album album = new Album();

                        album.Id = reader.GetInt32(0);
                        album.AlbumName = reader.GetString(1);
                        album.YearReleaseAlbum = reader.GetString(2);
                        album.MadeIn = reader.GetString(3);
                        album.Price = reader.GetString(4);
                        album.Amount = reader.GetInt32(5);
                        res.Add(album);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return res;
            }
        }
    }
}
