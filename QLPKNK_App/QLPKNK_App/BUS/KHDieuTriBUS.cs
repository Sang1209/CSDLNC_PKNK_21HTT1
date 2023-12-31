﻿using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLPKNK_App.BUS
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
                                dsKHDT.Add(new KHDieuTriDTO()
                                {
                                    id= Convert.ToInt32(Reader["id"]),
                                    department= Reader["address"].ToString(),
                                    dentist= Reader["dentist"].ToString(),
                                    den_name= Reader["den_name"].ToString(),
                                    patient= Convert.ToInt32(Reader["patient"]),
                                    pat_name= Reader["pat_name"].ToString(),
                                    assistant= Reader.IsDBNull(Reader.GetOrdinal("assistant")) ? "" : Reader["assistant"].ToString(),
                                    ass_name= Reader.IsDBNull(Reader.GetOrdinal("ass_name")) ? "" : Reader["ass_name"].ToString(),
                                    description= Reader["description"].ToString(),
                                    date= DateTime.Parse(Reader["date"].ToString()),
                                    note= Reader["note"].ToString(),
                                    method= Reader["method"].ToString(),
                                    tooth_name= Reader["tooth_name"].ToString(),
                                    state= Convert.ToInt32(Reader["state"]),
                                    total= Convert.ToDouble(Reader["total"])
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
            return dsKHDT;
        }

        public IList<KHDieuTriDTO> layDSDieuTri()
        {
            List<KHDieuTriDTO> dsKHDieuTri = new List<KHDieuTriDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(@"Select id from treatment", connection))
                    {
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                dsKHDieuTri.Add(new KHDieuTriDTO()
                                {
                                    id = Reader.GetInt32(Reader.GetOrdinal("id")),
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    MessageBox.Show("Error khdtBUS");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return dsKHDieuTri;
        }

        public void themDieuTri(int patient, int department, string dentist, string assistant, string description, string note, int method, int tooth)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("addTreatment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@patient", patient);
                        command.Parameters.AddWithValue("@department", department);
                        command.Parameters.AddWithValue("@dentist", dentist);
                        command.Parameters.AddWithValue("@assistant", assistant);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@note", note);
                        command.Parameters.AddWithValue("@method", method);
                        command.Parameters.AddWithValue("@tooth", tooth);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
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

