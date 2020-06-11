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
    public class UserService : IUserService
    {
        private IUserRepository repository;
        public UserService(IUserRepository _repository)
        {
            repository = _repository;
        }
        public ResultMessage<User> Add(User data)
        {
            return repository.Add(data);
        }

        public ResultMessage<User> Update(User data)
        {
            return repository.Update(data);
        }

        public ResultMessage<User> SoftDelete(int id)
        {
            return repository.SoftDelete(id);
        }

        public ResultMessage<User> Get(Expression<Func<User, bool>> filter)
        {
            return repository.Get(filter);
        }

        public ResultMessage<ICollection<User>> GetAll(Expression<Func<User, bool>> filter = null)
        {
            return repository.GetAll(filter);
        }

        public ResultMessage<User> Login(string email, string sifre)
        {
            return repository.Get(x => x.Username == email && x.Password == sifre);
        }
    }
}
