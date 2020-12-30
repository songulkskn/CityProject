using Microsoft.EntityFrameworkCore;
using SehirRehberi.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Data
{
    // appsettings.json a gidildİ CONNECTİONSTRİNGS AÇILDIIIII!!! ORADA BAĞLANILDI hangi data base olduğu
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) //Const.
        {

        }
        public DbSet<Value> Values { get; set; }   // value modeli ile values tablosunu bağla demek.
        public DbSet<City> Cities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }

    }
}



