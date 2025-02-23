using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieApp.Migrations
{
    /// <inheritdoc />
    public partial class MovieViewModelsNameFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorMovies_MoviesViewModel_MovieId",
                table: "ActorMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_MoviesViewModel_CinemaViewModels_CinemaId",
                table: "MoviesViewModel");

            migrationBuilder.DropForeignKey(
                name: "FK_MoviesViewModel_ProducerViewModels_ProducerId",
                table: "MoviesViewModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MoviesViewModel",
                table: "MoviesViewModel");

            migrationBuilder.RenameTable(
                name: "MoviesViewModel",
                newName: "MovieViewModels");

            migrationBuilder.RenameIndex(
                name: "IX_MoviesViewModel_ProducerId",
                table: "MovieViewModels",
                newName: "IX_MovieViewModels_ProducerId");

            migrationBuilder.RenameIndex(
                name: "IX_MoviesViewModel_CinemaId",
                table: "MovieViewModels",
                newName: "IX_MovieViewModels_CinemaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieViewModels",
                table: "MovieViewModels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorMovies_MovieViewModels_MovieId",
                table: "ActorMovies",
                column: "MovieId",
                principalTable: "MovieViewModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieViewModels_CinemaViewModels_CinemaId",
                table: "MovieViewModels",
                column: "CinemaId",
                principalTable: "CinemaViewModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieViewModels_ProducerViewModels_ProducerId",
                table: "MovieViewModels",
                column: "ProducerId",
                principalTable: "ProducerViewModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorMovies_MovieViewModels_MovieId",
                table: "ActorMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieViewModels_CinemaViewModels_CinemaId",
                table: "MovieViewModels");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieViewModels_ProducerViewModels_ProducerId",
                table: "MovieViewModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieViewModels",
                table: "MovieViewModels");

            migrationBuilder.RenameTable(
                name: "MovieViewModels",
                newName: "MoviesViewModel");

            migrationBuilder.RenameIndex(
                name: "IX_MovieViewModels_ProducerId",
                table: "MoviesViewModel",
                newName: "IX_MoviesViewModel_ProducerId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieViewModels_CinemaId",
                table: "MoviesViewModel",
                newName: "IX_MoviesViewModel_CinemaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MoviesViewModel",
                table: "MoviesViewModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorMovies_MoviesViewModel_MovieId",
                table: "ActorMovies",
                column: "MovieId",
                principalTable: "MoviesViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesViewModel_CinemaViewModels_CinemaId",
                table: "MoviesViewModel",
                column: "CinemaId",
                principalTable: "CinemaViewModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesViewModel_ProducerViewModels_ProducerId",
                table: "MoviesViewModel",
                column: "ProducerId",
                principalTable: "ProducerViewModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
