// using System;
// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.Rendering;
// using Microsoft.EntityFrameworkCore;
// using Library.Models;

// namespace Library.Controllers
// {
//   public class DepartmentsController : Controller
//   {
//     private readonly LibraryContext _db;

//     public DepartmentsController(LibraryContext db)
//     {
//       _db = db;
//     }

//     public ActionResult Index()
//     {
//       List<Department> model = _db.Departments.ToList();
//       return View(model);
//     }

//     public ActionResult Create()
//     {
// 			ViewBag.StudentId = new SelectList(_db.Students, "StudentId", "Name");
//       return View();
//     }
    
//     [HttpPost]
//     public ActionResult Create(Department department)
//     {
//       _db.Departments.Add(department);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }

//     public ActionResult Details(int id)
//     {
//       Department thisStudent = _db.Departments.FirstOrDefault(departments => departments.DepartmentId == id);
//       return View(thisStudent);
//     }
//   }
// }