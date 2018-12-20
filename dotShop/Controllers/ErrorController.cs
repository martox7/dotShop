using Microsoft.AspNetCore.Mvc;

namespace dotShop.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Error() => View();
    }
}