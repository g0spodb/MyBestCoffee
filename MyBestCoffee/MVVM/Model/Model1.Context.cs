﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyBestCoffee.MVVM.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MyBestCoffeeEntities : DbContext
    {
        public MyBestCoffeeEntities()
            : base("name=MyBestCoffeeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Coffee> Coffee { get; set; }
        public virtual DbSet<Complexity> Complexity { get; set; }
        public virtual DbSet<Favorite> Favorite { get; set; }
        public virtual DbSet<Instruction> Instruction { get; set; }
        public virtual DbSet<Recipe> Recipe { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
