using System;
using System.Collections.Generic;
using System.Text;
using TedarikYonetim.Core.Concrete;
using TedarikYonetim.Dal.Abstract;
using TedarikYonetim.Model;

namespace TedarikYonetim.Dal.Concrete
{
    public class SubCategoryRepository : EFBaseRepository<TedarikYonetimContext, SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(TedarikYonetimContext _context) : base(_context)
        {
        }
    }
}
