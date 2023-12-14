using System;

using ClassesDesign.OrderClasses.Customers;
using ClassesDesign.OrderClasses.Enums;

namespace ClassesDesign.OrderClasses.Deliveries
{
    abstract public class Delivery<TCustomer>
        where TCustomer : Customer
    {
        #region Properties
        public DateTime ETA { get; protected set; }
        public DeliveryStateEnum State { get; internal set; }
        public TCustomer Customer { get; private set; }
        public String Note { get; set; }
        public Double Price { get; protected set; }
        #endregion Properties

        #region Constructors
        public Delivery(
            DateTime eta, TCustomer customer)
        {
            ETA = eta;
            Customer = customer;
        }
        #endregion Constructors

        #region Methods
        public void NotifyStateChanged(DeliveryStateEnum state, String destination)
        {
            String message = GetNotificationMessage(state, destination);
            NotifyUser(message);
        }

        private void NotifyUser(String message) 
        { 
            //Send message via messanger/sms/email
        }

        private String GetNotificationMessage(DeliveryStateEnum state, String destination) 
        {
            switch (state)
            {
                case DeliveryStateEnum.Shipped:
                    return $"Your order shipped from werehouse. Estimated time of arrival to {destination}: {ETA.ToShortDateString()}";
                case DeliveryStateEnum.Delivered:
                    return $"Your order delivered to {destination}";
                case DeliveryStateEnum.Canceled:
                    return $"Your order has been canceled.";
                default:
                    return $"Your order is on its way to {destination}";
            }
        }

        abstract public void CalculateDeliveryPrice();
        #endregion Methods
    }
}
