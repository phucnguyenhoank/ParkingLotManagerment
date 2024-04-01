using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Contract
    {
        public string ContractID { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }
        public int RentalDurationInDays { get; set; }
        public int Price { get; set; }
        public int PaymentStatus { get; set; }
    }
}
