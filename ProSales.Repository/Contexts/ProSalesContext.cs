using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProSales.Domain;
using ProSales.Domain.Global;
using ProSales.Domain.Identity;

namespace ProSales.Repository.Contexts
{
    public class ProSalesContext : IdentityDbContext<User, Role, int,
    IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public ProSalesContext(DbContextOptions<ProSalesContext> options) : base(options)
        {

        }

        public DbSet<Address> Address { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<ContactType> ContactType { get; set; }
        public DbSet<DiscountType> DiscountType { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<DocumentType> DocumentType { get; set; }
        public DbSet<HistoryProductSale> HistoryProductSale { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Specification> Specification { get; set; }
        public DbSet<CalculationType> CalculationType { get; set; }
        public DbSet<CoinType> CoinType { get; set; }
        public DbSet<ProductCart> ProductCart { get; set; }
        public DbSet<ProductOrder> ProductOrder { get; set; }
        public DbSet<ProductSale> ProductSale { get; set; }
        public DbSet<FormTeste> FormTeste { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<UserRole>(ur =>
            {
                ur.HasKey(k => new { k.UserId, k.RoleId });

                ur
                .HasOne(x => x.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(fk => fk.RoleId)
                .IsRequired();

                ur
                .HasOne(x => x.User)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(fk => fk.UserId)
                .IsRequired();
            }
            );

            modelBuilder.Entity<ProductCart>(ur =>
            {
                ur.HasKey(k => new { k.ProductId, k.CartId });

                ur
                .HasOne(x => x.Product)
                .WithMany(r => r.ProductsCart)
                .HasForeignKey(fk => fk.ProductId)
                .IsRequired();

                ur
                .HasOne(x => x.Cart)
                .WithMany(r => r.ProductsCart)
                .HasForeignKey(fk => fk.CartId)
                .IsRequired();
            }
            );

            modelBuilder.Entity<ProductOrder>(ur =>
            {
                ur.HasKey(k => new { k.ProductId, k.OrderId });

                ur
                .HasOne(x => x.Product)
                .WithMany(r => r.ProductsOrder)
                .HasForeignKey(fk => fk.ProductId)
                .IsRequired();

                ur
                .HasOne(x => x.Order)
                .WithMany(r => r.ProductsOrder)
                .HasForeignKey(fk => fk.OrderId)
                .IsRequired();
            }
            );

            modelBuilder.Entity<ProductSale>(ur =>
            {
                ur.HasKey(k => new { k.ProductId, k.SaleId });

                ur
                .HasOne(x => x.Product)
                .WithMany(r => r.ProductsSale)
                .HasForeignKey(fk => fk.ProductId)
                .IsRequired();

                ur
                .HasOne(x => x.Sale)
                .WithMany(r => r.ProductsSale)
                .HasForeignKey(fk => fk.SaleId)
                .IsRequired();
            }
            );

            modelBuilder.Entity<ContactType>()
            .HasData(
                new ContactType { Id = 1, ExternalId = Guid.NewGuid(), Name = "Email Pessoal", InternalProperty = true }
                , new ContactType { Id = 2, ExternalId = Guid.NewGuid(), Name = "Email Comercial", InternalProperty = true }
                , new ContactType { Id = 3, ExternalId = Guid.NewGuid(), Name = "Celular Pessoal", InternalProperty = true }
                , new ContactType { Id = 4, ExternalId = Guid.NewGuid(), Name = "Celular Comercial", InternalProperty = true }
                , new ContactType { Id = 5, ExternalId = Guid.NewGuid(), Name = "Telefone Comercial", InternalProperty = true }
                , new ContactType { Id = 6, ExternalId = Guid.NewGuid(), Name = "Telefone Residencial", InternalProperty = true }
                , new ContactType { Id = 7, ExternalId = Guid.NewGuid(), Name = "WhatsApp Comercial", InternalProperty = true }
                , new ContactType { Id = 8, ExternalId = Guid.NewGuid(), Name = "WhatsApp Pessoal", InternalProperty = true }
            );

            modelBuilder.Entity<DocumentType>()
            .HasData(
                new DocumentType { Id = 1, ExternalId = Guid.NewGuid(), Name = "RG", InternalProperty = true }
                , new DocumentType { Id = 2, ExternalId = Guid.NewGuid(), Name = "CPF", InternalProperty = true }
                , new DocumentType { Id = 3, ExternalId = Guid.NewGuid(), Name = "CNPJ", InternalProperty = true }
                , new DocumentType { Id = 4, ExternalId = Guid.NewGuid(), Name = "CNH", InternalProperty = true }
                , new DocumentType { Id = 5, ExternalId = Guid.NewGuid(), Name = "Certidão de Nascimento", InternalProperty = true }
                , new DocumentType { Id = 6, ExternalId = Guid.NewGuid(), Name = "Certidão de Casamento", InternalProperty = true }
                , new DocumentType { Id = 7, ExternalId = Guid.NewGuid(), Name = "Foto do usuário", InternalProperty = true }
            );

            modelBuilder.Entity<CoinType>()
            .HasData(
                new CoinType { Id = 1, ExternalId = Guid.NewGuid(), Name = "Real", Label = "R$", InternalProperty = true }
                , new CoinType { Id = 2, ExternalId = Guid.NewGuid(), Name = "Dólar", Label = "US$", InternalProperty = true }
                , new CoinType { Id = 3, ExternalId = Guid.NewGuid(), Name = "Euro", Label = "€", InternalProperty = true }

            );

            modelBuilder.Entity<Brand>()
            .HasData(
                new Brand { Id = 1, ExternalId = Guid.NewGuid(), Name = "Generic", IsActive = true, InternalProperty = true }
            );

            modelBuilder.Entity<DiscountType>()
            .HasData(
                new DiscountType { Id = 1, ExternalId = Guid.NewGuid(), Name = "Gerente", CalculationTypeId = 3 , InternalProperty = true}
                , new DiscountType { Id = 2, ExternalId = Guid.NewGuid(), Name = "Cupom", CalculationTypeId = 3 , InternalProperty = true}
                , new DiscountType { Id = 3, ExternalId = Guid.NewGuid(), Name = "Pgamento a vista", Value = 0.15, CalculationTypeId = 2 , InternalProperty = true}

            );

            modelBuilder.Entity<ProductType>()
            .HasData(
                new ProductType { Id = 1, ExternalId = Guid.NewGuid(), Name = "Serviço", InternalProperty = true }
                , new ProductType { Id = 2, ExternalId = Guid.NewGuid(), Name = "Produto", InternalProperty = true }
            );

            modelBuilder.Entity<CalculationType>()
            .HasData(
                new CalculationType { Id = 1, ExternalId = Guid.NewGuid(), Name = "SUM", InternalProperty = true }
                , new CalculationType { Id = 2, ExternalId = Guid.NewGuid(), Name = "PERCENT", InternalProperty = true }
                , new CalculationType { Id = 3, ExternalId = Guid.NewGuid(), Name = "SUBTRACTION", InternalProperty = true }
            );

        }
    }


}