﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortfolioRK.Database;

namespace PortfolioRK.Migrations
{
    [DbContext(typeof(PortfolioRKContext))]
    partial class PortfolioRKContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.27");

            modelBuilder.Entity("PortfolioRK.Model.Repository", b =>
                {
                    b.Property<int>("RepositoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ReloLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("RepoDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("RepoName")
                        .HasColumnType("TEXT");

                    b.HasKey("RepositoryId");

                    b.ToTable("Repositories");
                });
#pragma warning restore 612, 618
        }
    }
}
