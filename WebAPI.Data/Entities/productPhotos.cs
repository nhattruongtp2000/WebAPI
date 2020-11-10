using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebAPI.Data.Entities
{
    [Table("productPhotos")]
    public class productPhotos
    {
        [Key]
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string idProductDetail { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string link { get; set; }
        [Required]
        public DateTime uploadedTime { get; set; }

        [ForeignKey("idProductDetail")]
        public virtual productDetail ProductDetail { get; set; }
    }
}
