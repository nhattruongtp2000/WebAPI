using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebAPI.Data.Entities
{
    
    [Table("ProductInCategories")]
    public class ProductInCategory
    {
        [Column(TypeName = "VARCHAR(200)")]
        public string  idProduct { get; set; }

        [ForeignKey("ProductId")]
        public products Product { get; set; }

       
        public int idCategory { get; set; }

        [ForeignKey("CategoryId")]
        public productCategories Category { get; set; }

        
    }
}
