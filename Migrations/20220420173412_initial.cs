using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace newDockeNet.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companys",
                columns: table => new
                {
                    CompanyId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Cnpj = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    NumberAddress = table.Column<string>(type: "TEXT", nullable: true),
                    Complement = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true),
                    District = table.Column<string>(type: "TEXT", nullable: true),
                    Cep = table.Column<string>(type: "TEXT", nullable: true),
                    Logo = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companys", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "DPOs",
                columns: table => new
                {
                    DpoId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Cpf = table.Column<string>(type: "TEXT", nullable: true),
                    Job = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Cellphone = table.Column<string>(type: "TEXT", nullable: true),
                    Telephone = table.Column<string>(type: "TEXT", nullable: true),
                    Branchline = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DPOs", x => x.DpoId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    EmailSecondary = table.Column<string>(type: "TEXT", nullable: true),
                    CPF = table.Column<string>(type: "TEXT", nullable: true),
                    Cellphone = table.Column<string>(type: "TEXT", nullable: true),
                    Telephone = table.Column<string>(type: "TEXT", nullable: true),
                    Birthday = table.Column<DateTime>(type: "TEXT", nullable: true),
                    createdAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companys");

            migrationBuilder.DropTable(
                name: "DPOs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
