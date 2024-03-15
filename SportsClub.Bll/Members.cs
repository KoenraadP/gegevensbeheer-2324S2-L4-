using SportsClub.Dal;
using SportsClub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClub.Bll
{
    public static class Members
    {
        // CREATE

        // READ ALL
        public static List<Member> Read()
        {
            // read methode uit Dal gebruiken
            List<Member> lstMembers = MemberDal.Read();
            return lstMembers;
        }

        // READ SINGLE
        public static Member Read(int id)
        {
            // member opzoeken met dal methode
            Member m = MemberDal.Read(id);
            // member als return geven
            return m;
        }

        // UPDATE

        // DELETE
    }
}
