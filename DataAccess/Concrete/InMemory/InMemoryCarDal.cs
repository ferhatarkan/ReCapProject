using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{BrandId=1,ColorId=1,DailyPrice=500,Id=1,ModelYear=2006,Description="Mercedes"},
                new Car{BrandId=2,ColorId=1,DailyPrice=200,Id=2,ModelYear=2007,Description="Audi"},
                new Car{BrandId=1,ColorId=2,DailyPrice=300,Id=3,ModelYear=2008,Description="Renault"},
                new Car{BrandId=2,ColorId=2,DailyPrice=160,Id=4,ModelYear=2009,Description="WolksWagen"},
                new Car{BrandId=2,ColorId=2,DailyPrice=500,Id=5,ModelYear=2010,Description="Ford"}
            };
        }
       

        public void Add(Car car)
        {
            _cars.Add(car);
        }

      

        public void Delete(Car car)
        {
           _cars.Remove( _cars.SingleOrDefault(c => c.Id == car.Id));
        }

        public List<Car> GetAll()
        {

            return _cars;
        }

        public List<Car> GetById()
        {
            return _cars;
        }

       
        public void Update(Car car)
        {
            var updateToCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            car.Id = updateToCar.Id;
            car.ColorId = updateToCar.ColorId;
            car.BrandId = updateToCar.BrandId;
            car.DailyPrice = updateToCar.DailyPrice;
            car.Description = updateToCar.Description;
            car.ModelYear = updateToCar.ModelYear;

        }
    }
}
