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
    
   public class CategoryService: ICategoryService
   {
        private ICategoryRepository repository;
        public CategoryService(ICategoryRepository _repository)
        {
            repository = _repository;
        }
        public ResultMessage<Category> Add(Category data)
        {
            return repository.Add(data);
        }

        public ResultMessage<Category> Update(Category data)
        {
            return repository.Update(data);
        }

        public ResultMessage<Category> SoftDelete(int id)
        {
            return repository.SoftDelete(id);
        }

        public ResultMessage<Category> Get(Expression<Func<Category, bool>> filter)
        {
            return repository.Get(filter);
        }

        public ResultMessage<ICollection<Category>> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return repository.GetAll(filter);
        }
    }
}
