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
<<<<<<< HEAD
        public List<DepartmentDTO> layDSDepartment()
        {
            List<DepartmentDTO> dsDepartment = new List<DepartmentDTO>();
=======
        public IList<DepartmentDTO> LayDSDepartment()
        {
            List<DepartmentDTO> dsDepartment = new List<DepartmentDTO>();

>>>>>>> d0f334d51b6366f197e82077589d6db50757cd6e
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
<<<<<<< HEAD
                    using (SqlCommand command = new SqlCommand(@"Select * from department", connection))
                    {
=======
                    using (SqlCommand command = new SqlCommand("pr_view_department_list", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
>>>>>>> d0f334d51b6366f197e82077589d6db50757cd6e
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
<<<<<<< HEAD
                                dsDepartment.Add(new DepartmentDTO()
                                {
                                    id = Reader.GetInt32(0),
                                    address = Reader.GetString(1),
=======
                                dsDepartment.Add( new DepartmentDTO()
                                {
                                    id = Convert.ToInt32(Reader["id"]),
                                    address = Reader.IsDBNull(Reader.GetOrdinal("address")) ? "" : Reader["address"].ToString(),
>>>>>>> d0f334d51b6366f197e82077589d6db50757cd6e
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