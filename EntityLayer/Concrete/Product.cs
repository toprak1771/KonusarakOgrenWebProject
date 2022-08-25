using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }
        public DateTime PublishDate { get; set; }
        public bool OnSale { get; set; }
        public int StockAmount { get; set; }

        public List<Comment> Comments { get; set; }


    }
}
