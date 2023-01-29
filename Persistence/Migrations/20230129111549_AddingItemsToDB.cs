using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddingItemsToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EngName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArbName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DelCategory = table.Column<string>(name: "Del_Category", type: "nvarchar(max)", nullable: false),
                    ArbName4Search = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArbName4S = table.Column<string>(type: "nvarchar(max)", nullable: false, computedColumnSql: "replace(replace(replace([ArbName],'ى','ي'),'أ','ا'),'ة','ه')"),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenericName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemClassID = table.Column<int>(type: "int", nullable: false),
                    Track = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantityDecimals = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ItemTypeID = table.Column<int>(type: "int", nullable: false),
                    ValuationMethodID = table.Column<int>(type: "int", nullable: false),
                    UnitID = table.Column<int>(type: "int", nullable: false),
                    AllowBackOrders = table.Column<bool>(type: "bit", nullable: false),
                    AbcCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    CustomDutyFreeQty = table.Column<float>(type: "real", nullable: false),
                    DeafultWasteUnitID = table.Column<int>(type: "int", nullable: false),
                    DeafultWasteQty = table.Column<float>(type: "real", nullable: false),
                    DeafultUnitSize = table.Column<float>(type: "real", nullable: false),
                    IssuePartialy = table.Column<bool>(type: "bit", nullable: false),
                    IsContinual = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    RegUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
