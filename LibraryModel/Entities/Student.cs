using LibraryModel.BaseEntity;
using System;
using System.Collections.Generic;

namespace LibraryConsoleApp.Models
{
    public partial class Student : BaseEntityClass
    {
        public Student()
        {
            SCards = new HashSet<SCard>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int IdGroup { get; set; }
        public int Term { get; set; }

        public virtual Group IdGroupNavigation { get; set; } = null!;
        public virtual ICollection<SCard> SCards { get; set; }
    }
}
