using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMudBlazor.Interfaces;
using TestMudBlazor.Models;

namespace TestMudBlazor.Services
{
    public class MyTableService : IMyTableService
    {
        public List<MyTable> GetTableData()
        {
            return new List<MyTable> {
                new MyTable { Number = 0, Date = new DateTime(2021, 5, 10), TypeOfFuel = "Дизель", LoadingPoint = "Склад 1",
                              Transporter = "Перевозчик 1", Client = "Покупатель 1", DeliveryPoint = "Точка доставки 1", 
                              PricePurchase = 1000, PriceSales = 1100, Costs = 50, Volume = 100 },
                new MyTable { Number = 1, Date = new DateTime(2021, 5, 12), TypeOfFuel = "Бензин", LoadingPoint = "Склад 2",
                              Transporter = "Перевозчик 2", Client = "Покупатель 1", DeliveryPoint = "Точка доставки 1",
                              PricePurchase = 2000, PriceSales = 2200, Costs = 100, Volume = 200 },
                new MyTable { Number = 2, Date = new DateTime(2021, 5, 15), TypeOfFuel = "Дизель", LoadingPoint = "Склад 1",
                              Transporter = "Перевозчик 3", Client = "Покупатель 2", DeliveryPoint = "Точка доставки 2",
                              PricePurchase = 3000, PriceSales = 3300, Costs = 150, Volume = 300 },
                new MyTable { Number = 3, Date = new DateTime(2021, 5, 16), TypeOfFuel = "Уголь", LoadingPoint = "Склад 2",
                              Transporter = "Перевозчик 1", Client = "Покупатель 2", DeliveryPoint = "Точка доставки 2",
                              PricePurchase = 4000, PriceSales = 4400, Costs = 200, Volume = 400 },
                new MyTable { Number = 4, Date = new DateTime(2021, 5, 19), TypeOfFuel = "Нефть", LoadingPoint = "Склад 2",
                              Transporter = "Перевозчик 3", Client = "Покупатель 3", DeliveryPoint = "Точка доставки 2",
                              PricePurchase = 5000, PriceSales = 5500, Costs = 250, Volume = 500 }
            };
        }
    }
}
