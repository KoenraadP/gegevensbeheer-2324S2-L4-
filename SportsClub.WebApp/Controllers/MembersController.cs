using SportsClub.Bll;
using SportsClub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsClub.WebApp.Controllers
{
    // deze NIET static!
    public class MembersController : Controller
    {
        // CREATE

        // READ ALL
        public ActionResult Index()
        {
            // read methode uit Bll gebruiken
            List<Member> lstMembers = Members.Read();
            // lijst van members doorsturen naar Index View pagina
            return View(lstMembers);
        }

        // READ SINGLE
        public ActionResult Details(int id)
        {
            // Read methode uit BLL gebruiken om member op te zoeken
            Member m = Members.Read(id);
            // Member m doorgeven aan view
            return View(m);
        }

        // UPDATE

        // DELETE
    }
}