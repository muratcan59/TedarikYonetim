using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TedarikYonetim.Bll.Abstract;
using TedarikYonetim.Model;

namespace TedarikYonetim.Ui.Controllers
{
    public class GroupController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public GroupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Group model)
        {
            model.CreateDate = DateTime.Now;
            model.IsDelete = false;

            _unitOfWork.Group.Add(model);
            _unitOfWork.SaveChanges();
            return View();

        }

        public IActionResult Update(int id)
        {
            var data = _unitOfWork.Group.Get(x => x.GroupId == id).Data;
            return View(data);
        }

        [HttpPost]
        public IActionResult Update(Group model)
        {
            model.UpdateDate = DateTime.Now;

            _unitOfWork.Group.Update(model);
            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(List));
        }

        public IActionResult List()
        {
            var list = _unitOfWork.Group.GetAll(x => x.IsDelete == false).Data;
            return View(list);
        }

        public IActionResult Delete(int id)
        {
            _unitOfWork.Group.SoftDelete(id);
            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(List));
        }
    }
}
