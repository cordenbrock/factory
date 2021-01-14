using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {

    private readonly FactoryContext _db;

    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Engineers =  _db.Engineers.OrderBy(e => e.EngineerName).ToList();
      ViewBag.Machines = _db.Machines.OrderBy(m => m.MachineName).ToList();
      return View();
    }
  }
}