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
    `Name` varchar(191) CHARACTER SET utf8mb4 NULL,
    `NormalizedName` varchar(191) CHARACTER SET utf8mb4 NULL,
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
    `UserName` varchar(191) CHARACTER SET utf8mb4 NULL,
    `NormalizedUserName` varchar(191) CHARACTER SET utf8mb4 NULL,
    `Email` varchar(191) CHARACTER SET utf8mb4 NULL,
    `NormalizedEmail` varchar(191) CHARACTER SET utf8mb4 NULL,
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

CREATE TABLE `Brand` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `Name` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
    `IsActive` tinyint(1) NOT NULL,
    `InternalProperty` tinyint(1) NOT NULL,
    CONSTRAINT `PK_Brand` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `CalculationType` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `InternalProperty` tinyint(1) NOT NULL,
    CONSTRAINT `PK_CalculationType` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `DocumentType` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NULL,
    `IsActive` tinyint(1) NOT NULL,
    `InternalProperty` tinyint(1) NOT NULL,
    CONSTRAINT `PK_DocumentType` PRIMARY KEY (`Id`)
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
    `UserCreatedId` int NULL,
    `UpdatedAt` datetime(6) NULL,
    `UserUpdatedId` int NULL,
    `IsActive` tinyint(1) NOT NULL,
    `InternalProperty` tinyint(1) NOT NULL,
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
    `UserUpdatedId` int NULL,
    CONSTRAINT `PK_ContactType` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_ContactType_AspNetUsers_UserUpdatedId` FOREIGN KEY (`UserUpdatedId`) REFERENCES `AspNetUsers` (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `ProductType` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ExternalId` char(36) COLLATE ascii_general_ci NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `InternalProperty` tinyint(1) NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UserCreatedId` int NULL,
    `UpdatedAt` datetime(6) NULL,
    `UserUpdatedId` int NULL,
    `IsActive` tinyint(1) NOT NULL,
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
    `IsActive` tinyint(1) NOT NULL,
    `InternalProperty` tinyint(1) NOT NULL,
    CONSTRAINT `PK_DiscountType` PRIMARY KEY (`Id`),
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

INSERT INTO `Brand` (`Id`, `CreatedAt`, `ExternalId`, `InternalProperty`, `IsActive`, `Name`, `UpdatedAt`)
VALUES (1, TIMESTAMP '2022-11-24 13:58:45', 'd5ef7f65-bb5e-4bfa-aa84-8cce7602a855', TRUE, TRUE, 'Generic', NULL);

INSERT INTO `CalculationType` (`Id`, `ExternalId`, `InternalProperty`, `Name`)
VALUES (1, '2b288b3d-c684-4cb1-8879-d6bc7b06b077', TRUE, 'SUM'),
(2, '97d69e05-b6e8-47fb-bc20-f1010704a545', TRUE, 'PERCENT'),
(3, 'ee934047-3cdb-4796-8c13-14b7f7d67be4', TRUE, 'SUBTRACTION');

INSERT INTO `CoinType` (`Id`, `CreatedAt`, `Description`, `ExternalId`, `InternalProperty`, `IsActive`, `Label`, `Name`, `UpdatedAt`, `UserCreatedId`, `UserUpdatedId`)
VALUES (1, TIMESTAMP '2022-11-24 13:58:45', NULL, '657bf6b4-458f-4ef4-81e3-249f3f427807', TRUE, TRUE, 'R$', 'Real', NULL, NULL, NULL),
(2, TIMESTAMP '2022-11-24 13:58:45', NULL, 'd5a0ed96-4f8c-4905-bd79-85f69edb711c', TRUE, TRUE, 'US$', 'Dólar', NULL, NULL, NULL),
(3, TIMESTAMP '2022-11-24 13:58:45', NULL, 'd2bde26a-65fa-44fe-8831-cee411477354', TRUE, TRUE, '€', 'Euro', NULL, NULL, NULL);

INSERT INTO `ContactType` (`Id`, `CreatedAt`, `ExternalId`, `InternalProperty`, `IsActive`, `Name`, `UpdatedAt`, `UserUpdatedId`)
VALUES (1, TIMESTAMP '2022-11-24 13:58:45', '92e3fdbc-252b-4c6f-8b93-1ffe1a19b325', TRUE, TRUE, 'Email Pessoal', NULL, NULL),
(2, TIMESTAMP '2022-11-24 13:58:45', 'e3ba5abd-a5d1-400f-b96b-34c1f34e266a', TRUE, TRUE, 'Email Comercial', NULL, NULL),
(3, TIMESTAMP '2022-11-24 13:58:45', 'f4003785-fca0-49fc-a3d3-96b7f9a23d25', TRUE, TRUE, 'Celular Pessoal', NULL, NULL),
(4, TIMESTAMP '2022-11-24 13:58:45', 'd986e222-d87e-412c-88cc-d531565bd2d7', TRUE, TRUE, 'Celular Comercial', NULL, NULL),
(5, TIMESTAMP '2022-11-24 13:58:45', '920d7802-ba9e-4bba-bc18-10e7726ce9d5', TRUE, TRUE, 'Telefone Comercial', NULL, NULL),
(6, TIMESTAMP '2022-11-24 13:58:45', '77c8547b-b122-47a6-8ccb-f1ceea91f9b7', TRUE, TRUE, 'Telefone Residencial', NULL, NULL),
(7, TIMESTAMP '2022-11-24 13:58:45', 'bd3ecbce-1d86-4a8a-a9de-db43695d1826', TRUE, TRUE, 'WhatsApp Comercial', NULL, NULL),
(8, TIMESTAMP '2022-11-24 13:58:45', 'cc0f9749-53d7-4e38-89ee-b94cb56b698d', TRUE, TRUE, 'WhatsApp Pessoal', NULL, NULL);

INSERT INTO `DocumentType` (`Id`, `CreatedAt`, `ExternalId`, `InternalProperty`, `IsActive`, `Name`, `UpdatedAt`)
VALUES (1, TIMESTAMP '2022-11-24 13:58:45', 'e36115b7-01ff-49a1-9e93-ea891d81e1a8', TRUE, TRUE, 'RG', NULL),
(2, TIMESTAMP '2022-11-24 13:58:45', '3447b5eb-6892-48c5-9c20-4563cb511746', TRUE, TRUE, 'CPF', NULL),
(3, TIMESTAMP '2022-11-24 13:58:45', '3a7ee09d-2aad-49cc-ab7b-c4aa4363d3cb', TRUE, TRUE, 'CNPJ', NULL),
(4, TIMESTAMP '2022-11-24 13:58:45', '69690e13-3e49-4837-a14f-e8927843436b', TRUE, TRUE, 'CNH', NULL),
(5, TIMESTAMP '2022-11-24 13:58:45', '9d72a405-b338-4def-8089-7d8b29f1e490', TRUE, TRUE, 'Certidão de Nascimento', NULL),
(6, TIMESTAMP '2022-11-24 13:58:45', 'c03abeb8-c6ab-4765-9e12-a62f4e5b5875', TRUE, TRUE, 'Certidão de Casamento', NULL),
(7, TIMESTAMP '2022-11-24 13:58:45', '1f71fe14-4078-4ceb-a490-af6519e17344', TRUE, TRUE, 'Foto do usuário', NULL);

INSERT INTO `ProductType` (`Id`, `CreatedAt`, `ExternalId`, `InternalProperty`, `IsActive`, `Name`, `UpdatedAt`, `UserCreatedId`, `UserUpdatedId`)
VALUES (1, TIMESTAMP '2022-11-24 13:58:45', '315fa0f0-041a-4393-b454-92e510dc54ea', TRUE, TRUE, 'Serviço', NULL, NULL, NULL),
(2, TIMESTAMP '2022-11-24 13:58:45', '583cef19-26da-4961-a452-25e0efc67411', TRUE, TRUE, 'Produto', NULL, NULL, NULL);

INSERT INTO `DiscountType` (`Id`, `CalculationTypeId`, `CreatedAt`, `ExternalId`, `InternalProperty`, `IsActive`, `Name`, `UpdatedAt`, `Value`)
VALUES (1, 3, TIMESTAMP '2022-11-24 13:58:45', 'e41c643d-481f-44d0-a373-0912c1c00d43', TRUE, TRUE, 'Gerente', NULL, 0.0),
(2, 3, TIMESTAMP '2022-11-24 13:58:45', '6f333274-b2a8-420b-aa6c-a0694ff2ad88', TRUE, TRUE, 'Cupom', NULL, 0.0),
(3, 2, TIMESTAMP '2022-11-24 13:58:45', '5128a7a6-64e1-41da-8424-2117ab4fe630', TRUE, TRUE, 'Pgamento a vista', NULL, 0.14999999999999999);

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

CREATE INDEX `IX_Cart_ClientId` ON `Cart` (`ClientId`);

CREATE INDEX `IX_Client_UserCreatedId` ON `Client` (`UserCreatedId`);

CREATE INDEX `IX_Client_UserUpdatedId` ON `Client` (`UserUpdatedId`);

CREATE INDEX `IX_CoinType_UserCreatedId` ON `CoinType` (`UserCreatedId`);

CREATE INDEX `IX_CoinType_UserUpdatedId` ON `CoinType` (`UserUpdatedId`);

CREATE INDEX `IX_Contact_ClientId` ON `Contact` (`ClientId`);

CREATE INDEX `IX_Contact_TypeId` ON `Contact` (`TypeId`);

CREATE INDEX `IX_ContactType_UserUpdatedId` ON `ContactType` (`UserUpdatedId`);

CREATE INDEX `IX_DiscountType_CalculationTypeId` ON `DiscountType` (`CalculationTypeId`);

CREATE INDEX `IX_Document_ClientId` ON `Document` (`ClientId`);

CREATE INDEX `IX_Document_TypeId` ON `Document` (`TypeId`);

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
VALUES ('20221124165845_Init', '7.0.0');

COMMIT;

