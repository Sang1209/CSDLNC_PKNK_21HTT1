using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    MessageBox.Show("Error");
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
                                HoSoDTO hoSo = new HoSoDTO();

                                if (!Reader.IsDBNull(Reader.GetOrdinal("id")))
                                {
                                    hoSo.id = Reader.GetInt32(Reader.GetOrdinal("id"));
                                }
                                if (!Reader.IsDBNull(Reader.GetOrdinal("name")))
                                {
                                    hoSo.name = Reader.GetString(Reader.GetOrdinal("name"));
                                }
                                if (!Reader.IsDBNull(Reader.GetOrdinal("birth")))
                                {
                                    hoSo.birth = Reader.GetDateTime(Reader.GetOrdinal("birth"));
                                }
                                if (!Reader.IsDBNull(Reader.GetOrdinal("phone")))
                                {
                                    hoSo.phone = Reader.GetString(Reader.GetOrdinal("phone"));
                                }
                                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                                {
                                    hoSo.email = Reader.GetString(Reader.GetOrdinal("email"));
                                }
                                if (!Reader.IsDBNull(Reader.GetOrdinal("address")))
                                {
                                    hoSo.address = Reader.GetString(Reader.GetOrdinal("address"));
                                }
                                if (!Reader.IsDBNull(Reader.GetOrdinal("gender")))
                                {
                                    hoSo.gender = Reader.GetBoolean(Reader.GetOrdinal("gender"));
                                }

                                dsHoSo.Add(hoSo);
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
