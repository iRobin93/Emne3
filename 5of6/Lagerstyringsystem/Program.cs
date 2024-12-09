

using Lagerstyringsystem;

Storage storage = new();
storage.AddProduct(new Electronics(30000, "PC", 12));
storage.AddProduct(new Electronics(1200, "Keyboard", 12));
storage.AddProduct(new Clothes(600, "Sweater", "Large"));
storage.AddProduct(new Clothes(300, "T-shirt", "Small"));
DateTime dateTime = DateTime.Now;
storage.AddProduct(new Food(300, "Avocado", dateTime.AddDays(10).Date));
storage.AddProduct(new Food(300, "Avocado", dateTime.AddDays(5).Date));
storage.RemoveProduct(storage.Products[0]);
storage.WriteAllProducts();