using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTutorialGavilan.Models
{
    public class Film
    {
        [Key]
        public int IdFilm { get; set; }
        public string Title { get; set; }
        public bool OnTheBill { get; set; }
        public string Gender { get; set; }
    }
}