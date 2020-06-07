using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vision.Data.IRepository;

namespace Vision.Data.Repository
{
    public class UserRepository: Repository<ApplcationUser>, IUserRepository
    {
        private ApplicationDbContext db;

        public UserRepository(ApplicationDbContext db) :base(db)
        {
            this.db = db;
        }
    }
}
