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
    [Table("Orders")]
    public class EOrders
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        public double TotalMoney { get; set; }

        [DisplayName("Order Date"),Required]
        public DateTime OrderDate { get; set; }

        [DisplayName("Is Approved")]
        public bool IsApproved { get; set; }

        [DisplayName("Description"), StringLength(300)]
        public string Description { get; set; }

        public string UserId { get; set; }
    }
}
