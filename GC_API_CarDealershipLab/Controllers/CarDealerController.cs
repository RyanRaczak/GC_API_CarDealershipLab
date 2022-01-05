using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GC_API_CarDealershipLab.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarDealerController : ControllerBase
    {
        
        /////////////////////////
        //INTERNAL DB SEARCHING//
        /////////////////////////
       
        List<Car> Cars = new List<Car>()
        {
         new Car("Plymouth", "Breeze", "1997", "Grey"),
         new Car("Dodge", "Challenger", "1972", "Black"),
         new Car("Dodge", "Challenger", "2021", "Black"),
         new Car("Ford", "F-150", "2015", "Red"),
         new Car("Ford", "F-150", "1924", "Red"),
         new Car("Chevy", "Malibu", "2010", "White")
        };

        [HttpGet]
        public List<Car> GetAllCars()
        {
            return Cars;
        }

        [HttpGet]
        [Route("SortColor/{color}")]
        public List<Car> GetByColor(string color)
        {
            List<Car> sortedCars = new List<Car>();
            foreach (var vehicle in Cars)
            {
                if (color.Trim().ToLower() == vehicle.Color.Trim().ToLower())
                {
                    sortedCars.Add(vehicle);
                }
            }
            return sortedCars;
        }

        [HttpGet]
        [Route("SortMake/{make}")]
        public List<Car> GetByMake(string make)
        {
            List<Car> sortedCars = new List<Car>();
            foreach (var vehicle in Cars)
            {
                if (make.Trim().ToLower() == vehicle.Make.Trim().ToLower())
                {
                    sortedCars.Add(vehicle);
                }
            }
            return sortedCars;
        }

        [HttpGet]
        [Route("SortModel/{model}")]
        public List<Car> GetByModel(string model)
        {
            List<Car> sortedCars = new List<Car>();
            foreach (var vehicle in Cars)
            {
                if (model.Trim().ToLower() == vehicle.Model.Trim().ToLower())
                {
                    sortedCars.Add(vehicle);
                }
            }
            return sortedCars;
        }

        [HttpGet]
        [Route("SortYear/{year}")]
        public List<Car> GetByYear(string year)
        {
            List<Car> sortedCars = new List<Car>();
            foreach (var vehicle in Cars)
            {
                if (year == vehicle.Year)
                {
                    sortedCars.Add(vehicle);
                }
            }
            return sortedCars;
        }

        [HttpGet]
        [Route("SortIndex/{index}")]
        public Car GetByIndex(int index)
        {
            try
            {
                return Cars[index];
            }
            catch (ArgumentOutOfRangeException)
            {
                Car blank = new Car();
                return blank;
            }
        }

        ////////////////////
        //SQL DB SEARCHING//
        ////////////////////

        [HttpGet]
        [Route("Search/{property}/{value}")]
        public List<Car> SearchCars(string property, string value)
        {
            //DAL SEARCH
            return null;
        }
    }
}
