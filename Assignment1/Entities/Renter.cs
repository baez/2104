using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1.Entities
{
    public class Renter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public int DriversLicenseNumber { get; set; }
        public DateTime LicenseExpiryDate { get; set; }

        public DateTime VehicleCheckIn { get; set; }
        public DateTime VehicleCheckOut { get; set; }
        public int MileageAtCheckIn { get; set; }
        public int MileageAtCheckout { get; set; }

        public string VIN { get; set; }

        public Renter() { }
        public Renter(string firstname, string lastname, string address, int phonenumber, int driversLicenseNumber, DateTime licenseExpiryDate, DateTime vehicleCheckIn, DateTime vehicleCheckOut, int mileageAtCheckIn, int mileageAtCheckOut, string vin)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Address = address;
            this.PhoneNumber = phonenumber;
            this.DriversLicenseNumber = driversLicenseNumber;
            this.LicenseExpiryDate = licenseExpiryDate;
            this.VehicleCheckIn = vehicleCheckIn;
            this.VehicleCheckOut = vehicleCheckOut;
            this.MileageAtCheckIn = mileageAtCheckIn;
            this.MileageAtCheckout = mileageAtCheckOut;
            this.VIN = vin;
        }
    }
}
