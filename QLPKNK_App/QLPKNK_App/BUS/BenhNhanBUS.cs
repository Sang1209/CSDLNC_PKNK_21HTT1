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
    public class BenhNhanBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;
        public IList<BenhNhanDTO> layDSBenhNhan()
        {
            List<BenhNhanDTO> dsBenhNhan = new List<BenhNhanDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(@"Select id,name from patient_profile", connection))
                    {
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                dsBenhNhan.Add(new BenhNhanDTO()
                                {
                                    id = Reader.GetInt32(Reader.GetOrdinal("id")),
                                    name=Reader.GetString(Reader.GetOrdinal("name")),
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
            return dsBenhNhan;
        }
    }
}
