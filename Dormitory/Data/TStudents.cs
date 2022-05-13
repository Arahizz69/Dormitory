namespace Dormitory.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TStudents
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TStudents()
        {
            TParentsStudents = new HashSet<TParentsStudents>();
            TStudentsRooms = new HashSet<TStudentsRooms>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string FCs { get; set; }

        [StringLength(50)]
        public string NumberPhone { get; set; }

        public int? NumberViolations { get; set; }

        public bool Men { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TParentsStudents> TParentsStudents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TStudentsRooms> TStudentsRooms { get; set; }
    }
}
