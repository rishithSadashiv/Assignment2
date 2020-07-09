using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int Cid{ get; set; }
        [Required]
        [StringLength(50)]
        public string Cname { get; set; }
        [Required]
        public string EmailId{ get; set; }
        [Required]
        public long MobileNo { get; set; }
        [Required]
        public string City { get; set; }

    }
}
