using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Consultation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ConsultationDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0A52E15B-95E6-40FE-9110-9A44817BFF39",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8tTRCoyDFA5/1kAsV2r3g48svfDU97p05H9h+L7jkGaOKU+/qfyeX1loUBQv63Fg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1226920F-9508-44B3-845A-ABABBBCBCF5D",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELzEVqIM3pml9o3zMtWAAtz4qUGXEquXHtZnWbviKGGwYyN/HS6BXhxFoLCYKMbOWg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "273F528F-5330-411F-9C6B-01543D6249C3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEK83DdiNtRvoFerfySe+1dVxBAU3A9Rpoo1lg7MCcwG3RJe2KO9V/8MdNEZDo2sUgA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEClmF4mbSDSJ7c8tAcIvVD8C9G7b+ZdOOd2TE/56kmFx32gnImHXMTmKJTFGjYvHWg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59CF8531-68E4-466B-BAEC-45305FE16A14",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIfiz8gO05ivrGrY9cLrlETVbTtPiqMSzWbKHWKEzsHVGbZXBqdIXyHbAdw2vwFBOA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFLsmT3IIfqvtoyhoWMbQCa6J6KRxuJus3C62Gcmwy1gmnmxLi/6eyFhD7auJ1TGiw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78B4AF2A-672F-43C5-B819-5F0B407B7187",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDbO9cW7TCzEGe7ykGQUr64qmkqluPt2r7HpBmklmFrtmApepXtF19X+jOc9c1q4TA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0B26692-E380-4374-985F-239B56D06C20",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMwWA0BjxKLqUb/oRmH21kojzQDZnxwIGYbt6ELy+/AX4vMjX3cND1Yv9Ue7qJsdZw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D81B4D15-B3CD-47D5-96B0-44EF8E39E538",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELsYiEYiu1y1F1TJjbN1bakdLu+hWSkgdG0XXXDtZkHRznb9XbDy07LAFSMmG6937w==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0A52E15B-95E6-40FE-9110-9A44817BFF39",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKsWfn9+J7/2DKuz9tpP/Z4vxlI3wAevpPWV1B8oyGPEW4IQrnTD1zW4QtD5Bi0ecw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1226920F-9508-44B3-845A-ABABBBCBCF5D",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPPcQFCKgfErUQGHYgU+8wIYsIy43sqkYEFGW3tKNfOrkTkUky1UAzghDyLoLabM7g==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "273F528F-5330-411F-9C6B-01543D6249C3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPadbQbC/CPM765Eq/j/plxaQTRYbHG6qjLaOXyrhnnzgF6imqxfyeew4rp31iFgEA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFID+CCvMYhpeQ0ko29erRRyGNCO0iX4GqjV/bVl5RzdmF/vwiITgDZ/BkftafkUjA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59CF8531-68E4-466B-BAEC-45305FE16A14",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIQDpooI0MtLwv0nWa4KT2nFJq/NGivcvHHpa/z/3r1EsKJRMKFCFe5hmzopWsU5Rg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEC7vYoOt8wWQXH0K7W1MI8qZg4HRoN6PB5IwfZxNx2dm1i4a2d39Kyid16kOD3SXVw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78B4AF2A-672F-43C5-B819-5F0B407B7187",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFa9zOhCvAcALOVpFOUceV9Uqk8PAahfhzGhQv62WlDJjorS2ax7oWu55cnbSao8Cg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0B26692-E380-4374-985F-239B56D06C20",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAF0fPvaV+OVjqy8n5BnildecyLI3YCXMQqjgajLF8yWsWeb8G+7os9ZyK0hNF8EAw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D81B4D15-B3CD-47D5-96B0-44EF8E39E538",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGlWDK4gdOxb+Nb1GeZHgQthVLsQbk6NnpkfGl+SwKTX1O1yl2K9TN84MR2JEScNag==");
        }
    }
}
