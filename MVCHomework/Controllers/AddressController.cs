using Microsoft.AspNetCore.Mvc;
using MVCHomework.Models;

namespace MVCHomework.Controllers
{
    public class AddressController : Controller
    {
        private readonly ILogger<AddressController> _logger;

        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;
        }

        // GET: AddressController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AddressController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddressController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddressModel data)
        {
            if (ModelState.IsValid == false)
            {
                _logger.LogWarning("the user submitted an invalid address upon create");
                return View();
            }
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
