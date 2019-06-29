using System;
using System.ComponentModel.DataAnnotations;

namespace dotnetgettingstarted.Models
{
    public class ValueModel
    {
        public int id { get; set; }

        [MinLength(5)]
        public string value { get; set; }
    }
}
