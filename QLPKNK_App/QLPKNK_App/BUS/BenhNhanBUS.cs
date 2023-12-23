using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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

        public IList<HoSoDTO> LayDsHoSo()
        {
            List<HoSoDTO> dsHoSo = new List<HoSoDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(@"Select id,name, birth, phone, email, address, gender from patient_profile", connection))
                    {
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                dsHoSo.Add(new HoSoDTO()
                                {
                                    id = Reader.GetInt32(Reader.GetOrdinal("id")),
                                    name = Reader.GetString(Reader.GetOrdinal("name")),
                                    birth = Reader.GetDateTime(Reader.GetOrdinal("birth")),
                                    phone = Reader.GetString(Reader.GetOrdinal("phone")),
                                    email = Reader.GetString(Reader.GetOrdinal("email")),
                                    address = Reader.GetString(Reader.GetOrdinal("address")),
                                    gender = Reader.GetBoolean(Reader.GetOrdinal("gender")),
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
            return dsHoSo;
        }
    }
}
