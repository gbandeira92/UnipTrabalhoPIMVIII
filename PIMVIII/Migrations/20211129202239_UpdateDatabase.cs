using Microsoft.EntityFrameworkCore.Migrations;

namespace PIMVIII.Migrations
{
    public partial class UpdateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Address_EnderecoId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Telephone_TelefoneId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Telephone_TelephoneType_TipoTelefoneId",
                table: "Telephone");

            migrationBuilder.DropIndex(
                name: "IX_Telephone_TipoTelefoneId",
                table: "Telephone");

            migrationBuilder.DropIndex(
                name: "IX_Person_EnderecoId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_TelefoneId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "TipoTelefoneId",
                table: "Telephone");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "TelefoneId",
                table: "Person");

            migrationBuilder.AddColumn<int>(
                name: "TelephoneId",
                table: "TelephoneType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Telephone",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Address",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TelephoneType_TelephoneId",
                table: "TelephoneType",
                column: "TelephoneId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Telephone_PersonId",
                table: "Telephone",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Address_PersonId",
                table: "Address",
                column: "PersonId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Person_PersonId",
                table: "Address",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telephone_Person_PersonId",
                table: "Telephone",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TelephoneType_Telephone_TelephoneId",
                table: "TelephoneType",
                column: "TelephoneId",
                principalTable: "Telephone",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Person_PersonId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Telephone_Person_PersonId",
                table: "Telephone");

            migrationBuilder.DropForeignKey(
                name: "FK_TelephoneType_Telephone_TelephoneId",
                table: "TelephoneType");

            migrationBuilder.DropIndex(
                name: "IX_TelephoneType_TelephoneId",
                table: "TelephoneType");

            migrationBuilder.DropIndex(
                name: "IX_Telephone_PersonId",
                table: "Telephone");

            migrationBuilder.DropIndex(
                name: "IX_Address_PersonId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "TelephoneId",
                table: "TelephoneType");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Telephone");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Address");

            migrationBuilder.AddColumn<int>(
                name: "TipoTelefoneId",
                table: "Telephone",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TelefoneId",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Telephone_TipoTelefoneId",
                table: "Telephone",
                column: "TipoTelefoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_EnderecoId",
                table: "Person",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_TelefoneId",
                table: "Person",
                column: "TelefoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Address_EnderecoId",
                table: "Person",
                column: "EnderecoId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Telephone_TelefoneId",
                table: "Person",
                column: "TelefoneId",
                principalTable: "Telephone",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Telephone_TelephoneType_TipoTelefoneId",
                table: "Telephone",
                column: "TipoTelefoneId",
                principalTable: "TelephoneType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
