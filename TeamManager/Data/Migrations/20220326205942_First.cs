using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamManager.Data.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ballparks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Zip = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ballparks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JerseyNumber = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    State = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeasonType = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ManagerFirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ManagerLastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ManagerEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ManagerPhone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BallparkId = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false),
                    HomeTeamId = table.Column<int>(type: "int", nullable: false),
                    AwayTeamId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HomeTeamRuns = table.Column<int>(type: "int", nullable: false),
                    AwayTeamRuns = table.Column<int>(type: "int", nullable: false),
                    Result = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Ballparks_BallparkId",
                        column: x => x.BallparkId,
                        principalTable: "Ballparks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeasonFieldingStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false),
                    TotalChances = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Putouts = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Assists = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Errors = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    DoublePlays = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    FieldingPercent = table.Column<decimal>(type: "decimal(18,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeasonFieldingStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeasonFieldingStats_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SeasonFieldingStats_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeasonHittingStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeasonId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    PlateAppearance = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    AtBats = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    Runs = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    Singles = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    Doubles = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    Triples = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    Homeruns = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    Walks = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    HitByPitch = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    RunsBattedIn = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    StolenBases = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    CaughtStealing = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    Strikeouts = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    SacrificeHits = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    GroundedInToDoublePlay = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    ScorePercent = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    BattingAvg = table.Column<decimal>(type: "decimal(18,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeasonHittingStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeasonHittingStats_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SeasonHittingStats_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeasonPitchingStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false),
                    InningsPitched = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    Hits = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Runs = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    EarnedRuns = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Walks = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Strikeouts = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Starter = table.Column<bool>(type: "bit", maxLength: 2, nullable: false),
                    Win = table.Column<bool>(type: "bit", nullable: false),
                    Saved = table.Column<bool>(type: "bit", nullable: false),
                    EarnedRunAverage = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    BattersFaced = table.Column<int>(type: "int", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeasonPitchingStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeasonPitchingStats_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SeasonPitchingStats_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameFieldingStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    TotalChances = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Putouts = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Assists = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Errors = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    DoublePlays = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    FieldingPercent = table.Column<decimal>(type: "decimal(18,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameFieldingStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameFieldingStats_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameFieldingStats_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameHittingStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    PlateAppearance = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    AtBats = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Runs = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    Singles = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Doubles = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Triples = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Homeruns = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Walks = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    HitByPitch = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    RunsBattedIn = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    StolenBases = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    CaughtStealing = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Strikeouts = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    SacrificeHits = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    GroundedInToDoublePlay = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    BattingAvg = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    ScorePercent = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    BattingOrder = table.Column<int>(type: "int", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameHittingStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameHittingStats_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameHittingStats_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GamePitchingStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    InningsPitched = table.Column<decimal>(type: "decimal(18,3)", maxLength: 2, nullable: false),
                    Hits = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Runs = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    EarnedRuns = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Walks = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Strikeouts = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Starter = table.Column<bool>(type: "bit", maxLength: 2, nullable: false),
                    Win = table.Column<bool>(type: "bit", nullable: false),
                    Saved = table.Column<bool>(type: "bit", nullable: false),
                    EarnedRunAverage = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    BattersFaced = table.Column<int>(type: "int", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePitchingStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GamePitchingStats_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GamePitchingStats_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameFieldingStats_GameId",
                table: "GameFieldingStats",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameFieldingStats_PlayerId",
                table: "GameFieldingStats",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_GameHittingStats_GameId",
                table: "GameHittingStats",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameHittingStats_PlayerId",
                table: "GameHittingStats",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePitchingStats_GameId",
                table: "GamePitchingStats",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePitchingStats_PlayerId",
                table: "GamePitchingStats",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_BallparkId",
                table: "Games",
                column: "BallparkId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_SeasonId",
                table: "Games",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_SeasonFieldingStats_PlayerId",
                table: "SeasonFieldingStats",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_SeasonFieldingStats_SeasonId",
                table: "SeasonFieldingStats",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_SeasonHittingStats_PlayerId",
                table: "SeasonHittingStats",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_SeasonHittingStats_SeasonId",
                table: "SeasonHittingStats",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_SeasonPitchingStats_PlayerId",
                table: "SeasonPitchingStats",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_SeasonPitchingStats_SeasonId",
                table: "SeasonPitchingStats",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_UserId",
                table: "Teams",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameFieldingStats");

            migrationBuilder.DropTable(
                name: "GameHittingStats");

            migrationBuilder.DropTable(
                name: "GamePitchingStats");

            migrationBuilder.DropTable(
                name: "SeasonFieldingStats");

            migrationBuilder.DropTable(
                name: "SeasonHittingStats");

            migrationBuilder.DropTable(
                name: "SeasonPitchingStats");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Ballparks");

            migrationBuilder.DropTable(
                name: "Seasons");
        }
    }
}
