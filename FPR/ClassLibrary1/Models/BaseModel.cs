using DAL.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class BaseModel
    {
        [Key]
        public Guid ID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }
        public DateTime DateGenerated { get; set; }
        public DateTime DateModified { get; set; }
        [ForeignKey("ModifierUser")]
        public Guid? ModifierUserID { get; set; }
        public User ModifierUser { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
