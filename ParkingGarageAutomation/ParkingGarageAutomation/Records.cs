using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarageAutomation
{
    public class Records
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Records() : this(string.Empty, string.Empty) { }
        public Records(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
