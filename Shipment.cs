using System;

namespace oop_2
{
    internal class Shipment
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

        public Shipment(string trackingcode, string describtion, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.Trackingcode = trackingcode;
            this.Describtion = describtion;
            this.Weight = weight;
            this.DeliveryFee = deliveryFee;
            this.Destination = destination;
        }

        public Shipment(string trackingcode)
        {
            this.trackingcode = string.Empty;
            this.describtion = "Unknown";
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
            get { return weight; }

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
            get { return deliveryFee; }

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

        // virtual: every shipment type calculates it differently (Express/International add extra fees)
        public virtual decimal EstimatedCost
        {
            get { return deliveryFee + (Weight * 5); }
        }

        // virtual: used only to print a nice header ("Standard Shipment" / "Express Shipment" / ...)
        public virtual string ShipmentType
        {
            get { return "Shipment"; }
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

        // Template Method pattern:
        // PrintShipment prints everything shared between all shipment types,
        // then calls PrintExtraDetails() which each child class can override
        // to add its own extra lines (ExtraFee, DestinationCountry, CustomsFee...)
        // EstimatedCost is read through the virtual property, so it is always
        // correct for whichever real type the object actually is.
        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
            {
                this.Weight = newWeight;
            }
            else
            {
                throw new ArgumentException("Weight must be greater than zero.");
            }
        }
      public void UpdateWeight(decimal newWeight, decimal extraweight)
        {
            if (newWeight > 0 && extraweight >= 0)
            {
                this.Weight = newWeight + extraweight;
            }
            else
            {
                throw new ArgumentException("Weight must be greater than zero and extra weight cannot be negative.");
            }
        }
        public virtual void PrintShipment()
        {
            Console.WriteLine(ShipmentType);
            Console.WriteLine();
            Console.WriteLine($"Tracking Code : {Trackingcode}");
            Console.WriteLine($"Description   : {Describtion}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Destination   : {Destination.GetFullAddress()}");
          
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        // Hook method: does nothing by default (StandardShipment doesn't need it).
        // ExpressShipment / InternationalShipment override it to print their own fields.
        
    }
}