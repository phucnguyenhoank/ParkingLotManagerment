using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VehicleDAL
    {
        public int AddVehicle(Vehicle vehicle)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SharedConnectionString.ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Vehicle (VehicleID, LicensePlate, Occupancy, TypeOfVehicle, CustomerID, ParkingSpotID) VALUES (@VehicleID, @LicensePlate, @Occupancy, @TypeOfVehicle, @CustomerID, @ParkingSpotID)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", vehicle.VehicleID);
                        command.Parameters.AddWithValue("@LicensePlate", vehicle.LicensePlate);
                        command.Parameters.AddWithValue("@Occupancy", vehicle.Occupancy);
                        command.Parameters.AddWithValue("@TypeOfVehicle", vehicle.TypeOfVehicle);
                        command.Parameters.AddWithValue("@CustomerID", vehicle.CustomerID);
                        command.Parameters.AddWithValue("@ParkingSpotID", vehicle.ParkingSpotID);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddVehicle:{ex.Message}]");
                throw;
            }
        }

    }
}
