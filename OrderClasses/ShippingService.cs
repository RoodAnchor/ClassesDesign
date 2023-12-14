using System;

namespace ClassesDesign.OrderClasses
{
    public class ShippingService : Company
    {
        #region Properties
        public Courier Courier { get; set; }
        #endregion Properties

        #region Constructors
        public ShippingService(
            String name, String description,
            Int32 tin, Address address, 
            Courier courier) :
            base (name, description, tin)
        {
            Address = address;
            Courier = courier;
        }
        #endregion Constructors

        #region Methods
        public Double GetDeliveryPrice()
        {
            throw new NotImplementedException();
        }
        #endregion Methods
    }
}
