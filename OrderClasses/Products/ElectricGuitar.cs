using ClassesDesign.OrderClasses.Enums;
using System;

namespace ClassesDesign.OrderClasses.Products
{
    public sealed class ElectricGuitar : Product
    {
        #region Properties
        public Byte StringsCount { get; set; }        
        public PickupsEnum Pickups { get; set; }
        //Other guitar props...
        #endregion Properties

        #region Constructors
        public ElectricGuitar(
            Int32 id, String name,
            String description, Double price, 
            Byte stringsCount, PickupsEnum pickups) :
            base(id, name, description, price)
        {
            StringsCount = stringsCount;
            Pickups = pickups;
        }
        #endregion Constructors

        #region Methods
        public override String GetProductDetails()
        {
            return String.Format($"Strings count: {StringsCount}, Pickups type: {Pickups}");
        }
        #endregion Methods
    }
}
