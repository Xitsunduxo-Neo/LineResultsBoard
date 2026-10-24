using Microsoft.AspNetCore.Mvc;
using LineResultsBoard.Models;

namespace LineResultsBoard.Controllers
{
    public class ProductionController : Controller
    {
        public IActionResult Index()
        {
            var vm = new LineBoardViewModel();
            string[] dayHours = { "06:00 - 07:00", "07:00 - 08:00", "08:00 - 09:00", "09:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "12:00 - 13:00", "13:00 - 14:00", "14:00 - 15:00", "15:00 - 16:00", "16:00 - 17:00", "17:00 - 18:00" };
            string[] nightHours = { "18:00 - 19:00", "19:00 - 20:00", "20:00 - 21:00", "21:00 - 22:00", "22:00 - 23:00", "23:00 - 00:00", "00:00 - 01:00", "01:00 - 02:00", "02:00 - 03:00", "03:00 - 04:00", "04:00 - 05:00", "05:00 - 06:00" };

            foreach (var h in dayHours) vm.DayShift.Add(new ProductionRecord { Hour = h, Target = h == "06:00 - 07:00" ? 35 : 70, IsDayShift = true, Line = "Line 1", Date = DateTime.Today });
            foreach (var h in nightHours) vm.NightShift.Add(new ProductionRecord { Hour = h, Target = h.StartsWith("03:00") ? 35 : 70, IsDayShift = false, Line = "Line 1", Date = DateTime.Today });

            return View(vm);
        }

        [HttpPost]
        public IActionResult Save(LineBoardViewModel model)
        {
            // Save to DB later
            return RedirectToAction("Index");
        }
    }
}