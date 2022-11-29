CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET=utf8mb4;

START TRANSACTION;

ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `AspNetRoles` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `Name` varchar(256) CHARACTER SET utf8mb4 NULL,
    `NormalizedName` varchar(256) CHARACTER SET utf8mb4 NULL,
    `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AspNetRoles` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `AspNetUsers` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `FullName` longtext CHARACTER SET utf8mb4 NOT NULL,
    `DataNascimento` datetime(6) NOT NULL,
    `Departamento` longtext CHARACTER SET utf8mb4 NOT NULL,
    `ImagemUrlUser` longtext CHARACTER SET utf8mb4 NOT NULL,
    `DataUltimoLogin` datetime(6) NOT NULL,
    `Status` tinyint(1) NOT NULL,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `UserName` varchar(256) CHARACTER SET utf8mb4 NULL,
    `NormalizedUserName` varchar(256) CHARACTER SET utf8mb4 NULL,
    `Email` varchar(256) CHARACTER SET utf8mb4 NULL,
    `NormalizedEmail` varchar(256) CHARACTER SET utf8mb4 NULL,
    `EmailConfirmed` tinyint(1) NOT NULL,
    `PasswordHash` longtext CHARACTER SET utf8mb4 NULL,
    `SecurityStamp` longtext CHARACTER SET utf8mb4 NULL,
    `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 NULL,
    `PhoneNumber` longtext CHARACTER SET utf8mb4 NULL,
    `PhoneNumberConfirmed` tinyint(1) NOT NULL,
    `TwoFactorEnabled` tinyint(1) NOT NULL,
    `LockoutEnd` datetime(6) NULL,
    `LockoutEnabled` tinyint(1) NOT NULL,
    `AccessFailedCount` int NOT NULL,
    CONSTRAINT `PK_AspNetUsers` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `CalculationType` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `InternalProperty` tinyint(1) NOT NULL,
    CONSTRAINT `PK_CalculationType` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `AspNetRoleClaims` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `RoleId` int NOT NULL,
    `ClaimType` longtext CHARACTER SET utf8mb4 NULL,
    `ClaimValue` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AspNetRoleClaims` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `AspNetUserClaims` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `UserId` int NOT NULL,
    `ClaimType` longtext CHARACTER SET utf8mb4 NULL,
    `ClaimValue` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AspNetUserClaims` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `AspNetUserLogins` (
    `LoginProvider` varchar(95) CHARACTER SET utf8mb4 NOT NULL,
    `ProviderKey` varchar(95) CHARACTER SET utf8mb4 NOT NULL,
    `ProviderDisplayName` longtext CHARACTER SET utf8mb4 NULL,
    `UserId` int NOT NULL,
    CONSTRAINT `PK_AspNetUserLogins` PRIMARY KEY (`LoginProvider`, `ProviderKey`),
    CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `AspNetUserRoles` (
    `UserId` int NOT NULL,
    `RoleId` int NOT NULL,
    CONSTRAINT `PK_AspNetUserRoles` PRIMARY KEY (`UserId`, `RoleId`),
    CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `AspNetUserTokens` (
    `UserId` int NOT NULL,
    `LoginProvider` varchar(95) CHARACTER SET utf8mb4 NOT NULL,
    `Name` varchar(95) CHARACTER SET utf8mb4 NOT NULL,
    `Value` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AspNetUserTokens` PRIMARY KEY (`UserId`, `LoginProvider`, `Name`),
    CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `Brand` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `Name` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
    `IsActive` tinyint(1) NOT NULL,
    `InternalProperty` tinyint(1) NOT NULL,
    `UserCreatedId` int NULL,
    `UserUpdatedId` int NULL,
    CONSTRAINT `PK_Brand` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Brand_AspNetUsers_UserCreatedId` FOREIGN KEY (`UserCreatedId`) REFERENCES `AspNetUsers` (`Id`),
    CONSTRAINT `FK_Brand_AspNetUsers_UserUpdatedId` FOREIGN KEY (`UserUpdatedId`) REFERENCES `AspNetUsers` (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Client` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `FullName` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UserCreatedId` int NULL,
    `UpdatedAt` datetime(6) NULL,
    `UserUpdatedId` int NULL,
    CONSTRAINT `PK_Client` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Client_AspNetUsers_UserCreatedId` FOREIGN KEY (`UserCreatedId`) REFERENCES `AspNetUsers` (`Id`),
    CONSTRAINT `FK_Client_AspNetUsers_UserUpdatedId` FOREIGN KEY (`UserUpdatedId`) REFERENCES `AspNetUsers` (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `CoinType` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Description` varchar(300) CHARACTER SET utf8mb4 NULL,
    `Label` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `IsActive` tinyint(1) NOT NULL,
    `InternalProperty` tinyint(1) NOT NULL,
    `UserCreatedId` int NULL,
    `UserUpdatedId` int NULL,
    CONSTRAINT `PK_CoinType` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_CoinType_AspNetUsers_UserCreatedId` FOREIGN KEY (`UserCreatedId`) REFERENCES `AspNetUsers` (`Id`),
    CONSTRAINT `FK_CoinType_AspNetUsers_UserUpdatedId` FOREIGN KEY (`UserUpdatedId`) REFERENCES `AspNetUsers` (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `ContactType` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `Name` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
    `InternalProperty` tinyint(1) NOT NULL,
    `IsActive` tinyint(1) NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `UserCreatedId` int NULL,
    `UserUpdatedId` int NULL,
    CONSTRAINT `PK_ContactType` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ContactType_AspNetUsers_UserCreatedId` FOREIGN KEY (`UserCreatedId`) REFERENCES `AspNetUsers` (`Id`),
    CONSTRAINT `FK_ContactType_AspNetUsers_UserUpdatedId` FOREIGN KEY (`UserUpdatedId`) REFERENCES `AspNetUsers` (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `DocumentType` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `IsActive` tinyint(1) NOT NULL,
    `InternalProperty` tinyint(1) NOT NULL,
    `UserCreatedId` int NULL,
    `UserUpdatedId` int NULL,
    CONSTRAINT `PK_DocumentType` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_DocumentType_AspNetUsers_UserCreatedId` FOREIGN KEY (`UserCreatedId`) REFERENCES `AspNetUsers` (`Id`),
    CONSTRAINT `FK_DocumentType_AspNetUsers_UserUpdatedId` FOREIGN KEY (`UserUpdatedId`) REFERENCES `AspNetUsers` (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `ProductType` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `InternalProperty` tinyint(1) NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `IsActive` tinyint(1) NOT NULL,
    `UserCreatedId` int NULL,
    `UserUpdatedId` int NULL,
    CONSTRAINT `PK_ProductType` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ProductType_AspNetUsers_UserCreatedId` FOREIGN KEY (`UserCreatedId`) REFERENCES `AspNetUsers` (`Id`),
    CONSTRAINT `FK_ProductType_AspNetUsers_UserUpdatedId` FOREIGN KEY (`UserUpdatedId`) REFERENCES `AspNetUsers` (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `DiscountType` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `Name` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
    `Value` double NOT NULL,
    `CalculationTypeId` bigint NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `UserCreatedId` int NULL,
    `UserUpdatedId` int NULL,
    `IsActive` tinyint(1) NOT NULL,
    `InternalProperty` tinyint(1) NOT NULL,
    CONSTRAINT `PK_DiscountType` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_DiscountType_AspNetUsers_UserCreatedId` FOREIGN KEY (`UserCreatedId`) REFERENCES `AspNetUsers` (`Id`),
    CONSTRAINT `FK_DiscountType_AspNetUsers_UserUpdatedId` FOREIGN KEY (`UserUpdatedId`) REFERENCES `AspNetUsers` (`Id`),
    CONSTRAINT `FK_DiscountType_CalculationType_CalculationTypeId` FOREIGN KEY (`CalculationTypeId`) REFERENCES `CalculationType` (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Address` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `City` varchar(30) CHARACTER SET utf8mb4 NOT NULL,
    `State` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
    `Street` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
    `ReferencePoint` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
    `Country` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
    `ZipCode` varchar(15) CHARACTER SET utf8mb4 NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UserCreatedId` int NULL,
    `UpdatedAt` datetime(6) NULL,
    `UserUpdatedId` int NULL,
    `ClientId` bigint NULL,
    CONSTRAINT `PK_Address` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Address_AspNetUsers_UserCreatedId` FOREIGN KEY (`UserCreatedId`) REFERENCES `AspNetUsers` (`Id`),
    CONSTRAINT `FK_Address_AspNetUsers_UserUpdatedId` FOREIGN KEY (`UserUpdatedId`) REFERENCES `AspNetUsers` (`Id`),
    CONSTRAINT `FK_Address_Client_ClientId` FOREIGN KEY (`ClientId`) REFERENCES `Client` (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Cart` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `ClientId` bigint NOT NULL,
    CONSTRAINT `PK_Cart` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Cart_Client_ClientId` FOREIGN KEY (`ClientId`) REFERENCES `Client` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `Order` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `EffectiveDate` datetime(6) NOT NULL,
    `ClientId` bigint NULL,
    `CoinTypeId` bigint NOT NULL,
    `Amount` double NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    CONSTRAINT `PK_Order` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Order_Client_ClientId` FOREIGN KEY (`ClientId`) REFERENCES `Client` (`Id`),
    CONSTRAINT `FK_Order_CoinType_CoinTypeId` FOREIGN KEY (`CoinTypeId`) REFERENCES `CoinType` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `Sale` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `ClientId` bigint NULL,
    `CoinTypeId` bigint NOT NULL,
    `Amount` double NOT NULL,
    `SellerId` int NULL,
    `CreatedAt` datetime(6) NOT NULL,
    CONSTRAINT `PK_Sale` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Sale_AspNetUsers_SellerId` FOREIGN KEY (`SellerId`) REFERENCES `AspNetUsers` (`Id`),
    CONSTRAINT `FK_Sale_Client_ClientId` FOREIGN KEY (`ClientId`) REFERENCES `Client` (`Id`),
    CONSTRAINT `FK_Sale_CoinType_CoinTypeId` FOREIGN KEY (`CoinTypeId`) REFERENCES `CoinType` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `Contact` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `TypeId` bigint NOT NULL,
    `Value` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `ClientId` bigint NULL,
    CONSTRAINT `PK_Contact` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Contact_Client_ClientId` FOREIGN KEY (`ClientId`) REFERENCES `Client` (`Id`),
    CONSTRAINT `FK_Contact_ContactType_TypeId` FOREIGN KEY (`TypeId`) REFERENCES `ContactType` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `Document` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `TypeId` bigint NOT NULL,
    `Value` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `UrlLocation` varchar(300) CHARACTER SET utf8mb4 NULL,
    `FileName` varchar(300) CHARACTER SET utf8mb4 NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `InternalProperty` tinyint(1) NOT NULL,
    `ClientId` bigint NULL,
    CONSTRAINT `PK_Document` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Document_Client_ClientId` FOREIGN KEY (`ClientId`) REFERENCES `Client` (`Id`),
    CONSTRAINT `FK_Document_DocumentType_TypeId` FOREIGN KEY (`TypeId`) REFERENCES `DocumentType` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `Product` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `ProductTypeId` bigint NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Description` varchar(300) CHARACTER SET utf8mb4 NULL,
    `Price` double NOT NULL,
    `ImageUrl` varchar(300) CHARACTER SET utf8mb4 NULL,
    `DiscountTypeId` bigint NULL,
    `Discount` double NOT NULL,
    `BrandId` bigint NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UserCreatedId` int NULL,
    `IsActive` tinyint(1) NOT NULL,
    `CartId` bigint NULL,
    `OrderId` bigint NULL,
    `SaleId` bigint NULL,
    CONSTRAINT `PK_Product` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Product_AspNetUsers_UserCreatedId` FOREIGN KEY (`UserCreatedId`) REFERENCES `AspNetUsers` (`Id`),
    CONSTRAINT `FK_Product_Brand_BrandId` FOREIGN KEY (`BrandId`) REFERENCES `Brand` (`Id`),
    CONSTRAINT `FK_Product_Cart_CartId` FOREIGN KEY (`CartId`) REFERENCES `Cart` (`Id`),
    CONSTRAINT `FK_Product_DiscountType_DiscountTypeId` FOREIGN KEY (`DiscountTypeId`) REFERENCES `DiscountType` (`Id`),
    CONSTRAINT `FK_Product_Order_OrderId` FOREIGN KEY (`OrderId`) REFERENCES `Order` (`Id`),
    CONSTRAINT `FK_Product_ProductType_ProductTypeId` FOREIGN KEY (`ProductTypeId`) REFERENCES `ProductType` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Product_Sale_SaleId` FOREIGN KEY (`SaleId`) REFERENCES `Sale` (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `HistoryProductSale` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `SellerId` int NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `ProductId` bigint NOT NULL,
    `AmountProductSale` double NOT NULL,
    CONSTRAINT `PK_HistoryProductSale` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_HistoryProductSale_AspNetUsers_SellerId` FOREIGN KEY (`SellerId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_HistoryProductSale_Product_ProductId` FOREIGN KEY (`ProductId`) REFERENCES `Product` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `Inventory` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `ProductId` bigint NOT NULL,
    `BarCode` longtext CHARACTER SET utf8mb4 NULL,
    `CreatedAt` datetime(6) NOT NULL,
    CONSTRAINT `PK_Inventory` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Inventory_Product_ProductId` FOREIGN KEY (`ProductId`) REFERENCES `Product` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `Specification` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `Key` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Value` varchar(1000) CHARACTER SET utf8mb4 NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `ProductId` bigint NULL,
    CONSTRAINT `PK_Specification` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Specification_Product_ProductId` FOREIGN KEY (`ProductId`) REFERENCES `Product` (`Id`)
) CHARACTER SET=utf8mb4;

INSERT INTO `Brand` (`Id`, `CreatedAt`, `ExternalId`, `InternalProperty`, `IsActive`, `Name`, `UpdatedAt`, `UserCreatedId`, `UserUpdatedId`)
VALUES (1, TIMESTAMP '2022-11-24 15:18:20', 'dcc00050-6381-465d-bf60-5aa50e3427c0', TRUE, TRUE, 'Generic', NULL, NULL, NULL);

INSERT INTO `CalculationType` (`Id`, `ExternalId`, `InternalProperty`, `Name`)
VALUES (1, 'ad0bafaf-faba-418f-90b9-ba7fe37290f5', TRUE, 'SUM'),
(2, 'b274a4ab-2cd1-4df3-b557-6597ecda2b98', TRUE, 'PERCENT'),
(3, '134f359e-19d8-44b7-9827-89a11cf3d236', TRUE, 'SUBTRACTION');

INSERT INTO `CoinType` (`Id`, `CreatedAt`, `Description`, `ExternalId`, `InternalProperty`, `IsActive`, `Label`, `Name`, `UpdatedAt`, `UserCreatedId`, `UserUpdatedId`)
VALUES (1, TIMESTAMP '2022-11-24 15:18:20', NULL, '20561ce4-b15c-443e-998b-cb40be97f628', TRUE, TRUE, 'R$', 'Real', NULL, NULL, NULL),
(2, TIMESTAMP '2022-11-24 15:18:20', NULL, '57581b2a-1519-485b-a7de-f6c7b809539a', TRUE, TRUE, 'US$', 'Dólar', NULL, NULL, NULL),
(3, TIMESTAMP '2022-11-24 15:18:20', NULL, '89a6c65d-6a0e-4b93-a5bf-186cdedbbee3', TRUE, TRUE, '€', 'Euro', NULL, NULL, NULL);

INSERT INTO `ContactType` (`Id`, `CreatedAt`, `ExternalId`, `InternalProperty`, `IsActive`, `Name`, `UpdatedAt`, `UserCreatedId`, `UserUpdatedId`)
VALUES (1, TIMESTAMP '2022-11-24 15:18:20', '53992184-16bd-4a97-a974-31fcc8cab0d7', TRUE, TRUE, 'Email Pessoal', NULL, NULL, NULL),
(2, TIMESTAMP '2022-11-24 15:18:20', '71ecca6d-4c7d-4e5a-b65d-e7db9b1e46cd', TRUE, TRUE, 'Email Comercial', NULL, NULL, NULL),
(3, TIMESTAMP '2022-11-24 15:18:20', '87ce1c43-867b-4f89-97c4-efe234895b41', TRUE, TRUE, 'Celular Pessoal', NULL, NULL, NULL),
(4, TIMESTAMP '2022-11-24 15:18:20', '0fe5735b-d669-487b-a187-549cd2a5742b', TRUE, TRUE, 'Celular Comercial', NULL, NULL, NULL),
(5, TIMESTAMP '2022-11-24 15:18:20', '9c05c442-16e6-42a0-8d10-953c665dd959', TRUE, TRUE, 'Telefone Comercial', NULL, NULL, NULL),
(6, TIMESTAMP '2022-11-24 15:18:20', '48933a6b-bd1b-474a-83d7-651248072e58', TRUE, TRUE, 'Telefone Residencial', NULL, NULL, NULL),
(7, TIMESTAMP '2022-11-24 15:18:20', '72079b2e-902e-41bf-9436-dd6016148653', TRUE, TRUE, 'WhatsApp Comercial', NULL, NULL, NULL),
(8, TIMESTAMP '2022-11-24 15:18:20', 'c30ef4a3-4bb7-479c-beda-820cc062819e', TRUE, TRUE, 'WhatsApp Pessoal', NULL, NULL, NULL);

INSERT INTO `DocumentType` (`Id`, `CreatedAt`, `ExternalId`, `InternalProperty`, `IsActive`, `Name`, `UpdatedAt`, `UserCreatedId`, `UserUpdatedId`)
VALUES (1, TIMESTAMP '2022-11-24 15:18:20', 'adbe227a-1c46-4c18-94ac-f1a092808d1e', TRUE, TRUE, 'RG', NULL, NULL, NULL),
(2, TIMESTAMP '2022-11-24 15:18:20', 'e65138b7-2461-4925-875c-8df1ada66477', TRUE, TRUE, 'CPF', NULL, NULL, NULL),
(3, TIMESTAMP '2022-11-24 15:18:20', '4f949ba0-9f21-4900-8a25-65fd8ef9240e', TRUE, TRUE, 'CNPJ', NULL, NULL, NULL),
(4, TIMESTAMP '2022-11-24 15:18:20', 'd91f2670-ebe4-4795-9c1f-12c088736402', TRUE, TRUE, 'CNH', NULL, NULL, NULL),
(5, TIMESTAMP '2022-11-24 15:18:20', 'ddf4f912-2df1-4281-af54-eaf445124f61', TRUE, TRUE, 'Certidão de Nascimento', NULL, NULL, NULL),
(6, TIMESTAMP '2022-11-24 15:18:20', '039e6343-b872-476d-9242-6b232ffddc5c', TRUE, TRUE, 'Certidão de Casamento', NULL, NULL, NULL),
(7, TIMESTAMP '2022-11-24 15:18:20', '21f5bca8-b74d-4c09-bc23-02c6fde0da72', TRUE, TRUE, 'Foto do usuário', NULL, NULL, NULL);

INSERT INTO `ProductType` (`Id`, `CreatedAt`, `ExternalId`, `InternalProperty`, `IsActive`, `Name`, `UpdatedAt`, `UserCreatedId`, `UserUpdatedId`)
VALUES (1, TIMESTAMP '2022-11-24 15:18:20', 'e07ae4a1-2a7a-4d05-8a62-39f828a5cab3', TRUE, TRUE, 'Serviço', NULL, NULL, NULL),
(2, TIMESTAMP '2022-11-24 15:18:20', '824fba14-26e7-4341-ad2a-693c8db5c487', TRUE, TRUE, 'Produto', NULL, NULL, NULL);

INSERT INTO `DiscountType` (`Id`, `CalculationTypeId`, `CreatedAt`, `ExternalId`, `InternalProperty`, `IsActive`, `Name`, `UpdatedAt`, `UserCreatedId`, `UserUpdatedId`, `Value`)
VALUES (1, 3, TIMESTAMP '2022-11-24 15:18:20', 'efa7f923-ab3f-49e6-8ea6-54ee5495f393', TRUE, TRUE, 'Gerente', NULL, NULL, NULL, 0.0),
(2, 3, TIMESTAMP '2022-11-24 15:18:20', '76fd987f-91a0-4b90-991b-53821252aaa7', TRUE, TRUE, 'Cupom', NULL, NULL, NULL, 0.0),
(3, 2, TIMESTAMP '2022-11-24 15:18:20', 'ae22c4d5-7f11-4d58-b9a7-2663f81ed774', TRUE, TRUE, 'Pgamento a vista', NULL, NULL, NULL, 0.14999999999999999);

CREATE INDEX `IX_Address_ClientId` ON `Address` (`ClientId`);

CREATE INDEX `IX_Address_UserCreatedId` ON `Address` (`UserCreatedId`);

CREATE INDEX `IX_Address_UserUpdatedId` ON `Address` (`UserUpdatedId`);

CREATE INDEX `IX_AspNetRoleClaims_RoleId` ON `AspNetRoleClaims` (`RoleId`);

CREATE UNIQUE INDEX `RoleNameIndex` ON `AspNetRoles` (`NormalizedName`);

CREATE INDEX `IX_AspNetUserClaims_UserId` ON `AspNetUserClaims` (`UserId`);

CREATE INDEX `IX_AspNetUserLogins_UserId` ON `AspNetUserLogins` (`UserId`);

CREATE INDEX `IX_AspNetUserRoles_RoleId` ON `AspNetUserRoles` (`RoleId`);

CREATE INDEX `EmailIndex` ON `AspNetUsers` (`NormalizedEmail`);

CREATE UNIQUE INDEX `UserNameIndex` ON `AspNetUsers` (`NormalizedUserName`);

CREATE INDEX `IX_Brand_UserCreatedId` ON `Brand` (`UserCreatedId`);

CREATE INDEX `IX_Brand_UserUpdatedId` ON `Brand` (`UserUpdatedId`);

CREATE INDEX `IX_Cart_ClientId` ON `Cart` (`ClientId`);

CREATE INDEX `IX_Client_UserCreatedId` ON `Client` (`UserCreatedId`);

CREATE INDEX `IX_Client_UserUpdatedId` ON `Client` (`UserUpdatedId`);

CREATE INDEX `IX_CoinType_UserCreatedId` ON `CoinType` (`UserCreatedId`);

CREATE INDEX `IX_CoinType_UserUpdatedId` ON `CoinType` (`UserUpdatedId`);

CREATE INDEX `IX_Contact_ClientId` ON `Contact` (`ClientId`);

CREATE INDEX `IX_Contact_TypeId` ON `Contact` (`TypeId`);

CREATE INDEX `IX_ContactType_UserCreatedId` ON `ContactType` (`UserCreatedId`);

CREATE INDEX `IX_ContactType_UserUpdatedId` ON `ContactType` (`UserUpdatedId`);

CREATE INDEX `IX_DiscountType_CalculationTypeId` ON `DiscountType` (`CalculationTypeId`);

CREATE INDEX `IX_DiscountType_UserCreatedId` ON `DiscountType` (`UserCreatedId`);

CREATE INDEX `IX_DiscountType_UserUpdatedId` ON `DiscountType` (`UserUpdatedId`);

CREATE INDEX `IX_Document_ClientId` ON `Document` (`ClientId`);

CREATE INDEX `IX_Document_TypeId` ON `Document` (`TypeId`);

CREATE INDEX `IX_DocumentType_UserCreatedId` ON `DocumentType` (`UserCreatedId`);

CREATE INDEX `IX_DocumentType_UserUpdatedId` ON `DocumentType` (`UserUpdatedId`);

CREATE INDEX `IX_HistoryProductSale_ProductId` ON `HistoryProductSale` (`ProductId`);

CREATE INDEX `IX_HistoryProductSale_SellerId` ON `HistoryProductSale` (`SellerId`);

CREATE INDEX `IX_Inventory_ProductId` ON `Inventory` (`ProductId`);

CREATE INDEX `IX_Order_ClientId` ON `Order` (`ClientId`);

CREATE INDEX `IX_Order_CoinTypeId` ON `Order` (`CoinTypeId`);

CREATE INDEX `IX_Product_BrandId` ON `Product` (`BrandId`);

CREATE INDEX `IX_Product_CartId` ON `Product` (`CartId`);

CREATE INDEX `IX_Product_DiscountTypeId` ON `Product` (`DiscountTypeId`);

CREATE INDEX `IX_Product_OrderId` ON `Product` (`OrderId`);

CREATE INDEX `IX_Product_ProductTypeId` ON `Product` (`ProductTypeId`);

CREATE INDEX `IX_Product_SaleId` ON `Product` (`SaleId`);

CREATE INDEX `IX_Product_UserCreatedId` ON `Product` (`UserCreatedId`);

CREATE INDEX `IX_ProductType_UserCreatedId` ON `ProductType` (`UserCreatedId`);

CREATE INDEX `IX_ProductType_UserUpdatedId` ON `ProductType` (`UserUpdatedId`);

CREATE INDEX `IX_Sale_ClientId` ON `Sale` (`ClientId`);

CREATE INDEX `IX_Sale_CoinTypeId` ON `Sale` (`CoinTypeId`);

CREATE INDEX `IX_Sale_SellerId` ON `Sale` (`SellerId`);

CREATE INDEX `IX_Specification_ProductId` ON `Specification` (`ProductId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20221124181820_Init', '7.0.0');

COMMIT;

