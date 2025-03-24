using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceMVC.Migrations
{
    /// <inheritdoc />
    public partial class updatedInsurance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Customers_CustomerId1",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Policies_Policies_PolicyId1",
                table: "Policies");

            migrationBuilder.DropIndex(
                name: "IX_Policies_PolicyId1",
                table: "Policies");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomerId1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PolicyId1",
                table: "Policies");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Customers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PolicyId1",
                table: "Policies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId1",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Policies_PolicyId1",
                table: "Policies",
                column: "PolicyId1");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerId1",
                table: "Customers",
                column: "CustomerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Customers_CustomerId1",
                table: "Customers",
                column: "CustomerId1",
                principalTable: "Customers",
                principalColumn: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Policies_Policies_PolicyId1",
                table: "Policies",
                column: "PolicyId1",
                principalTable: "Policies",
                principalColumn: "PolicyId");
        }
    }
}
