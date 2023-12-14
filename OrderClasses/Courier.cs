using System;

namespace ClassesDesign.OrderClasses
{
    public sealed class Courier : Person
    {
        #region Properties
        public Company Company { get; set; }
        #endregion Properties

        #region Constructors
        public Courier(
            String firstName, String lastName,
            String phoneNumber, String email) :
            base(firstName, lastName, phoneNumber)
        {
            Email = email;
        }
        #endregion Constructors

        #region Methods
        public override String GetAddress()
        {
            return Company?.Address?.ToString();
        }
        #endregion Methods
    }
}
