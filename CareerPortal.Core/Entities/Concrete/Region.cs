namespace CareerPortal.Core.Entities.Concrete
{
    public class Region : Entity
    {
        public string Name { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}
