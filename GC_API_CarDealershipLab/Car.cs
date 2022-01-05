using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GC_API_CarDealershipLab
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }

        public Car() { }
        public Car(string make, string model, string year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
    }
}
