using LibraryModel.BaseEntity;
using System;
using System.Collections.Generic;

namespace LibraryConsoleApp.Models
{
    public partial class Teacher : BaseEntityClass
    {
        public Teacher()
        {
            TCards = new HashSet<TCard>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int IdDep { get; set; }

        public virtual Department IdDepNavigation { get; set; } = null!;
        public virtual ICollection<TCard> TCards { get; set; }
    }
}
