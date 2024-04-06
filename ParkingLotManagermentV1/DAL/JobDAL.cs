using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class JobDAL
    {
        public int GetValueJobs(List<string> jobNames = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string jobNamesString = string.Join(",", jobNames.Select(name => $"'{name}'"));
                    string sql = $"SELECT SUM(JobValue) FROM Job WHERE JobName IN ({jobNamesString})";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        object result = command.ExecuteScalar();
                        return result == DBNull.Value ? 0 : Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetValueJobs:{ex.Message}]");
                throw;
            }
        }

        public string GetIDJob(string jobName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT JobID FROM Job WHERE JobName = @JobName";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@JobName", jobName);

                        object result = command.ExecuteScalar();
                        return result == null ? null : result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetIDJob:{ex.Message}]");
                throw;
            }
        }



    }
}
