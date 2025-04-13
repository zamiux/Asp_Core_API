using CityInfo_API.Models;
using System.Net;

namespace CityInfo_API
{
    public class CitiesDataStore
    {
        #region Ctor
        public CitiesDataStore()
        {
            Cities = new List<CityDTO>() {
                new CityDTO() {Id = 1, Name = "Tehran", Description = "MyCity is Tehran"
                // child
                ,pointOfOnterestDTOs = new List<PointOfOnterestDTO>(){
                    new PointOfOnterestDTO()
                    {
                        Id = 1,
                        Name = "TehranPars",
                        Description = "TehranPars is Best City"
                    },
                    new PointOfOnterestDTO()
                    {
                        Id = 2,
                        Name = "Sattarkhan",
                        Description = "Sattarkhan is Best City"
                    }
                }
                },
                new CityDTO() {Id = 2, Name = "Shiraz", Description = "MyCity is Shiraz"
                // child
                ,pointOfOnterestDTOs = new List<PointOfOnterestDTO>(){
                    new PointOfOnterestDTO()
                    {
                        Id = 3,
                        Name = "TakhteJamshid",
                        Description = "TakhteJamshid is Best City"
                    },
                    new PointOfOnterestDTO()
                    {
                        Id = 4,
                        Name = "NaghsheRostam",
                        Description = "NaghsheRostam is Best City"
                    }
                }
                },
                new CityDTO() {Id = 3, Name = "Esfahan", Description = "MyCity is Esfahan"
                // child
                ,pointOfOnterestDTOs = new List<PointOfOnterestDTO>(){
                    new PointOfOnterestDTO()
                    {
                        Id = 5,
                        Name = "PoleKhajoo",
                        Description = "PoleKhajoo is Best City"
                    },
                    new PointOfOnterestDTO()
                    {
                        Id = 6,
                        Name = "SeesioSePol",
                        Description = "SeesioSePol is Best City"
                    }
                }
                }
            };
        }
        #endregion
        public List<CityDTO> Cities { get; set; }

        public static CitiesDataStore FillcurrentData { get; } = new CitiesDataStore();
    }
}
