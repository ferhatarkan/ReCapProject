using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            carManager.Add(new Car { DailyPrice = 5000, Description = "temiz", ModelYear = 2010 });
            colorManager.Add(new Color { ColorName = "Mor" });
            brandManager.Add(new Brand { BrandName = "Citröen" });
            

        }
    }
}
