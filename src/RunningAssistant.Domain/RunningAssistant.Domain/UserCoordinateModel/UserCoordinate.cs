using RunningAssistant.Domain.Toolkit.Domain;
using RunningAssistant.Domain.UserModel;
using System;

namespace RunningAssistant.Domain.UserCoordinateModel
{
    public class UserCoordinate : Entity
    {
        public UserCoordinate (
            User user
            , float latitude
            , float longitude
            )
        {
            User = user;
            Latitude = latitude;
            Longitude = longitude;
        }

        public int IdUser { get; private set; }
        public virtual User User { get; private set; }
        public DateTime CreationDate { get; private set; }
        public float Latitude { get; private set; }
        public float Longitude { get; private set; }
    }
}
