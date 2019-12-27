using Infrastructure.DataBaseTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public interface IUserRepository
    {
        void Add(User user);
        User Get(int id);
        void Update(User movie);
    }
}
