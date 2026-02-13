using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultAboutComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var about = _context.Abouts.FirstOrDefault();
            var contact = _context.Contacts.FirstOrDefault();
            var model = new { About = about, Contact = contact };
            return View(model);
        }
    }
}
