﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using webCourse.Models;

namespace webCourse.Migrations
{
    [DbContext(typeof(WebCourseContext))]
    [Migration("20190626131538_UsuariosChangeV1")]
    partial class UsuariosChangeV1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("webCourse.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("webCourse.Models.Usuarios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("aniversario")
                        .HasMaxLength(5);

                    b.Property<string>("id_tabelionato")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(1)
                        .HasDefaultValue("1");

                    b.Property<string>("login");

                    b.Property<string>("nome");

                    b.Property<string>("senha");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("id");

                    b.HasIndex("login")
                        .HasName("Ix_UsuarioLogin");

                    b.ToTable("usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
