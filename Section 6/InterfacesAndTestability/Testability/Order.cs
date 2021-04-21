using System;

namespace InterfacesAndTestability
{
    public class Order
    {
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }
        public DateTime DatePlaced { get; set; }
        public bool IsShipped
        {
            get { return Shipment != null; }
        }
    }
}