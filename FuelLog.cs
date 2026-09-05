using System;
using System.Collections.Generic;
using System.Text;

namespace Fuel_Loger
{
    public class FuelLog
    {
        public DateTime LogDate { get; set; }
        public float Litres {  get; set; }
        public float Cost { get; set; }

        public FuelLog(DateTime date,float litres, float cost)
        {
            LogDate = date;
            Litres = litres;
            Cost = cost;
        }
        
    }
}
