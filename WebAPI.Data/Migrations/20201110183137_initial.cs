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
                name: "users",
                columns: table => new
                {
                    idUser = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    email = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    password = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    firstName = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    lastName = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    phoneNumber = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    address = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    note = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    province = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    interestedIn = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    lastLogin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.idUser);
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
                    idUser = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    idProduct = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    comment = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    rateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    rate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ratings", x => x.idUser);
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
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ordersLists",
                columns: table => new
                {
                    idOrder = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    idUser = table.Column<string>(type: "VARCHAR(200)", nullable: false),
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
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

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
