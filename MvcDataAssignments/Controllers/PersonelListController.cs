using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDataAssignments.Models;

namespace MvcDataAssignments.Controllers
{
    public class PersonelListController : Controller
    {
        // GET: PersonelList
        public ActionResult Index(string id)
        {
            //This will order the list after ID

            //var model =
            //    from r in personel
            //    orderby r.Id
            //    select r;

            string searchString = id;
            var people = from m in personel
                         select m;

            if (!String.IsNullOrEmpty(id))
            {
                people = people.Where(s => s.Name.Contains(id) || s.City.Contains(id));
            }

            return View(people);
        }

        // GET: PersonelList/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonelList/Create
        public ActionResult AddPerson()
        {
            return View();
        }

        // POST: PersonelList/Create
        [HttpPost]
        public ActionResult AddPerson(PersonModel person)
        {
            try
            {
                person.Id = personel[personel.Count - 1].Id + 1;

                personel.Add(person);
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View(personel);
            }
        }

        // GET: PersonelList/Edit/5
        public ActionResult Edit(int id)
        {
            var person = personel.Single(r => r.Id == id);

            return View(person);
        }

        // POST: PersonelList/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonelList/Delete/5
        public ActionResult Delete(int id)
        {
            var person1 = personel.Single(r => r.Id == id);
            return View(person1);
        }

        // POST: PersonelList/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, PersonModel person)
        {
            try
            {
                // TODO: Add delete logic here
                var person1 = personel.Single(r => r.Id == id);
                personel.Remove(person1);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        static List<PersonModel> personel = new List<PersonModel>
        {
            new PersonModel
            {
                Id = 1,
                Name = "Bob",
                City = "Göteborg",
                PhoneNumber = 123456789
            },
            new PersonModel
            {
                Id = 2,
                Name = "Steve",
                City = "Göteborg",
                PhoneNumber = 584927831
            },
            new PersonModel
            {
                Id = 3,
                Name = "Kalle",
                City = "Stockholm",
                PhoneNumber = 600271677
            },
            new PersonModel
            {
                Id = 4,
                Name = "Dave",
                City = "Malmö",
                PhoneNumber = 365490111
            }
        };
    }
}
