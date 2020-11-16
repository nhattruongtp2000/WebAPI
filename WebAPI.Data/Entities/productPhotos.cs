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
        public int Id { get; set; }
        [Required]
        public int idProduct { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string ImagePath { get; set; }
        public string Caption { get; set; }

        public bool IsDefault { get; set; }

        public long FileSize { get; set; }

        [Required]
        public DateTime uploadedTime { get; set; }

        [ForeignKey("idProduct")]
        public virtual products Products { get; set; }
    }
}
