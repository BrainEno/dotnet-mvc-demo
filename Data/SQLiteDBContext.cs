/*using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Dotnetweb.Data
{
    public class SQLiteDBContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=TestDatabase.db", optionsBuilder =>
             {
                 optionsBuilder.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
             });
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //遍历表格名
            modelBuilder.Entity<Category>().ToTable("Categories", "test");
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasIndex(e => e.Name);
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
*/