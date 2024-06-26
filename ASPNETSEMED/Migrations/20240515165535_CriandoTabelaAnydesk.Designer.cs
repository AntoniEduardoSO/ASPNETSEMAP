﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TesteMVC.Data;

#nullable disable

namespace TesteMVC.Migrations
{
    [DbContext(typeof(BancoContext))]
    [Migration("20240515165535_CriandoTabelaAnydesk")]
    partial class CriandoTabelaAnydesk
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TesteMVC.Models.AnydeskModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Escola")
                        .HasColumnType("text");

                    b.Property<string>("Patrimonio")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Anydesk");
                });
#pragma warning restore 612, 618
        }
    }
}
