using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspMvcTest2
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string RoleName { get; set; }

        public ICollection<Users> Users { get; set; }
        public Role() 
        {
            Users = new List<Users>();
        }
    }
}