using LibraryModel.BaseEntity;
using System;
using System.Collections.Generic;

namespace LibraryConsoleApp.Models
{
    public partial class Press : BaseEntityClass
    {
        public Press()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
    }
}
