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


    }
}