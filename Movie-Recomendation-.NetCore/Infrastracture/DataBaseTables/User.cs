using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataBaseTables
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age {get; set;}
        public string Nationality { get; set; }
    }
}
