using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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
        public DbSet<TypeCoin> TypeCoin { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserRole>(ur =>
            {
                ur.HasKey(k => new {k.UserId, k.RoleId});

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

            modelBuilder.Entity<ContactType>()
            .HasData(
                new ContactType { Id = 1, ExternalId = Guid.NewGuid(), Name = "Email Pessoal" }
                , new ContactType { Id = 2, ExternalId = Guid.NewGuid(), Name = "Email Comercial" }
                , new ContactType { Id = 3, ExternalId = Guid.NewGuid(), Name = "Celular Pessoal" }
                , new ContactType { Id = 4, ExternalId = Guid.NewGuid(), Name = "Celular Comercial" }
                , new ContactType { Id = 5, ExternalId = Guid.NewGuid(), Name = "Telefone Comercial" }
                , new ContactType { Id = 6, ExternalId = Guid.NewGuid(), Name = "Telefone Residencial" }
                , new ContactType { Id = 7, ExternalId = Guid.NewGuid(), Name = "WhatsApp Comercial" }
                , new ContactType { Id = 8, ExternalId = Guid.NewGuid(), Name = "WhatsApp Pessoal" }
            );

            modelBuilder.Entity<DocumentType>()
            .HasData(
                new DocumentType { Id = 1, ExternalId = Guid.NewGuid(), Name = "RG" }
                , new DocumentType { Id = 2, ExternalId = Guid.NewGuid(), Name = "CPF" }
                , new DocumentType { Id = 3, ExternalId = Guid.NewGuid(), Name = "CNPJ" }
                , new DocumentType { Id = 4, ExternalId = Guid.NewGuid(), Name = "CNH" }
                , new DocumentType { Id = 5, ExternalId = Guid.NewGuid(), Name = "Certidão de Nascimento" }
                , new DocumentType { Id = 6, ExternalId = Guid.NewGuid(), Name = "Certidão de Casamento" }
                , new DocumentType { Id = 7, ExternalId = Guid.NewGuid(), Name = "Foto do usuário" }
            );

            modelBuilder.Entity<TypeCoin>()
            .HasData(
                new TypeCoin { Id = 1, ExternalId = Guid.NewGuid(), Name = "Real", Label = "R$" }
                , new TypeCoin { Id = 2, ExternalId = Guid.NewGuid(), Name = "Dólar" , Label = "US$"}
                , new TypeCoin { Id = 3, ExternalId = Guid.NewGuid(), Name = "Euro" , Label = "€"}
         
            );

            modelBuilder.Entity<Brand>()
            .HasData(
                new Brand { Id = 1, ExternalId = Guid.NewGuid(), Name = "Generic", IsActive = true }
            );

            modelBuilder.Entity<DiscountType>()
            .HasData(
                new DiscountType { Id = 1, ExternalId = Guid.NewGuid(), Name = "Gerente", CalculationTypeId = 3}
                , new DiscountType { Id = 2, ExternalId = Guid.NewGuid(), Name = "Cupom", CalculationTypeId = 3 }
                , new DiscountType { Id = 3, ExternalId = Guid.NewGuid(), Name = "Pgamento a vista", Value = 0.15 ,CalculationTypeId = 2}
         
            );

            modelBuilder.Entity<ProductType>()
            .HasData(
                new ProductType { Id = 1, ExternalId = Guid.NewGuid(), TypeName = "Serviço", InternalProperty = true}
                , new ProductType { Id = 2, ExternalId = Guid.NewGuid(), TypeName = "Produto", InternalProperty = true }
            );

            modelBuilder.Entity<CalculationType>()
            .HasData(
                new CalculationType { Id = 1, ExternalId = Guid.NewGuid(), Name = "SUM", InternalProperty = true}
                , new CalculationType { Id = 2, ExternalId = Guid.NewGuid(), Name = "PERCENT", InternalProperty = true }
                ,new CalculationType { Id = 3, ExternalId = Guid.NewGuid(), Name = "SUBTRACTION", InternalProperty = true}
            );

        }
    }


}