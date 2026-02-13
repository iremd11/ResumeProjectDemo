using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;
using System.Linq;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponents
{
    public class _DefaultTestimonialComponentPartial : ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultTestimonialComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Testimonials.Where(x => x.IsConfirm).ToList();
            return View(values);
        }
    }
}
