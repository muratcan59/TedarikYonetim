using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TedarikYonetim.Core.Concrete;
using TedarikYonetim.Model;

namespace TedarikYonetim.Bll.Abstract
{
    public interface ISupplierService
    {
        ResultMessage<Supplier> Add(Supplier data);
        ResultMessage<Supplier> Update(Supplier data);
        ResultMessage<Supplier> SoftDelete(int id);
        ResultMessage<Supplier> Get(Expression<Func<Supplier, bool>> filter);
        ResultMessage<Supplier> SupplierStatePassive(int id);
        ResultMessage<ICollection<Supplier>> GetAll(Expression<Func<Supplier, bool>> filter = null);
    }
}
