using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDesign.OrderClasses.Utils
{
    public class AddressProvider
    {
        public static List<Address> Addresses = new List<Address>
        {
            new Address("Russia", "Saint-Petersburg", "Primorskiy ave.", 197374, 54, 2),
            new Address("Finland", "Helsinki", "Manerheimin katu", 97632, 12, 142)
        };

        public static Address GetAddress(String country) =>
            Addresses.FirstOrDefault(x => x.Country == country);
    }
}
