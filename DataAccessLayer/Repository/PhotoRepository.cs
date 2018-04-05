using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    class PhotoRepository: IRepository<Photo>
    {
        public IEnumerable<Photo> GetAll()
        {
            throw new NotImplementedException();
        }

        public Photo Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Photo> Find(Func<Photo, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Create(Photo item)
        {
            throw new NotImplementedException();
        }

        public void Update(Photo item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
