using System;
using System.Collections.Generic;
using System.Text;
using TedarikYonetim.Core.Abstract;
using TedarikYonetim.Core.Concrete;
using TedarikYonetim.Model;

namespace TedarikYonetim.Dal.Abstract
{
    public interface ISupplierRepository : IRepository<Supplier>
    {
        ResultMessage<Supplier> ActiveOrPassive(int id);
    }
}
