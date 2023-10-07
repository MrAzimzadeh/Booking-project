using Booking.DataAccess.Abstract;
using Booking.Entities.Concrete;
using CorePackage.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
namespace Booking.DataAccess.Concrete
{
     public class EFCategoryDAL : EfRepositoryBase<Category, AppDbContext>,ICategoryDAL
    {

        public List<Category> GetFeaturedCategories()
        {
            using var context = new AppDbContext();
            var categories = context.Categories
                .Include(x => x.Hotels)
                .Where(x => x.Status == true)
                .Take(12).ToList();

            return categories;
        }

        public List<Category> GetNavbarCategories()
        {
            using var context = new AppDbContext();

            var categories = context.Categories.Where(x => x.Status == true).Take(10).ToList();
            return categories;
        }
    }
}
  