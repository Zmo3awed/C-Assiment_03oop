using System;

namespace oop_2
{
    internal class ExpressShipment : Shipment
    {
        decimal extraFee;

        public ExpressShipment() : base() { }

        public ExpressShipment(string trackingcode, string describtion, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingcode, describtion, weight, deliveryFee, destination)
        {
            this.ExtraFee = extraFee;
        }

        public decimal ExtraFee
        {
            get { return extraFee; }
            set
            {
                if (value >= 0)
                {
                    extraFee = value;
                }
                else
                {
                    throw new ArgumentException("Extra fee cannot be negative.");
                }
            }
        }

        public override decimal EstimatedCost
        {
            get { return base.EstimatedCost + extraFee; }
        }

        public override string ShipmentType
        {
            get { return "Express Shipment"; }
        }

        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
        }
    }
}