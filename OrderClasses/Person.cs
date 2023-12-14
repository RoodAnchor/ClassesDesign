using System;

namespace ClassesDesign.OrderClasses
{
    public abstract class Person
    {
        #region Fields
        private DateTime _birtDate;
        private String _email;
        private String _phoneNumber;
        #endregion Fields

        #region Properties
        public String FirstName { get; private set; }
        public String LastName { get; private set; }
        public DateTime BirthDate 
        { 
            get => _birtDate;
            protected set
            {
                DateTime dateTime;

                if (DateTime.TryParse(LastName, out dateTime))
                {
                    _birtDate = dateTime;
                }
                else
                {
                    Console.WriteLine("Incorrect birthdate format");
                }
            }
        }
        public Int32 Age
        {
            get
            {
                TimeSpan ts = DateTime.Now - BirthDate;

                return (Int32)ts.TotalDays / 365;
            }
        }
        public String PhoneNumber 
        {
            get => _phoneNumber;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Email can not be empty");
                    return;
                };

                if (value.Length < 7)
                {
                    Console.WriteLine("Phone number should be at least 7 digits long");
                    return;
                };

                _phoneNumber = value;
            }
        }
        public Address Address { get; set; }
        public String Email 
        {
            get => _email;
            protected set
            {
                if (!value.Contains("@"))
                {
                    Console.WriteLine("Incorrect Email");
                    return;
                }

                if (String.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Email can not be empty");
                    return;
                }

                _email = value;
            }
        }
        #endregion Properties

        #region Methods
        virtual public String GetAddress() 
        {
            return Address.ToString();
        }
        #endregion Methods

        #region Constructors
        public Person(
            String firstName, String lastName,
            String phoneNumber) 
        { 
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }
        #endregion Constructors
    }
}
