using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

    

        public void Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Ekleme başarısız");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
        public void Update(Car car)
        {
            _carDal.Update(car);
        }


        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
       
        public List<CarDetailDto> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetCarDetails(c=>c.BrandId==brandId);
        }

        public List<CarDetailDto> GetCarsByColorId(int colorId)
        {
            return _carDal.GetCarDetails(c => c.ColorId == colorId);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c=>c.Id==id);
        }
    }
}
