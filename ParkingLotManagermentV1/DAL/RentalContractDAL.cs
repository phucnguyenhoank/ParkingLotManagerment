using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class RentalContractDAL
    {
        public int AddRentalContract(RentalContract rentalContract)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO RentalContract (ContractID, Renter) VALUES (@ContractID, @Renter)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ContractID", rentalContract.ContractID);
                        command.Parameters.AddWithValue("@Renter", rentalContract.Renter);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddRentalContract:{ex.Message}]");
                throw;
            }
        }

    }
}
