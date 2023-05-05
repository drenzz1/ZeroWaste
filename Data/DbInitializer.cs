using MyStore.Entities;

namespace MyStore.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;
            var products = new List<Product>()
            {
                new Product
                {
                    Name = "Product 1",
                    Description = "No Description",
                    Price = 30,
                    PictureUrl = "url",
                    Type = "Tipi",
                    Brand = "Gucci",
                    QuantityStock = 30
                }
            };

            foreach (var product in products) { 
                context.Products.Add(product); 
            }

    
                
            if (context.Shippings.Any()) return;
            var shippings = new List<Shipping>()
            {
                new Shipping
                {
                    Id = 1,
                    Weight = 10.5,
                    Pickuplocation = "Prishtine",
                    Description = "aaaa",
                    trackingNumber = 1111,

                }
            };
            foreach (var shipping in shippings)
            {
                context.Shippings.Add(shipping);
            }
        }
    
    }
}
