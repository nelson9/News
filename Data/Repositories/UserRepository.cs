using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.GenericRepo;
using NewsApp.Models;

namespace Data.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        
    }

    public class UserRepository : Repository<User>, IUserRepository
    {
        public NewsContext NewsContext
        {
            get
            {
                return Context as NewsContext;
            }
        }

        public UserRepository(NewsContext context) : base(context) { }
    }
}
