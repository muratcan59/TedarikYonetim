using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TedarikYonetim.Bll.Abstract;
using TedarikYonetim.Model;

namespace TedarikYonetim.Ui.Controllers
{
    public class ProductController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product model)
        {
            model.CreateDate = DateTime.Now;
            model.IsDelete = false;

            _unitOfWork.Product.Add(model);
            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(List));

        }

        public IActionResult Update(int id)
        {
            var data = _unitOfWork.Product.Get(x => x.ProductId == id).Data;
            return View(data);
        }

        [HttpPost]
        public IActionResult Update(Product model)
        {
            model.UpdateDate = DateTime.Now;

            _unitOfWork.Product.Update(model);
            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(List));
        }

        public IActionResult GetProductSupplier(int id)
        {
            var data = _unitOfWork.Product.GetSupplierProduct(id).Data;
            return View(data);
        }

        public IActionResult List()
        {
            var list = _unitOfWork.Product.GetAll(x => x.IsDelete == false).Data;
            return View(list);
        }

        public IActionResult Delete(int id)
        {
            _unitOfWork.Product.SoftDelete(id);
            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(List));
        }
    }
}
