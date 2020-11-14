using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebAPI.Data.Enums;

namespace WebAPI.Data.Entities
{
    [Table("productDetails")]
    public class productDetail
    {
        [Key]
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string idProductDetail           {get;set;}
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string idProduct{ get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string ProductName { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public decimal   price                     {get;set;}
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public decimal salePrice                 {get;set;}
        
        [Required]
        [Column(TypeName = "VARCHAR(2000)")]
        public string detail                    {get;set;}
        [Required]
        public Status isSaling                     {get;set;}
        public DateTime expiredSalingDate       {get;set;}
        [Required]
        public DateTime dateAdded { get; set; }

        [ForeignKey("idProduct")]
        public virtual products Products { get; set; }
        public virtual ICollection<productPhotos> productPhotos { set; get; }

        
    }
}
