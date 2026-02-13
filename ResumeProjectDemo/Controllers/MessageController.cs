using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;

namespace ResumeProjectDemo.Controllers
{
    public class MessageController : Controller
    {
        private readonly ResumeContext _context;
        public MessageController(ResumeContext context)
        {
            _context = context;
        }
        public IActionResult MessageList()
        {
            ViewBag.UnreadCount = _context.Messages.Count(x => !x.IsRead);
            var values = _context.Messages.ToList();
            return View(values);
        }
    }
}
