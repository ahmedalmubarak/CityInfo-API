using CityInfo.API.Models;

namespace CityInfo.api.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public ICollection<PointOfInterestDto> PointsOfInterest { get; set; } = new List<PointOfInterestDto>();
        public int NumberOfPointsOfinterest { get { return PointsOfInterest.Count; } }
    }
}
