using System;
using System.Collections.Generic;
using System.Text;

namespace Assimant006
{
    #region part02(2)
    //public struct Shipment
    //{
    //private fields:
    //private string TrackingCode;
    //private string Description;
    //public double Weight;
    //private decimal DeliveryFee;
    //private DeliveryAddress Destination;








    //public string trackingCode
    //{
    //    get => trackingCode;
    //    private set

    //    {
    //        if (!string.IsNullOrWhiteSpace(value))
    //        {
    //            trackingCode = value;
    //        }

    //    }
    //}

    //public string description
    //{
    //    get => description;
    //    private set

    //    {
    //        if (!string.IsNullOrWhiteSpace(value))
    //        {
    //            description = value;
    //        }
    //    }
    //}


    //public double weight
    //{
    //    get => weight;
    //    private set

    //    {
    //        if (value > 0)
    //        {
    //            weight = value;
    //        }

    //    }
    //}


    //public double deliveryfee
    //{
    //    get => deliveryfee;
    //    private set

    //    {
    //        if (value > 0)
    //        {
    //            deliveryfee = value;
    //        }

    //    }
    //}
    //public decimal Estimatedcost => DeliveryFee + (decimal)(weight * 5);


    #endregion

    #region prt02(3)
    //public struct Shipment
    //{
    //    public string TrackingCode { get; set; }
    //    public string Description { get; set; }
    //    public double Weight { get; set; }
    //    public decimal DeliveryFee { get; set; }
    //    public DeliveryAddress Destination { get; set; }


    //    public Shipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destination)
    //    {
    //        TrackingCode = trackingcode;
    //        Description = description;
    //        Weight = weight;
    //        DeliveryFee = deliveryfee;
    //        Destination = destination;

    //    }

    //    public Shipment(string TrackingCode) : this(TrackingCode, "UnKnown", 1, 50m, new DeliveryAddress())
    //    {

    //    }
    //}

    #endregion

    #region part02(4)
    //public struct Shipment
    //{
    //    public string TrackingCode { get; set; }
    //    public string Description { get; set; }
    //    public double Weight { get; set; }
    //    public decimal DeliveryFee { get; set; }
    //    public DeliveryAddress Destination { get; set; }


    //    public Shipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destination)
    //    {
    //        TrackingCode = trackingcode;
    //        Description = description;
    //        Weight = weight;
    //        DeliveryFee = deliveryfee;
    //        Destination = destination;

    //    }

    //    public Shipment(string TrackingCode) : this(TrackingCode, "UnKnown", 1, 50m, new DeliveryAddress())
    //    {

    //    }
    //    public decimal Estimatedcost => DeliveryFee + (decimal)(Weight * 5);
    //    public void UpdateDelivaryFee(decimal newFee)
    //    {
    //        if (newFee > 0)
    //        {
    //            DeliveryFee = newFee;
    //        }
    //    }
    //    public void  printShipment()
    //    {
    //        Console.WriteLine($"TrackingCode:{TrackingCode},Description:{Destination},Weight:{Weight}Kg,deliveryfee:{DeliveryFee},Address:{Destination.city},{Destination.street},Estimated Cost:{Estimatedcost}");
    //    }
    #endregion

    }
}











