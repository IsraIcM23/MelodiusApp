using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MelodiusDataAccess.MigrationsMelodius
{
    /// <inheritdoc />
    public partial class segundamigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SongID",
                table: "Songs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PlaylistID",
                table: "PlayLists",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ArtistSongs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ArtistID",
                table: "Artists",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AlbumSongs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AlbumID",
                table: "Albums",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TotalLength",
                table: "PlayLists",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "PlayLists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Songs",
                newName: "SongID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PlayLists",
                newName: "PlaylistID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ArtistSongs",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Artists",
                newName: "ArtistID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AlbumSongs",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Albums",
                newName: "AlbumID");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TotalLength",
                table: "PlayLists",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "PlayLists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
