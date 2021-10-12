using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformDemo.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string CmdName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Platform { get; set; }
    }
}
