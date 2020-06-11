using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TedarikYonetim.Core.Concrete;
using TedarikYonetim.Model;

namespace TedarikYonetim.Bll.Abstract
{
   public interface ICategoryService
    {
        ResultMessage<Category> Add(Category data);
        ResultMessage<Category> Update(Category data);
        ResultMessage<Category> SoftDelete(int id);
        ResultMessage<Category> Get(Expression<Func<Category, bool>> filter);
        ResultMessage<ICollection<Category>> GetAll(Expression<Func<Category, bool>> filter = null);
    }
}
