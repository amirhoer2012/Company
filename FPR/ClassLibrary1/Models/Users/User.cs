using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Users
{
   public class User:BaseModel
    {
        public string Name { get; set; }
        public string Family { get; set; }

    }
}
