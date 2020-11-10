using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

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
        public string price                     {get;set;}
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string salePrice                 {get;set;}
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string photoReview               {get;set;}
        [Required]
        [Column(TypeName = "VARCHAR(2000)")]
        public string detail                    {get;set;}
        [Required]
        public int isSaling                     {get;set;}
        public DateTime expiredSalingDate       {get;set;}
        [Required]
        public DateTime dateAdded { get; set; }

        
        public virtual ICollection<productPhotos> productPhotos { set; get; }

        public virtual ICollection<rating> Ratings { set; get; }
    }
}
