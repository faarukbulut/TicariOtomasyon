using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicariOtomasyon.Migrations
{
    public partial class mig_iliski_duzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caris_SatisHarekets_SatisHareketID",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_Personels_SatisHarekets_SatisHareketID",
                table: "Personels");

            migrationBuilder.DropForeignKey(
                name: "FK_Uruns_SatisHarekets_SatisHareketID",
                table: "Uruns");

            migrationBuilder.DropIndex(
                name: "IX_Uruns_SatisHareketID",
                table: "Uruns");

            migrationBuilder.DropIndex(
                name: "IX_Personels_SatisHareketID",
                table: "Personels");

            migrationBuilder.DropIndex(
                name: "IX_Caris_SatisHareketID",
                table: "Caris");

            migrationBuilder.DropColumn(
                name: "SatisHareketID",
                table: "Uruns");

            migrationBuilder.DropColumn(
                name: "SatisHareketID",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "SatisHareketID",
                table: "Caris");

            migrationBuilder.AddColumn<int>(
                name: "CariID",
                table: "SatisHarekets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonelID",
                table: "SatisHarekets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UrunID",
                table: "SatisHarekets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SatisHarekets_CariID",
                table: "SatisHarekets",
                column: "CariID");

            migrationBuilder.CreateIndex(
                name: "IX_SatisHarekets_PersonelID",
                table: "SatisHarekets",
                column: "PersonelID");

            migrationBuilder.CreateIndex(
                name: "IX_SatisHarekets_UrunID",
                table: "SatisHarekets",
                column: "UrunID");

            migrationBuilder.AddForeignKey(
                name: "FK_SatisHarekets_Caris_CariID",
                table: "SatisHarekets",
                column: "CariID",
                principalTable: "Caris",
                principalColumn: "CariID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SatisHarekets_Personels_PersonelID",
                table: "SatisHarekets",
                column: "PersonelID",
                principalTable: "Personels",
                principalColumn: "PersonelID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SatisHarekets_Uruns_UrunID",
                table: "SatisHarekets",
                column: "UrunID",
                principalTable: "Uruns",
                principalColumn: "UrunID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SatisHarekets_Caris_CariID",
                table: "SatisHarekets");

            migrationBuilder.DropForeignKey(
                name: "FK_SatisHarekets_Personels_PersonelID",
                table: "SatisHarekets");

            migrationBuilder.DropForeignKey(
                name: "FK_SatisHarekets_Uruns_UrunID",
                table: "SatisHarekets");

            migrationBuilder.DropIndex(
                name: "IX_SatisHarekets_CariID",
                table: "SatisHarekets");

            migrationBuilder.DropIndex(
                name: "IX_SatisHarekets_PersonelID",
                table: "SatisHarekets");

            migrationBuilder.DropIndex(
                name: "IX_SatisHarekets_UrunID",
                table: "SatisHarekets");

            migrationBuilder.DropColumn(
                name: "CariID",
                table: "SatisHarekets");

            migrationBuilder.DropColumn(
                name: "PersonelID",
                table: "SatisHarekets");

            migrationBuilder.DropColumn(
                name: "UrunID",
                table: "SatisHarekets");

            migrationBuilder.AddColumn<int>(
                name: "SatisHareketID",
                table: "Uruns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SatisHareketID",
                table: "Personels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SatisHareketID",
                table: "Caris",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Uruns_SatisHareketID",
                table: "Uruns",
                column: "SatisHareketID");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_SatisHareketID",
                table: "Personels",
                column: "SatisHareketID");

            migrationBuilder.CreateIndex(
                name: "IX_Caris_SatisHareketID",
                table: "Caris",
                column: "SatisHareketID");

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_SatisHarekets_SatisHareketID",
                table: "Caris",
                column: "SatisHareketID",
                principalTable: "SatisHarekets",
                principalColumn: "SatisHareketID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_SatisHarekets_SatisHareketID",
                table: "Personels",
                column: "SatisHareketID",
                principalTable: "SatisHarekets",
                principalColumn: "SatisHareketID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Uruns_SatisHarekets_SatisHareketID",
                table: "Uruns",
                column: "SatisHareketID",
                principalTable: "SatisHarekets",
                principalColumn: "SatisHareketID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
