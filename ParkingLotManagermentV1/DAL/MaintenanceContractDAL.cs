using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class MaintenanceContractDAL
    {
        public int AddMaintenanceContract(MaintenanceContract maintenanceContract)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO MaintenanceContract (ContractID, WarrantyDurationInMonths) VALUES (@ContractID, @WarrantyDurationInMonths)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ContractID", maintenanceContract.ContractID);
                        command.Parameters.AddWithValue("@WarrantyDurationInMonths", maintenanceContract.WarrantyDurationInMonths);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddMaintenanceContract:{ex.Message}]");
                throw;
            }
        }

    }
}
