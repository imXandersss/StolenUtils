using System;
namespace StolenUtils.Models{
    public class MyDBContext : DbContext{
        public DbSet<Robo> Robos{get;set;}
    }


}