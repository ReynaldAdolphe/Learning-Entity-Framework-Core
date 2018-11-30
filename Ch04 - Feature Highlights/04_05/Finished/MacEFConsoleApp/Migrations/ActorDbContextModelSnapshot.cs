using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DemoConsole.Entities;

namespace MacEFConsoleApp.Migrations
{
    [DbContext(typeof(ActorDbContext))]
    partial class ActorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-preview1-22509");

            modelBuilder.Entity("DemoConsole.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AcademyWinner");

                    b.Property<int>("Age");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });
        }
    }
}
