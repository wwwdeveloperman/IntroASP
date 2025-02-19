﻿using System.ComponentModel.DataAnnotations;

namespace IntroASP.Models.ViewModels
{
    public class BeerViewModel
    {
        //
        [Required]
        [Display(Name = "Nombre")]          // using System.Comp...DataAnnotations
        public string Name { get; set; }

        //
        [Required]
        [Display(Name = "Marca")]
        public int BrandId { get; set; }    


    }
}
