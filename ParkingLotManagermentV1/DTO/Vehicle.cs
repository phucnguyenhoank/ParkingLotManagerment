using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Vehicle
    {
        public string VehicleID { get; set; }
        public string LicensePlate { get; set; }
        public int Occupancy { get; set; }
        public string TypeOfVehicle { get; set; }
        public string CustomerID { get; set; }
        public string ParkingSpotID { get; set; }
    }
}
