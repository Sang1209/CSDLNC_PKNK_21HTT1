using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPKNK_App.BUS
{
    internal class MedUseBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;
        public IList<MedUseDTO> getMedUseToday()
        {
            List<MedUseDTO> medUseToday = new List<MedUseDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("pr_used_medicine_day", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {

                            while (Reader.Read())
                            {
                                medUseToday.Add(new MedUseDTO()
                                {
                                    medID = Reader["medicine"].ToString(),
                                    medName = Reader["name"].ToString(),
                                    usage = Convert.ToInt32(Reader["usage_count"])
                                });
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
            return medUseToday;
        }
        public IList<MedUseDTO> getMedUseMonth()
        {
            List<MedUseDTO> medUseToday = new List<MedUseDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("pr_used_medicine_month", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {

                            while (Reader.Read())
                            {
                                medUseToday.Add(new MedUseDTO()
                                {
                                    medID = Reader["medicine"].ToString(),
                                    medName = Reader["name"].ToString(),
                                    usage = Convert.ToInt32(Reader["usage_count"])
                                });
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
            return medUseToday;
        }
    }
}
