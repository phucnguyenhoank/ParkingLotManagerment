using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ContractDetailDAL
    {
        public int AddContractDetail(ContractDetail contractDetail)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO ContractDetail (ContractID, JobID, CustomerID, Wage) VALUES (@ContractID, @JobID, @CustomerID, @Wage)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ContractID", contractDetail.ContractID);
                        command.Parameters.AddWithValue("@JobID", contractDetail.JobID);
                        command.Parameters.AddWithValue("@CustomerID", contractDetail.CustomerID);
                        command.Parameters.AddWithValue("@Wage", contractDetail.Wage);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddContractDetail:{ex.Message}]");
                throw;
            }
        }

    }
}
