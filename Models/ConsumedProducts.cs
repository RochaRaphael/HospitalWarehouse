namespace HospitalWarehouse.Models
{
    public class ConsumedProducts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Value { get; set; }
        public Category ProductCategory { get; set; }
        public Sector SectorThatConsumed { get; set; }
    }
}