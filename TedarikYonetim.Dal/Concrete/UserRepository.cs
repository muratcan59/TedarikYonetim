using System;
using System.Collections.Generic;
using System.Text;
using TedarikYonetim.Core.Concrete;
using TedarikYonetim.Dal.Abstract;
using TedarikYonetim.Model;

namespace TedarikYonetim.Dal.Concrete
{
    public class UserRepository : EFBaseRepository<TedarikYonetimContext,User>, IUserRepository
    {
        public UserRepository(TedarikYonetimContext _context): base(_context)
        {

        }
    }
}
