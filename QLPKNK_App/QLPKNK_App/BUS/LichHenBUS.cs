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
                                    den_name = Reader["den_name"].ToString(),
                                    patient = Reader.IsDBNull(Reader.GetOrdinal("patient")) ? 0 : Reader.GetInt32(Reader.GetOrdinal("patient")),
                                    pat_name = Reader.IsDBNull(Reader.GetOrdinal("pat_name")) ? "" : Reader["pat_name"].ToString(),
                                    assistant = Reader.IsDBNull(Reader.GetOrdinal("assistant")) ? "" : Reader["assistant"].ToString(),
                                    ass_name = Reader.IsDBNull(Reader.GetOrdinal("ass_name")) ? "" : Reader["ass_name"].ToString(),
                                    type = Reader.IsDBNull(Reader.GetOrdinal("type")) ? 0 : Reader.GetInt32(Reader.GetOrdinal("type")),
                                    depId = Convert.ToInt32(Reader["id"]),
                                    DepAddress = Reader["DepAddress"].ToString(),
                                    accept = Convert.ToBoolean(Reader["accept"])
                                }); ;
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
        public void taoLichHen(DateTime date, int shiftId, string dentist, string assistant, int depID)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("pr_add_schedule", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@date",SqlDbType.Date)).Value = date;
                        command.Parameters.Add(new SqlParameter("@shift_id", SqlDbType.Int)).Value = shiftId;
                        command.Parameters.Add(new SqlParameter("@dentist", SqlDbType.Char,10)).Value = dentist;
                        command.Parameters.Add(new SqlParameter("@asisstant", SqlDbType.Char,10)).Value = assistant;
                        command.Parameters.Add(new SqlParameter("@depId", SqlDbType.Int)).Value = depID;
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
        public void xoaLichHen(DateTime date,int shiftId,string dentist)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("pr_delete_schedule", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@date", SqlDbType.Date)).Value = date;
                        command.Parameters.Add(new SqlParameter("@shift_id", SqlDbType.Int)).Value = shiftId;
                        command.Parameters.Add(new SqlParameter("@dentist", SqlDbType.Char, 10)).Value = dentist;
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
        public void datLichHen(DateTime date,int shiftId,string dentist,int patient)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("pr_reserve_schedule", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@date", SqlDbType.Date)).Value = date;
                        command.Parameters.Add(new SqlParameter("@shift_id", SqlDbType.Int)).Value = shiftId;
                        command.Parameters.Add(new SqlParameter("@dentist", SqlDbType.Char, 10)).Value = dentist;
                        command.Parameters.Add(new SqlParameter("@patient", SqlDbType.Int)).Value = patient;
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
        public void huyDatLichHen(DateTime date,int shiftId,string dentist)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("pr_cancel_reserved_schedule", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@date", SqlDbType.Date)).Value = date;
                        command.Parameters.Add(new SqlParameter("@shift_id", SqlDbType.Int)).Value = shiftId;
                        command.Parameters.Add(new SqlParameter("@dentist", SqlDbType.Char, 10)).Value = dentist;
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
        public void capNhatLichHen(DateTime d_old,DateTime d_new,int shiftId_old,int shiftId_new,string dentist)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("pr_update_schedule", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@date_old", SqlDbType.Date)).Value = d_old;
                        command.Parameters.Add(new SqlParameter("@date_new", SqlDbType.Date)).Value = d_new;
                        command.Parameters.Add(new SqlParameter("@shift_id_old", SqlDbType.Int)).Value = shiftId_old;
                        command.Parameters.Add(new SqlParameter("@shift_id_new", SqlDbType.Int)).Value = shiftId_new;
                        command.Parameters.Add(new SqlParameter("@dentist", SqlDbType.Char, 10)).Value = dentist;
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
        public void nhanLichHen(DateTime date,int shiftId,string dentist)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("pr_accept_schedule", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@date", SqlDbType.Date)).Value = date;
                        command.Parameters.Add(new SqlParameter("@shift_id", SqlDbType.Int)).Value = shiftId;
                        command.Parameters.Add(new SqlParameter("@dentist", SqlDbType.Char, 10)).Value = dentist;
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
        public void taoLichTaiKham(DateTime date,int shiftId,string dentist,int patient,string assistant,int lastTreatment)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("pr_delete_schedule", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@date", SqlDbType.Date)).Value = date;
                        command.Parameters.Add(new SqlParameter("@shift_id", SqlDbType.Int)).Value = shiftId;
                        command.Parameters.Add(new SqlParameter("@dentist", SqlDbType.Char, 10)).Value = dentist;
                        command.Parameters.Add(new SqlParameter("@patient", SqlDbType.Int)).Value = patient;
                        command.Parameters.Add(new SqlParameter("@asisstant", SqlDbType.Char,10)).Value = assistant;
                        command.Parameters.Add(new SqlParameter("@last_treatment", SqlDbType.Int)).Value = lastTreatment;
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
