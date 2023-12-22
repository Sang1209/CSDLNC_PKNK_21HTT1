﻿using QLPKNK_App.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKNK_App.BUS
{
    public class NhaSiBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;
        IList<NhaSiDTO> layDSNhaSi()
        {
            List<NhaSiDTO> dsNhaSi = new List<NhaSiDTO>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(@"Select * from account_de", connection))
                    {
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                dsNhaSi.Add(new NhaSiDTO()
                                {
                                    username = Reader.GetString(0),
                                    password = Reader.GetString(1),
                                    name = Reader.GetString(2),
                                    phone = Reader.GetString(3),
                                    email = Reader.GetString(4),
                                    address = Reader.GetString(5),
                                    gender=Reader.GetBoolean(6),
                                    depID=Reader.GetInt32(7),
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
            return dsNhaSi;
        }
    }
}