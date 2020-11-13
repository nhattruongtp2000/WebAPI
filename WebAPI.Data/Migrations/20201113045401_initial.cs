using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrdersDetails",
                columns: table => new
                {
                    idOrder = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    totalPrice = table.Column<int>(type: "int", nullable: false),
                    idVoucher = table.Column<string>(type: "VARCHAR(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersDetails", x => x.idOrder);
                });

            migrationBuilder.CreateTable(
                name: "productBrands",
                columns: table => new
                {
                    idBrand = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    brandName = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    brandDetail = table.Column<string>(type: "VARCHAR(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productBrands", x => x.idBrand);
                });

            migrationBuilder.CreateTable(
                name: "productCategories",
                columns: table => new
                {
                    idCategory = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    categoryName = table.Column<string>(type: "VARCHAR(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productCategories", x => x.idCategory);
                });

            migrationBuilder.CreateTable(
                name: "productColors",
                columns: table => new
                {
                    idColor = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    colorName = table.Column<string>(type: "VARCHAR(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productColors", x => x.idColor);
                });

            migrationBuilder.CreateTable(
                name: "productDetails",
                columns: table => new
                {
                    idProductDetail = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    price = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    salePrice = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    photoReview = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    detail = table.Column<string>(type: "VARCHAR(2000)", nullable: false),
                    isSaling = table.Column<int>(type: "int", nullable: false),
                    expiredSalingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productDetails", x => x.idProductDetail);
                });

            migrationBuilder.CreateTable(
                name: "productSizes",
                columns: table => new
                {
                    idSize = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    sizeName = table.Column<string>(type: "VARCHAR(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productSizes", x => x.idSize);
                });

            migrationBuilder.CreateTable(
                name: "productTypes",
                columns: table => new
                {
                    idType = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    typeName = table.Column<string>(type: "VARCHAR(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypes", x => x.idType);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    firstName = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    lastName = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    birthday = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    note = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    province = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    interestedIn = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    lastLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "vouchers",
                columns: table => new
                {
                    idVoucher = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    isUse = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vouchers", x => x.idVoucher);
                });

            migrationBuilder.CreateTable(
                name: "productPhotos",
                columns: table => new
                {
                    idProductDetail = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    link = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    uploadedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productPhotos", x => x.idProductDetail);
                    table.ForeignKey(
                        name: "FK_productPhotos_productDetails_idProductDetail",
                        column: x => x.idProductDetail,
                        principalTable: "productDetails",
                        principalColumn: "idProductDetail",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    idProduct = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    idProductDetail = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    idSize = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    idBrand = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    idColor = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    idCategory = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    idType = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    ordersDetailsidOrder = table.Column<string>(type: "VARCHAR(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.idProduct);
                    table.ForeignKey(
                        name: "FK_products_OrdersDetails_ordersDetailsidOrder",
                        column: x => x.ordersDetailsidOrder,
                        principalTable: "OrdersDetails",
                        principalColumn: "idOrder",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_products_productBrands_idBrand",
                        column: x => x.idBrand,
                        principalTable: "productBrands",
                        principalColumn: "idBrand",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_productCategories_idCategory",
                        column: x => x.idCategory,
                        principalTable: "productCategories",
                        principalColumn: "idCategory",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_productColors_idColor",
                        column: x => x.idColor,
                        principalTable: "productColors",
                        principalColumn: "idColor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_productDetails_idProductDetail",
                        column: x => x.idProductDetail,
                        principalTable: "productDetails",
                        principalColumn: "idProductDetail",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_productSizes_idSize",
                        column: x => x.idSize,
                        principalTable: "productSizes",
                        principalColumn: "idSize",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_productTypes_idType",
                        column: x => x.idType,
                        principalTable: "productTypes",
                        principalColumn: "idType",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ratings",
                columns: table => new
                {
                    idUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idProduct = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    comment = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    rateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    rate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ratings_productDetails_idProduct",
                        column: x => x.idProduct,
                        principalTable: "productDetails",
                        principalColumn: "idProductDetail",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ratings_users_idUser",
                        column: x => x.idUser,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ordersLists",
                columns: table => new
                {
                    idOrder = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    idUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idProduct = table.Column<string>(type: "VARCHAR(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ordersLists_OrdersDetails_idOrder",
                        column: x => x.idOrder,
                        principalTable: "OrdersDetails",
                        principalColumn: "idOrder",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ordersLists_products_idProduct",
                        column: x => x.idProduct,
                        principalTable: "products",
                        principalColumn: "idProduct",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ordersLists_users_idUser",
                        column: x => x.idUser,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "7d76b690-7e86-4d00-9920-c52545c3f31b", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") });

            migrationBuilder.InsertData(
                table: "productBrands",
                columns: new[] { "idBrand", "brandDetail", "brandName" },
                values: new object[,]
                {
                    { "1", "Logo", "Logo" },
                    { "2", "Company", "Company" }
                });

            migrationBuilder.InsertData(
                table: "productCategories",
                columns: new[] { "idCategory", "categoryName" },
                values: new object[,]
                {
                    { "1", "Shoes" },
                    { "2", "Shirt" }
                });

            migrationBuilder.InsertData(
                table: "productColors",
                columns: new[] { "idColor", "colorName" },
                values: new object[,]
                {
                    { "ffffff", "While" },
                    { "Red", "Red" }
                });

            migrationBuilder.InsertData(
                table: "productDetails",
                columns: new[] { "idProductDetail", "dateAdded", "detail", "expiredSalingDate", "isSaling", "photoReview", "price", "salePrice" },
                values: new object[,]
                {
                    { "1", new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "goood product", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "yes", "1000000", "1000000" },
                    { "2", new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "goood product", new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "yes", "2000000", "1000000" }
                });

            migrationBuilder.InsertData(
                table: "productSizes",
                columns: new[] { "idSize", "sizeName" },
                values: new object[,]
                {
                    { "1", "L" },
                    { "2", "M" }
                });

            migrationBuilder.InsertData(
                table: "productTypes",
                columns: new[] { "idType", "typeName" },
                values: new object[,]
                {
                    { "1", "Cheap" },
                    { "2", "Expensive" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "birthday", "firstName", "interestedIn", "lastLogin", "lastName", "note", "province" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "c71b7c00-8f38-4f21-9a9e-0f13bcfe5d20", "nhattruongtp2000@gmail.com", true, false, null, "nhattruongtp2000@gmail.com", "admin", "AQAAAAEAACcQAAAAENk5b0tIHDe9Fndjw2kPP8n/m5dbx9tul5PYotxUOm1oR1q1kI5c5O6lPIb1TsUNtw==", null, false, "", false, "admin", "2020-10-12 00:00:00", "Nguyen", null, new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Truong", null, null });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "idProduct", "idBrand", "idCategory", "idColor", "idProductDetail", "idSize", "idType", "ordersDetailsidOrder" },
                values: new object[] { "001", "1", "1", "ffffff", "1", "1", "1", null });

            migrationBuilder.CreateIndex(
                name: "IX_ordersLists_idOrder",
                table: "ordersLists",
                column: "idOrder");

            migrationBuilder.CreateIndex(
                name: "IX_ordersLists_idProduct",
                table: "ordersLists",
                column: "idProduct");

            migrationBuilder.CreateIndex(
                name: "IX_ordersLists_idUser",
                table: "ordersLists",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_products_idBrand",
                table: "products",
                column: "idBrand");

            migrationBuilder.CreateIndex(
                name: "IX_products_idCategory",
                table: "products",
                column: "idCategory");

            migrationBuilder.CreateIndex(
                name: "IX_products_idColor",
                table: "products",
                column: "idColor");

            migrationBuilder.CreateIndex(
                name: "IX_products_idProductDetail",
                table: "products",
                column: "idProductDetail");

            migrationBuilder.CreateIndex(
                name: "IX_products_idSize",
                table: "products",
                column: "idSize");

            migrationBuilder.CreateIndex(
                name: "IX_products_idType",
                table: "products",
                column: "idType");

            migrationBuilder.CreateIndex(
                name: "IX_products_ordersDetailsidOrder",
                table: "products",
                column: "ordersDetailsidOrder");

            migrationBuilder.CreateIndex(
                name: "IX_ratings_idProduct",
                table: "ratings",
                column: "idProduct");

            migrationBuilder.CreateIndex(
                name: "IX_ratings_idUser",
                table: "ratings",
                column: "idUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ordersLists");

            migrationBuilder.DropTable(
                name: "productPhotos");

            migrationBuilder.DropTable(
                name: "ratings");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "vouchers");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "OrdersDetails");

            migrationBuilder.DropTable(
                name: "productBrands");

            migrationBuilder.DropTable(
                name: "productCategories");

            migrationBuilder.DropTable(
                name: "productColors");

            migrationBuilder.DropTable(
                name: "productDetails");

            migrationBuilder.DropTable(
                name: "productSizes");

            migrationBuilder.DropTable(
                name: "productTypes");
        }
    }
}
