﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectOmega.DAL.MsSql.Services;

namespace ProjectOmega.DAL.MsSql.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181215131519_MSSQLMigrate")]
    partial class MSSQLMigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectOmega.Data.Entities.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ClientId");

                    b.Property<string>("Number");

                    b.Property<int>("Status");

                    b.Property<long?>("UserAddedId");

                    b.Property<long?>("UserInvoiceId");

                    b.Property<long?>("UserResponsibleId");

                    b.HasKey("Id");

                    b.HasIndex("UserAddedId");

                    b.HasIndex("UserInvoiceId");

                    b.HasIndex("UserResponsibleId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ProjectOmega.Data.Entities.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ProjectOmega.Data.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<long?>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProjectOmega.Data.Entities.Order", b =>
                {
                    b.HasOne("ProjectOmega.Data.Entities.User", "UserAdded")
                        .WithMany()
                        .HasForeignKey("UserAddedId");

                    b.HasOne("ProjectOmega.Data.Entities.User", "UserInvoice")
                        .WithMany()
                        .HasForeignKey("UserInvoiceId");

                    b.HasOne("ProjectOmega.Data.Entities.User", "UserResponsible")
                        .WithMany()
                        .HasForeignKey("UserResponsibleId");
                });

            modelBuilder.Entity("ProjectOmega.Data.Entities.User", b =>
                {
                    b.HasOne("ProjectOmega.Data.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });
#pragma warning restore 612, 618
        }
    }
}
