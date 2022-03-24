using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace _22032022_Filter.Models
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<LogTable> Loglar { get; set; }
    }
}