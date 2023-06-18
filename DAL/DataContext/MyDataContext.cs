using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataContext
{
    public class MyDataContext:DbContext
    {
        public MyDataContext(DbContextOptions<MyDataContext> options):base(options)
        {
                
        }
       public DbSet<Cities> Cities { get;set; }
        public DbSet<CVInfo> CVInfos { get;set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<JobCategories> JobCategories { get; set; }
        public DbSet<Jobİnfo> Jobİnfos { get; set; }
        public DbSet<User> Users { get; set; }
        




    }
}
