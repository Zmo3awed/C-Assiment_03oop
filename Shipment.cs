using System;

namespace oop_2
{
    internal struct Shipment
    {
        string trackingcode;
        string describtion;
        decimal weight;
        decimal deliveryFee;
        DeliveryAddress destination;
         
        public Shipment()
        {
            this.trackingcode = string.Empty;
            this.describtion = string.Empty;
            this.weight = 0;
            this.deliveryFee = 0;
            this.destination = default;
        }
        public Shipment(string trackingcode, string describtion, decimal weight, decimal DeliveryFee, DeliveryAddress destination)
        {
            

            this.Trackingcode = trackingcode;
            this.Describtion = describtion;
            this.Weight = weight;
            this.DeliveryFee = DeliveryFee;
            this.Destination = destination;
        }

        public Shipment(string trackingcode)
        {
            this.trackingcode = string.Empty;
            this.describtion = "UnKnown";
            this.weight = 1;
            this.deliveryFee = 50;
            this.destination = default;

            this.Trackingcode = trackingcode;
        }

        public string Trackingcode
        {
            get { return trackingcode; }

            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingcode = value;
                }
                else
                {
                    throw new ArgumentException("Tracking code cannot be null or empty.");
                }
            }
        }

        public string Describtion
        {
            get { return describtion; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    describtion = value;
                }
                else
                {
                    throw new ArgumentException("Describtion cannot be null or empty.");
                }
            }
        }

        public decimal Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException("Weight must be greater than zero.");
                }
            }
        }

        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }

            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
                else
                {
                    throw new ArgumentException("Delivery fee must be greater than zero.");
                }
            }
        }

        public DeliveryAddress Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public decimal EstimatedCost
        {
            get { return deliveryFee + (Weight * 5); }
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                this.DeliveryFee = newFee;
            }
            else
            {
                throw new ArgumentException("Delivery fee must be greater than zero.");
            }
        }

        public void printShipmentDetails()
        {
            Console.WriteLine($"Tracking Code: {Trackingcode}");
            Console.WriteLine($"Description: {Describtion}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
            Console.WriteLine($"Estimated Cost: ${EstimatedCost}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        }
    }
}