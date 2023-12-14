using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDesign.OrderClasses.Utils
{
    public static class ShopProvider
    {
        public static List<Shop> Shops = new List<Shop>
        {
            new Shop(
                0, 
                "Shop 1", 
                "Medium size shop",
                36598354, 
                AddressProvider.GetAddress("Russia")),
            new Shop(
                1,
                "Shop 2",
                "Small size shop in Finland",
                789654,
                AddressProvider.GetAddress("Finland")),
        };

        public static Shop GetShop(int id) =>
            Shops.Where(x => x.Id == id).FirstOrDefault();

        public static Shop GetShop(String shopName) =>
            Shops.Where(x => x.Name == shopName).FirstOrDefault();
    }
}
