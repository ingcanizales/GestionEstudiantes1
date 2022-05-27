using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EstudiantesCore.Dtos;
using EstudiantesCore.Entidades;
using EstudiantesCore.Interactores;

namespace GestionEstudiantes1.Pages
{
    public class EstudiantesModel : PageModel
    {
        private readonly IMatricula _matricula;
        public void OnGet()
        {
        }

        public EstudiantesModel(IMatricula matricula)
        {
            _matricula = matricula;
        }

       [HttpPost]
        public IActionResult OnPostCrearEstudiante(Estudiantes estudiante)
        {

            try
            {
                bool modeloValido = TryValidateModel(estudiante);

                if (modeloValido)
                {
                    _matricula.MatricularEstudiante(estudiante);
                }
                else
                {
                    return StatusCode(400, "Modelo invalido");

                }
                
                
                return StatusCode(200);
            }

            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }
    }
}