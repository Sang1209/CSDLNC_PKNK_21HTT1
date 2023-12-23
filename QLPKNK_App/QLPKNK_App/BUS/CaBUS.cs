using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPKNK_App.utils;
using System.Windows.Forms;

namespace QLPKNK_App.BUS
{
    public class CaBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;
        public CaDTO LayTTCa(int shiftID)
        {
            CaDTO ca = null;
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("Select * from shift_period where id=@shiftID", connection))
                    {
                        command.Parameters.Add(new SqlParameter("shiftID",SqlDbType.Int,0)).Value=shiftID;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            if(!Reader.HasRows) { return ca; }
                            while (Reader.Read())
                            {
                                ca = new CaDTO()
                                {
                                   id = Convert.ToInt32(Reader.GetOrdinal("id")),
                                   start = TimeSpan.Parse(Reader["start"].ToString()).StripMilliseconds(),
                                   finish = TimeSpan.Parse(Reader["finish"].ToString()).StripMilliseconds(),
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
            return ca;
        }
    }
}
