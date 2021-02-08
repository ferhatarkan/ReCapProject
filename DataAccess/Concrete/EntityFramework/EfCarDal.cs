using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal :IEntityRepository<Car>,ICarDal
    {
        public void Add(Car entity)
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }



        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }



        public Car GetById(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }



        public void Update(Car entity)
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                var updatedEntity = context.Entry(entity); //Referansı yakaldık
                updatedEntity.State = EntityState.Modified; //database e güncellemeyi set ettik
                context.SaveChanges(); // Değişiklikleri kaydettik yani güncelledik
            }
        }
    }
}
