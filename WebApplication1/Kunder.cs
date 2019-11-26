namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kunder")]
    public partial class Kunder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kunder()
        {
            Opgavers = new HashSet<Opgaver>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KundeID { get; set; }

        [Required]
        [StringLength(255)]
        public string KundeNavn { get; set; }

        [Required]
        [StringLength(11)]
        public string KundeNummer { get; set; }

        [Required]
        [StringLength(255)]
        public string KundeAdresse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Opgaver> Opgavers { get; set; }
    }
}
