using Microsoft.EntityFrameworkCore.Migrations;

namespace Ip2Location.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ip2location");

            migrationBuilder.CreateTable(
                name: "ip_geo_location",
                schema: "ip2location",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ip_from = table.Column<double>(nullable: false),
                    ip_to = table.Column<double>(nullable: false),
                    country_code = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    country_name = table.Column<string>(unicode: false, maxLength: 64, nullable: false),
                    region = table.Column<string>(unicode: false, maxLength: 128, nullable: false),
                    city = table.Column<string>(unicode: false, maxLength: 128, nullable: false),
                    latitude = table.Column<double>(nullable: false),
                    longitude = table.Column<double>(nullable: false),
                    zip_code = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    time_zone = table.Column<string>(unicode: false, maxLength: 7, nullable: false),
                    isp_name = table.Column<string>(unicode: false, maxLength: 256, nullable: false),
                    domain_name = table.Column<string>(unicode: false, maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ip_geo_location", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IDX_ECF8386FAA7DFDFF",
                schema: "ip2location",
                table: "ip_geo_location",
                column: "ip_from");

            migrationBuilder.CreateIndex(
                name: "IDX_ECF8386FC881EB0B",
                schema: "ip2location",
                table: "ip_geo_location",
                column: "ip_to");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ip_geo_location",
                schema: "ip2location");
        }
    }
}
