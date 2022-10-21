using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnTask.BlazorWpf.Migrations
{
    /// <inheritdoc />
    public partial class CorrectLinkedIdOnActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivityId",
                table: "Activities");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ActivityId",
                table: "Activities",
                type: "TEXT",
                nullable: true);
        }
    }
}
