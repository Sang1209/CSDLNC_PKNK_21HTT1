using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPKNK_App.BUS
{
        internal class CachTraBUS
        {
            readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;
            public IList<CachTraDTO> layDSCachTra()
            {
                List<CachTraDTO> dsCachTra = new List<CachTraDTO>();
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("Select id,name from payment_method", connection))
                        {
                            using (SqlDataReader Reader = command.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    dsCachTra.Add(new CachTraDTO()
                                    {
                                        id = Convert.ToInt32(Reader["id"]),
                                        name = Reader["name"].ToString(),
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý các ngoại lệ nếu có
                        MessageBox.Show("Error cachtraBUS");
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                return dsCachTra;
            }
        }

}
