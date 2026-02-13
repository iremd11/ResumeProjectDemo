using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeProjectDemo.Context;

namespace ResumeProjectDemo.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly ResumeContext _context;

        public StatisticsController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Mesaj istatistikleri
            ViewBag.ToplamMesaj = _context.Messages.Count();
            ViewBag.OkunmamisMesaj = _context.Messages.Count(x => !x.IsRead);
            ViewBag.OkunmusMesaj = _context.Messages.Count(x => x.IsRead);

            // Proje özeti
            ViewBag.ToplamProje = _context.Portfolios.Count();
            ViewBag.ToplamKategori = _context.Categories.Count();

            // Yetenek / Hizmet / Referans
            ViewBag.ToplamYetenek = _context.Skills.Count();
            ViewBag.ToplamHizmet = _context.Services.Count();
            ViewBag.ToplamReferans = _context.Testimonials.Count();

            // Son mesajlar (timeline için)
            ViewBag.SonMesajlar = _context.Messages
                .OrderByDescending(x => x.SendDate)
                .Take(5)
                .ToList();

            // Son projeler
            ViewBag.SonProjeler = _context.Portfolios
                .Include(p => p.Category)
                .OrderByDescending(x => x.PortfolioId)
                .Take(5)
                .ToList();

            return View();
        }
    }
}
