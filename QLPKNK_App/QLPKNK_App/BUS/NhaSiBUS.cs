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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                    using (SqlCommand command = new SqlCommand("select de.username username, de.password password, de.name name, de.phone phone, de.email email, de.address address, de.gender gender, de.department depID, dep.address dep_addr from account_de de join department dep on de.department = dep.id ", connection))
                    {
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {

                            while (Reader.Read())
                            {
                                NhaSiDTO ns = new NhaSiDTO();                         

                                ns.username = Reader.GetString(Reader.GetOrdinal("username"));
                                ns.password = Reader.GetString(Reader.GetOrdinal("password"));
                                ns.name = Reader.GetString(Reader.GetOrdinal("name"));
                                ns.phone = Reader.GetString(Reader.GetOrdinal("phone"));
                                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                                {
                                    ns.email = Reader.GetString(Reader.GetOrdinal("email"));
                                }
                                ns.address = Reader.GetString(Reader.GetOrdinal("address"));
                                ns.gender = Reader.GetBoolean(Reader.GetOrdinal("gender"));
                                ns.depID = Reader.GetInt16(Reader.GetOrdinal("depID"));
                                ns.dep_addr = Reader.GetString(Reader.GetOrdinal("dep_addr"));

                                dsNhaSi.Add(ns);
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
            return dsNhaSi;
        }

        public IList<NhaSiDTO> locNhaSi_Department(int depID)
        {
            List<NhaSiDTO> dsNhaSi = new List<NhaSiDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("select de.username username, de.password password, de.name name, de.phone phone, de.email email, de.address address, de.gender gender, de.department depID, dep.address dep_addr from account_de de join department dep on de.department = dep.id where de.department = @dep", connection))
                    {
                        command.Parameters.Add(new SqlParameter("dep", SqlDbType.SmallInt)).Value = depID;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {

                            while (Reader.Read())
                            {
                                NhaSiDTO ns = new NhaSiDTO();

                                ns.username = Reader.GetString(Reader.GetOrdinal("username"));
                                ns.password = Reader.GetString(Reader.GetOrdinal("password"));
                                ns.name = Reader.GetString(Reader.GetOrdinal("name"));
                                ns.phone = Reader.GetString(Reader.GetOrdinal("phone"));
                                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                                {
                                    ns.email = Reader.GetString(Reader.GetOrdinal("email"));
                                }
                                ns.address = Reader.GetString(Reader.GetOrdinal("address"));
                                ns.gender = Reader.GetBoolean(Reader.GetOrdinal("gender"));
                                ns.depID = Reader.GetInt16(Reader.GetOrdinal("depID"));
                                ns.dep_addr = Reader.GetString(Reader.GetOrdinal("dep_addr"));

                                dsNhaSi.Add(ns);
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
            return dsNhaSi;
        }

        public IList<NhaSiDTO> locNhaSi_Ten(string name)
        {
            List<NhaSiDTO> dsNhaSi = new List<NhaSiDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("select de.username username, de.password password, de.name name, de.phone phone, de.email email, de.address address, de.gender gender, de.department depID, dep.address dep_addr from account_de de join department dep on de.department = dep.id where de.name = @name", connection))
                    {
                        command.Parameters.Add(new SqlParameter("name", SqlDbType.VarChar)).Value = name;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {

                            while (Reader.Read())
                            {
                                NhaSiDTO ns = new NhaSiDTO();

                                ns.username = Reader.GetString(Reader.GetOrdinal("username"));
                                ns.password = Reader.GetString(Reader.GetOrdinal("password"));
                                ns.name = Reader.GetString(Reader.GetOrdinal("name"));
                                ns.phone = Reader.GetString(Reader.GetOrdinal("phone"));
                                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                                {
                                    ns.email = Reader.GetString(Reader.GetOrdinal("email"));
                                }
                                ns.address = Reader.GetString(Reader.GetOrdinal("address"));
                                ns.gender = Reader.GetBoolean(Reader.GetOrdinal("gender"));
                                ns.depID = Reader.GetInt16(Reader.GetOrdinal("depID"));
                                ns.dep_addr = Reader.GetString(Reader.GetOrdinal("dep_addr"));

                                dsNhaSi.Add(ns);
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
            return dsNhaSi;
        }

        public NhaSiDTO timNhaSi(string username)
        {
            NhaSiDTO ns = new NhaSiDTO();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("select de.username username, de.password password, de.name name, de.phone phone, de.email email, de.address address, de.gender gender, de.department depID, dep.address dep_addr from account_de de join department dep on de.department = dep.id where de.username = @username", connection))
                    {
                        command.Parameters.Add(new SqlParameter("username", SqlDbType.VarChar)).Value = username;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {

                            while (Reader.Read())
                            {
                                ns.username = Reader.GetString(Reader.GetOrdinal("username"));
                                ns.password = Reader.GetString(Reader.GetOrdinal("password"));
                                ns.name = Reader.GetString(Reader.GetOrdinal("name"));
                                ns.phone = Reader.GetString(Reader.GetOrdinal("phone"));
                                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                                {
                                    ns.email = Reader.GetString(Reader.GetOrdinal("email"));
                                }
                                ns.address = Reader.GetString(Reader.GetOrdinal("address"));
                                ns.gender = Reader.GetBoolean(Reader.GetOrdinal("gender"));
                                ns.depID = Reader.GetInt16(Reader.GetOrdinal("depID"));
                                ns.dep_addr = Reader.GetString(Reader.GetOrdinal("dep_addr"));
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
            return ns;
        }

        public void themNhaSi(string username, string password, string name, bool gender, int department, string phone, string email, string address)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("add_account_de", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@gender", gender);
                        command.Parameters.AddWithValue("@department", department);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@address", address);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    MessageBox.Show("Error");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void capNhatNhaSi(string username, string password, string name, string phone, string email, string address, bool gender, int depID)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("update_account_de", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@department", depID);
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
    }
}
