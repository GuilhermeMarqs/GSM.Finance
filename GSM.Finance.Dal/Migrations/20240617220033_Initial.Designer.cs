﻿// <auto-generated />
using System;
using GSM.Finance.Dal.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GSM.Finance.Dal.Migrations
{
    [DbContext(typeof(MeuDbContext))]
    [Migration("20240617220033_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GSM.Finance.Domain.Entities.Cartao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Bandeira")
                        .HasColumnType("int");

                    b.Property<string>("FechamentoFatura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Limite")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Cartao");
                });

            modelBuilder.Entity("GSM.Finance.Domain.Entities.Faturas", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Faturas");
                });

            modelBuilder.Entity("GSM.Finance.Domain.Entities.Movimento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Efetivado")
                        .HasColumnType("bit");

                    b.Property<int?>("FaturaId")
                        .HasColumnType("int");

                    b.Property<Guid?>("FaturasId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<Guid?>("TipoMovimentoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("FaturasId");

                    b.ToTable("Movimento");
                });

            modelBuilder.Entity("GSM.Finance.Domain.Entities.Perfil", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("GSM.Finance.Domain.Entities.RelCartaoPerfil", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CartaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PerfilId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RelCartaoPerfil");
                });

            modelBuilder.Entity("GSM.Finance.Domain.Entities.RelFaturaCartao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CartaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FaturaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RelFaturaCartao");
                });

            modelBuilder.Entity("GSM.Finance.Domain.Entities.RelMovimentoCartao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CartaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MovimentoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RelMovimentoCartao");
                });

            modelBuilder.Entity("GSM.Finance.Domain.Entities.RelPerfilTipoMovimento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PerfilId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TipoMovimentoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PerfilId");

                    b.ToTable("RelPerfilTipoMovimento");
                });

            modelBuilder.Entity("GSM.Finance.Domain.Entities.TipoMovimento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoMovimento");
                });

            modelBuilder.Entity("GSM.Finance.Domain.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PerfilId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PerfilId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("GSM.Finance.Domain.Entities.Movimento", b =>
                {
                    b.HasOne("GSM.Finance.Domain.Entities.Faturas", null)
                        .WithMany("MovimentosFatura")
                        .HasForeignKey("FaturasId");
                });

            modelBuilder.Entity("GSM.Finance.Domain.Entities.RelPerfilTipoMovimento", b =>
                {
                    b.HasOne("GSM.Finance.Domain.Entities.Perfil", "Perfil")
                        .WithMany()
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("GSM.Finance.Domain.Entities.Usuario", b =>
                {
                    b.HasOne("GSM.Finance.Domain.Entities.Perfil", "Perfil")
                        .WithMany()
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("GSM.Finance.Domain.Entities.Faturas", b =>
                {
                    b.Navigation("MovimentosFatura");
                });
#pragma warning restore 612, 618
        }
    }
}
