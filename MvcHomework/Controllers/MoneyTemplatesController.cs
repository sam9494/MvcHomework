using System.Web.Mvc;
using MvcHomework.Models;

namespace MvcHomework.Controllers
{
    public class MoneyTemplatesController : Controller
    {
        // GET: MoneyTemplate
        public ActionResult Index()
        {
            return View(DataGenerator.GenetareDataList());
        }
    }
}