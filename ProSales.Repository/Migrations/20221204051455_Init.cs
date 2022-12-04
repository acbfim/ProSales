using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProSales.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(191)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(191)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Departamento = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagemUrlUser = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataUltimoLogin = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserName = table.Column<string>(type: "varchar(191)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(191)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(191)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(191)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CalculationType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InternalProperty = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationType", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FormTeste",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FormTesteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTeste", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormTeste_FormTeste_FormTesteId",
                        column: x => x.FormTesteId,
                        principalTable: "FormTeste",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(95)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(95)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(95)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(95)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    UserUpdatedId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InternalProperty = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brand_AspNetUsers_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Brand_AspNetUsers_UserUpdatedId",
                        column: x => x.UserUpdatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    FullName = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BirthDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    UserUpdatedId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_AspNetUsers_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Client_AspNetUsers_UserUpdatedId",
                        column: x => x.UserUpdatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CoinType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(300)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Label = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    UserUpdatedId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InternalProperty = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoinType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoinType_AspNetUsers_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CoinType_AspNetUsers_UserUpdatedId",
                        column: x => x.UserUpdatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ContactType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InternalProperty = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    UserUpdatedId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactType_AspNetUsers_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContactType_AspNetUsers_UserUpdatedId",
                        column: x => x.UserUpdatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DocumentType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    UserUpdatedId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InternalProperty = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentType_AspNetUsers_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DocumentType_AspNetUsers_UserUpdatedId",
                        column: x => x.UserUpdatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    UserUpdatedId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InternalProperty = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductType_AspNetUsers_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductType_AspNetUsers_UserUpdatedId",
                        column: x => x.UserUpdatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DiscountType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<double>(type: "double", nullable: false),
                    CalculationTypeId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    UserUpdatedId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InternalProperty = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiscountType_AspNetUsers_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DiscountType_AspNetUsers_UserUpdatedId",
                        column: x => x.UserUpdatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DiscountType_CalculationType_CalculationTypeId",
                        column: x => x.CalculationTypeId,
                        principalTable: "CalculationType",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    City = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Street = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReferencePoint = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ZipCode = table.Column<string>(type: "varchar(15)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Number = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    UserUpdatedId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_AspNetUsers_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Address_AspNetUsers_UserUpdatedId",
                        column: x => x.UserUpdatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Address_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ClientId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Amount = table.Column<double>(type: "double", nullable: false),
                    ClientId = table.Column<long>(type: "bigint", nullable: false),
                    CoinTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_CoinType_CoinTypeId",
                        column: x => x.CoinTypeId,
                        principalTable: "CoinType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Amount = table.Column<double>(type: "double", nullable: false),
                    ClientId = table.Column<long>(type: "bigint", nullable: true),
                    CoinTypeId = table.Column<long>(type: "bigint", nullable: true),
                    SellerId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FinishedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sale_AspNetUsers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sale_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sale_CoinType_CoinTypeId",
                        column: x => x.CoinTypeId,
                        principalTable: "CoinType",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ContactTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Value = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    UserUpdatedId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_AspNetUsers_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contact_AspNetUsers_UserUpdatedId",
                        column: x => x.UserUpdatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contact_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contact_ContactType_ContactTypeId",
                        column: x => x.ContactTypeId,
                        principalTable: "ContactType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Value = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UrlLocation = table.Column<string>(type: "varchar(300)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FileName = table.Column<string>(type: "varchar(130)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DocumentTypeId = table.Column<long>(type: "bigint", nullable: false),
                    ClientId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    UserUpdatedId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Document_AspNetUsers_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Document_AspNetUsers_UserUpdatedId",
                        column: x => x.UserUpdatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Document_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Document_DocumentType_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(300)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<double>(type: "double", nullable: false),
                    ImageUrl = table.Column<string>(type: "varchar(300)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Discount = table.Column<double>(type: "double", nullable: false),
                    ProductTypeId = table.Column<long>(type: "bigint", nullable: false),
                    DiscountTypeId = table.Column<long>(type: "bigint", nullable: true),
                    BrandId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    UserUpdatedId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_AspNetUsers_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Product_AspNetUsers_UserUpdatedId",
                        column: x => x.UserUpdatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Product_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_DiscountType_DiscountTypeId",
                        column: x => x.DiscountTypeId,
                        principalTable: "DiscountType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Product_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HistoryProductSale",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    AmountProductSale = table.Column<double>(type: "double", nullable: false),
                    SellerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryProductSale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryProductSale_AspNetUsers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryProductSale_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BarCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    UserUpdatedId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventory_AspNetUsers_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inventory_AspNetUsers_UserUpdatedId",
                        column: x => x.UserUpdatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inventory_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductCart",
                columns: table => new
                {
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    CartId = table.Column<long>(type: "bigint", nullable: false),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCart", x => new { x.ProductId, x.CartId });
                    table.ForeignKey(
                        name: "FK_ProductCart_AspNetUsers_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductCart_Cart_CartId",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCart_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductOrder",
                columns: table => new
                {
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrder", x => new { x.ProductId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_ProductOrder_AspNetUsers_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductOrder_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductOrder_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductSale",
                columns: table => new
                {
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    SaleId = table.Column<long>(type: "bigint", nullable: false),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Discount = table.Column<double>(type: "double", nullable: false),
                    DiscountTypeId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSale", x => new { x.ProductId, x.SaleId });
                    table.ForeignKey(
                        name: "FK_ProductSale_AspNetUsers_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductSale_DiscountType_DiscountTypeId",
                        column: x => x.DiscountTypeId,
                        principalTable: "DiscountType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductSale_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSale_Sale_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Specification",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Key = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "varchar(1000)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    UserUpdatedId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specification_AspNetUsers_UserCreatedId",
                        column: x => x.UserCreatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Specification_AspNetUsers_UserUpdatedId",
                        column: x => x.UserUpdatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Specification_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "Id", "CreatedAt", "ExternalId", "InternalProperty", "IsActive", "Name", "UpdatedAt", "UserCreatedId", "UserUpdatedId" },
                values: new object[] { 1L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(870), new Guid("d35f72ff-2cb0-447f-9e71-fca6556561f7"), true, true, "Generic", null, null, null });

            migrationBuilder.InsertData(
                table: "CalculationType",
                columns: new[] { "Id", "ExternalId", "InternalProperty", "Name" },
                values: new object[,]
                {
                    { 1L, new Guid("5abb49ac-500e-4f40-9951-e8b556c32cd9"), true, "SUM" },
                    { 2L, new Guid("52220b8b-99b3-482a-90c9-0667318d8b78"), true, "PERCENT" },
                    { 3L, new Guid("7044025f-7b49-4e72-b59d-f5bf2a0e0915"), true, "SUBTRACTION" }
                });

            migrationBuilder.InsertData(
                table: "CoinType",
                columns: new[] { "Id", "CreatedAt", "Description", "ExternalId", "InternalProperty", "IsActive", "Label", "Name", "UpdatedAt", "UserCreatedId", "UserUpdatedId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(820), null, new Guid("d56dac24-bac7-442d-9e70-7dd349393e9c"), true, true, "R$", "Real", null, null, null },
                    { 2L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(840), null, new Guid("36e121dc-b0b5-42ef-b43e-1df3bfcc3334"), true, true, "US$", "Dólar", null, null, null },
                    { 3L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(850), null, new Guid("ff12fded-31a6-4bcf-abec-54dc41211b9a"), true, true, "€", "Euro", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ContactType",
                columns: new[] { "Id", "CreatedAt", "ExternalId", "InternalProperty", "IsActive", "Name", "UpdatedAt", "UserCreatedId", "UserUpdatedId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(510), new Guid("f13c71d3-d153-4881-8a49-1699387d3ef8"), true, true, "Email Pessoal", null, null, null },
                    { 2L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(570), new Guid("b1e8993d-4447-4e88-993e-ef8331e9e7fb"), true, true, "Email Comercial", null, null, null },
                    { 3L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(580), new Guid("e15ec82b-307c-4cf5-b0bb-a1987f4b4a07"), true, true, "Celular Pessoal", null, null, null },
                    { 4L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(590), new Guid("01bd1779-77d8-419b-919b-5861de7bd9d0"), true, true, "Celular Comercial", null, null, null },
                    { 5L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(600), new Guid("d7d6598d-34d1-4736-b6ac-45b1cd2f47cb"), true, true, "Telefone Comercial", null, null, null },
                    { 6L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(610), new Guid("9ddc1d49-a1d9-444d-886c-6d6be1cf2f6b"), true, true, "Telefone Residencial", null, null, null },
                    { 7L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(630), new Guid("43a4d1f1-9759-47a8-8aa2-b482114350f4"), true, true, "WhatsApp Comercial", null, null, null },
                    { 8L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(640), new Guid("eedd9150-d883-4552-a007-71dc670fa70d"), true, true, "WhatsApp Pessoal", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "DocumentType",
                columns: new[] { "Id", "CreatedAt", "ExternalId", "InternalProperty", "IsActive", "Name", "UpdatedAt", "UserCreatedId", "UserUpdatedId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(720), new Guid("0fec0636-0a25-4433-bcdd-de2fddd7485e"), true, true, "RG", null, null, null },
                    { 2L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(740), new Guid("3e4247be-f60d-471e-bf5f-d41e2dc63b22"), true, true, "CPF", null, null, null },
                    { 3L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(750), new Guid("3465a010-8ab3-4df1-a234-ab7c093207d2"), true, true, "CNPJ", null, null, null },
                    { 4L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(760), new Guid("f3e11a82-8274-43f9-9c8a-b0d5558cfea1"), true, true, "CNH", null, null, null },
                    { 5L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(780), new Guid("63f45de2-2569-48da-a1ae-bc3f383c2dba"), true, true, "Certidão de Nascimento", null, null, null },
                    { 6L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(790), new Guid("8b23e4c2-5575-45e7-b2b4-6c520d55e3cc"), true, true, "Certidão de Casamento", null, null, null },
                    { 7L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(800), new Guid("9c7b40d6-eb85-4b0c-87a6-7c2206fc0eb3"), true, true, "Foto do usuário", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "Id", "CreatedAt", "ExternalId", "InternalProperty", "IsActive", "Name", "UpdatedAt", "UserCreatedId", "UserUpdatedId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(960), new Guid("651f2ee8-2631-4cb3-9926-24afd922426d"), true, true, "Serviço", null, null, null },
                    { 2L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(970), new Guid("5dcf1889-8f37-4ab2-8390-11cdd4605df9"), true, true, "Produto", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "DiscountType",
                columns: new[] { "Id", "CalculationTypeId", "CreatedAt", "ExternalId", "InternalProperty", "IsActive", "Name", "UpdatedAt", "UserCreatedId", "UserUpdatedId", "Value" },
                values: new object[,]
                {
                    { 1L, 3L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(910), new Guid("aff22554-1841-413d-b920-28eeeca07c73"), true, true, "Gerente", null, null, null, 0.0 },
                    { 2L, 3L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(930), new Guid("393ee895-46d3-4fc1-94f6-4721b5e1e82b"), true, true, "Cupom", null, null, null, 0.0 },
                    { 3L, 2L, new DateTime(2022, 12, 4, 2, 14, 55, 329, DateTimeKind.Local).AddTicks(940), new Guid("e2328040-1cd2-4559-9ecb-71f5c332c828"), true, true, "Pgamento a vista", null, null, null, 0.14999999999999999 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_ClientId",
                table: "Address",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_UserCreatedId",
                table: "Address",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_UserUpdatedId",
                table: "Address",
                column: "UserUpdatedId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Brand_UserCreatedId",
                table: "Brand",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Brand_UserUpdatedId",
                table: "Brand",
                column: "UserUpdatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_ClientId",
                table: "Cart",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_UserCreatedId",
                table: "Client",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_UserUpdatedId",
                table: "Client",
                column: "UserUpdatedId");

            migrationBuilder.CreateIndex(
                name: "IX_CoinType_UserCreatedId",
                table: "CoinType",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_CoinType_UserUpdatedId",
                table: "CoinType",
                column: "UserUpdatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_ClientId",
                table: "Contact",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_ContactTypeId",
                table: "Contact",
                column: "ContactTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_UserCreatedId",
                table: "Contact",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_UserUpdatedId",
                table: "Contact",
                column: "UserUpdatedId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactType_UserCreatedId",
                table: "ContactType",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactType_UserUpdatedId",
                table: "ContactType",
                column: "UserUpdatedId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountType_CalculationTypeId",
                table: "DiscountType",
                column: "CalculationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountType_UserCreatedId",
                table: "DiscountType",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountType_UserUpdatedId",
                table: "DiscountType",
                column: "UserUpdatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_ClientId",
                table: "Document",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_DocumentTypeId",
                table: "Document",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_UserCreatedId",
                table: "Document",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_UserUpdatedId",
                table: "Document",
                column: "UserUpdatedId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentType_UserCreatedId",
                table: "DocumentType",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentType_UserUpdatedId",
                table: "DocumentType",
                column: "UserUpdatedId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTeste_FormTesteId",
                table: "FormTeste",
                column: "FormTesteId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryProductSale_ProductId",
                table: "HistoryProductSale",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryProductSale_SellerId",
                table: "HistoryProductSale",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_ProductId",
                table: "Inventory",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_UserCreatedId",
                table: "Inventory",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_UserUpdatedId",
                table: "Inventory",
                column: "UserUpdatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientId",
                table: "Order",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CoinTypeId",
                table: "Order",
                column: "CoinTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BrandId",
                table: "Product",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_DiscountTypeId",
                table: "Product",
                column: "DiscountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductTypeId",
                table: "Product",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UserCreatedId",
                table: "Product",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UserUpdatedId",
                table: "Product",
                column: "UserUpdatedId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCart_CartId",
                table: "ProductCart",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCart_UserCreatedId",
                table: "ProductCart",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrder_OrderId",
                table: "ProductOrder",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrder_UserCreatedId",
                table: "ProductOrder",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSale_DiscountTypeId",
                table: "ProductSale",
                column: "DiscountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSale_SaleId",
                table: "ProductSale",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSale_UserCreatedId",
                table: "ProductSale",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductType_UserCreatedId",
                table: "ProductType",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductType_UserUpdatedId",
                table: "ProductType",
                column: "UserUpdatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_ClientId",
                table: "Sale",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_CoinTypeId",
                table: "Sale",
                column: "CoinTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_SellerId",
                table: "Sale",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Specification_ProductId",
                table: "Specification",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Specification_UserCreatedId",
                table: "Specification",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Specification_UserUpdatedId",
                table: "Specification",
                column: "UserUpdatedId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "FormTeste");

            migrationBuilder.DropTable(
                name: "HistoryProductSale");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "ProductCart");

            migrationBuilder.DropTable(
                name: "ProductOrder");

            migrationBuilder.DropTable(
                name: "ProductSale");

            migrationBuilder.DropTable(
                name: "Specification");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ContactType");

            migrationBuilder.DropTable(
                name: "DocumentType");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "CoinType");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "DiscountType");

            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropTable(
                name: "CalculationType");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
