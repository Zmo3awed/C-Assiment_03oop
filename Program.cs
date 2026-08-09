using System;

namespace oop_2
{
    internal class Program
    {
        static string Check_Type() {
            string[] shipmentTypes = { "Standard", "Express", "International" };
            Console.WriteLine();
            Console.WriteLine("Choose Shipment Type");
            Console.WriteLine("enter 1 for Standard");
            Console.WriteLine("enter 2 for Express");
            Console.WriteLine("enter 3 for International");
            int choice = Check_int(Console.ReadLine());
           
            switch (choice)
            {

                case 1:
                    return  "Standard";
                    break;
                case 2:
                    return "Express";
                    break;
                case 3:
                    return  "International";
                    break;
                default:
                    Console.WriteLine("Invalid choice. Adding Standard Shipment by default.");
                    return "Standard";
                    break;
            }

        }

        static string Check_string(string s) {
           
            if (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("your string should not be null or white space ");
                return Check_string(Console.ReadLine());

            }
            else             {
                return s;
            }
        }
        static decimal Check_decimal(string s)
        {
            if (!decimal.TryParse(s, out decimal result) )

            {
                
                Console.WriteLine("your input should be an integer ");
                return Check_decimal(Console.ReadLine());
            }
            else
            {
                if(result <= 0)
                {
                    Console.WriteLine("your input should be a positive number ");
                    return Check_decimal(Console.ReadLine());
                }
                return result;
            }
        }
        static int Check_int(string s)
        {
            if (!int.TryParse(s, out int result)&&result <= 0)
            {
                Console.WriteLine("your input should be an integer ");
                return Check_int(Console.ReadLine());
            }
            else
            {
                return result;
            }
        }


        static void Add_Shipment( DeliveryCenter center, Shipment[] shipments,ref int index)
        {
            
            string type = Check_Type();

            Console.WriteLine($"--- Enter {type} Shipment Data ---");
            Console.Write("Tracking Code: ");
            string trackingCode = Check_string(Console.ReadLine());
            Console.Write("Description: ");
            string description =Check_string( Console.ReadLine());
            Console.Write("Weight: ");
            decimal weight = Check_decimal(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal deliveryFee = Check_decimal(Console.ReadLine());
            Console.WriteLine("--- Enter Delivery Address ---");
            Console.Write("City: ");
            string city = Check_string(Console.ReadLine());
            Console.Write("Street: ");
            string street = Check_string(Console.ReadLine());
            Console.Write("Building Number: ");
            int buildingNumber = Check_int(Console.ReadLine());

            DeliveryAddress address = new DeliveryAddress(city, street, buildingNumber);

            Shipment shipment;

            if (type == "Express")
            {
                Console.Write("Extra Fee: ");
                decimal extraFee = Check_decimal(Console.ReadLine());
                shipment = new ExpressShipment(trackingCode, description, weight, deliveryFee, address, extraFee);
            }
            else if (type == "International")
            {
                Console.Write("Destination Country: ");
                string destinationCountry = Check_string(Console.ReadLine());
                Console.Write("Customs Fee: ");
                decimal customsFee = Check_decimal(Console.ReadLine());
                shipment = new InternationalShipment(trackingCode, description, weight, deliveryFee, address, destinationCountry, customsFee);
            }
            else
            {
                shipment = new StandardShipment(trackingCode, description, weight, deliveryFee, address);
            }

            if (center.AddShipment(shipment))
            {
                Console.WriteLine("Shipment Added Successfully.\n");
                DlevireHelper.PrintShipmentDetailes(shipment);
                shipments[index++] = shipment; // Store the shipment in the array
            }
            else
            {
                Console.WriteLine("Failed to add shipment.\n");
            }
        }

        static void Main(string[] args)
        {
            /*Theoretical Questions
             * Q1 a)  What is the difference between Method Overloading and Method Overriding?
             * --> Method Overloading: Method overloading allow for you to make more than one method at the same class has same behaveor but deffrint in params.
             * --> Method Overriding: Method overriding is a feature that allows to take the part of method implementation or all or no thing and you can make your own behaveor .
             *Q2  b)  What is the difference between Static Binding and Dynamic Binding?
             *static binding: Static binding is a compile-time mechanism where the method to be invoked is determined at compile time based on the reference type. It is also known as early binding. In static binding, the method call is resolved based on the declared type of the object reference.
             *dynamic binding: Dynamic binding is a runtime mechanism where the method to be invoked is determined at runtime based on the actual object type. It is also known as late binding. In dynamic binding, the method call is resolved based on the actual type of the object being referenced, allowing for polymorphic behavior.
             *a)  What is the purpose of the sealed keyword when applied to a class?
             * --> prevent the inhertance of the class and to ensure that the class's behavior remains unchanged.
             *b)  What is the difference between a sealed class and a sealed method?
             * --> A sealed class is a class that cannot be inherited, while a sealed method is a method that cannot be overridden in derived classes. A sealed class prevents further derivation, while a sealed method prevents further customization of the method's behavior in subclasses.
             *c)  Can a sealed method be overridden? Why?
             * --> no becauce sealed keyword is prevent the overriding for methods 


            
             
             */
            #region Decleration
            Driver driver = new Driver(20, "Zyad Mohamed", "01114195719");
            DeliveryCenter center = new DeliveryCenter();

            // 2. Read the center name from the use5
            // r
            Console.Write("Enter Delivery Center Name: ");
            center.CenterName = Check_string(Console.ReadLine());
            Console.WriteLine();
            #endregion
         Shipment[] shipments = new Shipment[10];
         int index = 0;
         Add_Shipment(center,shipments,ref index);
         Add_Shipment(center,shipments,ref index);
         Add_Shipment(center,shipments,ref index);

         #region print all shipments
            // 8. Print all shipments
            Console.WriteLine("============================================");
            Console.WriteLine($"Delivery Center : {center.CenterName}");
            Console.WriteLine("============================================");
            center.PrintAllShipments();
            #endregion 

            Console.WriteLine("------------------test Update Weight----------------------");
            Shipment s1 = new StandardShipment("SHP001", "Electronics", 2.5m, 50m, new DeliveryAddress("Cairo", "Tahrir St", 10));
            s1.UpdateWeight(5.2m);
            s1.PrintShipment();
            s1.UpdateWeight(5.2m, 1.0m); // Update weight with extra weight
            s1.PrintShipment();
            Console.WriteLine("------------------end test Update Weight----------------------");


          for(int i = 0; i < shipments.Length; i++)
          {
            if (shipments[i] != null)
            {
                Console.WriteLine($"Shipment {i + 1}:");
                DlevireHelper.PrintShipmentDetailes(shipments[i]);
                Console.WriteLine();
            }
            }

            /*
             * sealed class: A sealed class is a class that cannot be inherited. It is declared using the sealed keyword. Sealed classes are used to prevent further derivation and to ensure that the class's behavior remains unchanged.
             * sealed methods: A sealed method is a method that cannot be overridden in derived classes. It is declared using the sealed keyword in the method declaration. Sealed methods are used to prevent further customization of the method's behavior in subclasses.

             */


        }
    }
}