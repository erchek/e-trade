using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeSite.Entities.DbEntities
{
    [Table("Products")]
    public class EProducts : MyEntitiyBase
    {
        [DisplayName("Product Name"), Required]
        public  string Name { get; set; }

        [DisplayName("Description"), StringLength(200)]
        public string Description { get; set; }

        [DisplayName("Product Price"), Required]
        public double Price { get; set; }

        [DisplayName("Stock")]
        public int Stock { get; set; }

        [StringLength(100)]
        public string ImageFileName { get; set; }

        [DisplayName("Is Approved")]
        public bool IsApproved { get; set; }

        [DisplayName("Is Front")]
        public bool IsFront { get; set; }

        public virtual int CategoryId { get; set; }

        public virtual ECategories Category { get; set; }
    }
}
