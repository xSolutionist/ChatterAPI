using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatterAPI.Migrations
{
    public partial class AzureInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFirst",
                table: "Post");

            migrationBuilder.AddColumn<string>(
                name: "SubThread",
                table: "Post",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubThread",
                table: "Post");

            migrationBuilder.AddColumn<bool>(
                name: "IsFirst",
                table: "Post",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
