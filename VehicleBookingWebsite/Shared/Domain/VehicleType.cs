using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleBookingWebsite.Shared.Domain
{
    public class VehicleType: BaseDomainModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
