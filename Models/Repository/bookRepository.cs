using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models.Repository
{
    public class bookRepository : IBookRepositorye<book>
    {
        public List<book> books;

        public bookRepository() => books = new List<book> {
            new book {id=1 , Titel="programming java" },
            new book {id=2 , Titel="programming c++" },
            new book {id=3 , Titel="programming python" },

        };
        public void add(book entity)
        {
            books.Add(entity);
        }

        public void delete(int id)
        {
            var book = fined(id);
           books.Remove(book);
        }

        public book fined(int id)
        {
            var book = books.SingleOrDefault(b=>b.id ==id);
            return book;
        }

        public IList<book> list()
        {
            return books;
        }
    };
    
    }
