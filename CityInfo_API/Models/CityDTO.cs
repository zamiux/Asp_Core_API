namespace CityInfo_API.Models
{
    public class CityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public int? NumberOfPointInterest // read only va dar lahze fill mishe. 
        {
            get
            {
                return pointOfOnterestDTOs.Count;
            }
        }

        #region Relation With Another Dto
        public ICollection<PointOfOnterestDTO> pointOfOnterestDTOs { get; set; }
         = new List<PointOfOnterestDTO>(); // yani list khali
        #endregion
    }
}



