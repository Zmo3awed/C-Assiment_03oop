using System;

namespace oop_2
{
    internal class InternationalShipment : Shipment
    {
        string destinationCountry;
        decimal customsFee;

        public InternationalShipment() : base() { }

        public InternationalShipment(string trackingcode, string describtion, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingcode, describtion, weight, deliveryFee, destination)
        {
            this.DestinationCountry = destinationCountry;
            this.CustomsFee = customsFee;
        }

        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
                else
                {
                    throw new ArgumentException("Destination country cannot be null or empty.");
                }
            }
        }

        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
                else
                {
                    throw new ArgumentException("Customs fee cannot be negative.");
                }
            }
        }

        public override decimal EstimatedCost
        {
            get { return base.EstimatedCost + customsFee; }
        }

        public override string ShipmentType
        {
            get { return "International Shipment"; }
        }
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs Report for Shipment {Trackingcode}:");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee        : {CustomsFee} EGP");
        }

        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee        : {CustomsFee} EGP");
        }
    }
}