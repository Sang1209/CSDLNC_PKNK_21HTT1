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
using System.Windows.Forms;

namespace QLPKNK_App.BUS
{
    public class LichHenBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;
        public IList<LichHenDTO> layDSLichHenTrongNgay(int pId,int diD,string dentist)
        {
            string sp;
            int type = 0;
            if (pId == -1)
            {
                if (diD == -1)
                {
                    if (dentist.Equals("-1"))
                    {
                        sp = "xemLichHenTrongNgay";
                    }
                    else
                    {
                        sp = "locLichHenTrongNgay_den";
                        type = 1;
                    }
                }
                else
                {
                    if (dentist.Equals("-1"))
                    {
                        sp = "locLichHenTrongNgay_dep";
                        type = 2;
                    }
                    else
                    {
                        sp = "locLichHenTrongNgay_dep_den";
                        type = 3;
                    }
                }
            }
            else
            {
                if (diD == -1)
                {
                    if (dentist.Equals("-1"))
                    {
                        sp = "locLichHenTrongNgay_pat";
                        type = 4;
                    }
                    else
                    {
                        sp = "locLichHenTrongNgay_pat_den";
                        type = 5;
                    }
                }
                else
                {
                    if (dentist.Equals("-1"))
                    {
                        sp = "locLichHenTrongNgay_pat_dep";
                        type = 6;
                    }
                    else
                    {
                        sp = "locLichHenTrongNgay_pat_dep_den";
                        type = 7;
                    }
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
                        if(type==1||type==3||type==5||type==7)
                        {
                            command.Parameters.Add(new SqlParameter("@dentist", SqlDbType.Char, 10)).Value = dentist;
                        }
                        if (type == 2 || type == 3 || type == 6 || type == 7)
                        {
                            command.Parameters.Add(new SqlParameter("@depID", SqlDbType.Int)).Value = diD;
                        }
                        if (type == 4 || type == 5 || type == 6 || type == 7)
                        {
                            command.Parameters.Add(new SqlParameter("@patientID", SqlDbType.Int)).Value = pId;
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
                    MessageBox.Show("Error");
                    Console.WriteLine(ex.Message);
               }
               finally
               {
                    connection.Close();
               }
            }
            return dsLichHen;
        }
        public IList<LichHenDTO> layDSLichHenTheoNgay(int pId, int diD, string dentist,DateTime date)
        {
            string sp;
            int type = 0;
            if (pId == -1)
            {
                if (diD == -1)
                {
                    if (dentist.Equals("-1"))
                    {
                        sp = "xemLichHenTheoNgay";
                    }
                    else
                    {
                        sp = "locLichHenTheoNgay_den";
                        type = 1;
                    }
                }
                else
                {
                    if (dentist.Equals("-1"))
                    {
                        sp = "locLichHenTheoNgay_dep";
                        type = 2;
                    }
                    else
                    {
                        sp = "locLichHenTheoNgay_dep_den";
                        type = 3;
                    }
                }
            }
            else
            {
                if (diD == -1)
                {
                    if (dentist.Equals("-1"))
                    {
                        sp = "locLichHenTheoNgay_pat";
                        type = 4;
                    }
                    else
                    {
                        sp = "locLichHenTheoNgay_pat_den";
                        type = 5;
                    }
                }
                else
                {
                    if (dentist.Equals("-1"))
                    {
                        sp = "locLichHenTheoNgay_pat_dep";
                        type = 6;
                    }
                    else
                    {
                        sp = "locLichHenTheoNgay_pat_dep_den";
                        type = 7;
                    }
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
                        if (type == 1 || type == 3 || type == 5 || type == 7)
                        {
                            command.Parameters.Add(new SqlParameter("@dentist", SqlDbType.Char, 10)).Value = dentist;
                        }
                        if (type == 2 || type == 3 || type == 6 || type == 7)
                        {
                            command.Parameters.Add(new SqlParameter("@depID", SqlDbType.Int)).Value = diD;
                        }
                        if (type == 4 || type == 5 || type == 6 || type == 7)
                        {
                            command.Parameters.Add(new SqlParameter("@patientID", SqlDbType.Int)).Value = pId;
                        }
                        command.Parameters.Add(new SqlParameter("@date", SqlDbType.Date)).Value = date;
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
                    MessageBox.Show("Error");
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
                    MessageBox.Show("Error");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            MessageBox.Show("Success");
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
                    MessageBox.Show("Error");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            MessageBox.Show("Success");
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
                    MessageBox.Show("Error");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            MessageBox.Show("Success");
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
                    MessageBox.Show("Error");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            MessageBox.Show("Success");
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
                    MessageBox.Show("Error");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            MessageBox.Show("Success");
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
                    MessageBox.Show("Error");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            MessageBox.Show("Success");
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
                    MessageBox.Show("Error");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            MessageBox.Show("Success");
        }
    }
}
