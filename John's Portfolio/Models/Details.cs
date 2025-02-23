using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace John_s_Portfolio.Models
{

    //Creates Variables for which I can pull from and display on my webpage
    public class Details
    {
        //Creates a variable for the ID(which is basically useless)
        public int Id { get; set; }
        //Creates a variable for the Name(for you to display your name)
        public string Name { get; set; }
        //Creates a variable for the Age(for you to display your Gender)
        public string Gender { get; set; }
        //Creates a variable for the Age(for you to display your Email Address)
        public string EmailAddress { get; set; }
    }
}
