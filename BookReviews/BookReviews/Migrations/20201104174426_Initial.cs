using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReviews.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ReviewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(nullable: true),
                    AuthorName = table.Column<string>(nullable: true),
                    ReviewerUserID = table.Column<int>(nullable: true),
                    ReviewText = table.Column<string>(nullable: true),
                    ReviewDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_Books_User_ReviewerUserID",
                        column: x => x.ReviewerUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_ReviewerUserID",
                table: "Books",
                column: "ReviewerUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
