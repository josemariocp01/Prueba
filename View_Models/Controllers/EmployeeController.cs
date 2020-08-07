using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using View_Models.Models;
using View_Models.ViewModels;

namespace View_Models.Controllers
{
    public class EmployeeController : Controller
    {

        public IActionResult Info()
        {
            Person persona1 = new Person() { RFC = "hckvjan", edad = 23, Nombre = "Luis" };
            Employee empleado1 = new Employee() { ID = 01, area = "sistemas" };


            EmployeeDetailsViewModel empleado_persona1 = new EmployeeDetailsViewModel()
            {
                persona = persona1,
                empleado = empleado1
            };

            Person persona2 = new Person() { RFC = "asdff", edad = 20, Nombre = "Alejandra" };
            Employee empleado2 = new Employee() { ID = 02, area = "Ventas" };


            EmployeeDetailsViewModel empleado_persona2 = new EmployeeDetailsViewModel()
            {
                persona = persona2,
                empleado = empleado2
            };


            var empleado = new List<EmployeeDetailsViewModel>();
            empleado.Add(empleado_persona1);
            empleado.Add(empleado_persona2);



            return View(empleado);
        }

    }
}
