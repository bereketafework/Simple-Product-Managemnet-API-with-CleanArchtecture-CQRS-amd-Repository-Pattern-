using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Domain;
using TaskManagemnt.Application.DTOs;

namespace TaskManagemnt.Application.Mappings
{
    public class ProductProfile: Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
