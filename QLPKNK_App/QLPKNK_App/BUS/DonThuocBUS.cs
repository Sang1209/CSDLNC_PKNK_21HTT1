using buhbuhlmao.BUS;
using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKNK_App.BUS
{
    internal class DonThuocBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;
        public IList<DonThuocDTO> layDsThuocCuaKHDT(int tId)
        {
            List<DonThuocDTO> dsThuoc = new List<DonThuocDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("xemThuocCuaKHDT", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@TreatmentID", SqlDbType.Int, 0)).Value = tId;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                dsThuoc.Add(new DonThuocDTO
                                (
                                    Reader["id"].ToString(),
                                    Reader["name"].ToString(),
                                    Convert.ToInt32(Reader["quantity"]),
                                    Reader["note"].ToString()
                                ));
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
            return dsThuoc;
        }
        public void themThuocChoKHDT(int tId,string mId,int quantity,string note)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("themThuocChoKHDT", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@TreatmentID", SqlDbType.Int, 0)).Value = tId;
                        command.Parameters.Add(new SqlParameter("@MedicineID", SqlDbType.VarChar, 5)).Value = mId;
                        command.Parameters.Add(new SqlParameter("@amount", SqlDbType.Int, 0)).Value = quantity;
                        command.Parameters.Add(new SqlParameter("@note", SqlDbType.VarChar, 100)).Value = (object)note??DBNull.Value;

                        command.ExecuteNonQuery();
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
        }
        //meh
        public void xoaThuocChoKHDT(int tId, string mId)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("xoaThuocChoKHDT", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@TreatmentID", SqlDbType.Int, 0)).Value = tId;
                        command.Parameters.Add(new SqlParameter("@MedicineID", SqlDbType.VarChar, 5)).Value = mId;
                        command.ExecuteNonQuery();
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
        }
        //meh
        public void suaThuocChoKHDT(int tId, string mId, int quantity, string note)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("suaThuocChoKHDT", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@TreatmentID", SqlDbType.Int, 0)).Value = tId;
                        command.Parameters.Add(new SqlParameter("@MedicineID", SqlDbType.VarChar, 5)).Value = mId;
                        command.Parameters.Add(new SqlParameter("@amount", SqlDbType.Int, 0)).Value = quantity;
                        command.Parameters.Add(new SqlParameter("@note", SqlDbType.VarChar, 100)).Value = (object)note ?? DBNull.Value;
                        command.ExecuteNonQuery();
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
        }
    }
}
