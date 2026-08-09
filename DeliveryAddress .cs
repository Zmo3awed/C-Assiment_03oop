using System;

namespace oop_2
{
    internal struct DeliveryAddress
    {
        string city;
        string street;
        int bildingNumber;

        public DeliveryAddress(string city, string street, int bildingNumber)
        {
            if (string.IsNullOrWhiteSpace(city))
            {
                throw new ArgumentException("City cannot be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(street))
            {
                throw new ArgumentException("Street cannot be null or empty.");
            }

            if (bildingNumber <= 0)
            {
                throw new ArgumentException("Building number must be greater than zero.");
            }

            this.city = city;
            this.street = street;
            this.bildingNumber = bildingNumber;
        }

        public string GetFullAddress()
        {
            return $"City: {city}, Street: {street}, Building Number: {bildingNumber}";
        }
    }
}