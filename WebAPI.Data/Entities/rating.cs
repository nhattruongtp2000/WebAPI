using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebAPI.Data.Entities
{
    [Keyless]
    [Table("ratings")]
    public class rating
    {
        
        
        public Guid idUser { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string idProduct { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string comment { get; set; }
        [Required]
        public DateTime rateDate { get; set; }
        [Required]
        public int rate { get; set; }
     
        [ForeignKey("idUser")]
        public virtual users Users { get; set; }

        [ForeignKey("idProduct")]
        public virtual productDetail ProductDetail { get; set; }


    }
}
