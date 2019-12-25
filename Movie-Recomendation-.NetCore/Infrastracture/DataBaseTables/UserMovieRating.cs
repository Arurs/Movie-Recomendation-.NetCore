﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataBaseTables
{
    public class UserMovieRating
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int MovieID { get; set; }
        public int Rating { get; set; }
        public Movie Movie { get; set; }
        public User User { get; set; }
    }
}
