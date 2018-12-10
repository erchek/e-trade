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
    [Table("Users")]
    public class EUser : MyEntitiyBase
    {
        [DisplayName("Name"),StringLength(30)]
        public string Name { get; set; }

        [DisplayName("Surname"),StringLength(30)]
        public string Surname { get; set; }

        [DisplayName("User name"),StringLength(20),Required(ErrorMessage = "{0} cannot be empty")]
        public string Username { get; set; }

        [DisplayName("E-Mail"), Required(ErrorMessage = "{0} cannot be empty"), StringLength(50)]
        public string Email { get; set; }

        [DisplayName("Passwprd"), Required(ErrorMessage = "{0} cannot be empty"), StringLength(20)]
        public string Password { get; set; }

        [Required]
        public Guid ActiveGuid { get; set; }

        [StringLength(100)]  
        public string ProfileImageFileName { get; set; }

        [DisplayName("Is Active")]
        public bool IsActive { get; set; }

        [DisplayName("Is Admin")]
        public bool IsAdmin { get; set; }

        [DisplayName("Gender")]
        public string Gender { get; set; }

        [DisplayName("Birthday")]
        public DateTime Birthday { get; set; }

    }
}
