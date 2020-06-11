using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TedarikYonetim.Bll.Abstract;
using TedarikYonetim.Model;
using TedarikYonetim.Ui.Models;

namespace TedarikYonetim.Ui.Controllers
{
    public class UserController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor accessor;

        public UserController(IUnitOfWork unitOfWork, IHttpContextAccessor _accessor)
        {
            _unitOfWork = unitOfWork;
            accessor = _accessor;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            var user = _unitOfWork.User.Login(model.Username, model.Password);
            if (user.Data != null)
            {
                accessor.HttpContext.Session.SetObject<User>("lgnUser", user.Data);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            _unitOfWork.User.Add(new User { NameSurname = model.NameSurname, IsDelete = false, CreateDate = DateTime.Now, Password = model.Password, Username = model.Username }) ;
            var sonuc = _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(Login));
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User model)
        {
            model.CreateDate = DateTime.Now;
            model.IsDelete = false;

            _unitOfWork.User.Add(model);
            _unitOfWork.SaveChanges();
            return View();

        }

        public IActionResult Update(int id)
        {
            var data = _unitOfWork.User.Get(x => x.UserId == id).Data;
            return View(data);
        }

        [HttpPost]
        public IActionResult Update(User model)
        {
            model.UpdateDate = DateTime.Now;

            _unitOfWork.User.Update(model);
            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(List));
        }

        public IActionResult List()
        {
            var list = _unitOfWork.User.GetAll(x => x.IsDelete == false);
            return View(list);
        }

        public IActionResult Delete(int id)
        {
            _unitOfWork.User.SoftDelete(id);
            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(List));
        }
    }
}
