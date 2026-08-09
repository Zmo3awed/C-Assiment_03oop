using System;

namespace oop_2
{
    internal class DeliveryCenter
    {
        string centerName;

        // must be private per the requirements - kept private (no modifier = private by default in a class)
        private Shipment[] shipments = new Shipment[20];


        public Driver Driver { get; set; }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }

                return null;
            }

            set
            {
                if (index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(trackingCode))
                {
                    return null;
                }

                foreach (Shipment shipment in shipments)
                {
                    // shipment can be null (empty slot) now that Shipment is a class,
                    // so we must check for null BEFORE reading .Trackingcode
                    if (shipment != null && shipment.Trackingcode == trackingCode)
                    {
                        return shipment;
                    }
                }

                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            if (shipment == null || string.IsNullOrWhiteSpace(shipment.Trackingcode))
            {
                return false;
            }

            for (int i = 0; i < shipments.Length; i++)
            {
                // an empty slot is now null, not a "default" struct with an empty tracking code
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            if (string.IsNullOrWhiteSpace(trackingCode))
            {
                return false;
            }

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && shipments[i].Trackingcode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }

            return false;
        }

        public void PrintAllShipments()
        {
            foreach (Shipment shipment in shipments)
            {
                if (shipment != null)
                {
                    shipment.PrintShipment();
                    Console.WriteLine("------------------------------------------");
                }
            }
        }

        public string CenterName
        {
            get { return centerName; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    centerName = value;
                }
                else
                {
                    throw new ArgumentException("Center name cannot be null or empty.");
                }
            }
        }
    }
}