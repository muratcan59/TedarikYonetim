using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TedarikYonetim.Bll.Abstract;
using TedarikYonetim.Core.Concrete;
using TedarikYonetim.Dal.Abstract;
using TedarikYonetim.Model;

namespace TedarikYonetim.Bll.Concrete
{
   public class ProductService: IProductService
   {
       private IProductRepository repository;
        public ProductService(IProductRepository _repository)
        {
            repository = _repository;
        }
        public ResultMessage<Product> Add(Product data)
        {
            return repository.Add(data);
        }

        public ResultMessage<Product> Update(Product data)
        {
            return repository.Update(data);
        }

        public ResultMessage<Product> SoftDelete(int id)
        {
            return repository.SoftDelete(id);
        }

        public ResultMessage<Product> Get(Expression<Func<Product, bool>> filter)
        {
            return repository.Get(filter);
        }

        public ResultMessage<ICollection<Product>> GetSupplierProduct(int supplierId)
        {
            return repository.GetAll(x => x.SupplierId == supplierId);
        }

        public ResultMessage<ICollection<Product>> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return repository.GetAll(filter);
        }
    }
}
