﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketSystem.Data.Context;

#nullable disable

namespace TicketSystem.Data.Migrations
{
    [DbContext(typeof(TicketSystemDataContext))]
    partial class TicketSystemDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Rezervation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("Cinsiyet")
                        .HasColumnType("int");

                    b.Property<int>("FirmaNo")
                        .HasColumnType("int");

                    b.Property<string>("Guzergah")
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Isim")
                        .HasColumnType("varchar(200)");

                    b.Property<int>("KalkisNoktaID")
                        .HasColumnType("int");

                    b.Property<string>("KoltukNo")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("PnrNo")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("SoyIsim")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("TcNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VarisNoktaID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rezervation");
                });
#pragma warning restore 612, 618
        }
    }
}
