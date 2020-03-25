using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Library.Models;

namespace Library.Controllers
{
  public class PatronsController : Controller
  {
    private readonly LibraryContext _db;

    public PatronsController(LibraryContext db)
    {
        _db = db;
    }

    public ActionResult Index(string searchString)
    {
      var model = _db.Patrons.ToList();

      // if (!String.IsNullOrEmpty(searchString))
      // {
      //     model = model.Where(m => m.Name.Contains(searchString) || m.Name.Contains(searchString));
      // }
      return View(model.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Patron patron)
    {
        _db.Patrons.Add(patron);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        var thisPatron = _db.Patrons
            .Include(book => book.Copys)
            .ThenInclude(join => join.Copy)
            .FirstOrDefault(book => book.PatronId == id);
        return View(thisPatron);
    }

    public ActionResult Delete(int id)
    {
        var thisPatron = _db.Patrons.FirstOrDefault(patrons => patrons.PatronId == id);
        return View(thisPatron);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisPatron = _db.Patrons.FirstOrDefault(patron => patron.PatronId == id);
        _db.Patrons.Remove(thisPatron);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}