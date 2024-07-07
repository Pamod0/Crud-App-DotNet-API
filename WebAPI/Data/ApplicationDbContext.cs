using Microsoft.EntityFrameworkCore;
using WebAPI.Models.Domain;

namespace WebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

    //class DataControll
    //{
    //    static void Main(string[] args)
    //    {
    //        using (var db = new ApplicationDbContext())
    //        {
    //            var query = 
    //                from c in db.Categories
    //                where c.Name == "Angular"
    //                select c;

    //            foreach (var category in query)
    //            {
    //                Console.WriteLine(category.Name);
    //            }

    //        }
    //    }
    //}
}
