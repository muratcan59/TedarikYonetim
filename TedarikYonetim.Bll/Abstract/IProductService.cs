using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TedarikYonetim.Core.Concrete;
using TedarikYonetim.Model;

namespace TedarikYonetim.Bll.Abstract
{
   public interface IProductService
    {
        ResultMessage<Product> Add(Product data);
        ResultMessage<Product> Update(Product data);
        ResultMessage<Product> SoftDelete(int id);
        ResultMessage<Product> Get(Expression<Func<Product, bool>> filter);
        ResultMessage<ICollection<Product>> GetSupplierProduct(int supplierId);
        ResultMessage<ICollection<Product>> GetAll(Expression<Func<Product, bool>> filter = null);
    }
}
