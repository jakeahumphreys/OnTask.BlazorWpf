using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnTask.BlazorWpf.Migrations
{
    /// <inheritdoc />
    public partial class AddActivitiesToCollections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CollectionId",
                table: "Activities",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Activities_CollectionId",
                table: "Activities",
                column: "CollectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Collections_CollectionId",
                table: "Activities",
                column: "CollectionId",
                principalTable: "Collections",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Collections_CollectionId",
                table: "Activities");

            migrationBuilder.DropIndex(
                name: "IX_Activities_CollectionId",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "CollectionId",
                table: "Activities");
        }
    }
}
