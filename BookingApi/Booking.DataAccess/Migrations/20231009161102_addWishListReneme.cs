using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addWishListReneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "WishLists",
                newName: "CratedDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CratedDate",
                table: "WishLists",
                newName: "DateTime");
        }
    }
}
