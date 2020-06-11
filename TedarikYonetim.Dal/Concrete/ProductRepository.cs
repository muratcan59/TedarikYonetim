using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TedarikYonetim.Core.Concrete;
using TedarikYonetim.Dal;
using TedarikYonetim.Dal.Abstract;
using TedarikYonetim.Model;

namespace TedarikYonetim.Dal.Concrete
{
    public class ProductRepository : EFBaseRepository<TedarikYonetimContext, Product>, IProductRepository
    {
        public ProductRepository(TedarikYonetimContext _context) : base(_context)
        {
        }
    }
}
