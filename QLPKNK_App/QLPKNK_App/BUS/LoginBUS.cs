using QLPKNK_App.DTO;
using QLPKNK_App.utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLPKNK_App.BUS
{
    internal class LoginBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;
        public Admin_StaffDTO checkLoginAdmin(string username,string password)
        {
            Admin_StaffDTO admin=null;
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("Select name,phone,email,address,gender,admin from account_adst where [username]=@username and [password]=@password", connection))
                    {
                        command.Parameters.Add(new SqlParameter("username", SqlDbType.VarChar, 10)).Value = username;
                        command.Parameters.Add(new SqlParameter("password", SqlDbType.VarChar, 30)).Value = password;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            if (!Reader.HasRows) { return admin; }
                            while (Reader.Read())
                            {
                                admin = new Admin_StaffDTO()
                                {
                                    username=username,
                                    password=password,
                                    name= Reader["name"].ToString(),
                                    phone= Reader["phone"].ToString(),
                                    email= Reader["email"].ToString(),
                                    address= Reader["address"].ToString(),
                                    gender = Convert.ToBoolean(Reader.GetOrdinal("gender")),
                                    admin = Convert.ToBoolean(Reader.GetOrdinal("admin")),
                                };
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
            return admin;
        }
        public NhaSiDTO checkLoginDentist(string username,string password)
        {
            NhaSiDTO nhasi = null;
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("Select name,phone,email,address,gender,department from account_de where [username]=@username and [password]=@password", connection))
                    {
                        command.Parameters.Add(new SqlParameter("username", SqlDbType.VarChar, 10)).Value = username;
                        command.Parameters.Add(new SqlParameter("password", SqlDbType.VarChar, 30)).Value = password;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            if(!Reader.HasRows) { return nhasi; }
                            while (Reader.Read())
                            {
                                nhasi = new NhaSiDTO()
                                {
                                    username = username,
                                    password = password,
                                    name = Reader["name"].ToString(),
                                    phone = Reader["phone"].ToString(),
                                    email = Reader["email"].ToString(),
                                    address = Reader["address"].ToString(),
                                    gender = Convert.ToBoolean(Reader.GetOrdinal("gender")),
                                    depID = Convert.ToInt32(Reader.GetOrdinal("department")),
                                };
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
            return nhasi;
        }
        public Admin_StaffDTO checkLoginStaff(string username, string password)
        {
            Admin_StaffDTO staff = null;
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("Select name,phone,email,address,gender,admin from account_adst where [username]=@username and [password]=@password", connection))
                    {
                        command.Parameters.Add(new SqlParameter("username", SqlDbType.VarChar, 10)).Value = username;
                        command.Parameters.Add(new SqlParameter("password", SqlDbType.VarChar, 30)).Value = password;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            if (!Reader.HasRows) { return staff; }
                            while (Reader.Read())
                            {
                                staff = new Admin_StaffDTO()
                                {
                                    username = username,
                                    password = password,
                                    name = Reader["name"].ToString(),
                                    phone = Reader["phone"].ToString(),
                                    email = Reader["email"].ToString(),
                                    address = Reader["address"].ToString(),
                                    gender = Convert.ToBoolean(Reader.GetOrdinal("gender")),
                                    admin = Convert.ToBoolean(Reader.GetOrdinal("admin")),
                                };
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
            return staff;
        }
    }
}
