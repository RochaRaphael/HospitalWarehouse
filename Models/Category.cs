namespace HospitalWarehouse.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public Products Products { get; set; }
    }
}