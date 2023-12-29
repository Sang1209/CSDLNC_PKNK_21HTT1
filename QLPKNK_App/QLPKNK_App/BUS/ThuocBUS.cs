using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLPKNK_App.BUS
{
    public class ThuocBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;

        public IList<ThuocDTO> LayDSThuoc()
        {
            List<ThuocDTO> dsThuoc = new List<ThuocDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("ViewMedicineList", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                dsThuoc.Add(new ThuocDTO()
                                {
                                    id = Reader["id"].ToString(),
                                    name = Reader["name"].ToString(),
                                    price = Convert.ToSingle(Reader["price"]),

                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

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
        public void ThemThuoc(string id, string name, float price)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("AddMedicine", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                       
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@price", price);

          
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
           
                    MessageBox.Show("Error");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void XoaThuoc(string id)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("DeleteMedicine", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void SuaThuoc(string id, string name, float price)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UpdateMedicine", connection))
                    {
                        command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                        command.Parameters.Add(new SqlParameter("@newName", SqlDbType.VarChar)).Value = name;
                        command.Parameters.Add(new SqlParameter("@newPrice", SqlDbType.VarChar)).Value = price;
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
