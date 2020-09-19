using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialJoseReneGuarachi.Models
{
    public class Country
    {
        [Key]
        [Required]
        [StringLength(20, ErrorMessage ="No valido ", MinimumLength =2)]
        public string alpha2Code { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "No valido ", MinimumLength = 2)]
        public string Region { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "No valido ", MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [Range(1,6000000)]
        public int Area { get; set; }

        [Required]
        [Range(1, 1000)]
        public int callingCodes { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "No valido ", MinimumLength = 2)]
        public string languages { get; set; }

        [Required]
        public string flag { get; set; }
    }
}