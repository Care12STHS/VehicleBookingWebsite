using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleBookingWebsite.Shared.Domain
{
    public class Order: BaseDomainModel
    {
        public DateTime OrderDateTime { get; set; }
        public int Quantity { get; set; }
        public string Location { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Staff StaffID { get; set; }
    }
}
