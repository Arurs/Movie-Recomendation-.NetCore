using Infrastructure.DataBaseTables;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseService.Repository
{
    public class RatingRepository : IRatingRepository
    {
        public void Add(UserMovieRating rating)
        {
            using (var db = new MovieRecomendationContext())
            {
                db.Add(rating);
                db.SaveChanges();
            }
        }

        public UserMovieRating Get(int id)
        {
            using (var db = new MovieRecomendationContext())
            {
                return db.UserMovieRatings.Find(id);
            }
        }

        public void Update(UserMovieRating rating)
        {
            using (var db = new MovieRecomendationContext())
            {
                db.Add(rating);
                db.SaveChanges();
            }
        }
    }
}
