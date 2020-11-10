using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebAPI.Data.Entities
{
    [Table("users")]
    public class users
    {
        [Key]
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string idUser { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string email { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string password { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string firstName { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string lastName { get; set; }
        public DateTime birthday { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string phoneNumber { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string address { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string note { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string province { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string interestedIn { get; set; }
        public DateTime lastLogin { get; set; }

        
        public virtual ICollection<rating> Ratings { set; get; }

    }
}
