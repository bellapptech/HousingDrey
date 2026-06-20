using HousingDrey.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HousingDrey.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.TotalProperties = await _context.Properties.CountAsync();
            ViewBag.TotalReservations = await _context.Reservations.CountAsync();
            ViewBag.PendingReservations = await _context.Reservations.CountAsync(r => r.Status == "Pending");

            var latestReservations = await _context.Reservations
                .Include(r => r.Property)
                .OrderByDescending(r => r.CreatedAt)
                .Take(10)
                .ToListAsync();

            return View(latestReservations);
        }
    }
}