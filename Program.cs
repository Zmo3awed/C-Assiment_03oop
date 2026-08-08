using System;

namespace oop_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DeliveryAddress d1= new DeliveryAddress("New York", "5th Avenue", 10);
            //DeliveryAddress d2= new DeliveryAddress("Los Angeles", "Sunset Boulevard", 20);
            //d1 = d2; // Copying the value of d2 into d1 
            //d2.bildingNumber = 30; // Changing the building number of d2   but not affecting d1 since they are value types   
            //Console.WriteLine(d1.GetFullAddress());
            //Console.WriteLine(d2.GetFullAddress());


            // 1. Create a DeliveryCenter
            DeliveryCenter center = new DeliveryCenter();

            // 2 & 3. Read data for three shipments
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"--- Enter Shipment {i + 1} Data ---");

                Console.Write("Tracking Code: ");
                string trackingCode = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Weight: ");
                decimal weight = decimal.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal deliveryFee = decimal.Parse(Console.ReadLine());

                Console.WriteLine("--- Enter Delivery Address ---");

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("Street: ");
                string street = Console.ReadLine();

                Console.Write("Building Number: ");
                int buildingNumber = int.Parse(Console.ReadLine());

                DeliveryAddress address =
                    new DeliveryAddress(city, street, buildingNumber);

                Shipment shipment =
                    new Shipment(
                        trackingCode,
                        description,
                        weight,
                        deliveryFee,
                        address
                    );

                // Add shipment to DeliveryCenter
                if (center.AddShipment(shipment))
                {
                    Console.WriteLine("Shipment added successfully.\n");
                }
                else
                {
                    Console.WriteLine("Failed to add shipment.\n");
                }
            }

            // 4. Print the three shipments using the integer indexer
            Console.WriteLine("========== All Shipments ==========");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nShipment {i + 1}:");

                Shipment shipment = center[i];

                shipment.printShipmentDetails();
            }

            // 5. Ask the user to enter a tracking code
            Console.WriteLine("\n========== Search Shipment ==========");

            Console.Write("Enter Tracking Code: ");
            string searchTrackingCode = Console.ReadLine();

            // 6. Search using the string indexer
            Shipment foundShipment = center[searchTrackingCode];

            // 7. Print shipment if found
            if (!string.IsNullOrWhiteSpace(foundShipment.Trackingcode))
            {
                Console.WriteLine("\nShipment Found:");
                foundShipment.printShipmentDetails();
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            // 8. Demonstrate DeliveryAddress struct copy behavior
            Console.WriteLine("\n========== Struct Copy Behavior ==========");

            DeliveryAddress address1 =
                new DeliveryAddress("Cairo", "Nile Street", 10);

            DeliveryAddress address2 = address1;

            Console.WriteLine("Original Address:");
            Console.WriteLine(address1.GetFullAddress());

            Console.WriteLine("\nCopied Address:");
            Console.WriteLine(address2.GetFullAddress());
        }
    }
}