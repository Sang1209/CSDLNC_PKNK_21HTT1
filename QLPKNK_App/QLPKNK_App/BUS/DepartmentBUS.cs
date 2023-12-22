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
using QLPKNK_App.utils;

namespace QLPKNK_App.BUS
{
    internal class DepartmentBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;
        public IList<DepartmentDTO> LayDSDepartment()
        {
            List<DepartmentDTO> dsDepartment = new List<DepartmentDTO>();

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("pr_view_department_list", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                dsDepartment.Add( new DepartmentDTO()
                                {
                                    id = Convert.ToInt32(Reader["id"]),
                                    address = Reader.IsDBNull(Reader.GetOrdinal("address")) ? "" : Reader["address"].ToString(),
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
            return dsDepartment;
        }
    }
}