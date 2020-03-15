using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace promact.Models
{
    public class Postapp
    {
        [Key]
        public int messageID { get; set; }
        public string username { get; set; }
        public string message { get; set; }
        public int likes { get; set; }
        public int commentID { get; set; }
        public int shareID { get; set; }

      
    }
}
