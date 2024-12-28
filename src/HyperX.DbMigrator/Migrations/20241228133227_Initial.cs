using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HyperX.DbMigrator.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HyperX_Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HyperX_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HyperX_Friendlinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LinkUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HyperX_Friendlinks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HyperX_Post_Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HyperX_Post_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HyperX_Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Url = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Html = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Markdown = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HyperX_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HyperX_Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HyperX_Tags", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HyperX_Categories");

            migrationBuilder.DropTable(
                name: "HyperX_Friendlinks");

            migrationBuilder.DropTable(
                name: "HyperX_Post_Tags");

            migrationBuilder.DropTable(
                name: "HyperX_Posts");

            migrationBuilder.DropTable(
                name: "HyperX_Tags");
        }
    }
}
