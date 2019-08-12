﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VBaseProject.Data.Context;

namespace VBaseProject.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190812102319_Add-RefreshToken")]
    partial class AddRefreshToken
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VBaseProject.Entities.Domain.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("PublicId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("CustomerId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("VBaseProject.Entities.Domain.RefreshToken", b =>
                {
                    b.Property<int>("RefreshTokenId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<string>("PublicId");

                    b.Property<string>("Refreshtoken");

                    b.HasKey("RefreshTokenId");

                    b.ToTable("RefreshToken");
                });

            modelBuilder.Entity("VBaseProject.Entities.Domain.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("LastUpdated");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<int>("Profile");

                    b.Property<string>("PublicId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
