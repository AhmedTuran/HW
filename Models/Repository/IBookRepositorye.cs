using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models.Repository
{
   public interface IBookRepositorye<Entity>
    {
        IList<Entity> list();
        Entity fined(int id);
        void add(Entity entity);
        void delete(int id);
    }
}
