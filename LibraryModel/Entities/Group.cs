using LibraryModel.BaseEntity;
using System;
using System.Collections.Generic;

namespace LibraryConsoleApp.Models
{
    public partial class Group : BaseEntityClass
    {
        public Group()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int IdFaculty { get; set; }

        public virtual Faculty IdFacultyNavigation { get; set; } = null!;
        public virtual ICollection<Student> Students { get; set; }
    }
}
