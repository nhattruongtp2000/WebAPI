using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebAPI.Data.Entities
{
    [Table("Roles")]
    public class role :IdentityRole<Guid>
    {
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string Description { get; set; }
    }
}
