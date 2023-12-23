using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using QLPKNK_App.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLPKNK_App.BUS
{
    public class HoSoBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;
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

        public void capNhatHoSo(int id, string name, DateTime? birth, string phone, string email, string address, bool? gender)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateData", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@name", string.IsNullOrEmpty(name) ? (object)DBNull.Value : name);
                    command.Parameters.AddWithValue("@birth", birth ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@phone", string.IsNullOrEmpty(phone) ? (object)DBNull.Value : phone);
                    command.Parameters.AddWithValue("@email", string.IsNullOrEmpty(name) ? (object)DBNull.Value : name);
                    command.Parameters.AddWithValue("@address", string.IsNullOrEmpty(address) ? (object)DBNull.Value : address);
                    command.Parameters.AddWithValue("@gender", gender ?? (object)DBNull.Value);
                    // Thêm các parameters cho các cột khác nếu cần

                    command.ExecuteNonQuery();
                }
            }
        }

        public HoSoDTO layThongTinHoSO(int id)
        {
            HoSoDTO hs = new HoSoDTO();
            hs.id = id;
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(@"Select name, birth, phone, email, address, gender from patient_profile where id = @id", connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            hs.name = Reader.GetString(Reader.GetOrdinal("name"));
                            hs.birth = Reader.GetDateTime(Reader.GetOrdinal("birth"));
                            hs.phone = Reader.GetString(Reader.GetOrdinal("phone"));
                            hs.email = Reader.GetString(Reader.GetOrdinal("email"));
                            hs.address = Reader.GetString(Reader.GetOrdinal("address"));
                            hs.gender = Reader.GetBoolean(Reader.GetOrdinal("gender"));
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
                return hs;
            }
        }
    }
}
