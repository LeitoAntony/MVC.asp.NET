using MVCTutorialGavilan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorialGavilan.Repositories
{
    public class FilmRepository
    {
        public List<Film> getFilms()
        {
            return new List<Film>()
            {
                new Film()
                {
                    Title = "Lo que el viento se llevo.",
                    Gender = "Romantico.",
                    OnTheBill = true

                },
                new Film()
                {
                Title = "Misión imposible.",
                    Gender = "Acción.",
                    OnTheBill = true
                },
                new Film()
                {
                Title = "DeadPoll.",
                    Gender = "Acción.",
                    OnTheBill = false
                }
            };
        
        }

    }
}