using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using QLPKNK_App.utils;
using System.Windows.Forms;

namespace QLPKNK_App.BUS
{
    internal class DepartmentBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;

        public IList<DepartmentDTO> LayDSDepartment()
        {
            List<DepartmentDTO> dsDepartment = new List<DepartmentDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(@"Select * from department", connection))
                    {
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                DepartmentDTO dep = new DepartmentDTO();

                                dep.id = Reader.GetInt16(Reader.GetOrdinal("id"));
                                dep.address = Reader.GetString(Reader.GetOrdinal("address"));

                                dsDepartment.Add(dep);
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
            return dsDepartment;
        }
        public void xoaCoSo(int id)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("delete from department where id=@id", connection))
                    {
                        command.Parameters.Add(new SqlParameter("id",SqlDbType.Int)).Value=id;
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Co so dang duoc su dung!");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void themCoSo(int id, string address)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("insert into department values (@id,@address)", connection))
                    {
                        command.Parameters.Add(new SqlParameter("id", SqlDbType.Int)).Value = id;
                        command.Parameters.Add(new SqlParameter("address", SqlDbType.VarChar,50)).Value = address;
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Error");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void capNhatCoSo(int id,string address)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("update department set address=@address where id=@id", connection))
                    {
                        command.Parameters.Add(new SqlParameter("id", SqlDbType.Int)).Value = id;
                        command.Parameters.Add(new SqlParameter("address", SqlDbType.VarChar, 50)).Value = address;
                        command.ExecuteNonQuery();
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
        }
    }
}