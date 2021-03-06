﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SmartMirror.WebAPI.Models;

namespace SmartMirror.WebAPI.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SmartMirror.WebAPI.Models.Server", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<bool>("isOnline");

                    b.HasKey("Id");

                    b.ToTable("Servers");
                });

            modelBuilder.Entity("SmartMirror.WebAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SmartMirror.WebAPI.Models.Widget", b =>
                {
                    b.Property<int>("WidgetId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ApiTokenId");

                    b.Property<int?>("UserId");

                    b.Property<string>("WidgetName");

                    b.HasKey("WidgetId");

                    b.HasIndex("ApiTokenId");

                    b.HasIndex("UserId");

                    b.ToTable("Widgets");
                });

            modelBuilder.Entity("SmartMirror.WebAPI.Models.Widget", b =>
                {
                    b.HasOne("SmartMirror.WebAPI.Models.User", "ApiToken")
                        .WithMany()
                        .HasForeignKey("ApiTokenId");

                    b.HasOne("SmartMirror.WebAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
