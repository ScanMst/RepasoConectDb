using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUD_Estudiantes.Models;
using System.Net.Mime;

namespace CRUD_Estudiantes.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContex _contex;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContex contex)
    {
        _logger = logger;
        _contex = contex;
    }

    public IActionResult Index()
    {

        //Students estudiante = new Students();
        //estudiante.Id = new Guid();
        //estudiante.Nombre = "Mario";
        //estudiante.Apellido = "Juarez";
        //estudiante.Tetra = 7;
        //estudiante.Cuota = 100;
        //this._contex.Students.Add(estudiante);
        //this._contex.SaveChanges();

        return View();
    }

    public IActionResult Privacy()
    {
        //para insertar
        //Students Estudiante = new Students();
        //Estudiante.Id = new Guid();
        //Estudiante.Nombre = "Ulises";
        //Estudiante.Apellido = "Del Villar";
        //Estudiante.Tetra = 7;
        //Estudiante.Cuota = 1500;
        //this._contex.Students.Add(Estudiante);
        //this._contex.SaveChanges();

        //Para  Avtualizar 
        //Students estudianteActualiza = this._contex.Students.Where(c=> c.Id == new Guid ("870F3C56-3B5A-4FF0-8757-08DC871A7B7A")).First();
        //estudianteActualiza.Nombre = "Pancho";
        //this._contex.Students.Update(estudianteActualiza);
        //this._contex.SaveChanges();

        //Para  Borrar 
        //Students estudianteBorrar = this._contex.Students.Where(c=> c.Id == new Guid ("870F3C56-3B5A-4FF0-8757-08DC871A7B7A")).First();
        //estudianteBorrar.Nombre = "Pancho";
        //this._contex.Students.Remove(estudianteBorrar);
        //this._contex.SaveChanges();
        
        //Para cargar informacion SELECT
        List<StudentsModel> list = new List<StudentsModel>();
        list = _contex.Students.Select(s => new StudentsModel()
        {
            Id = s.Id,
            Nombre = s.Nombre,
            Apellido = s.Apellido,
            Tetra = s.Tetra,
            Cuota = s.Cuota,

        }).ToList();

        return View(list);


    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
