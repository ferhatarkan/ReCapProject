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
    public class EfColorDal:IEntityRepository<Color>
    {
        public void Add(Color entity)
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }



        public void Delete(Color entity)
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }


        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                return filter == null
                    ? context.Set<Color>().ToList()
                    : context.Set<Color>().Where(filter).ToList();
            }
        }


        public Color GetById(Expression<Func<Color, bool>> filter = null)
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }



        public void Update(Color entity)
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
