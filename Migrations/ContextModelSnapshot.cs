﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicariOtomasyon.Models.Siniflar;

#nullable disable

namespace TicariOtomasyon.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminID"), 1L, 1);

                    b.Property<string>("KullaniciAd")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("Varchar(10)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("Varchar(10)");

                    b.Property<string>("Yetki")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("Char(1)");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.Cari", b =>
                {
                    b.Property<int>("CariID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CariID"), 1L, 1);

                    b.Property<string>("CariAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("CariMail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("CariSehir")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("Varchar(13)");

                    b.Property<string>("CariSoyad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.HasKey("CariID");

                    b.ToTable("Caris");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.Departman", b =>
                {
                    b.Property<int>("DepartmanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmanID"), 1L, 1);

                    b.Property<string>("DepartmanAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.HasKey("DepartmanID");

                    b.ToTable("Departmans");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.Fatura", b =>
                {
                    b.Property<int>("FaturaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FaturaID"), 1L, 1);

                    b.Property<string>("FaturaSeriNo")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("Char(1)");

                    b.Property<string>("FaturaSiraNo")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("Varchar(6)");

                    b.Property<string>("Saat")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("Char(5)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("TeslimAlan")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("TeslimEden")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<decimal>("Toplam")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("VergiDairesi")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("Varchar(60)");

                    b.HasKey("FaturaID");

                    b.ToTable("Faturas");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.FaturaKalem", b =>
                {
                    b.Property<int>("FaturaKalemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FaturaKalemID"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("Varchar(1000)");

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("FaturaID")
                        .HasColumnType("int");

                    b.Property<int>("Miktar")
                        .HasColumnType("int");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FaturaKalemID");

                    b.HasIndex("FaturaID");

                    b.ToTable("FaturaKalems");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.Gider", b =>
                {
                    b.Property<int>("GiderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GiderID"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("GiderID");

                    b.ToTable("Giders");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriID"), 1L, 1);

                    b.Property<string>("KategoriAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategoris");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.Personel", b =>
                {
                    b.Property<int>("PersonelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonelID"), 1L, 1);

                    b.Property<int>("DepartmanID")
                        .HasColumnType("int");

                    b.Property<string>("PersonelAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("PersonelGorsel")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("Varchar(250)");

                    b.Property<string>("PersonelSoyad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.HasKey("PersonelID");

                    b.HasIndex("DepartmanID");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.SatisHareket", b =>
                {
                    b.Property<int>("SatisHareketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SatisHareketID"), 1L, 1);

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<int>("CariID")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PersonelID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ToplamTutar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UrunID")
                        .HasColumnType("int");

                    b.HasKey("SatisHareketID");

                    b.HasIndex("CariID");

                    b.HasIndex("PersonelID");

                    b.HasIndex("UrunID");

                    b.ToTable("SatisHarekets");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.Urun", b =>
                {
                    b.Property<int>("UrunID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UrunID"), 1L, 1);

                    b.Property<decimal>("AlisFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<decimal>("SatisFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<short>("Stok")
                        .HasColumnType("smallint");

                    b.Property<string>("UrunAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("UrunGorsel")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("Varchar(250)");

                    b.HasKey("UrunID");

                    b.HasIndex("KategoriID");

                    b.ToTable("Uruns");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.UrunDetay", b =>
                {
                    b.Property<int>("UrunDetayID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UrunDetayID"), 1L, 1);

                    b.Property<string>("UrunAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("UrunBilgi")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("Varchar(2000)");

                    b.HasKey("UrunDetayID");

                    b.ToTable("UrunDetays");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.FaturaKalem", b =>
                {
                    b.HasOne("TicariOtomasyon.Models.Siniflar.Fatura", "Fatura")
                        .WithMany("FaturaKalems")
                        .HasForeignKey("FaturaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fatura");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.Personel", b =>
                {
                    b.HasOne("TicariOtomasyon.Models.Siniflar.Departman", "Departman")
                        .WithMany("Personels")
                        .HasForeignKey("DepartmanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departman");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.SatisHareket", b =>
                {
                    b.HasOne("TicariOtomasyon.Models.Siniflar.Cari", "Cari")
                        .WithMany("SatisHarekets")
                        .HasForeignKey("CariID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicariOtomasyon.Models.Siniflar.Personel", "Personel")
                        .WithMany("SatisHarekets")
                        .HasForeignKey("PersonelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicariOtomasyon.Models.Siniflar.Urun", "Urun")
                        .WithMany("SatisHarekets")
                        .HasForeignKey("UrunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cari");

                    b.Navigation("Personel");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.Urun", b =>
                {
                    b.HasOne("TicariOtomasyon.Models.Siniflar.Kategori", "Kategori")
                        .WithMany("Uruns")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.Cari", b =>
                {
                    b.Navigation("SatisHarekets");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.Departman", b =>
                {
                    b.Navigation("Personels");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.Fatura", b =>
                {
                    b.Navigation("FaturaKalems");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.Kategori", b =>
                {
                    b.Navigation("Uruns");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.Personel", b =>
                {
                    b.Navigation("SatisHarekets");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Siniflar.Urun", b =>
                {
                    b.Navigation("SatisHarekets");
                });
#pragma warning restore 612, 618
        }
    }
}
