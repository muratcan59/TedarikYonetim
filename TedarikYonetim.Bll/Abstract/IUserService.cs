using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TedarikYonetim.Core.Concrete;
using TedarikYonetim.Model;

namespace TedarikYonetim.Bll.Abstract
{
   public interface IUserService
    {
        ResultMessage<User> Add(User data);
        ResultMessage<User> Update(User data);
        ResultMessage<User> SoftDelete(int id);
        ResultMessage<User> Get(Expression<Func<User, bool>> filter);
        ResultMessage<ICollection<User>> GetAll(Expression<Func<User, bool>> filter = null);
        ResultMessage<User> Login(string email, string sifre);

    }
}
