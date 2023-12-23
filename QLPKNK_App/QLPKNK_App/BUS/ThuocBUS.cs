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
using System.Windows.Forms;

namespace QLPKNK_App.BUS
{
    public class ThuocDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
    }
    public class ThuocBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;

        public void ThemThuoc(ThuocDTO thuoc)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("AddMedicine", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                       
                        command.Parameters.AddWithValue("@id", thuoc.id);
                        command.Parameters.AddWithValue("@name", thuoc.name);
                        command.Parameters.AddWithValue("@price", thuoc.price);

          
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
                                    name= Reader["name"].ToString(),
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
    }
}
