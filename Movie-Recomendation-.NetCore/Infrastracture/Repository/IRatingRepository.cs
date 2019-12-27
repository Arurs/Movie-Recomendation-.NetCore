using Infrastructure.DataBaseTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public interface IRatingRepository
    {
        void Add(UserMovieRating rating);
        UserMovieRating Get(int id);
        void Update(UserMovieRating rating);
    }
}
