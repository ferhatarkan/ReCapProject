using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
       

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length > 2 )
            {
                _brandDal.Add(brand);
            }
            else
            {
                Console.WriteLine("Ekleme başarısız");
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }


        public List<Brand> GetCarsByBrandId(int brandId)
        {
            return _brandDal.GetAll().Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }
}
