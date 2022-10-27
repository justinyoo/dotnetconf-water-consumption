using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class WaterConsumptionModel
    {
        public virtual List<WaterConsumptionItemModel> Data { get; set; } = new List<WaterConsumptionItemModel>();
    }

    public class WaterConsumptionItemModel
    {
        public virtual DateTimeOffset Date { get; set; }
        public virtual decimal Value { get; set; }
    }
}