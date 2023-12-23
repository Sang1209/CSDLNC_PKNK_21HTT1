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

namespace QLPKNK_App.BUS
{
    public class HoaDonBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;
        public IList<HoaDonDTO> LayDSHoaDon(int patientID)
        {
            List<HoaDonDTO> dsHoaDon = new List<HoaDonDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("XemHoaDonCuaKH", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.Int, 0)).Value = patientID;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                dsHoaDon.Add(new HoaDonDTO() 
                                {
                                    treatment = Convert.ToInt32(Reader["treatment"]),
                                    times= Convert.ToInt32(Reader["num"]),
                                    total= Convert.ToDouble(Reader["change"]),
                                    given=Convert.ToDouble(Reader["need"]),
                                    method= Reader["method"].ToString(),
                                    date = DateTime.Parse(Reader["date"].ToString()),
                                    payer= Reader["payer"].ToString(),
                                    note= Reader["note"].ToString(),

                                });
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
            return dsHoaDon;
        }
    }
}
