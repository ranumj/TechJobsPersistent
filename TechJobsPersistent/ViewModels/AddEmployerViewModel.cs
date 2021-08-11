using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage ="Every Job must have a Name!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Every Job must have a Location!")]
        public string Location { get; set; }

    }
}
