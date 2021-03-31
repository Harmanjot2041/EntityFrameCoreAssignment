using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentEntities.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.InsertData(
                table: "StudentsTable",
                columns: new[] { "StudentID", "Age", "StudentName" },
                values: new object[,]
                {
                    { 1L, 21, "Harman" },
                    { 2L, 21, "Harmanjot" },
                    { 3L, 23, "Reema Sandhu" },
                    { 4L, 21, "Happy" }
                });
        }
          
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
