using System;

namespace oop_2
{
    internal struct DeliveryCenter

    {
        public DeliveryCenter() { }
        Shipment[] shipments = new Shipment[10];

        public Shipment this[int s]
        {
            get
            {
                if (s >= 0 && s < shipments.Length)
                {
                    return shipments[s];
                }

                return default;
            }

            set
            {
                if (s >= 0 && s < shipments.Length)
                {
                    shipments[s] = value;
                }
            }
        }

        public Shipment this[string trackingcode]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(trackingcode))
                {
                    return default;
                }

                foreach (Shipment shipment in shipments)
                {
                    if (!string.IsNullOrWhiteSpace(shipment.Trackingcode) &&
                        shipment.Trackingcode == trackingcode)
                    {
                        return shipment;
                    }
                }

                return default;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            if (string.IsNullOrWhiteSpace(shipment.Trackingcode))
            {
                return false;
            }

            for (int i = 0; i < shipments.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(shipments[i].Trackingcode))
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }
    }
}