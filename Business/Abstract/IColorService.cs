using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Car car);
        void Delete(Car car);
        List<Car> GetAll();
        Car GetCarsById(int id);
        void Update(Car car);
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);

    }
}
