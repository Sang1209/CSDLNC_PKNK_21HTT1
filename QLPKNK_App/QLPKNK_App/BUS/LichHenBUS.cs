using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using static QLPKNK_App.utils.DateTimeMod;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLPKNK_App.BUS
{
    public class LichHenBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;
        public IList<LichHenDTO> layDSLichHenTrongNgay(int type,int id,string username)
        {
            string sp;
            string param="";
            switch(type)
            {
                case 0:
                {
                    sp = "xemLichHenTrongNgay";
                    break;
                }
                case 1:
                {
                    sp = "locLichHenTheoBN";
                    param = "@PatientID";
                    break;
                }
                case 2:
                {
                    sp = "locLichHenTheoBS";
                    param = "@dentistUsername";
                    break;
                }
                case 3:
                {
                    sp = "locLichHenTheoPhongKham";
                    param = "@DepID";
                    break;
                }
                default:
                {
                    return null;
                }
            }
            List<LichHenDTO> dsLichHen = new List<LichHenDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
               try
               {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sp, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if(type==1||type==3)
                        {
                            command.Parameters.Add(new SqlParameter(param, SqlDbType.Int, 0)).Value = id;
                        }
                        else if (type==2)
                        {
                            command.Parameters.Add(new SqlParameter(param, SqlDbType.VarChar, 10)).Value = username;
                        }
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                dsLichHen.Add(new LichHenDTO()
                                {
                                    date = DateTime.Parse(Reader["date"].ToString()),
                                    shiftId = Convert.ToInt32(Reader["shift_id"]),
                                    start = TimeSpan.Parse(Reader["start"].ToString()).StripMilliseconds(),
                                    finish = TimeSpan.Parse(Reader["finish"].ToString()).StripMilliseconds(),
                                    dentist = Reader["dentist"].ToString(),
                                    patient = Convert.ToInt32(Reader["patient"]),
                                    assistant = Reader["assistant"].ToString(),
                                    type = Reader.IsDBNull(Reader.GetOrdinal("type")) ? 0 : Reader.GetInt32(Reader.GetOrdinal("type")),
                                    depId= Convert.ToInt32(Reader["id"]),
                                    DepAddress = Reader["DepAddress"].ToString()
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
            return dsLichHen;
        }
        public void NhaSiTaoLichHen(DateTime date,int shift_id,string dentist,string assistant)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("pr_add_schedule", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        
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
