using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ParkingSpot
    {
        public string ParkingSpotID { get; set; }
        public int BeingOccupied { get; set; }
        public string DesignatedFor { get; set; }
        public int Capacity { get; set; }
    }
}
