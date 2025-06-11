using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_PhamHuynhAnh.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Phims",
                columns: new[] { "Id", "DienVien", "GiaVe", "ThoiLuong", "TrongNuoc", "TuaDe" },
                values: new object[,]
                {
                    { 1, "Trần Nghĩa", 75000.0, 117, true, "Mắt Biếc" },
                    { 2, "Robert Downey Jr.", 120000.0, 181, false, "Avengers: Endgame" },
                    { 3, "Song Kang-ho", 95000.0, 132, false, "Parasite" },
                    { 4, "Trấn Thành", 80000.0, 128, true, "Bố Già" },
                    { 5, "Christian Bale", 110000.0, 152, false, "The Dark Knight" },
                    { 6, "Avin Lu", 70000.0, 136, true, "Em và Trịnh" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
