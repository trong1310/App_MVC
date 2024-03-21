using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLib_App_Data.Migrations
{
    /// <inheritdoc />
    public partial class WebMVC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "danhMucs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_danhMucs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "phuongThucThanhToans",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phuongThucThanhToans", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RolesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "sanPhams",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductsPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductsQuantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductsImages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductsStatus = table.Column<int>(type: "int", nullable: false),
                    DanhMucID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_sanPhams_danhMucs_DanhMucID",
                        column: x => x.DanhMucID,
                        principalTable: "danhMucs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RolesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_roles_RolesID",
                        column: x => x.RolesID,
                        principalTable: "roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gioHangs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gioHangs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_gioHangs_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDons",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SolDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalMoney = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_hoaDons_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gioHangChiTiets",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CartID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GioHangID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SanPhamID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gioHangChiTiets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_gioHangChiTiets_gioHangs_GioHangID",
                        column: x => x.GioHangID,
                        principalTable: "gioHangs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gioHangChiTiets_sanPhams_SanPhamID",
                        column: x => x.SanPhamID,
                        principalTable: "sanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDonChiTiets",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoaDonID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SanPhamID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonChiTiets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_hoaDons_HoaDonID",
                        column: x => x.HoaDonID,
                        principalTable: "hoaDons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_sanPhams_SanPhamID",
                        column: x => x.SanPhamID,
                        principalTable: "sanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "thanhToans",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalMoney = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    HoaDonID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhuongThucID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhuongThucThanhToanID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_thanhToans", x => x.ID);
                    table.ForeignKey(
                        name: "FK_thanhToans_hoaDons_HoaDonID",
                        column: x => x.HoaDonID,
                        principalTable: "hoaDons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_thanhToans_phuongThucThanhToans_PhuongThucThanhToanID",
                        column: x => x.PhuongThucThanhToanID,
                        principalTable: "phuongThucThanhToans",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_gioHangChiTiets_GioHangID",
                table: "gioHangChiTiets",
                column: "GioHangID");

            migrationBuilder.CreateIndex(
                name: "IX_gioHangChiTiets_SanPhamID",
                table: "gioHangChiTiets",
                column: "SanPhamID");

            migrationBuilder.CreateIndex(
                name: "IX_gioHangs_UserID",
                table: "gioHangs",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_HoaDonID",
                table: "hoaDonChiTiets",
                column: "HoaDonID");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_SanPhamID",
                table: "hoaDonChiTiets",
                column: "SanPhamID");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_UserID",
                table: "hoaDons",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_DanhMucID",
                table: "sanPhams",
                column: "DanhMucID");

            migrationBuilder.CreateIndex(
                name: "IX_thanhToans_HoaDonID",
                table: "thanhToans",
                column: "HoaDonID");

            migrationBuilder.CreateIndex(
                name: "IX_thanhToans_PhuongThucThanhToanID",
                table: "thanhToans",
                column: "PhuongThucThanhToanID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RolesID",
                table: "Users",
                column: "RolesID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gioHangChiTiets");

            migrationBuilder.DropTable(
                name: "hoaDonChiTiets");

            migrationBuilder.DropTable(
                name: "thanhToans");

            migrationBuilder.DropTable(
                name: "gioHangs");

            migrationBuilder.DropTable(
                name: "sanPhams");

            migrationBuilder.DropTable(
                name: "hoaDons");

            migrationBuilder.DropTable(
                name: "phuongThucThanhToans");

            migrationBuilder.DropTable(
                name: "danhMucs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "roles");
        }
    }
}
