using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPKNK_App.DTO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace QLPKNK_App.BUS
{
    public class ToothBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;
        public IList<ToothDTO> layDSRang()
        {
            List<ToothDTO> dsRang = new List<ToothDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(@"select * from tooth_list", connection))
                    {
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {

                            while (Reader.Read())
                            {
                                ToothDTO t = new ToothDTO();
                                t.id = Reader.GetInt16(Reader.GetOrdinal("id"));
                                t.name = Reader.GetString(Reader.GetOrdinal("name"));
                                dsRang.Add(t);
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
            return dsRang;
        }
    }
}
