﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestePagueVeloz.Models;

namespace TestePagueVeloz.Migrations
{
    [DbContext(typeof(TesteContext))]
    [Migration("20200116194954_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestePagueVeloz.Models.Empresa", b =>
                {
                    b.Property<int>("EmpresaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cnpj");

                    b.Property<string>("NomeFantasia");

                    b.Property<int>("Uf");

                    b.HasKey("EmpresaId");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("TestePagueVeloz.Models.Fornecedor", b =>
                {
                    b.Property<int>("FornecedorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CnpjOuCpf");

                    b.Property<DateTime>("DataDeCadastro");

                    b.Property<DateTime>("DataDeNascimento");

                    b.Property<int?>("EmpresaId");

                    b.Property<string>("Nome");

                    b.Property<string>("Rg");

                    b.Property<string>("Telefone");

                    b.HasKey("FornecedorId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("TestePagueVeloz.Models.Fornecedor", b =>
                {
                    b.HasOne("TestePagueVeloz.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId");
                });
#pragma warning restore 612, 618
        }
    }
}
