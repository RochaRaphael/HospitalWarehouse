namespace HospitalWarehouse.Models
{
    public class Sector
    {
        public int Id { get; set; }
        public string SectorName { get; set; }
        public IList<ConsumedProducts> ConsumedProducts { get; set; }
    }
}