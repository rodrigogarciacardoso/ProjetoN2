﻿// <auto-generated />
using System;
using Estoque.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Estoque.Migrations
{
    [DbContext(typeof(EstoqueDbContext))]
    partial class EstoqueDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Estoque.Core.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cep")
                        .HasMaxLength(10);

                    b.Property<string>("Cidade")
                        .IsRequired();

                    b.Property<string>("Complemento")
                        .HasMaxLength(100);

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Estado")
                        .IsRequired();

                    b.Property<string>("Logradouro")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("NumDocumento")
                        .HasMaxLength(20);

                    b.Property<string>("Numero")
                        .HasMaxLength(20);

                    b.Property<string>("Pais")
                        .IsRequired();

                    b.Property<string>("RazaoSocial")
                        .HasMaxLength(100);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<bool>("TipoPessoa");

                    b.Property<DateTime>("UltimaModificacao");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Estoque.Core.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("Estoque.Core.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<DateTime>("DataValidade");

                    b.Property<int?>("MarcaId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("PrecoCusto")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<decimal>("PrecoVenda")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<int>("QuantEstoque");

                    b.Property<DateTime>("UltimaModificacao");

                    b.Property<int?>("UnidadeMedidaId");

                    b.HasKey("Id");

                    b.HasIndex("MarcaId");

                    b.HasIndex("UnidadeMedidaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Estoque.Core.Models.ProdutoCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId");

                    b.Property<int>("ProdutoId");

                    b.Property<DateTime>("DataCompra");

                    b.Property<decimal>("PrecoPago")
                        .HasColumnType("decimal(9, 2)");

                    b.Property<int>("QuantidadeProduto");

                    b.HasKey("Id", "ClienteId", "ProdutoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("Estoque.Core.Models.UnidadeMedida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Sigla")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("UnidadeMedidas");
                });

            modelBuilder.Entity("Estoque.Core.Models.Produto", b =>
                {
                    b.HasOne("Estoque.Core.Models.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId");

                    b.HasOne("Estoque.Core.Models.UnidadeMedida", "UnidadeMedida")
                        .WithMany()
                        .HasForeignKey("UnidadeMedidaId");
                });

            modelBuilder.Entity("Estoque.Core.Models.ProdutoCliente", b =>
                {
                    b.HasOne("Estoque.Core.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Estoque.Core.Models.Produto", "Produto")
                        .WithMany("Clientes")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
