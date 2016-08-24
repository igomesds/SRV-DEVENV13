using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Mvc5.Models
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalParam);
    }

    public class DeafultDiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (10m / 100m * totalParam));
        }
    }
}