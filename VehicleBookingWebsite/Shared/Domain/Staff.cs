using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleBookingWebsite.Shared.Domain
{
    public class Staff: BaseDomainModel
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public int DrivingLicenseNumber { get; set; }
        public string Password { get; set; }
    }
}
