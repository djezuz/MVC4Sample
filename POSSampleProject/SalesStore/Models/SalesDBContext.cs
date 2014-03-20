using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SalesStore.Models;

namespace SalesStore.Entities
{
    

    public class SalesDBContext : DbContext
    {
        // Pass database name you want to create in constructor or Pass connection string name if you want to set location and DB name from connection string
        // If nothing is passed in base constructor then it will create database with Namespacename.classname eg. "SchoolDataLayer.Context" in SQLExpress
        public SalesDBContext()
            : base("SalesData") //: base("SchoolDBCodeFirst") 
        {
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseIfModelChanges<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new CreateDatabaseIfNotExists<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new  SchoolDBInitializer());


            //Disable initializer
            Database.SetInitializer<SalesDBContext>(null);
        }

        public DbSet<ItemBrand> ItemBrands { get; set; }
        //public DbSet<Standard> Standards { get; set; }

    }

}