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
    [Table("Categories")]
    public class ECategories : MyEntitiyBase
    {
        [DisplayName("Category"), Required, StringLength(50)]
        public string Title { get; set; }

        [DisplayName("Description"), StringLength(200)]
        public string Description { get; set; }

        public virtual List<EProducts> Products { get; set; }

        public ECategories()
        {
            Products= new List<EProducts>();
        }
    }
}
