using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ETradeSite.Entities.DbEntities;

namespace ETradeSite.DataAccess.EntityFramework
{
    public class MyInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            EUser admin = new EUser()
            {
                Name = "Sinan",
                Surname = "Tok",
                Email = "snntok@gmail.com",
                ActiveGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = true,
                Gender = "Erkek",
                Birthday = DateTime.Now.AddYears(-22),
                Username = "sinantok",
                Password = "123",
                ProfileImageFileName = "user.jpg",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now.AddMinutes(5),
                ModifiedUser = "sinantok"
            };

            EUser standartUser = new EUser()
            {
                Name = "Ada",
                Surname = "Adale",
                Email = "ada@gmail.com",
                ActiveGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = false,
                Gender = "Kadın",
                Birthday = DateTime.Now.AddYears(-22),
                Username = "ada",
                Password = "123",
                ProfileImageFileName = "user.jpg",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now.AddMinutes(5),
                ModifiedUser = "sinantok"
            };

            context.EUsers.Add(admin);
            context.EUsers.Add(standartUser);

            context.SaveChanges();

            ECategories eCategories1 = new ECategories()
            {
                Title = "Cüzdan",
                Description = "El Yapımı Cüzdan",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                ModifiedUser = "sinantok"
            };

            ECategories eCategories2 = new ECategories()
            {
                Title = "Kartlık",
                Description = "El Yapımı kartlık",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                ModifiedUser = "sinantok"
            };

            context.ECategories.Add(eCategories1); context.ECategories.Add(eCategories2);
            context.SaveChanges();

            EProducts eProducts1 = new EProducts()
            {
                Name = "Legos Cüzdan",
                Description = "Minimal tasarımı ile el yapımı cüzdan",
                Price = 1200,
                Stock = 500,
                IsApproved = true,
                Category = eCategories1,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                IsFront = true,
                ModifiedUser = "sinan",
                ImageFileName = "legos.jpeg"
            };

            EProducts eProducts2 = new EProducts()
            {
                Name = "Legos Kartlık",
                Description = "Minimal tasarımı ile el yapımı cüzdan",
                Price = 1200,
                Stock = 500,
                IsApproved = true,
                Category = eCategories1,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                IsFront = true,
                ModifiedUser = "sinan",
                ImageFileName = "legos.jpeg"
            };

            context.EProducts.Add(eProducts1); context.EProducts.Add(eProducts2);
            context.SaveChanges();

            EOrders eOrders = new EOrders()
            {
                Description = "First Order",
                IsApproved = true,
                OrderDate = DateTime.Now,
                TotalMoney = 2400,
                UserId = "1",
            };

            EOrdersDetail eOrdersDetail = new EOrdersDetail()
            {
                Order = eOrders,
                Products = eProducts1
            };

            EOrdersDetail eOrdersDetail2 = new EOrdersDetail()
            {
                Order = eOrders,
                Products = eProducts2
            };

            context.EOrders.Add(eOrders);
            context.SaveChanges();
            context.EOrdersDetail.Add(eOrdersDetail);
            context.EOrdersDetail.Add(eOrdersDetail2);
            context.SaveChanges();
        }
    }
}
