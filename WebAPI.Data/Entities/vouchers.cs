using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebAPI.Data.Entities
{
    [Table("vouchers")]
    public class vouchers
    {
        [Key]
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string idVoucher { get; set; }
        [Required]    
        public int price { get; set; }
        [Required]
        [DefaultValue(0)]
        public int isUse { get; set; }

    }
}
