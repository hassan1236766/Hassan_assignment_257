using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hassan_257.Models
{
    public class Omodel
    {


        public int Id { get; set; }
       
        public string Name { get; set; }


        public int Price { get; set; }
        [Required]
        public int Quantity { get; set; }

        public string Discription { get; set; }


    }
}
