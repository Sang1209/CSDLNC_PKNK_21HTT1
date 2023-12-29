using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPKNK_App.DTO;
using System.Windows.Forms;

namespace QLPKNK_App.BUS
{
    internal class Admin_StaffBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;

        public IList<Admin_StaffDTO> layDSNhanVien()
        {
            List<Admin_StaffDTO> dsNhanVien = new List<Admin_StaffDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("select * from account_adst ", connection))
                    {
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {

                            while (Reader.Read())
                            {
                                Admin_StaffDTO nv = new Admin_StaffDTO();

                                nv.username = Reader.GetString(Reader.GetOrdinal("username"));
                                nv.password = Reader.GetString(Reader.GetOrdinal("password"));
                                nv.name = Reader.GetString(Reader.GetOrdinal("name"));
                                nv.phone = Reader.GetString(Reader.GetOrdinal("phone"));
                                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                                {
                                    nv.email = Reader.GetString(Reader.GetOrdinal("email"));
                                }
                                nv.address = Reader.GetString(Reader.GetOrdinal("address"));
                                nv.gender = Reader.GetBoolean(Reader.GetOrdinal("gender"));
                                nv.admin = Reader.GetBoolean(Reader.GetOrdinal("admin"));

                                dsNhanVien.Add(nv);
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
            return dsNhanVien;
        }

        public IList<Admin_StaffDTO> locNhanVien_Ten(string name)
        {
            List<Admin_StaffDTO> dsNhanVien = new List<Admin_StaffDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("select * from account_adst where name = @name", connection))
                    {
                        command.Parameters.Add(new SqlParameter("name", SqlDbType.VarChar)).Value = name;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {

                            while (Reader.Read())
                            {
                                Admin_StaffDTO nv = new Admin_StaffDTO();

                                nv.username = Reader.GetString(Reader.GetOrdinal("username"));
                                nv.password = Reader.GetString(Reader.GetOrdinal("password"));
                                nv.name = Reader.GetString(Reader.GetOrdinal("name"));
                                nv.phone = Reader.GetString(Reader.GetOrdinal("phone"));
                                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                                {
                                    nv.email = Reader.GetString(Reader.GetOrdinal("email"));
                                }
                                nv.address = Reader.GetString(Reader.GetOrdinal("address"));
                                nv.gender = Reader.GetBoolean(Reader.GetOrdinal("gender"));
                                nv.admin = Reader.GetBoolean(Reader.GetOrdinal("admin"));

                                dsNhanVien.Add(nv);
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
            return dsNhanVien;
        }

        public IList<Admin_StaffDTO> locNhanVien_Loai(bool admin)
        {
            List<Admin_StaffDTO> dsNhanVien = new List<Admin_StaffDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("select * from account_adst where admin = @admin", connection))
                    {
                        command.Parameters.Add(new SqlParameter("admin", SqlDbType.VarChar)).Value = admin;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {

                            while (Reader.Read())
                            {
                                Admin_StaffDTO nv = new Admin_StaffDTO();

                                nv.username = Reader.GetString(Reader.GetOrdinal("username"));
                                nv.password = Reader.GetString(Reader.GetOrdinal("password"));
                                nv.name = Reader.GetString(Reader.GetOrdinal("name"));
                                nv.phone = Reader.GetString(Reader.GetOrdinal("phone"));
                                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                                {
                                    nv.email = Reader.GetString(Reader.GetOrdinal("email"));
                                }
                                nv.address = Reader.GetString(Reader.GetOrdinal("address"));
                                nv.gender = Reader.GetBoolean(Reader.GetOrdinal("gender"));
                                nv.admin = Reader.GetBoolean(Reader.GetOrdinal("admin"));

                                dsNhanVien.Add(nv);
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
            return dsNhanVien;
        }

        public Admin_StaffDTO timNhanVien(string username)
        {
            Admin_StaffDTO nv = new Admin_StaffDTO();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("select * from account_adst where username = @username", connection))
                    {
                        command.Parameters.Add(new SqlParameter("username", SqlDbType.VarChar)).Value = username;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {

                            while (Reader.Read())
                            {
                                nv.username = Reader.GetString(Reader.GetOrdinal("username"));
                                nv.password = Reader.GetString(Reader.GetOrdinal("password"));
                                nv.name = Reader.GetString(Reader.GetOrdinal("name"));
                                nv.phone = Reader.GetString(Reader.GetOrdinal("phone"));
                                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                                {
                                    nv.email = Reader.GetString(Reader.GetOrdinal("email"));
                                }
                                nv.address = Reader.GetString(Reader.GetOrdinal("address"));
                                nv.gender = Reader.GetBoolean(Reader.GetOrdinal("gender"));
                                nv.admin = Reader.GetBoolean(Reader.GetOrdinal("admin"));
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
            return nv;
        }

        public void themAdmin_NhanVien(string username, string password, string name, bool gender, bool type, string phone, string email, string address)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("add_account_adst", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@gender", gender);
                        command.Parameters.AddWithValue("@type", type);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@address", address);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    Console.WriteLine(ex.Message);
                }
            }
            MessageBox.Show("Success");
        }

        public void capNhatNhanVien(string username, string password, string name, string phone, string email, string address, bool gender, bool admin)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("update_account_adst", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@admin", admin);
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
            MessageBox.Show("Success");
        }
    }
}
