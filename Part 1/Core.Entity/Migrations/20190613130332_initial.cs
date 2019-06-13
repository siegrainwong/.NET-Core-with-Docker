using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Entity.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[,]
                {
                    { 1, "a2bf1adc-3dfc-4939-aa9a-3320e4fb9600", "本教程由Siegrain倾情奉献 :)" },
                    { 2, "6c6286bf-626f-4de9-8300-7caca71851a1", "感谢大家关注~" },
                    { 3, "13da4743-0b63-413a-8a16-d5bda43cafca", "博客地址为 http://siegrain.wang" },
                    { 4, "9b439e03-47b0-40ea-a988-aa26e6d75916", "本教程Github地址为 https://github.com/Seanwong933/.NET-Core-with-Docker" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Post");
        }
    }
}
