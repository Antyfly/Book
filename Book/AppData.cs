using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
   public class AppData
    {
        public static bookEntities context = new bookEntities();
        public static User usersData;
    }
}
