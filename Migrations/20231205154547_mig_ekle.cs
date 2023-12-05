using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicariOtomasyon.Migrations
{
    public partial class mig_ekle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAd = table.Column<string>(type: "Varchar(10)", maxLength: 10, nullable: false),
                    Sifre = table.Column<string>(type: "Varchar(10)", maxLength: 10, nullable: false),
                    Yetki = table.Column<string>(type: "Char(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Departmans",
                columns: table => new
                {
                    DepartmanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmanAd = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmans", x => x.DepartmanID);
                });

            migrationBuilder.CreateTable(
                name: "Faturas",
                columns: table => new
                {
                    FaturaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaturaSeriNo = table.Column<string>(type: "Char(1)", maxLength: 1, nullable: false),
                    FaturaSiraNo = table.Column<string>(type: "Varchar(6)", maxLength: 6, nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VergiDairesi = table.Column<string>(type: "Varchar(60)", maxLength: 60, nullable: false),
                    Saat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeslimEden = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    TeslimAlan = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faturas", x => x.FaturaID);
                });

            migrationBuilder.CreateTable(
                name: "Giders",
                columns: table => new
                {
                    GiderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giders", x => x.GiderID);
                });

            migrationBuilder.CreateTable(
                name: "Kategoris",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoris", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "SatisHarekets",
                columns: table => new
                {
                    SatisHareketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ToplamTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatisHarekets", x => x.SatisHareketID);
                });

            migrationBuilder.CreateTable(
                name: "FaturaKalems",
                columns: table => new
                {
                    FaturaKalemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "Varchar(1000)", maxLength: 1000, nullable: false),
                    Miktar = table.Column<int>(type: "int", nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FaturaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaturaKalems", x => x.FaturaKalemID);
                    table.ForeignKey(
                        name: "FK_FaturaKalems_Faturas_FaturaID",
                        column: x => x.FaturaID,
                        principalTable: "Faturas",
                        principalColumn: "FaturaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Caris",
                columns: table => new
                {
                    CariID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CariAd = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    CariSoyad = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    CariSehir = table.Column<string>(type: "Varchar(13)", maxLength: 13, nullable: false),
                    CariMail = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: false),
                    SatisHareketID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caris", x => x.CariID);
                    table.ForeignKey(
                        name: "FK_Caris_SatisHarekets_SatisHareketID",
                        column: x => x.SatisHareketID,
                        principalTable: "SatisHarekets",
                        principalColumn: "SatisHareketID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    PersonelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelAd = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    PersonelSoyad = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    PersonelGorsel = table.Column<string>(type: "Varchar(250)", maxLength: 250, nullable: false),
                    SatisHareketID = table.Column<int>(type: "int", nullable: false),
                    DepartmanID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.PersonelID);
                    table.ForeignKey(
                        name: "FK_Personels_Departmans_DepartmanID",
                        column: x => x.DepartmanID,
                        principalTable: "Departmans",
                        principalColumn: "DepartmanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personels_SatisHarekets_SatisHareketID",
                        column: x => x.SatisHareketID,
                        principalTable: "SatisHarekets",
                        principalColumn: "SatisHareketID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uruns",
                columns: table => new
                {
                    UrunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAd = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    Marka = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    Stok = table.Column<short>(type: "smallint", nullable: false),
                    AlisFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SatisFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    UrunGorsel = table.Column<string>(type: "Varchar(250)", maxLength: 250, nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    SatisHareketID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uruns", x => x.UrunID);
                    table.ForeignKey(
                        name: "FK_Uruns_Kategoris_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoris",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Uruns_SatisHarekets_SatisHareketID",
                        column: x => x.SatisHareketID,
                        principalTable: "SatisHarekets",
                        principalColumn: "SatisHareketID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Caris_SatisHareketID",
                table: "Caris",
                column: "SatisHareketID");

            migrationBuilder.CreateIndex(
                name: "IX_FaturaKalems_FaturaID",
                table: "FaturaKalems",
                column: "FaturaID");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_DepartmanID",
                table: "Personels",
                column: "DepartmanID");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_SatisHareketID",
                table: "Personels",
                column: "SatisHareketID");

            migrationBuilder.CreateIndex(
                name: "IX_Uruns_KategoriID",
                table: "Uruns",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Uruns_SatisHareketID",
                table: "Uruns",
                column: "SatisHareketID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Caris");

            migrationBuilder.DropTable(
                name: "FaturaKalems");

            migrationBuilder.DropTable(
                name: "Giders");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Uruns");

            migrationBuilder.DropTable(
                name: "Faturas");

            migrationBuilder.DropTable(
                name: "Departmans");

            migrationBuilder.DropTable(
                name: "Kategoris");

            migrationBuilder.DropTable(
                name: "SatisHarekets");
        }
    }
}
