using System;

namespace ClassesDesign.OrderClasses
{
    public abstract class Company
    {
        #region Properties
        public String Name { get; set; }
        public String Description { get; set; }
        public String PhoneNumber { get; set; }
        public Address Address { get; set; }
        public Int32 TIN { get; set; }
        #endregion Properties

        #region Constructors
        public Company(
            String name, String description,
            Int32 tin)
        {
            Name = name;
            Description = description;
            TIN = tin;
        }
        #endregion Constructors
    }
}
