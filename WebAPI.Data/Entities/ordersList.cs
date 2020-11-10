using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebAPI.Data.Entities
{
    [Keyless]
    [Table("ordersLists")]
    public class ordersList
    {        
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string idOrder { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string idUser { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string idProduct { get; set; }


        [ForeignKey("idUser")]
        public virtual users Users { get; set; }

        [ForeignKey("idOrder")]
        public virtual ordersDetails OrdersDetails { get; set; }

        [ForeignKey("idProduct")]
        public virtual products Products { get; set; }
    }
}
