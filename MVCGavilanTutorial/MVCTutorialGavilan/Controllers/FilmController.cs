using MVCTutorialGavilan.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorialGavilan.Controllers
{
    public class FilmController : Controller
    {
        private FilmRepository filmRepository;

        public FilmController()
        {
            filmRepository = new FilmRepository();
        }

        // GET: Film
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]//esta view no se muestra por separado, se muestra como renderAccion en otra view
        public ActionResult Film()
        {
            var model = filmRepository.getFilms();
            return View(model);
        }


    }
}