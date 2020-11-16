using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebAPI.Data.Entities
{
    [Keyless]
    [Table("ProductInCategories")]
    public class ProductInCategory
    {
        
        public int  idProduct { get; set; }

        [ForeignKey("idProduct")]
        public virtual products Product { get; set; }
  
        public int idCategory { get; set; }

        [ForeignKey("idCategory")]
        public virtual productCategories Category { get; set; }

        
    }
}
