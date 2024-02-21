﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RINHABACKEND.Data;

#nullable disable

namespace Rinha.Migrations
{
    [DbContext(typeof(Databasecontext))]
    [Migration("20240221225357_caralhovsf")]
    partial class caralhovsf
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RINHABACKEND.Model.Saldo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data_extrato")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Limite")
                        .HasColumnType("integer");

                    b.Property<int>("Total")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Saldos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Data_extrato = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Limite = 100000,
                            Total = -9098
                        },
                        new
                        {
                            Id = 2,
                            Data_extrato = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Limite = 80000,
                            Total = 1000
                        },
                        new
                        {
                            Id = 3,
                            Data_extrato = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Limite = 1000000,
                            Total = 2000
                        },
                        new
                        {
                            Id = 4,
                            Data_extrato = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Limite = 10000000,
                            Total = 120
                        },
                        new
                        {
                            Id = 5,
                            Data_extrato = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Limite = 200,
                            Total = 3
                        });
                });

            modelBuilder.Entity("RINHABACKEND.Model.Transacao", b =>
                {
                    b.Property<int>("TransacaoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TransacaoID"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Realizada_em")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("SaldoId")
                        .HasColumnType("integer");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Valor")
                        .HasColumnType("integer");

                    b.HasKey("TransacaoID");

                    b.HasIndex("SaldoId");

                    b.ToTable("Transacoes");
                });

            modelBuilder.Entity("RINHABACKEND.Model.Transacao", b =>
                {
                    b.HasOne("RINHABACKEND.Model.Saldo", "Saldo")
                        .WithMany("Transacoes")
                        .HasForeignKey("SaldoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Saldo");
                });

            modelBuilder.Entity("RINHABACKEND.Model.Saldo", b =>
                {
                    b.Navigation("Transacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
