using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithVisualStudio.Models
{
    public class SimpleRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products = new Dictionary<string, Product>();
        public static SimpleRepository SharedRepository => sharedRepository; // Он же get { return sharedRepository; }

        public IEnumerable<Product> Products => products.Values;
        public void AddProduct(Product p) => products.Add(p.Name, p);

        public SimpleRepository()
        {
            var initialItems = new[]
            {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "LifeJacket", Price = 48.95M },
                new Product { Name = "Soccer Ball", Price = 19.50M },
                new Product { Name = "Corner Flag", Price = 34.95M }
            };

            foreach (var p in initialItems)
            {
                AddProduct(p);
            }
            products.Add("Error", null);
        }
    }
}
