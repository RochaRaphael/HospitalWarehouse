namespace HospitalWarehouse.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public IList<Products> Products { get; set; }
    }
}