﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoCiclo3.App.Persistencia;

namespace ProyectoCiclo3.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220824013556_MigraInicial")]
    partial class MigraInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ProyectoCiclo3.App.Dominio.Encomienda", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("peso")
                        .HasColumnType("int");

                    b.Property<string>("presentacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Encomiendas");
                });

            modelBuilder.Entity("ProyectoCiclo3.App.Dominio.Servicio", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("destinoid")
                        .HasColumnType("int");

                    b.Property<int?>("encomiendaid")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("hora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("origenid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("destinoid");

                    b.HasIndex("encomiendaid");

                    b.HasIndex("origenid");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("ProyectoCiclo3.App.Dominio.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProyectoCiclo3.App.Dominio.Servicio", b =>
                {
                    b.HasOne("ProyectoCiclo3.App.Dominio.Usuario", "destino")
                        .WithMany()
                        .HasForeignKey("destinoid");

                    b.HasOne("ProyectoCiclo3.App.Dominio.Encomienda", "encomienda")
                        .WithMany()
                        .HasForeignKey("encomiendaid");

                    b.HasOne("ProyectoCiclo3.App.Dominio.Usuario", "origen")
                        .WithMany()
                        .HasForeignKey("origenid");

                    b.Navigation("destino");

                    b.Navigation("encomienda");

                    b.Navigation("origen");
                });
#pragma warning restore 612, 618
        }
    }
}
