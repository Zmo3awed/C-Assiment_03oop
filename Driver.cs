using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    internal class Driver
    {
        int driverId;
        string fullName;
        string phoneNumber;
        public Driver() { } 
        public int DriverId { get { return driverId; } 
            set {
                if (value > 0)
                {
                    driverId = value;
                }
                else
                {
                    throw new ArgumentException("Driver ID must be a positive integer.");
                }



            } 
        }
        public string PhoneNumber { get { return phoneNumber; } 
            set {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    phoneNumber = value;
                }
                else
                {
                    throw new ArgumentException("Phone number cannot be null or empty.");
                }
            }
        }
        public string FullName { get { return fullName; } 
            set {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    fullName = value;
                }
                else
                {
                    throw new ArgumentException("Full name cannot be null or empty.");
                }
            }
        }
        public Driver(int id , string fullname, string phone) { 
            this.DriverId = id;
            this.FullName = fullname;
            this.PhoneNumber = phone;

        }
    }
}
