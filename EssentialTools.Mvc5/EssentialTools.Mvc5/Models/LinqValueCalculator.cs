using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Mvc5.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        IDiscountHelper discounter;

        public LinqValueCalculator(IDiscountHelper discounterParam)
        {
            discounter = discounterParam;
        }

        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return discounter.ApplyDiscount(products.Sum(p => p.Price));
        }
    }
}