namespace Dormitory.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TParentsStudents
    {
        public int Id { get; set; }

        public int IdParents { get; set; }

        public int IdStudents { get; set; }

        public virtual TParents TParents { get; set; }

        public virtual TStudents TStudents { get; set; }
    }
}
