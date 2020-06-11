using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TedarikYonetim.Model;
using TedarikYonetim.Ui;

namespace TedarikYonetim.UI.ViewComponents
{
    [ViewComponent]
    public class GetLoginNameViewComponent : ViewComponent
    {
        IHttpContextAccessor acc;

        public GetLoginNameViewComponent(IHttpContextAccessor _acc)
        {
            acc = _acc;
        }
        public IViewComponentResult Invoke()
        {
            var user = acc.HttpContext.Session.GetObject<User>("lgnUser");
            return View(user);
        }
    }
}
