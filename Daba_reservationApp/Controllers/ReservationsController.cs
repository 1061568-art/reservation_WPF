using Daba_reservationApp.Data;
using Daba_reservationApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Daba_reservationApp.Controllers
{
    public class ReservationsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ReservationsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allReservations = _context.Reservations.ToList();
            return View(allReservations);
        }

        public IActionResult Create() //´Zeigt View an
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Reservations reservation)
        {
            //save Reservation
            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var reservation = _context.Reservations.Find(id);
            return View(reservation);
        }
        [HttpPost]
        public IActionResult Edit(Reservations reservations)
        {
            _context.Reservations.Update(reservations);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var reservation = _context.Reservations.Find(id);
            _context.Reservations.Remove(reservation);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }

}
