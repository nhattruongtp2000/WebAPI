using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebAPI.Data.Entities
{
    [Table("products")]
    public class products
    {
        [Key]
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string idProduct { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string idProductDetail { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string idSize { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string idBrand { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string idColor { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string idCategory { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string idType { get; set; }

        

        [ForeignKey("idProductDetail")]
        public virtual productDetail ProductDetail { get; set; }

        [ForeignKey("idBrand")]
        public virtual productBrand ProductBrand { get; set; }

        [ForeignKey("idSize")]
        public virtual productSize ProductSize { get; set; }

        [ForeignKey("idCategory")]
        public virtual productCategories ProductCategories { get; set; }

        [ForeignKey("idType")]
        public virtual productTypes ProductTypes { get; set; }

        [ForeignKey("idColor")]
        public virtual productColor ProductColor { get; set; }

    }
}
