using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BeerTracker5000.Models;

namespace BeerTracker5000.Migrations
{
    [DbContext(typeof(BeerTracker5000Context))]
    partial class BeerTracker5000ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BeerTracker5000.Models.Beer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Abv");

                    b.Property<string>("BeerName");

                    b.Property<string>("BreweryName");

                    b.Property<int>("Ibu");

                    b.Property<string>("Notes");

                    b.Property<int>("Rating");

                    b.Property<string>("Style");

                    b.HasKey("ID");

                    b.ToTable("Beer");
                });
        }
    }
}
