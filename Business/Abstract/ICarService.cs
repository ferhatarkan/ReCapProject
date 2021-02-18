using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int id);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<CarDetailDto> GetCarDetails();
        List<CarDetailDto> GetCarsByBrandId(int brandId);
        List<CarDetailDto> GetCarsByColorId(int colorId);
 

    }
}
