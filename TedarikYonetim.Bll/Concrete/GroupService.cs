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
    public class GroupService : IGroupService
    {
        private IGroupRepository repository;
        public GroupService(IGroupRepository _repository)
        {
            repository = _repository;
        }
        public ResultMessage<Group> Add(Group data)
        {
            return repository.Add(data);
        }

        public ResultMessage<Group> Update(Group data)
        {
            return repository.Update(data);
        }

        public ResultMessage<Group> SoftDelete(int id)
        {
            return repository.SoftDelete(id);
        }

        public ResultMessage<Group> Get(Expression<Func<Group, bool>> filter)
        {
            return repository.Get(filter);
        }

        public ResultMessage<ICollection<Group>> GetAll(Expression<Func<Group, bool>> filter = null)
        {
            return repository.GetAll(filter);
        }
    }
}
