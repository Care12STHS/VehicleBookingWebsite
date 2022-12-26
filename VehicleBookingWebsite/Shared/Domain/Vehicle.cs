using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleBookingWebsite.Shared.Domain
{
    public class Vehicle: BaseDomainModel
    {
        public string LicensePlateNumber { get; set; }
        public string Colour { get; set; }
        public int Year { get; set; }
        public string Brand { get; set; }
        public int PassengerCapacity { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual Staff StaffID { get; set; }
        public virtual VehicleType VehicleTypeID { get; set; }
    }
}
