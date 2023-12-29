using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace QLPKNK_App.BUS
{
    internal class DiUngBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;
        public IList<DiUngDTO> layDSDiUng()
        {
            List<DiUngDTO> dsDiUng= new List<DiUngDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("layDSDiUng", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                dsDiUng.Add(new DiUngDTO()
                                {
                                    patient = Convert.ToInt32(Reader["patient"]),
                                    pName = Reader["pName"].ToString(),
                                    medicine= Reader["medicine"].ToString(),
                                    medName= Reader["medName"].ToString(),
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
            return dsDiUng;
        }
        public IList<DiUngDTO> layDSDiUngTheoBN(int pId)
        {
            List<DiUngDTO> dsDiUng = new List<DiUngDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("layDSDiUngTheoBN", connection))
                    {
                        command.Parameters.Add(new SqlParameter("@pID", SqlDbType.Int)).Value = pId;
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                dsDiUng.Add(new DiUngDTO()
                                {
                                    patient = Convert.ToInt32(Reader["patient"]),
                                    pName = Reader["pName"].ToString(),
                                    medicine = Reader["medicine"].ToString(),
                                    medName = Reader["medName"].ToString(),
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
            return dsDiUng;
        }
        public void themDiUng(int pId,string mId)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("themDiUng", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@pID", SqlDbType.Int)).Value = pId;
                        command.Parameters.Add(new SqlParameter("@mID", SqlDbType.VarChar)).Value = mId;
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
        public void capNhatDiUng(int pId,string mId_old,string mId_new)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("capNhatDiUng", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@pID", SqlDbType.Int)).Value = pId;
                        command.Parameters.Add(new SqlParameter("@mID_old", SqlDbType.VarChar)).Value = mId_old;
                        command.Parameters.Add(new SqlParameter("@mID_new", SqlDbType.VarChar)).Value = mId_new;
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
        public void xoaDiUng(int pID,string mID)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine(pID);
                    using (SqlCommand command = new SqlCommand("xoaDiUng", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@pID", SqlDbType.Int,0)).Value = pID;
                        command.Parameters.Add(new SqlParameter("@mID", SqlDbType.VarChar)).Value = mID;
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
