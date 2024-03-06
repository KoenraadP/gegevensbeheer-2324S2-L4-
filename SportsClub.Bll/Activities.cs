using SportsClub.Dal;
using SportsClub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClub.Bll
{
    public static class Activities
    {
        // CREATE

        // READ ALL
        public static List<Activity> Read()
        {
            // read methode uit Dal gebruiken
            List<Activity> lstActivities = ActivityDal.Read();
            return lstActivities;
        }

        // READ SINGLE

        // UPDATE

        // DELETE
    }
}
