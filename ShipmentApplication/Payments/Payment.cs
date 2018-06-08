using System;
using System.Collections.Generic;
using System.Text;

namespace ShipmentApplication.Payments
{
    class Payment
    {
        public float AmountToPay { get; set; }
        public string CardNumber { get; set; }
        public string CVV_Number { get; set; }
        public string Card_Name { get; set; }
        public string ExpiryDate { get; set; }
        public string[] BankList = new String[10];

        // Shipment shipmentId;
        // Shipper shipperId;
    }
}
