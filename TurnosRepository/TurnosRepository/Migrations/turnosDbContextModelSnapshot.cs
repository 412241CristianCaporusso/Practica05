﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TurnosRepository.Models.Entities;

#nullable disable

namespace TurnosRepository.Migrations
{
    [DbContext(typeof(turnosDbContext))]
    partial class turnosDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TurnosRepository.Models.Entities.TDetallesTurno", b =>
                {
                    b.Property<int>("IdTurno")
                        .HasColumnType("int")
                        .HasColumnName("id_turno");

                    b.Property<int>("IdServicio")
                        .HasColumnType("int")
                        .HasColumnName("id_servicio");

                    b.Property<string>("Observaciones")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("observaciones");

                    b.HasKey("IdTurno", "IdServicio");

                    b.ToTable("T_DETALLES_TURNO", (string)null);
                });

            modelBuilder.Entity("TurnosRepository.Models.Entities.TServicio", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("Costo")
                        .HasColumnType("int")
                        .HasColumnName("costo");

                    b.Property<string>("EnPromocion")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("enPromocion");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("T_SERVICIOS", (string)null);
                });

            modelBuilder.Entity("TurnosRepository.Models.Entities.TTurno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cliente")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("cliente");

                    b.Property<string>("Fecha")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("fecha");

                    b.Property<string>("FechaCancelacion")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("fecha_cancelacion");

                    b.Property<string>("Hora")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("hora");

                    b.Property<string>("MotivoCancelacion")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("motivo_cancelacion");

                    b.HasKey("Id");

                    b.ToTable("T_TURNOS", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
