using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TedarikYonetim.Bll.Abstract;
using TedarikYonetim.Model;

namespace TedarikYonetim.Ui.Controllers
{
    public class SupplierController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public SupplierController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Supplier model)
        {
            model.CreateDate = DateTime.Now;
            model.IsDelete = false;

            _unitOfWork.Supplier.Add(model);
            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(List));

        }

        public IActionResult Update(int id)
        {
            var data = _unitOfWork.Supplier.Get(x => x.SupplierId == id).Data;
            return View(data);
        }

        [HttpPost]
        public IActionResult Update(Supplier model)
        {
            model.UpdateDate = DateTime.Now;

            _unitOfWork.Supplier.Update(model);
            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(List));
        }

        public IActionResult List()
        {
            var list = _unitOfWork.Supplier.GetAll(x => x.IsDelete == false).Data;
            return View(list);
        }

        public IActionResult ActivePassive(int id)
        {
            _unitOfWork.Supplier.SupplierStatePassive(id);
            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(List));
        }
    }
}
