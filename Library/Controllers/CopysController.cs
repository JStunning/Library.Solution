using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Library.Models;

namespace Library.Controllers
{
  public class CopysController : Controller
  {
    private readonly LibraryContext _db;

    public CopysController(LibraryContext db)
    {
        _db = db;
    }

    public ActionResult Index(string searchString)
    {
      return View(_db.Copys.ToList());
    }

    public ActionResult Create()
    {
        ViewBag.PatronId = new SelectList(_db.Patrons, "PatronId", "PatronName");
        return View();
    }

    [HttpPost]
    public ActionResult Create(Copy copy, int PatronId)
    {
        _db.Copys.Add(copy);
        if (PatronId != 0)
        {
            _db.Checkout.Add(new Checkout() { PatronId = PatronId, CopyId = copy.CopyId });
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        var thisCopy = _db.Copys
            .Include(copy => copy.Patrons)
            .ThenInclude(join => join.Patron)
            .FirstOrDefault(copy => copy.CopyId == id);
        return View(thisCopy);
    }

    public ActionResult Delete(int id)
    {
        var thisCopy = _db.Copys.FirstOrDefault(copys => copys.CopyId == id);
        return View(thisCopy);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisCopy = _db.Copys.FirstOrDefault(copys => copys.CopyId == id);
        _db.Copys.Remove(thisCopy);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
        var thisCopy = _db.Copys.FirstOrDefault(copys => copys.CopyId == id);
        ViewBag.PatronId = new SelectList(_db.Patrons, "PatronId", "Name");
        return View(thisCopy);
    }

    [HttpPost]
    public ActionResult Edit(Copy copy, int PatronId)
    {
      if (PatronId != 0)
      {
        _db.Checkout.Add(new Checkout() { PatronId = PatronId, CopyId = copy.CopyId });
      }
      _db.Entry(copy).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddPatron(int id)
    {
        var thisCopy = _db.Copys.FirstOrDefault(copys => copys.CopyId == id);
        ViewBag.PatronId = new SelectList(_db.Patrons, "PatronId", "Name");
        return View(thisCopy);
    }

    [HttpPost]
    public ActionResult AddPatron(Copy copy, int PatronId)
    {
        if (PatronId != 0)
        {
        _db.Checkout.Add(new Checkout() { PatronId = PatronId, CopyId = copy.CopyId });
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeletePatron(int joinId)
    {
        var joinEntry = _db.Checkout.FirstOrDefault(entry => entry.CheckoutId == joinId);
        _db.Checkout.Remove(joinEntry);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}