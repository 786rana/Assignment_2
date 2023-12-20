using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Assignment_2.Data.Assignment2;
using System;

public class StudentController : Controller
{
    private readonly Assignment2DbContext _dbContext;

    public StudentController(Assignment2DbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public IActionResult Index()
    {
        var students = _dbContext.Students.ToList();
        return View(students);
    }
    public IActionResult Details(int id)
    {
        var student = _dbContext.Students.Find(id);

        if (student == null)
        {
            return NotFound();
        }

        return View(student);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Student student)
    {
        if (ModelState.IsValid)
        {
            _dbContext.Students.Add(student);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        return View(student);
    }
    public IActionResult Edit(int id)
    {
        var student = _dbContext.Students.Find(id);

        if (student == null)
        {
            return NotFound();
        }

        return View(student);
    }

    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Student student)
    {
        if (id != student.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _dbContext.Students.Update(student);
                _dbContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(student.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(Index));
        }

        return View(student);
    }


    public IActionResult Delete(int id)
    {
        var student = _dbContext.Students.Find(id);

        if (student == null)
        {
            return NotFound();
        }

        return View(student);
    }

   
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var student = _dbContext.Students.Find(id);
        _dbContext.Students.Remove(student);
        _dbContext.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    private bool StudentExists(int id)
    {
        return _dbContext.Students.Any(e => e.Id == id);
    }
}
