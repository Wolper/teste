﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using teste.Data;

namespace teste.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191028132336_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("teste.Model.Usuario", b =>
                {
                    b.Property<int>("usuarioId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email");

                    b.Property<string>("nome");

                    b.HasKey("usuarioId");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
