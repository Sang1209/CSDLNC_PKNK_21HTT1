using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKNK_App.BUS
{
    public class NhaSiBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;
        public IList<NhaSiDTO> layDSNhaSi()
        {
            List<NhaSiDTO> dsNhaSi = new List<NhaSiDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("Select * from account_de", connection))
                    {
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {

                            while (Reader.Read())
                            {
                                dsNhaSi.Add(new NhaSiDTO()
                                {
                                    username = Reader["username"].ToString(),
                                    password = Reader["password"].ToString(),
                                    name = Reader["name"].ToString(),
                                    phone = Reader["phone"].ToString(),
                                    email = Reader["email"].ToString(),
                                    address = Reader["address"].ToString(),
                                    gender=Convert.ToBoolean(Reader.GetOrdinal("gender")),
                                    depID=Convert.ToInt32(Reader.GetOrdinal("department")),
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return dsNhaSi;
        }
    }
}
