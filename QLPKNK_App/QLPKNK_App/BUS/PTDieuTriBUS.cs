using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPKNK_App.DTO;

namespace QLPKNK_App.BUS
{
    public class PTDieuTriBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;

        public IList<PTDieuTriDTO> layDSPhuongThucDT()
        {
            IList<PTDieuTriDTO> dsPT = new List<PTDieuTriDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(@"Select * from treatment_list", connection))
                    {
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                PTDieuTriDTO pt = new PTDieuTriDTO();

                                pt.id = Reader.GetInt16(Reader.GetOrdinal("id"));
                                pt.name = Reader.GetString(Reader.GetOrdinal("name"));
                                pt.price = Reader.GetDouble(Reader.GetOrdinal("price"));
                                dsPT.Add(pt);
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
            return dsPT;
        }
    }
}
