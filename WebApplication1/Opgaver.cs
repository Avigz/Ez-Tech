namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Opgaver")]
    public partial class Opgaver
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int KundeID { get; set; }

        [StringLength(255)]
        public string Beskrivelse { get; set; }

        public int? HjælperTilknyttet { get; set; }

        public bool IsDone { get; set; }

        public virtual Kunder Kunder { get; set; }
    }
}
