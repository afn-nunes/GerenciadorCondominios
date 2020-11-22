﻿// <auto-generated />
using System;
using GerenciadorCondominios.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GerenciadorCondominios.DAL.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20201112232602_criacaoDB")]
    partial class criacaoDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Aluguel", b =>
                {
                    b.Property<int>("AluguelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("MesId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("AluguelId");

                    b.HasIndex("MesId");

                    b.ToTable("Alugueis");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Apartamento", b =>
                {
                    b.Property<int>("ApartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Andar")
                        .HasColumnType("int");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoradorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("ProprietarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ApartamentoId");

                    b.HasIndex("MoradorId");

                    b.HasIndex("ProprietarioId");

                    b.ToTable("Apartamentos");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Evento", b =>
                {
                    b.Property<int>("EventoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EventoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Funcao", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Funcoes");

                    b.HasData(
                        new
                        {
                            Id = "be21138a-4790-4dfc-9ee8-9487eb2caed5",
                            ConcurrencyStamp = "38b757ae-0114-4e94-b902-99930d67d80b",
                            Descricao = "Morador do Prédio",
                            Name = "Morador",
                            NormalizedName = "MORADOR"
                        },
                        new
                        {
                            Id = "512b2b4c-d9ff-4875-b944-84dbb192216e",
                            ConcurrencyStamp = "cdb8ee2b-0c73-4c6f-8fe6-cb838b131348",
                            Descricao = "Sindico do Prédio",
                            Name = "Sindico",
                            NormalizedName = "SINDICO"
                        },
                        new
                        {
                            Id = "985719e4-4e66-417a-8fea-5618cecb5be7",
                            ConcurrencyStamp = "fe743bfb-b955-4200-ae36-04db23dd500f",
                            Descricao = "Administrador do Prédio",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        });
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.HistoricoRecursos", b =>
                {
                    b.Property<int>("HistoricoRecursosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("Dia")
                        .HasColumnType("int");

                    b.Property<int>("MesId")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("HistoricoRecursosId");

                    b.HasIndex("MesId");

                    b.ToTable("HistoricoRecursos");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Mes", b =>
                {
                    b.Property<int>("MesId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("MesId");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("Meses");

                    b.HasData(
                        new
                        {
                            MesId = 1,
                            Nome = "Janeiro"
                        },
                        new
                        {
                            MesId = 2,
                            Nome = "Fevereiro"
                        },
                        new
                        {
                            MesId = 3,
                            Nome = "Março"
                        },
                        new
                        {
                            MesId = 4,
                            Nome = "Abril"
                        },
                        new
                        {
                            MesId = 5,
                            Nome = "Maio"
                        },
                        new
                        {
                            MesId = 6,
                            Nome = "Junho"
                        },
                        new
                        {
                            MesId = 7,
                            Nome = "Julho"
                        },
                        new
                        {
                            MesId = 8,
                            Nome = "Agosto"
                        },
                        new
                        {
                            MesId = 9,
                            Nome = "Setembro"
                        },
                        new
                        {
                            MesId = 10,
                            Nome = "Outubro"
                        },
                        new
                        {
                            MesId = 11,
                            Nome = "Novembro"
                        },
                        new
                        {
                            MesId = 12,
                            Nome = "Dezembro"
                        });
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Pagamento", b =>
                {
                    b.Property<int>("PagamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AluguelId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataPagamento")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusPagamento")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PagamentoId");

                    b.HasIndex("AluguelId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Servico", b =>
                {
                    b.Property<int>("ServicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ServicoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.ServicoPredio", b =>
                {
                    b.Property<int>("ServicoPredioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DataExecucao")
                        .HasColumnType("datetime2");

                    b.Property<int>("ServicoId")
                        .HasColumnType("int");

                    b.HasKey("ServicoPredioId");

                    b.HasIndex("ServicoId");

                    b.ToTable("ServicoPredios");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("PrimeiroAcesso")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("CPF")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Veiculo", b =>
                {
                    b.Property<int>("VeiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("VeiculoId");

                    b.HasIndex("Placa")
                        .IsUnique();

                    b.HasIndex("UsuarioId");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Aluguel", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Mes", "Mes")
                        .WithMany("Alugueis")
                        .HasForeignKey("MesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mes");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Apartamento", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", "Morador")
                        .WithMany("MoradoresApartamentos")
                        .HasForeignKey("MoradorId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", "Proprietario")
                        .WithMany("ProprietariosApartamentos")
                        .HasForeignKey("ProprietarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Morador");

                    b.Navigation("Proprietario");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Evento", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", "Usuario")
                        .WithMany("Eventos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.HistoricoRecursos", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Mes", "Mes")
                        .WithMany("HistoricoRecursos")
                        .HasForeignKey("MesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mes");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Pagamento", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Aluguel", "Aluguel")
                        .WithMany("Pagamentos")
                        .HasForeignKey("AluguelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", "Usuario")
                        .WithMany("Pagamentos")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Aluguel");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Servico", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", "Usuario")
                        .WithMany("Servicos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.ServicoPredio", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Servico", "Servico")
                        .WithMany("ServicoPredios")
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Veiculo", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", "Usuario")
                        .WithMany("Veiculos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Funcao", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Funcao", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Aluguel", b =>
                {
                    b.Navigation("Pagamentos");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Mes", b =>
                {
                    b.Navigation("Alugueis");

                    b.Navigation("HistoricoRecursos");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Servico", b =>
                {
                    b.Navigation("ServicoPredios");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Usuario", b =>
                {
                    b.Navigation("Eventos");

                    b.Navigation("MoradoresApartamentos");

                    b.Navigation("Pagamentos");

                    b.Navigation("ProprietariosApartamentos");

                    b.Navigation("Servicos");

                    b.Navigation("Veiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
