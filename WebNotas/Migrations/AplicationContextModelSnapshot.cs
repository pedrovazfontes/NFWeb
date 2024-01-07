﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebNotas.Data;

#nullable disable

namespace WebNotas.Migrations
{
    [DbContext(typeof(AplicationContext))]
    partial class AplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebNotas.Models.NF", b =>
                {
                    b.Property<Guid>("NotaFiscalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CnpjDestinatarioNf")
                        .IsRequired()
                        .HasColumnType("VARCHAR(14)");

                    b.Property<string>("CnpjEmissorNf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNf")
                        .HasColumnType("DATETIME");

                    b.Property<int>("NumeroNf")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("DECIMAL(7,2)");

                    b.HasKey("NotaFiscalId");

                    b.ToTable("Notas", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
