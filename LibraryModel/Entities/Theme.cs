using LibraryModel.BaseEntity;
using System;
using System.Collections.Generic;

namespace LibraryConsoleApp.Models
{
    public partial class Theme : BaseEntityClass
    {
        public Theme()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
    }
}
