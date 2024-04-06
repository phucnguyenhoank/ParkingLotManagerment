using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ContractSigningDAL
    {
        public int AddContractSigning(ContractSigning contractSigning)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO ContractSigning (VehicleID, ContractID) VALUES (@VehicleID, @ContractID)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", contractSigning.VehicleID);
                        command.Parameters.AddWithValue("@ContractID", contractSigning.ContractID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddContractSigning:{ex.Message}]");
                throw;
            }
        }

    }
}
