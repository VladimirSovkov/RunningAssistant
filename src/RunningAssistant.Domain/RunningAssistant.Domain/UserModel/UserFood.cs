using RunningAssistant.Domain.FoodModel;
using RunningAssistant.Domain.Toolkit.Domain;

namespace RunningAssistant.Domain.UserModel
{
    public class UserFood : Entity
    {
        public UserFood(
            User user
            , Food food)
        {
            User = user;
            Food = food;
        }

        public int IdUser {get; private set;}
        public virtual User User {get; private set;}

        public int IdFood { get; private set; }
        public virtual Food Food { get; private set; }
    }
}
