namespace Simple_Ecommerce_Proj.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hang")]
    public partial class Hang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hang()
        {
            GioHang = new HashSet<GioHang>();
        }

        [Key]
        [StringLength(15)]
        public string MaHang { get; set; }

        [Required]
        [StringLength(15)]
        public string MaNCC { get; set; }

        [Required]
        [StringLength(20)]
        public string TenHang { get; set; }

        public decimal Gia { get; set; }

        public short LuongCo { get; set; }

        [StringLength(200)]
        public string MoTa { get; set; }

        public decimal? ChietKhau { get; set; }

        [StringLength(30)]
        public string HinhAnh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GioHang> GioHang { get; set; }

        public virtual Nha_CC Nha_CC { get; set; }
    }
}
