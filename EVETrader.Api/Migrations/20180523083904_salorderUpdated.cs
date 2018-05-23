using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EVETrader.Api.Migrations
{
    public partial class salorderUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypeID",
                table: "ShoppingLists",
                newName: "TypeId");

            migrationBuilder.AddColumn<bool>(
                name: "Finished",
                table: "SalesOrders",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Finished",
                table: "SalesOrders");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "ShoppingLists",
                newName: "TypeID");
        }
    }
}
