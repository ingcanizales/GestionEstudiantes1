using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EstudiantesCore.Dtos;
using EstudiantesCore.Entidades;

namespace GestionEstudiantes1.Pages
{
    public class EstudiantesModel : PageModel
    {
        public void OnGet()
        {
        }

        [HttpPost]
        public IActionResult OnPostCrearEstudiante(EstudianteDTO estudiante)
        {

            try
            {
                //_matricula.MatricularEstudiante();
                return StatusCode(200, "Todo quedo bien");
            }

            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }
    }
}