using LibraryConsoleApp.Models;
using LibraryDbAccess.Repostori.Abstarct;
using LibraryModel.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDbAccess.Repostori.Concret
{
    public class BaseRepostori<T> : IBaseRepostori<T>where T : class,BaseEntityClass
    {
        private LibraryContext _context;
        public void Add(T item)
        {
            _context.Set<T>().Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Remove(T item)
        {
            _context.Remove(item);
        }

        public void Save()
        {
           _context.SaveChanges();
        }

        public void Update(T item)
        {
            _context.Update(item);
        }
    }
}
