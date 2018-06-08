using System;
using System.Collections.Generic;
using System.Text;

namespace ShipmentApplication.Users
{
    public class Shipper : User
    {
        public Shipper shipper { get; set; }
        public string Password { get; set; }
        //dynamic  shipper=new Shipper();
        public Shipper GetUser()
        {
            return shipper;
        }
        public void SetUser(Shipper _shipper)
        {
            shipper = _shipper;
        }
        public void rate() { }
        //Shipment Shipments[];
    }
}
