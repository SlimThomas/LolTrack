using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LolTrack.Migrations
{
    /// <inheritdoc />
    public partial class LolTrack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    AbiID = table.Column<int>(type: "int", nullable: false),
                    AbiChampID = table.Column<int>(type: "int", nullable: false),
                    AbilityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AbilityDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AbilitySplash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.AbiID);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemID);
                });

            migrationBuilder.CreateTable(
                name: "Runes",
                columns: table => new
                {
                    RuneID = table.Column<int>(type: "int", nullable: false),
                    RunePageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RuneDesc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runes", x => x.RuneID);
                });

            migrationBuilder.CreateTable(
                name: "SSpells",
                columns: table => new
                {
                    SSpellID = table.Column<int>(type: "int", nullable: false),
                    SpellType = table.Column<int>(type: "int", nullable: false),
                    SpellDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSpellSplash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSpells", x => x.SSpellID);
                });

            migrationBuilder.CreateTable(
                name: "Champions",
                columns: table => new
                {
                    ChampionID = table.Column<int>(type: "int", nullable: false),
                    ChampName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChampDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Difficulty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChampSplash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    abilityAbiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Champions", x => x.ChampionID);
                    table.ForeignKey(
                        name: "FK_Champions_Abilities_abilityAbiID",
                        column: x => x.abilityAbiID,
                        principalTable: "Abilities",
                        principalColumn: "AbiID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchID = table.Column<int>(type: "int", nullable: false),
                    PlayerMatchID = table.Column<int>(type: "int", nullable: false),
                    UserMatchID = table.Column<int>(type: "int", nullable: false),
                    Win = table.Column<bool>(type: "bit", nullable: false),
                    Kills = table.Column<int>(type: "int", nullable: false),
                    Deaths = table.Column<int>(type: "int", nullable: false),
                    Assists = table.Column<int>(type: "int", nullable: false),
                    KDA = table.Column<double>(type: "float", nullable: false),
                    Visionscore = table.Column<int>(type: "int", nullable: false),
                    Minions = table.Column<int>(type: "int", nullable: false),
                    LaneType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Items = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Champions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSpells = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchID);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerID = table.Column<int>(type: "int", nullable: false),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalWins = table.Column<int>(type: "int", nullable: false),
                    WinPerC = table.Column<double>(type: "float", nullable: false),
                    KDA = table.Column<double>(type: "float", nullable: false),
                    TotalMatch = table.Column<int>(type: "int", nullable: false),
                    TotalLosses = table.Column<int>(type: "int", nullable: false),
                    AvgVision = table.Column<double>(type: "float", nullable: false),
                    MostPlayedChampMatchID = table.Column<int>(type: "int", nullable: false),
                    MostPlayedLaneMatchID = table.Column<int>(type: "int", nullable: false),
                    MatchID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerID);
                    table.ForeignKey(
                        name: "FK_Players_Matches_MatchID",
                        column: x => x.MatchID,
                        principalTable: "Matches",
                        principalColumn: "MatchID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Players_Matches_MostPlayedChampMatchID",
                        column: x => x.MostPlayedChampMatchID,
                        principalTable: "Matches",
                        principalColumn: "MatchID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Players_Matches_MostPlayedLaneMatchID",
                        column: x => x.MostPlayedLaneMatchID,
                        principalTable: "Matches",
                        principalColumn: "MatchID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PlayerID = table.Column<int>(type: "int", nullable: false),
                    UserPlayerID = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileSplash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Players_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Players",
                        principalColumn: "PlayerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Champions_abilityAbiID",
                table: "Champions",
                column: "abilityAbiID");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_UserID",
                table: "Matches",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Players_MatchID",
                table: "Players",
                column: "MatchID");

            migrationBuilder.CreateIndex(
                name: "IX_Players_MostPlayedChampMatchID",
                table: "Players",
                column: "MostPlayedChampMatchID");

            migrationBuilder.CreateIndex(
                name: "IX_Players_MostPlayedLaneMatchID",
                table: "Players",
                column: "MostPlayedLaneMatchID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PlayerID",
                table: "Users",
                column: "PlayerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Users_UserID",
                table: "Matches",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Users_UserID",
                table: "Matches");

            migrationBuilder.DropTable(
                name: "Champions");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Runes");

            migrationBuilder.DropTable(
                name: "SSpells");

            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Matches");
        }
    }
}
