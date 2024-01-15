namespace Simple_Ecommerce_Proj.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nha CC")]
    public partial class Nha_CC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nha_CC()
        {
            Hang = new HashSet<Hang>();
        }

        [Key]
        [StringLength(15)]
        public string MaNCC { get; set; }

        [Required]
        [StringLength(20)]
        public string TenNCC { get; set; }

        [Required]
        [StringLength(20)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(10)]
        public string DienThoai { get; set; }

        [Required]
        [StringLength(25)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hang> Hang { get; set; }
    }
}
