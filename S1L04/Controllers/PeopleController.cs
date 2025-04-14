using S1L04.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace S1L04.Controllers
{
    public class PeopleController : Controller
    {
        
        
            // Static list to persist between requests
            private static List<PersonModel> people = new List<PersonModel>();

            // GET: People/ListPeople
            public ActionResult ListPeople()
            {
                return View(people);
            }

            // GET: People/AddPerson
            public ActionResult AddPerson()
            {
                return View();
            }

            // POST: People/AddPerson
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult AddPerson(PersonModel person)
            {
                if (ModelState.IsValid)
                {
                    people.Add(person);
                    return RedirectToAction("ListPeople");
                }
                return View(person);
            }

            // POST: People/DeletePerson
            [HttpPost]
            public ActionResult DeletePerson(string StuNumber)
            {
                var personToDelete = people.FirstOrDefault(p => p.StuNumber == StuNumber);
                if (personToDelete != null)
                {
                    people.Remove(personToDelete);
                }
                return RedirectToAction("ListPeople");
            }
        }

    }
