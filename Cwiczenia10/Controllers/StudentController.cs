using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia10.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia10.Controllers
{
    public class StudentController : Controller
    {
        static StudentsList studentsList;

        public StudentController()
        {

            studentsList = StudentsList.getInstance();
        }


        // GET: Student
        public ActionResult Index()
        {
            return View(studentsList.students);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
          
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string FirstName, string LastName, string Studies)
        {

            // TODO: Add insert logic here
            Student student = null;

            try
            {
                if (FirstName == null)
                    throw new System.ArgumentException("First name must not be null");
                else if(LastName == null)
                    throw new System.ArgumentException("Last name must not be null");
                else
                {
                    student = new Student(FirstName, LastName, Studies);
                    if (ModelState.IsValid)
                    {
                        studentsList.students.Add(student);
                        return RedirectToAction(nameof(Index));
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return View(student);
            }

            return View(student);

        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(int id)
        {
            foreach (var st in studentsList.students)
            {
                if (st.IdStudent == id)
                {
                    studentsList.students.Remove(st);
                    break;
                }
            }

            return RedirectToAction(nameof(Index));
        }
       
      
    }
}