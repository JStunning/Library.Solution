using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Library.Models;

namespace Library.Controllers
{
  public class AuthorsController : Controller
  {
    private readonly LibraryContext _db;

    public AuthorsController(LibraryContext db)
    {
        _db = db;
    }

    public ActionResult Index(string searchString)
    {
      return View(_db.Authors.ToList());
    }

    public ActionResult Create()
    {
        ViewBag.BookId = new SelectList(_db.Books, "BookId", "Name");
        return View();
    }

    [HttpPost]
    public ActionResult Create(Author author, int BookId)
    {
        _db.Authors.Add(author);
        if (BookId != 0)
        {
            _db.BookAuthor.Add(new BookAuthor() { BookId = BookId, AuthorId = author.AuthorId });
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        var thisAuthor = _db.Authors
            .Include(author => author.Books)
            .ThenInclude(join => join.Book)
            .FirstOrDefault(author => author.AuthorId == id);
        return View(thisAuthor);
    }

    public ActionResult Delete(int id)
    {
        var thisAuthor = _db.Authors.FirstOrDefault(authors => authors.AuthorId == id);
        return View(thisAuthor);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisAuthor = _db.Authors.FirstOrDefault(authors => authors.AuthorId == id);
        _db.Authors.Remove(thisAuthor);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
        var thisAuthor = _db.Authors.FirstOrDefault(authors => authors.AuthorId == id);
        ViewBag.BookId = new SelectList(_db.Books, "BookId", "Name");
        return View(thisAuthor);
    }

    [HttpPost]
    public ActionResult Edit(Author author, int BookId)
    {
      if (BookId != 0)
      {
        _db.BookAuthor.Add(new BookAuthor() { BookId = BookId, AuthorId = author.AuthorId });
      }
      _db.Entry(author).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddBook(int id)
    {
        var thisAuthor = _db.Authors.FirstOrDefault(authors => authors.AuthorId == id);
        ViewBag.BookId = new SelectList(_db.Books, "BookId", "Name");
        return View(thisAuthor);
    }

    [HttpPost]
    public ActionResult AddBook(Author author, int BookId)
    {
        if (BookId != 0)
        {
        _db.BookAuthor.Add(new BookAuthor() { BookId = BookId, AuthorId = author.AuthorId });
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteBook(int joinId)
    {
        var joinEntry = _db.BookAuthor.FirstOrDefault(entry => entry.BookAuthorId == joinId);
        _db.BookAuthor.Remove(joinEntry);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}