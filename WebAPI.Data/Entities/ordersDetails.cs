using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebAPI.Data.Entities
{
    [Table("OrdersDetails")]
    public class ordersDetails
    {
        [Key]
        [Column(TypeName = "VARCHAR(200)")]
        [Required]
        public string idOrder { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string status { get; set; }
        [Required]
        public int totalPrice { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string idVoucher { get; set; }

        public virtual ICollection<products> products { get; set; }

        
    }
}
