using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPKNK_App.utils;

namespace QLPKNK_App.BUS
{
    public class CaBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;
        IList<CaDTO> LayDSCa()
        {
            List<CaDTO> dsCa = new List<CaDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(@"Select * from shift_period", connection))
                    {
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                dsCa.Add(new CaDTO()
                                {
                                    id = Reader.GetInt32(Reader.GetOrdinal("id")),
                                    start = TimeSpan.Parse(Reader["start"].ToString()).StripMilliseconds(),
                                    finish = TimeSpan.Parse(Reader["finish"].ToString()).StripMilliseconds(),
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
            return dsCa;
        }
    }
}
