namespace Proyecto_Multiplataforma.Controllers
{
    public class HomeController: Controller
    {
         public IActionResult RegistroMascota()
        {
            ViewBag.Tipos = _context.Tipos.ToList();//lo nuevo en este proyecto

            return View();
        }

        [HttpPost]
        public IActionResult RegistroMascota(Mascota m)
        {
            if (ModelState.IsValid){
                _context.Add(m);
                _context.SaveChanges();

                return RedirectToAction("index");
            }
            ViewBag.Tipos = _context.Tipos.ToList();//lo nuevo

            return View();
        }
    }
}