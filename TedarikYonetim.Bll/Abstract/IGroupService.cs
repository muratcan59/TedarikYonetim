using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TedarikYonetim.Core.Concrete;
using TedarikYonetim.Model;

namespace TedarikYonetim.Bll.Abstract
{
    public interface IGroupService
    {
        ResultMessage<Group> Add(Group data);
        ResultMessage<Group> Update(Group data);
        ResultMessage<Group> SoftDelete(int id);
        ResultMessage<Group> Get(Expression<Func<Group, bool>> filter);
        ResultMessage<ICollection<Group>> GetAll(Expression<Func<Group, bool>> filter = null);
    }
}
