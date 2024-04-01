using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccessHelperDAL
    {
        // Hàm tiềm ẩn rủi ro
        public DataTable GetTableData(string tableName, string condition = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = $"SELECT * FROM {tableName}";
                    if (!string.IsNullOrEmpty(condition))
                    {
                        query += " WHERE " + condition;
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetTableData:{ex.Message}]");
                throw;
            }
        }
    }
}
