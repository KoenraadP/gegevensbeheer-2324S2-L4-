using SportsClub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClub.Dal
{
    public static class ActivityDal
    {
        // CREATE

        // READ ALL
        public static List<Activity> Read()
        {
            // verbinding met databank maken
            using (var db = new SportsClubDbContext())
            {
                // lijst van members uit db halen
                List<Activity> lstActivities = db.Activities.ToList();
                return lstActivities;
            }
        }

        // READ SINGLE

        // UPDATE

        // DELETE
    }
}
