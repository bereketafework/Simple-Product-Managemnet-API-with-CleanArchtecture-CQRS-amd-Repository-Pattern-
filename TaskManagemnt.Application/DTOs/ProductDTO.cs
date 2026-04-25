using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TaskManagemnt.Application.DTOs
{
    public class ProductDTO
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public  string  Name { get; set; }
       
        [Required(ErrorMessage = "Price is Required")]
        public decimal Price { get; set; }

        public int Stock { get; set; }
    }
}
