using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleBookingWebsite.Shared.Domain
{
    public class OrderVehicle: BaseDomainModel
    {
        public virtual Order OrderID { get; set; }
        public virtual Vehicle VehicleID { get; set; }
        public virtual VehicleType VehicleTypeID { get; set; }
    }
}
