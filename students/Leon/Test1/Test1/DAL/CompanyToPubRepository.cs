using Test1.Models;
using Microsoft.Data.SqlClient;
using System.ComponentModel.Design;


namespace Test1.Dal
{
    public class CompanyToPubRepository
    {
        //        const string connectionString =
        //            "data source=DESKTOP-QFG274R\\SQL2022; initial catalog=test1; Integrated Security=true; trusted_connection=true";
        const string connectionString =
        "Data Source=DESKTOP-QFG274R\\SQL2022;Initial Catalog=test1;"
    + "Integrated Security=true; TrustServerCertificate=True";
        public List<ComToPub> GetPublished(int companyId)
        {
            var res = new List<ComToPub>();

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new(connectionString))
            {
                var queryString = $"select G.* from dbo.Game G inner join dbo.GameToPublisher MTM on MTM.IdGame = G.Id inner join dbo.Company Au on Au.Id = MTM.IdCompany Where IdCompany = {companyId};";
 //               var queryString = $"select MTM.* from dbo.Game G inner join dbo.GameToPublisher MTM on MTM.IdGame = G.Id inner join dbo.Company Au on Au.Id = MTM.IdCompany Where IdCompany = @companyId;";



                // sql injection
                // CdProjct'; drop database test2;

                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                //command.Parameters.AddWithValue("companyId", companyId);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ComToPub Published = new ComToPub();

                        Published.Id = reader.GetInt32(0);
                        Published.Name = reader.GetString(1);
                        Published.Genre = reader.GetString(2);
                        Published.Release = reader.GetString(3);
                        Published.Price = reader.GetString(4);
                        res.Add(Published);
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
