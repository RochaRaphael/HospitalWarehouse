namespace HospitalWarehouse.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Value { get; set; }
        public IList<Category> ProductCategory { get; set; }

    }
}