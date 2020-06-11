using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TedarikYonetim.Bll.Abstract;
using TedarikYonetim.Model;

namespace TedarikYonetim.Ui.Controllers
{
    public class CategoryController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category model)
        {
            model.CreateDate = DateTime.Now;
            model.IsDelete = false;

            _unitOfWork.Category.Add(model);
            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(List));

        }
        //Normalde kategori ekleme işlemi aynı, fakat burada alt kategoriyi eklemek için ayrı bir sayfa yapılması istendiği için bu şekilde yaptım.
        public IActionResult AddSubCategory()
        {
            ViewBag.Categories = _unitOfWork.Category.GetAllUpperCategory().Data;
            return View();
        }

        [HttpPost]
        public IActionResult AddSubCategory(Category model)
        {
            model.CreateDate = DateTime.Now;
            model.IsDelete = false;

            _unitOfWork.Category.Add(model);
            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(List));

        }

        public IActionResult Update(int id)
        {
            ViewBag.Categories = _unitOfWork.Category.GetAllUpperCategory().Data;
            var data = _unitOfWork.Category.Get(x => x.CategoryId == id).Data;
            return View(data);
        }

        [HttpPost]
        public IActionResult Update(Category model)
        {
            model.UpdateDate = DateTime.Now;

            var result = _unitOfWork.Category.Update(model);
            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(List));
        }

        public IActionResult List()
        {
            var list = _unitOfWork.Category.GetAll(x => x.IsDelete == false && x.UpperCategoryId == null).Data;
            return View(list);
        }

        public IActionResult SubCategoryList()
        {
            var list = _unitOfWork.Category.GetAllSubCategory().Data;
            return View(list);
        }

        public IActionResult Delete(int id)
        {
            var result=_unitOfWork.Category.SoftDelete(id);
            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(List));
        }
    }
}
