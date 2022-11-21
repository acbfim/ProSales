# ProSales
Version of plattaform PRO, for sales and sales manangment

# Start server mariadb homebew
brew services start MariaDB

## Manual do publish NET CORE
->Publish
dotnet publish

->ef core migration dentro do repositoty

dotnet ef --startup-project ../ProSales.API migrations add InitIdentity
dotnet ef --startup-project ../ProSales.API database update    