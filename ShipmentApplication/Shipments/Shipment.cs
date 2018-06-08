using System;
using System.Collections.Generic;
using System.Text;

namespace ShipmentApplication.Shipments
{
    public class Shipment
    {
        private string Id { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public string Password { get; set; }
        public int NumberToShare { get; set; }
        public float Weight { get; set; }
        public int[] Dimensions = new int[3];
        public string DateToDeliver { get; set; }
        //Date today = Date.Today;
        //Shipper shipperId = new Shipper();
        //Driver driverId;
        public void CreateShipment() { }
        public void CancelShipment() { }
        public void CrackShipment() { }
        public void ShipmentDetails() { }
    }
}
