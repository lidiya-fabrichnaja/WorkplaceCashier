using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.Abstactions;

namespace DAL
{
    /// <summary>
    /// определяет контекст данных, используемый для взаимодействия с базой данных
    /// </summary>
    public class Context : DbContext
    {
      
        public Context() : base("name=sqlExpressConnectionString")
        {
            Database.SetInitializer(new MyDataBaseInitializer());
        }

        /// <summary>
        /// набор данных сущности для взаимодействия с бд
        /// </summary>
        public DbSet<Unit> Units { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Seller> Seller { get; set; }
        public DbSet<Check> Checks { get; set; }
        public DbSet<CheckRow> CheckRows { get; set; }
        public DbSet<CashBox> CashBoxs { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<User> Users { get; set; }

        

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Session>().Property(x => x.EndDate).HasColumnType("datetime").IsOptional();

            modelBuilder.Entity<Check>().Property(x => x.Date).HasColumnType("datetime").IsOptional();

            base.OnModelCreating(modelBuilder);
        }

    }
}
