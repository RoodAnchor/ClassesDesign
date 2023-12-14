using System;

using ClassesDesign.OrderClasses.Customers;

namespace ClassesDesign.OrderClasses.Deliveries
{
    public sealed class ShopDelivery<TCustomer> : Delivery<TCustomer>
        where TCustomer : Customer
    {
        #region Properties
        public Shop Shop { get; private set; }
        public Courier Courier { get; set; }
        #endregion Properties

        #region Constructors
        public ShopDelivery(
            DateTime eta, TCustomer customer,
            Shop shop) : 
            base(eta, customer)
        {
            Shop = shop;
        }

        public ShopDelivery(
            DateTime eta, TCustomer customer,
            Shop shop, Courier courier) : 
            this(eta, customer, shop)
        {
            Courier = courier;
        }
        #endregion Constructors

        #region Methods
        public override void CalculateDeliveryPrice() 
        {
            Price = 0D;
        }
        #endregion Methods
    }
}
