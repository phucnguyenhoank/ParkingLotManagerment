using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContractDAL
    {
        public int AddContract(Contract contract)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Contract (ContractID, RentalStartDate, RentalEndDate, RentalDurationInDays, Price, PaymentStatus) VALUES (@ContractID, @RentalStartDate, @RentalEndDate, @RentalDurationInDays, @Price, @PaymentStatus)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ContractID", contract.ContractID);
                        command.Parameters.AddWithValue("@RentalStartDate", contract.RentalStartDate);
                        command.Parameters.AddWithValue("@RentalEndDate", contract.RentalEndDate);
                        command.Parameters.AddWithValue("@RentalDurationInDays", contract.RentalDurationInDays);
                        command.Parameters.AddWithValue("@Price", contract.Price);
                        command.Parameters.AddWithValue("@PaymentStatus", contract.PaymentStatus);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddContract:{ex.Message}]");
                throw;
            }
        }



    }
}
