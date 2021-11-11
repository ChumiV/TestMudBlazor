using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMudBlazor.Models
{
    public class MyTable
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string TypeOfFuel { get; set; }
        public string LoadingPoint { get; set; }
        public string Transporter { get; set; }
        public string Client { get; set; }
        public string DeliveryPoint { get; set; }
        public int PricePurchase { get; set; }
        public int PriceSales { get; set; }
        public int Costs { get; set; }
        public int Volume { get; set; }
        public int Revenue { get { return PriceSales * Volume; } } 
        public int Profit { get { return Revenue - Costs - PricePurchase; } }

        public MyTable()
        {
            Date = new DateTime();
        }
    }
}
