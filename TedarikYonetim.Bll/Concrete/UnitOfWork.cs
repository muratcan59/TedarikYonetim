using System;
using TedarikYonetim.Bll.Abstract;
using TedarikYonetim.Core.Concrete;
using TedarikYonetim.Dal;
using TedarikYonetim.Dal.Concrete;

namespace TedarikYonetim.Bll.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        TedarikYonetimContext context;

        public UnitOfWork(TedarikYonetimContext _context)
        {
            context = _context;
        }


        ICategoryService category;
        IProductService product;
        ISupplierService supplier;
        IUserService user;
        IGroupService group;

        public ICategoryService Category => category ?? (category = new CategoryService(new CategoryRepository(context)));

        public IProductService Product => product ?? (product = new ProductService(new ProductRepository(context)));
        public ISupplierService Supplier => supplier ?? (supplier = new SupplierService(new SupplierRepository(context)));

        public IUserService User => user ?? (user = new UserService(new UserRepository(context)));

        public IGroupService Group => group ?? (group = new GroupService(new GroupRepository(context)));


        public ResultMessage<int> SaveChanges()
        {
            using (var dbTransaction = context.Database.BeginTransaction())
            {
                try
                {
                    int result = context.SaveChanges();

                    dbTransaction.Commit();
                    return new ResultMessage<int> { BasariliMi = true, Data = result, Mesaj = "İşlem başarılı." };
                }
                catch (Exception ex)
                {
                    dbTransaction.Rollback();
                    return new ResultMessage<int> { BasariliMi = false, Data = -1, Mesaj = ex.Message };

                }
            }
        }

        private bool disposedValue = false; // To detect redundant calls


        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }


                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
    }
}
