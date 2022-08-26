using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccessLayer.Concrete
{
    public class DataGenerator
    {
        

        public DataGenerator()
        {
            
        }
        public async void InitializeData()
        {
           
            Context c = new Context();
            if (c.Products.Count() == 0) 
            {
                //EfProductDal efProductDal = new EfProductDal();
                c.Products.AddRange
                (
                    new Product()
                    {
                        Brand = "Nike",
                        Color = "Yellow",
                        Name = "tshirt",
                        Image = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/dce293e5-71cb-4c2e-b67f-f68ea0602705/sportswear-standard-issue-ti%C5%9F%C3%B6rt%C3%BC-N234RW.png",
                        Size = "s",
                        PublishDate = DateTime.Now,
                        Price = 25,
                        OnSale = true,
                        Comments = new List<Comment>(),
                        StockAmount = 150,
                        Type = "tshirt"

                    },
                    new Product()
                    {
                        Brand = "Nike",
                        Color = "Yellow",
                        Name = "tshirt",
                        Image = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/dce293e5-71cb-4c2e-b67f-f68ea0602705/sportswear-standard-issue-ti%C5%9F%C3%B6rt%C3%BC-N234RW.png",
                        Size = "s",
                        PublishDate = DateTime.Now,
                        Price = 25,
                        OnSale = true,
                        Comments = new List<Comment>(),
                        StockAmount = 150,
                        Type = "tshirt"

                    },
                    new Product()
                    {
                        Brand = "Nike",
                        Color = "Yellow",
                        Name = "tshirt",
                        Image = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/dce293e5-71cb-4c2e-b67f-f68ea0602705/sportswear-standard-issue-ti%C5%9F%C3%B6rt%C3%BC-N234RW.png",
                        Size = "s",
                        PublishDate = DateTime.Now,
                        Price = 25,
                        OnSale = true,
                        Comments = new List<Comment>(),
                        StockAmount = 150,
                        Type = "tshirt"

                    }             
                
                );
                

                //var product = new Product()
                //{
                //    Brand = "Nike",
                //    Color = "Yellow",
                //    Name = "tshirt",
                //    Image = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/dce293e5-71cb-4c2e-b67f-f68ea0602705/sportswear-standard-issue-ti%C5%9F%C3%B6rt%C3%BC-N234RW.png",
                //    Size = "s",
                //    PublishDate = DateTime.Now,
                //    Price = 25,
                //    OnSale = true,
                //    Comments = new List<Comment>(),
                //    StockAmount = 150,
                //    Type = "tshirt"

                //};
                //var product2 = new Product()
                //{
                //    Brand = "Nike",
                //    Color = "Yellow",
                //    Name = "tshirt",
                //    Image = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/dce293e5-71cb-4c2e-b67f-f68ea0602705/sportswear-standard-issue-ti%C5%9F%C3%B6rt%C3%BC-N234RW.png",
                //    Size = "s",
                //    PublishDate = DateTime.Now,
                //    Price = 25,
                //    OnSale = true,
                //    Comments = new List<Comment>(),
                //    StockAmount = 150,
                //    Type = "tshirt"

                //};
                //var product3 = new Product()
                //{
                //    Brand = "Nike",
                //    Color = "Yellow",
                //    Name = "tshirt",
                //    Image = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/dce293e5-71cb-4c2e-b67f-f68ea0602705/sportswear-standard-issue-ti%C5%9F%C3%B6rt%C3%BC-N234RW.png",
                //    Size = "s",
                //    PublishDate = DateTime.Now,
                //    Price = 25,
                //    OnSale = true,
                //    Comments = new List<Comment>(),
                //    StockAmount = 150,
                //    Type = "tshirt"

                //};               
                //efProductDal.Insert(product);
                //efProductDal.Insert(product2);
                //efProductDal.Insert(product3);
            }
            await c.SaveChangesAsync();

            

        }
    }
}
