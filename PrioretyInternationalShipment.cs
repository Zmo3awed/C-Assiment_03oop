using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    internal class PrioretyInternationalShipment: InternationalShipment
    {
        public PrioretyInternationalShipment() : base() { }
        public PrioretyInternationalShipment(string trackingcode, string describtion, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingcode, describtion, weight, deliveryFee, destination, destinationCountry, customsFee)
        {
        }
        public override string ShipmentType
        {
            get { return "Priority International Shipment"; }
        }
        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine("Generating priority customs report...");
            // Add logic for generating priority customs report
        }
    }
}
