using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Actors_Actor_Id",
                table: "Actor_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Movies_Movie_Id",
                table: "Actor_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemies_Cinema_Id",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_Producer_Id",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actor_Movies",
                table: "Actor_Movies");

            migrationBuilder.RenameTable(
                name: "Actor_Movies",
                newName: "Actors_Movies");

            migrationBuilder.RenameColumn(
                name: "FallName",
                table: "Producers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "Producer_Id",
                table: "Movies",
                newName: "ProducerId");

            migrationBuilder.RenameColumn(
                name: "Discription",
                table: "Movies",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Cinema_Id",
                table: "Movies",
                newName: "CinemaId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_Producer_Id",
                table: "Movies",
                newName: "IX_Movies_ProducerId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_Cinema_Id",
                table: "Movies",
                newName: "IX_Movies_CinemaId");

            migrationBuilder.RenameColumn(
                name: "Discription",
                table: "Cinemies",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "FallName",
                table: "Actors",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "Actor_Id",
                table: "Actors_Movies",
                newName: "ActorId");

            migrationBuilder.RenameColumn(
                name: "Movie_Id",
                table: "Actors_Movies",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Actor_Movies_Actor_Id",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_ActorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors_Movies",
                table: "Actors_Movies",
                columns: new[] { "MovieId", "ActorId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemies_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "Cinemies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemies_CinemaId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors_Movies",
                table: "Actors_Movies");

            migrationBuilder.RenameTable(
                name: "Actors_Movies",
                newName: "Actor_Movies");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Producers",
                newName: "FallName");

            migrationBuilder.RenameColumn(
                name: "ProducerId",
                table: "Movies",
                newName: "Producer_Id");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Movies",
                newName: "Discription");

            migrationBuilder.RenameColumn(
                name: "CinemaId",
                table: "Movies",
                newName: "Cinema_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies",
                newName: "IX_Movies_Producer_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies",
                newName: "IX_Movies_Cinema_Id");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cinemies",
                newName: "Discription");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Actors",
                newName: "FallName");

            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "Actor_Movies",
                newName: "Actor_Id");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Actor_Movies",
                newName: "Movie_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_ActorId",
                table: "Actor_Movies",
                newName: "IX_Actor_Movies_Actor_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actor_Movies",
                table: "Actor_Movies",
                columns: new[] { "Movie_Id", "Actor_Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Actors_Actor_Id",
                table: "Actor_Movies",
                column: "Actor_Id",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Movies_Movie_Id",
                table: "Actor_Movies",
                column: "Movie_Id",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemies_Cinema_Id",
                table: "Movies",
                column: "Cinema_Id",
                principalTable: "Cinemies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_Producer_Id",
                table: "Movies",
                column: "Producer_Id",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
