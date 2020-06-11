using System;
using System.Collections.Generic;
using System.Text;
using TedarikYonetim.Core.Concrete;
using TedarikYonetim.Dal.Abstract;
using TedarikYonetim.Model;

namespace TedarikYonetim.Dal.Concrete
{
    public class GroupRepository : EFBaseRepository<TedarikYonetimContext, Group>, IGroupRepository
    {
        public GroupRepository(TedarikYonetimContext _context) : base(_context)
        {

        }
    }
}
