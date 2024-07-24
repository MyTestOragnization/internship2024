using Test1.Models;
using Microsoft.Data.SqlClient;
using System.ComponentModel.Design;


namespace Test1.Dal
{
    public class CompanyToDevRepository
    {
        //        const string connectionString =
        //            "data source=DESKTOP-QFG274R\\SQL2022; initial catalog=test1; Integrated Security=true; trusted_connection=true";
        const string connectionString =
        "Data Source=DESKTOP-QFG274R\\SQL2022;Initial Catalog=test1;"
    + "Integrated Security=true; TrustServerCertificate=True";
        public List<ComToDev> GetDeveloped(int companyId)
        {
            var res = new List<ComToDev>();

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new(connectionString))
            {
                var queryString = $"select G.* from dbo.Game G inner join dbo.GameToDeveloper MTM on MTM.IdGame = G.Id inner join dbo.Company Au on Au.Id = MTM.IdCompany Where IdCompany = {companyId};";

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
                        ComToDev Developed = new ComToDev();

                        Developed.Id = reader.GetInt32(0);
                        Developed.Name = reader.GetString(1);
                        Developed.Genre = reader.GetString(2);
                        Developed.Release = reader.GetString(3);
                        Developed.Price = reader.GetString(4);
                        res.Add(Developed);
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
