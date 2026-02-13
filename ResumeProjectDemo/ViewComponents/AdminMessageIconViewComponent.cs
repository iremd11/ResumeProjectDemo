using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;
using System.Linq;

namespace ResumeProjectDemo.ViewComponents
{
    public class AdminMessageIconViewComponent : ViewComponent
    {
        private readonly ResumeContext _context;

        public AdminMessageIconViewComponent(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            
            var unreadCount = _context.Messages
                .Where(x => x.IsRead == false)
                .Count();

           
            ViewBag.unreadCount = unreadCount;
            return View();
        }
    }
}