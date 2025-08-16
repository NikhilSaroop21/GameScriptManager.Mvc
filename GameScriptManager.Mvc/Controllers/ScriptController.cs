using GameScriptManager.Mvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameScriptManager.Mvc.Controllers
{
    public class ScriptController : Controller
    {
        private readonly IScriptService _svc;
        public ScriptController(IScriptService svc) => _svc = svc;

        // Full Story
        public IActionResult Index()
        {
            var items = _svc.GetSortedScript();
            return View(items);
        }

        // Line-by-line
        public IActionResult Line(int index = 0)
        {
            var count = _svc.Count;
            if (index < 0) index = 0;
            if (index >= count) index = count - 1;

            var node = _svc.GetLine(index);
            if (node == null) return RedirectToAction(nameof(Index));

            ViewBag.Index = index;
            ViewBag.Count = count;
            return View(node);
        }
    }
}
