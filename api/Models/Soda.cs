namespace api.Models
import System;
{
    public interface Soda
    {
         public string Flavor { get; set; }
         public double RetailPrice { get; set; }
         public double DiscountPrice { get; set; }
         public string Description { get; set; }
         public double Weight { get; set; }
         public DateTime StartDate { get; set; }
         public DateTime EndDate { get; set; }
    }
}