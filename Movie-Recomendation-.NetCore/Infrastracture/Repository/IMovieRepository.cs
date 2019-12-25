using Infrastructure.DataBaseTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public interface IMovieRepository
    {
        void Add(Movie movie);
        Movie Get(int id);
        void Update(Movie movie);
    }
}
