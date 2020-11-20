using RunningAssistant.Domain.PlaceModel;
using RunningAssistant.Domain.Toolkit.Domain;

namespace RunningAssistant.Domain.TrainingModel
{
    public class TrainingAndPlace : Entity
    {
        public TrainingAndPlace(
            Place place
            , Training training)
        {
            Place = place;
            Training = training;
        }

        public virtual Place Place { get; private set; }
        public int PlaceId { get; private set; }

        public virtual Training Training { get; private set; }
        public int TrainingId { get; private set; }
    }
}
