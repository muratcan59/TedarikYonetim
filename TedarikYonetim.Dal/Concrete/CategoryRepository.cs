using System;
using System.Collections.Generic;
using System.Text;
using TedarikYonetim.Core.Concrete;
using TedarikYonetim.Dal.Abstract;
using TedarikYonetim.Model;

namespace TedarikYonetim.Dal.Concrete
{
    public class CategoryRepository : EFBaseRepository<TedarikYonetimContext, Category>, ICategoryRepository
    {
        public CategoryRepository(TedarikYonetimContext _context) : base(_context)
        {
        }
    }
}
