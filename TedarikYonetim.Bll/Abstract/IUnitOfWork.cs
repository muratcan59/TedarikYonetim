using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using TedarikYonetim.Core.Concrete;

namespace TedarikYonetim.Bll.Abstract
{
    public interface IUnitOfWork : IDisposable
    {

        ICategoryService Category { get; }
        IProductService Product { get; }
        IUserService User { get; }
        ISupplierService Supplier { get; }
        IGroupService Group { get; }

        ResultMessage<int> SaveChanges();
    }
}
