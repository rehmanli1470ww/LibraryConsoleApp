using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDbAccess.Repostori.Abstarct
{
    public interface IBaseRepostori<T>
    {
        public IEnumerable<T> GetAll();
        public void Add(T item);
        public void Remove(T item);
        public void Update(T item);
        public void Save();
    }
}
