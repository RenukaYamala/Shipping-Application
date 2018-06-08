using System;
using System.Collections.Generic;
using System.Text;

namespace ShipmentApplication.Users
{
    class Driver:User
    {
        Driver driver;
        public string Password { get; set; }
        //public Driver driver { get; set; }
        public string LicenceNumber{ get; set; }
        public string VehicleNumber { get; set; }
        public string TypeOfVehicle { get; set; }
        public float WeightHold { get; set; }
        public Driver GetUser()
        {
            return driver;
        }
        public void SetUser(Driver _driver)
        {
            driver = _driver;
        }
        private void acceptShipment() { }
    }
}
