using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Product t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Product t)
        {
            throw new NotImplementedException();
        }

        public Product TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Product t)
        {
            throw new NotImplementedException();
        }
    }
}
