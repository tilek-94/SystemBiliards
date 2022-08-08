using SystemBiliards.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows;

namespace SystemBiliards.Infrastucture
{
    public class ApplicationContext : DbContext
    {
     
        public DbSet<Accounts> Accounts { get;  set; }
        public DbSet<CurrTimeTable> CurrTimeTables { get;  set; }
        public DbSet<Historys> Histories { get;  set; }
        public DbSet<Statuses> Statuses { get;  set; }
        public DbSet<Tables> Tables { get;  set; }

        public ApplicationContext()
        {
            
                Database.EnsureCreated();
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;password=123456;database=biliard;",
                 new MySqlServerVersion(new Version(5, 7, 33))
             );
        }
       
    }
}
