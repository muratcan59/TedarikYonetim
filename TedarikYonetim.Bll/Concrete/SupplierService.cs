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
    public class SupplierService : ISupplierService
    {
        private ISupplierRepository repository;
        public SupplierService(ISupplierRepository _repository)
        {
            repository = _repository;
        }
        public ResultMessage<Supplier> Add(Supplier data)
        {
            return repository.Add(data);
        }

        public ResultMessage<Supplier> Update(Supplier data)
        {
            return repository.Update(data);
        }

        public ResultMessage<Supplier> SoftDelete(int id)
        {
            return repository.SoftDelete(id);
        }

        public ResultMessage<Supplier> SupplierStatePassive(int id)
        {
            return repository.ActiveOrPassive(id);
        }

        public ResultMessage<Supplier> Get(Expression<Func<Supplier, bool>> filter)
        {
            return repository.Get(filter);
        }

        public ResultMessage<ICollection<Supplier>> GetAll(Expression<Func<Supplier, bool>> filter = null)
        {
            return repository.GetAll(filter);
        }
    }
}
