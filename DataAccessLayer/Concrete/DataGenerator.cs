using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class DataGenerator
    {
        public DataGenerator()
        {
            
        }
        public void InitializeData()
        {
            //EfAppUserDal EfProduct = new EfAppUserDal();
            //var appUser = new AppUser
            //{
            //    Name = "orçun",
            //    Surname = "Or",
            //    Gender = "E",
            //    UserName="orcnor",
            //    Password = "123456aA*",
               
            //};
            //PasswordHasher<AppUser> test = new PasswordHasher<AppUser>();
            //test.HashPassword(appUser, appUser.Password);
            //appUser.PasswordHash = test.HashPassword(appUser, appUser.Password);

            //EfProduct.Insert(appUser);

            EfProductDal efProductDal = new EfProductDal();
            var product = new Product()
            {
                Brand = "Nike",
                Color = "Yellow",
                Name = "tshirt",
                Image="123.jpeg",
                Size="s",
                PublishDate=DateTime.Now,
                Price=25,
                OnSale=true,
                Comments=new List<Comment>(),
                StockAmount=150,
                Type="tshirt"

            };
            efProductDal.Insert(product);
        }
    }
}
