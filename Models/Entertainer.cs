using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace final_rtj34.Models
{
    public class Entertainer
    {
        [Required]
        [Key]
        public int EntertainerID { get; set; }
        public string? EntStageName { get; set; }
        public int? EntSSN { get; set; }
        public string? EntStreetAddress { get; set; }
        public string? EntCity { get; set; }
        public string? EntState { get; set; }
        public int? EntZipCode { get; set; }
        public int? EntPhoneNumber { get; set; }
        public string? EntWebPage { get; set; }
        public string? EntEMailAddress { get; set; }
        public DateTime? DateEntered { get; set; }
        
    }
}
