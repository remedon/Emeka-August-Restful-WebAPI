﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Austine.Test.Migrations
{
    public partial class FKToAccountBalance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "AccountId",
                table: "AppAccountBalance",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_AppAccountBalance_AccountId",
                table: "AppAccountBalance",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppAccountBalance_AppAccount_AccountId",
                table: "AppAccountBalance",
                column: "AccountId",
                principalTable: "AppAccount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppAccountBalance_AppAccount_AccountId",
                table: "AppAccountBalance");

            migrationBuilder.DropIndex(
                name: "IX_AppAccountBalance_AccountId",
                table: "AppAccountBalance");

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "AppAccountBalance",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}