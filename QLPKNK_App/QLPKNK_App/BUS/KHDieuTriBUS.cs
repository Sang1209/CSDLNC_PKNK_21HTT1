using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace buhbuhlmao.BUS
{
    public class KHDieuTriBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;
        public IList<KHDieuTriDTO> layDsKHDieuTriTheoBN(int patientID)
        {
            List<KHDieuTriDTO> dsKHDT=new List<KHDieuTriDTO> ();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("xemKHDT", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@PatientID",SqlDbType.Int, 0)).Value= patientID;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                dsKHDT.Add(new KHDieuTriDTO
                                (
                                    Convert.ToInt32(Reader["id"]),
                                    Reader["address"].ToString(),
                                    Reader["dentist"].ToString(),
                                    Convert.ToInt32(Reader["patient"]),
                                    Reader["assistant"].ToString(),
                                    Reader["description"].ToString(),
                                    DateTime.Parse(Reader["date"].ToString()),
                                    Reader["note"].ToString(),
                                    Reader["method"].ToString(),
                                    Reader["tooth_name"].ToString(),
                                    Convert.ToInt32(Reader["state"]),
                                    Convert.ToDouble(Reader["total"])
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
            return dsKHDT;
        }
    }
}
