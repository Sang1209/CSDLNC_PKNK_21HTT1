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
            IList<HoSoDTO> dsHoSo = new List<HoSoDTO>();
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

                                hoSo.id = Reader.GetInt32(Reader.GetOrdinal("id"));                               
                                hoSo.name = Reader.GetString(Reader.GetOrdinal("name"));                             
                                hoSo.birth = Reader.GetDateTime(Reader.GetOrdinal("birth"));                                
                                hoSo.phone = Reader.GetString(Reader.GetOrdinal("phone"));                               
                                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                                {
                                    hoSo.email = Reader.GetString(Reader.GetOrdinal("email"));
                                }
                                hoSo.address = Reader.GetString(Reader.GetOrdinal("address"));                              
                                hoSo.gender = Reader.GetBoolean(Reader.GetOrdinal("gender"));                              
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

        public void capNhatHoSo(int id, string name, DateTime birth, string phone, string email, string address, bool gender)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("pr_update_patient", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@birth", birth);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@gender", gender);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
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
                    using (SqlCommand command = new SqlCommand(@"select name, birth, phone, email, address, gender from patient_profile where id = @id", connection))
                    {
                        command.Parameters.Add(new SqlParameter("id", SqlDbType.Int)).Value = id;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                hs.name = Reader.GetString(Reader.GetOrdinal("name"));
                                hs.birth = Reader.GetDateTime(Reader.GetOrdinal("birth"));
                                hs.phone = Reader.GetString(Reader.GetOrdinal("phone"));
                                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                                {
                                    hs.email = Reader.GetString(Reader.GetOrdinal("email"));
                                }

                                hs.address = Reader.GetString(Reader.GetOrdinal("address"));
                                hs.gender = Reader.GetBoolean(Reader.GetOrdinal("gender"));
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
                return hs;
            }
        }
        public IList<HoSoDTO> TimHoSo(string name)
        {
            IList<HoSoDTO> dsHoSo = new List<HoSoDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(@"Select id, name, birth, phone, email, address, gender from patient_profile where name = @name", connection))
                    {
                        command.Parameters.Add(new SqlParameter("name", SqlDbType.VarChar)).Value = name;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                HoSoDTO hoSo = new HoSoDTO();

                                hoSo.id = Reader.GetInt32(Reader.GetOrdinal("id"));
                                hoSo.name = Reader.GetString(Reader.GetOrdinal("name"));
                                hoSo.birth = Reader.GetDateTime(Reader.GetOrdinal("birth"));
                                hoSo.phone = Reader.GetString(Reader.GetOrdinal("phone"));
                                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                                {
                                    hoSo.email = Reader.GetString(Reader.GetOrdinal("email"));
                                }
                                hoSo.address = Reader.GetString(Reader.GetOrdinal("address"));
                                hoSo.gender = Reader.GetBoolean(Reader.GetOrdinal("gender"));
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
