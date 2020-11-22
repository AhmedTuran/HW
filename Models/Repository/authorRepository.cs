using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models.Repository
{
    namespace library.Models.Repository
    {
        public class authorRepository : IBookRepositorye<author>
        {
            public List<author> authors;

            public authorRepository() => authors = new List<author> {
            new author {id=1 , name="mhmod java" },
            new author {id=2 , name="saeed c++" },
            new author {id=3 , name="mohammed python" },

        };
            public void add(author entity)
            {
                authors.Add(entity);            }

            public void delete(int id)
            {
                var author = fined(id);
                authors.Remove(author);
            }

            public author fined(int id)
            {
                var author = authors.SingleOrDefault(b => b.id == id);
                return author;
            }

            public IList<author> list()
            {
                return authors;            }
        }
    }
}