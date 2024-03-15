using SportsClub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClub.Dal
{
    // door static toe te voegen kunnen we deze class
    // gebruiken zonder new ...() te moeten typen
    // zorgt ook voor minder memory usage
    // als de class static is, moeten alle methodes erin
    // OOK static zijn
    public static class MemberDal
    {
        // CREATE

        // READ ALL
        public static List<Member> Read()
        {
            // verbinding met databank maken
            using (var db = new SportsClubDbContext())
            {
                // lijst van members uit db halen
                // select * from...
                List<Member> lstMembers = db.Members.ToList();
                return lstMembers;
            }
        }

        // READ SINGLE
        public static Member Read(int id)
        {
            // verbinding met databank maken
            using (var db = new SportsClubDbContext())
            {
                // record van member opzoeken op basis van id
                Member m = db.Members.Find(id);
                // member als return waarde geven
                return m;
            }
        }

        // UPDATE

        // DELETE
    }
}
