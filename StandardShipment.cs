namespace oop_2
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment() : base() { }

        public StandardShipment(string trackingcode, string describtion, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingcode, describtion, weight, deliveryFee, destination)
        {
        }

        public override string ShipmentType
        {
            get { return "Standard Shipment"; }
        }
    }
}