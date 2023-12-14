using System;

namespace ClassesDesign.OrderClasses
{
    public class Shop : Company
    {
        #region Properties
        public Int32 Id { get; private set; }
        #endregion Properties

        #region Constructors
        public Shop(
            Int32 id, String name, 
            String description, Int32 tin,
            Address address) : 
            base(name, description, tin)
        {
            Id = id; 
            Address = address;
        }
        #endregion Constructors
    }
}
