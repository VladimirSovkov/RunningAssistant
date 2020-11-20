using RunningAssistant.Domain.Toolkit.Domain;

namespace RunningAssistant.Domain.PlaceModel
{
    public class Place : Entity
    {
        public Place(
            string street
            , string city)
        {
            Street = street;
            City = city;
        }

        public string Street { get; private set; }
        public string City { get; private set; }
        public float Latitude { get; private set; }
        public float Longitude { get; private set; }

        public void SetCoordinate (float latitude, float longitude)
        {
            Latitude = latitude;
            Longitude = Longitude;
        }
    }
}
