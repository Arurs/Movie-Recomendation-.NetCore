using Infrastructure.DataBaseTables;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseService.Repository
{
    public class UserRepository : IUserRepository
    {
        public void Add(User user)
        {
            using (var db = new MovieRecomendationContext())
            {
                db.Add(user);
                db.SaveChanges();
            }
        }

        public User Get(int id)
        {
            using (var db = new MovieRecomendationContext())
            {
                return db.Users.Find(id);
            }
        }

        public void Update(User user)
        {
            using (var db = new MovieRecomendationContext())
            {
                db.Update(user);
                db.SaveChanges();
            }
        }
    }
}
