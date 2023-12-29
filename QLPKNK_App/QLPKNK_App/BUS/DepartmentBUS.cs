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
            MessageBox.Show("Success");
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
            MessageBox.Show("Success");
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
            MessageBox.Show("Success");
        }
        public IList<MedDepDTO> layDSThuoc_CoSo(int id)
        {
            List<MedDepDTO> dsThuoc = new List<MedDepDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("view_medicine_department", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@depID",SqlDbType.SmallInt)).Value = id;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                dsThuoc.Add(new MedDepDTO()
                                {
                                    mID = Reader["medicine"].ToString(),
                                    name = Reader["name"].ToString(),
                                    remain = Convert.ToInt32(Reader["remain"])
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
            return dsThuoc;
        }
        public void taoThuoc_CoSo(string mID,int depID,int quantity)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("add_medicine_to_department", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@medicine", SqlDbType.Char,5)).Value = mID;
                        command.Parameters.Add(new SqlParameter("@department", SqlDbType.SmallInt)).Value = depID;
                        command.Parameters.Add(new SqlParameter("@quantity", SqlDbType.Int)).Value = quantity;
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
        public void capNhatThuoc_CoSo(string mID, int depID, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("update_medicine_to_department", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@medicine", SqlDbType.Char, 5)).Value = mID;
                        command.Parameters.Add(new SqlParameter("@department", SqlDbType.SmallInt)).Value = depID;
                        command.Parameters.Add(new SqlParameter("@quantity", SqlDbType.Int)).Value = quantity;
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
        public IList<ThuocDTO> dsThuocChuaThem_CoSo(int depID)
        {
            List<ThuocDTO> dsThuoc = new List<ThuocDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("getMedToAdd", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@depID", SqlDbType.SmallInt)).Value = depID;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                dsThuoc.Add(new ThuocDTO()
                                {
                                    id = Reader["id"].ToString(),
                                    name = Reader["name"].ToString(),
                                }) ;
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
            return dsThuoc;
        }
    }
}