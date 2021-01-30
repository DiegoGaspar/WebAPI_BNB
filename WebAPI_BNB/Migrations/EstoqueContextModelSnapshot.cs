﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI_BNB.Configuracao;

namespace WebAPI_BNB.Migrations
{
    [DbContext(typeof(EstoqueContext))]
    partial class EstoqueContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("WebAPI_BNB.Models.Agendamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("HorarioDeTermino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorarioInicial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VeiculoID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("WebAPI_BNB.Models.TipoDeCarga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposDeCargas");
                });

            modelBuilder.Entity("WebAPI_BNB.Models.VagaEstoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NomeVaga")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumeroVaga")
                        .HasColumnType("int");

                    b.Property<bool>("Ocupada")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("VagasEstoque");
                });

            modelBuilder.Entity("WebAPI_BNB.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CargaId")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Veiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
