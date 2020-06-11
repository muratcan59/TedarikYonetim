using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TedarikYonetim.Core.Concrete;
using TedarikYonetim.Model;

namespace TedarikYonetim.Bll.Abstract
{
    public interface ISubSubCategoryService
    {
        ResultMessage<SubCategory> Add(SubCategory data);
        ResultMessage<SubCategory> Update(SubCategory data);
        ResultMessage<SubCategory> SoftDelete(int id);
        ResultMessage<SubCategory> Get(Expression<Func<SubCategory, bool>> filter);
        ResultMessage<ICollection<SubCategory>> GetAll(Expression<Func<SubCategory, bool>> filter = null);
    }
}
