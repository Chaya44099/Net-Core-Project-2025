using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConvalescentHome.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Baby",
                columns: table => new
                {
                    IdTable = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    MomId = table.Column<int>(type: "int", nullable: false),
                    Tz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WeightBirth = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    WeightNow = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baby", x => x.IdTable);
                });

            migrationBuilder.CreateTable(
                name: "Invitation",
                columns: table => new
                {
                    IdTable = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Yoledet_Id = table.Column<int>(type: "int", nullable: false),
                    Room_Id = table.Column<int>(type: "int", nullable: false),
                    Amount_Of_Days = table.Column<int>(type: "int", nullable: false),
                    pay = table.Column<int>(type: "int", nullable: false),
                    Invantion_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_arive = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Invantion_Leave = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invitation", x => x.IdTable);
                });

            migrationBuilder.CreateTable(
                name: "Parturient",
                columns: table => new
                {
                    IdTable = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Tz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_of_the_birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Health_fund = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birth_number = table.Column<int>(type: "int", nullable: false),
                    Id_Room = table.Column<int>(type: "int", nullable: false),
                    Id_invitation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parturient", x => x.IdTable);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    IdTable = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    Number_Room = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    kind = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.IdTable);
                });

            migrationBuilder.CreateTable(
                name: "Worker",
                columns: table => new
                {
                    IdTable = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Tz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duty = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seniority = table.Column<int>(type: "int", nullable: false),
                    Weekly_Hours = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker", x => x.IdTable);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Baby");

            migrationBuilder.DropTable(
                name: "Invitation");

            migrationBuilder.DropTable(
                name: "Parturient");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Worker");
        }
    }
}
