using Infrastructure.DataBaseTables;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseService.Repository
{
    public class MovieRepository : IMovieRepository
    {
        public void Add(Movie movie)
        {
            using (var db = new MovieRecomendationContext())
            {
                db.Add(movie);
                db.SaveChanges();
            }
        }
        public Movie Get(int id)
        {
            using (var db = new MovieRecomendationContext())
            {
                 return db.Movies.Find(id);
            }
        }

        public void Update(Movie movie)
        {
            using (var db = new MovieRecomendationContext())
            {
                db.Update(movie);
            }
        }
    }
}
