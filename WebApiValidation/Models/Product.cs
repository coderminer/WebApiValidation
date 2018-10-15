using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiValidation.Models
{
    [Validator(typeof(ProductValidator))]
    public class Product 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }


    }

    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("product id must be greater than 0");
            RuleFor(x => x.Name).NotEmpty().WithMessage("the name cannot be blank")
                .Length(0, 100)
                .WithMessage("the name length cannot more than 100 characters");
            RuleFor(x => x.Description).NotEmpty().WithMessage("the des cannot be empty");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("the price must be greater than 0");
        }
    }
}
