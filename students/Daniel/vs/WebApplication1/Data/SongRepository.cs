using Microsoft.Data.SqlClient;
using System.Data;
using WebApplication1.Models;

namespace WebApplication1.Data
{

    public class SongRepository 
    {
        private SqlConnection sqlConnection;
        static string connectionString = "Server=L-01452019\\SQL2022;Database=LyricsWorld1;Trusted_Connection=True;TrustServerCertificate=True;";

        public List<Piosenka> GetAllSongs()
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                List<Piosenka> piosenka = new List<Piosenka>();
                SqlCommand cmd = new SqlCommand("GetAllSongs", sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    piosenka.Add(new Piosenka
                    {
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

        public bool EditSong(int Id, Piosenka song)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateSongs", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@SongID", Id);
                sqlCommand.Parameters.AddWithValue("@SongTitle", song.SongTitle);
                sqlCommand.Parameters.AddWithValue("@SongDuration", song.SongDuration);
                sqlCommand.Parameters.AddWithValue("@SongLyrics", song.SongLyrics);
                sqlCommand.Parameters.AddWithValue("@SongGenre", song.SongGenre);

                sqlConnection.Open();
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    sqlConnection.Close();
                    return false;
                }
            }
        }

        public Piosenka GetSongById(int SongID)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                List<Piosenka> piosenka = new List<Piosenka>();
                SqlCommand cmd = new SqlCommand("GetSongById", sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Id", SongID);
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();



                while (reader.Read())
                {
                    piosenka.Add(new Piosenka()
                    {
                        SongID = Convert.ToInt32(reader["SongID"]),
                        SongTitle = reader["SongTitle"].ToString(),
                        SongDuration = Convert.ToInt32(reader["SongDuration"]),
                        SongLyrics = reader["SongLyrics"].ToString(),
                        SongGenre = reader["SongGenre"].ToString()
                    });


                }
                sqlConnection.Close();
                return piosenka[0];
            }
        }


        public bool DeleteSong(int SongID)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Songs WHERE SongID=" + SongID + ";DELETE FROM ConnectDB WHERE IDsong=" + SongID + ";", sqlConnection);

                sqlConnection.Open();

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    return true;
                }
                catch
                {
                    sqlConnection.Close();
                    return false;
                }
            }
        }

        public bool AddNewSong(Piosenka piosenka)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Songs ([SongTitle],[SongDuration],[SongLyrics],[SongGenre]) " +
                "VALUES ('" + piosenka.SongTitle + "'," + piosenka.SongDuration + ",'" +
                piosenka.SongLyrics + "','" + piosenka.SongGenre + "')", sqlConnection);

                sqlConnection.Open();

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    return true;
                }
                catch { sqlConnection.Close(); return false; }
            }
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