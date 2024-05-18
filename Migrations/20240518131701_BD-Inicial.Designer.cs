﻿// <auto-generated />
using System;
using ChurnAnalitycs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace ChurnAnalitycs.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240518131701_BD-Inicial")]
    partial class BDInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ChurnAnalitycs.Models.CadastroEmpresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("Id");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Bairro");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("CEP");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("NVARCHAR2(14)")
                        .HasColumnName("CNPJ");

                    b.Property<string>("CargoContatoPrincipal")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Cidade");

                    b.Property<string>("EmailContato")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Endereco");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Estado");

                    b.Property<int>("Lucratividade")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("Lucratividade");

                    b.Property<string>("NomeContatoPrincipal")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Numero");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Pais");

                    b.Property<string>("Porte")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("Porte");

                    b.Property<string>("ProdutoServicoAdquirido")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("ProdutoServicoAdquirido");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("RazaoSocial");

                    b.Property<int>("ReceitaAnual")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ReceitaAnual");

                    b.Property<string>("SetorAtuacao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("SetorAtuacao");

                    b.Property<string>("TelefoneContato")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("ValorCompra")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ValorCompra");

                    b.HasKey("Id");

                    b.ToTable("CadastroEmpresas");
                });

            modelBuilder.Entity("ChurnAnalitycs.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("Id");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataAtendimento")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime?>("DataFeedback")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("IndicadorDesempenho")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("NomeCanalComunicacao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("ResolucaoProblema")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("NVARCHAR2(500)");

                    b.Property<string>("TipoAtendimento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("TipoInteracao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("TipoInteracao");

                    b.Property<int>("ValorIndicador")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("ChurnAnalitycs.Models.InfoAdicional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("Id");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EstruturaOrganizacional")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("NVARCHAR2(500)");

                    b.Property<string>("InfoProdutosServicos")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("NVARCHAR2(1000)");

                    b.Property<string>("InformacoesRegulatoriasConformidade")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("NVARCHAR2(500)");

                    b.Property<string>("NomeIntegracaoSistema")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("ObjetivosMetasEstrategicas")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("NVARCHAR2(500)");

                    b.Property<string>("OutrasInformacoesSetor")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("NVARCHAR2(1000)");

                    b.Property<string>("PersonaCliente")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("NVARCHAR2(500)");

                    b.Property<string>("SegmentacaoClientes")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("NVARCHAR2(500)");

                    b.HasKey("Id");

                    b.ToTable("InfoAdicionais");
                });
#pragma warning restore 612, 618
        }
    }
}
