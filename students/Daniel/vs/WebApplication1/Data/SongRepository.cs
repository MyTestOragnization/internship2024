using Microsoft.Data.SqlClient;
using System.Data;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class SongRepository
    {
        private SqlConnection sqlConnection;

        public SongRepository()
        {
            string connectionString = "Server=L-01452019\\SQL2022;Database=LyricsWorld1;Trusted_Connection=True;TrustServerCertificate=True;";
            sqlConnection = new SqlConnection(connectionString);
        }
        public List<TestPiosenka> GetAllSongs()
        {
            List<TestPiosenka> piosenka = new List<TestPiosenka>();
            SqlCommand cmd = new SqlCommand("GetAllSongs", sqlConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            
            adapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                piosenka.Add(new TestPiosenka { 
                    SongID = Convert.ToInt32(row["SongID"]),
                    SongTitle = row["SongTitle"].ToString(),    
                    SongDuration = Convert.ToInt32(row["SongDuration"]),
                    SongLyrics = row["SongLyrics"].ToString(),
                    SongGenre = row["SongGenre"].ToString()
                });
            }
            return piosenka;
        }
    }
}



//try
//{
//    string connectionString = "Server=L-01452019\\SQL2022;Database=LyricsWorld1;Trusted_Connection=True;TrustServerCertificate=True;";
//    string query = "SELECT * FROM dbo.Songs";

//    using (SqlConnection conn = new SqlConnection(connectionString))
//    {
//        conn.Open();
//        Console.WriteLine("jest ok");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Something Went Wrong: {ex.Message}");
//}