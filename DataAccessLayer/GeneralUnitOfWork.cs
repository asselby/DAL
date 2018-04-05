using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class GeneralUnitOfWork : IUnitOfWork
    {
        public IRepository<Photo> Photo
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<UserProfile> UserProfile
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
