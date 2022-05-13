namespace Dormitory.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TParents
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TParents()
        {
            TParentsStudents = new HashSet<TParentsStudents>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string FCs { get; set; }

        [StringLength(50)]
        public string NumberPhone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TParentsStudents> TParentsStudents { get; set; }
    }
}
