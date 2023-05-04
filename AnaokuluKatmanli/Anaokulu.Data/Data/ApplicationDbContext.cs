using AnaokuluKatmanli.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anaokulu.Data.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Ogretmenler> Ogretmenler { get; set; }
        public virtual DbSet<Ogrenciler> Ogrenciler { get; set; }
        public virtual DbSet<Etkinlikler> Etkinlikler { get; set; }
        public virtual DbSet<Dersler> Dersler { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }
    }
}
