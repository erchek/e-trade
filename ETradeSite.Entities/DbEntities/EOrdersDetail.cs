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
    [Table("OrdersDetail")]
    public class EOrdersDetail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public virtual EOrders Order { get; set; }

        public virtual EProducts Products { get; set; }
    }
}
