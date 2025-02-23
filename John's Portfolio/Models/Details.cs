using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace John_s_Portfolio.Models
{
    public class Details
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string EmailAddress { get; set; }
    }
}
