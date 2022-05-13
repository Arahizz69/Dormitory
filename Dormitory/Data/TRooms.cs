namespace Dormitory.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRooms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRooms()
        {
            TStudentsRooms = new HashSet<TStudentsRooms>();
        }

        public int Id { get; set; }

        public int NumberRoom { get; set; }

        public int NumberFloor { get; set; }

        public int NumberSeats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TStudentsRooms> TStudentsRooms { get; set; }
    }
}
