namespace Dormitory.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TStudentsRooms
    {
        public int Id { get; set; }

        public int IdRooms { get; set; }

        public int IdStudents { get; set; }

        [Column(TypeName = "date")]
        public DateTime СheckInDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EvictionDate { get; set; }

        public virtual TRooms TRooms { get; set; }

        public virtual TStudents TStudents { get; set; }
    }
}
