using HospitalWarehouse.DataContext;
using HospitalWarehouse.Models;

namespace HospitalWarehouse
{
    public class DataAccess
    {
        public static void InsertProduct()
        {
            using (var context = new HospitalDataContext())
            {
                Category category = new Category();
                int quantity;
                double valueItem;

                Console.WriteLine("Enter product name: ");
                string productName = Console.ReadLine();

                Console.WriteLine("Enter Quantity:  ");
                quantity = int.Parse(Console.ReadLine());

                var product = context.Products.FirstOrDefault(x => x.Name == productName);

                if (product == null)
                {
                    Console.WriteLine("Enter Category name: ");
                    string categoryName = Console.ReadLine();

                    var categoryExists = context.Category.FirstOrDefault(x => x.CategoryName == categoryName);
                    if (categoryExists == null)
                    {
                        category = categoryExists;
                    }
                    else
                    {
                        category = new Category { CategoryName = categoryName };
                    }

                    Console.WriteLine("Enter Value: ");
                    valueItem = double.Parse(Console.ReadLine());

                    context.Products.Add(new Products
                    {
                        Name = productName,
                        ProductCategory = category,
                        Quantity = quantity,
                        Value = valueItem

                    });
                }
                else
                {
                    product.Quantity = product.Quantity + quantity;
                    context.Update(product);
                }
                context.SaveChanges();
            }

        }

        public static void UseProduct()
        {
            Console.WriteLine("Which one product do you want use?");
            string productUsed = Console.ReadLine();
            int ConsumedQuantity;

            using (var context = new HospitalDataContext())
            {
                var product = context.Products.FirstOrDefault(x => x.Name == productUsed);

                if (product != null)
                {
                    Console.WriteLine("How many units will you use??");
                    ConsumedQuantity = int.Parse(Console.ReadLine());
                    int availableQuantity = product.Quantity;

                    if (availableQuantity > 0 && availableQuantity > ConsumedQuantity)
                    {
                        product.Quantity -= ConsumedQuantity;
                        context.Update(product);

                        var productAlreadyConsumed = context.ConsumedProducts.FirstOrDefault(x => x.Name == productUsed);
                        if (productAlreadyConsumed == null)
                        {
                            var consumedProduct = new ConsumedProducts
                            {
                                Name = product.Name,
                                ProductCategory = product.ProductCategory,
                                Quantity = ConsumedQuantity,
                                Value = product.Value
                            };
                        }
                        else
                        {
                            productAlreadyConsumed.Quantity += ConsumedQuantity;
                        }


                    }
                    else
                    {
                        Console.WriteLine($"We don't have enough, we only have {availableQuantity} units.");
                    }
                }
                else
                {
                    Console.WriteLine("This product is not registered.");
                }
            }
        }
    }
}